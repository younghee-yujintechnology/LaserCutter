using System;

using System.Windows.Forms;
using System.IO;
using System.Reflection;
using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Transactions;
using System.Data;
using YujinTechnology;

using Raize.CodeSiteLogging;
using System.Linq;

namespace LaserCutter
{
    public partial class panAlarm : UserControl
    {
        private FbConnection connection;
        private FbTransaction transaction;
        private FbCommand command;

        private string connectionString = "User=SYSDBA;" +
                      "Password=masterkey;" +
                      "Database=C:\\Temp\\aa.fdb;" +
                      "DataSource=localhost;" +
                      "Port=3050;" +
                      "Dialect=3;" +
                      "Charset=UTF8;" +
                      "Role=;" +
                      "Connection lifetime=15;" +
                      "Pooling=true;" +
                      "MinPoolSize=0;" +
                      "MaxPoolSize=50;" +
                      "Packet Size=8192;" +
                      "ServerType=0;"; // 0: Firebird 서버 연결, 1: Firebird 임베디드 연결

        private int currentPage = 1;
        private int pageSize = 10; // 한 페이지에 보여줄 레코드 수

        public panAlarm()
        {
            InitializeComponent();

            InitDataGridViewControl();
        }

        #region public void InitDataGridViewControl()
        // DataGridView Column 동적 생성

        public void InitDataGridViewControl()
        {
            DataGridView1.RowHeadersVisible = false;

            DataGridView1.Rows.Clear();
            DataGridView1.Columns.Clear();

            DataGridView1.AllowUserToResizeRows = false;
        }
        #endregion

        private void bitBtn1_Click(object sender, EventArgs e)
        {
            string databaseFilePath = String.Format("{0}Error.fdb", yjCommon.AppPath());

            CheckDatabase(databaseFilePath);
            CheckTable();
        }

        private bool CheckDatabase(String ADBPath)
        {
            bool result = false;

            // 파일이 없을 경우 데이터베이스 생성
            if (!File.Exists(ADBPath))
            {
                string createConnectionString = "User=SYSDBA;" +
                                "Password=masterkey;" +
                                $"Database={ADBPath};" +
                                "DataSource=localhost;" +
                                "Port=3050;" +
                                "Dialect=3;" +
                                "Charset=UTF8;" +
                                "ServerType=0;";

                FbConnection.CreateDatabase(createConnectionString, 4096, true);
            }
            else
            {
                connectionString = "User=SYSDBA;" +
                                "Password=masterkey;" +
                                $"Database={ADBPath};" +
                                "DataSource=localhost;" +
                                "Port=3050;" +
                                "Dialect=3;" +
                                "Charset=UTF8;" +
                                "ServerType=0;";
            }

            // 데이터베이스 연결
            connection = new FbConnection(connectionString);
            try
            {
                connection.Open();
                result = true;
            }
            catch (Exception _)
            {
                
            }

            return result;
        }

        private void GetTableList(StringList List)
        {
            string getTableListSql = "SELECT rdb$relation_name FROM rdb$relations WHERE rdb$system_flag = 0";
            using (FbCommand cmd = new FbCommand(getTableListSql, connection))
            {
                using (FbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tableName = reader["rdb$relation_name"].ToString().Trim(); // 테이블 이름 트림
                        List.Add(tableName);
                    }
                }
            }
        }

        private void CheckTable()
        {
            StringList tableList = new StringList();

            GetTableList(tableList); // 테이블 목록 가져오기

            if (tableList.IndexOf("ERRORLOG") == (-1))
            {
                try
                {
                    // 테이블 생성
                    string createTableSql = @"CREATE TABLE ErrorLog (
                                                    Code INTEGER,
                                                    OccurDate TIMESTAMP,
                                                    ReleaseDate TIMESTAMP
                                                  )";
                    using (FbCommand cmd = new FbCommand(createTableSql, connection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("ErrorLog 테이블을 생성했습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("테이블 생성 중 오류 발생: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ErrorLog 테이블이 이미 존재합니다.");
            }
        }

        public void AddError(int errorCode)
        {
            // 데이터베이스 연결이 안 되어 있으면 종료
            if (connection.State != System.Data.ConnectionState.Open) return;

            try
            {
                // 트랜잭션 시작
                transaction = connection.BeginTransaction();

                // SQL 쿼리 준비
                command = new FbCommand("INSERT INTO ErrorLog (Code, OccurDate) " +
                                        "VALUES (@Code, @OccurDate)", connection, transaction);

                // 파라미터 설정
                command.Parameters.AddWithValue("@Code", errorCode);
                command.Parameters.AddWithValue("@OccurDate", DateTime.Now);

                // 쿼리 실행
                command.ExecuteNonQuery();

                // 트랜잭션 커밋
                transaction.Commit();
            }

            catch (Exception)
            {
                // 트랜잭션 롤백
                if (transaction != null)
                {
                    transaction.Rollback();
                }

                throw;  // 예외 처리 로직이 있으면 추가 가능
            }
            finally
            {
                // 트랜잭션 객체 해제
                if (transaction != null)
                {
                    transaction.Dispose();
                }

                // 커맨드 객체 해제
                if (command != null)
                {
                    command.Dispose();
                }
            }
        }

        private void bitBtn2_Click(object sender, EventArgs e)
        {
            AddError(12);
            AddError(25);
            AddError(112);
        }

        private void bitBtn3_Click(object sender, EventArgs e)
        {
            currentPage = 1; // 필터 적용 시 첫 페이지로 이동
            LoadDataFromDatabase(currentPage, startDatePicker.Value, endDatePicker.Value);
        }

        private void LoadDataFromDatabase(int page, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    // 페이지에 해당하는 데이터를 가져오는 쿼리 작성 (기간 필터 적용)
                    int skipRecords = (page - 1) * pageSize;
                    string sql = $"SELECT FIRST {pageSize} SKIP {skipRecords} Code, OccurDate, ReleaseDate " +
                                 $"FROM ErrorLog " +
                                 $"WHERE (OccurDate BETWEEN @StartDate AND @EndDate OR ReleaseDate IS NULL) " +
                                 $"ORDER BY OccurDate";

                    FbDataAdapter dataAdapter = new FbDataAdapter(sql, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                    // DataTable에 데이터를 채우고 DataGridView에 바인딩
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    DataGridView1.DataSource = dataTable;

                    // 페이지 정보 업데이트
                    lblPageInfo.Text = $"Page {currentPage}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터를 가져오는 중 오류 발생: " + ex.Message);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadDataFromDatabase(currentPage, startDatePicker.Value, endDatePicker.Value);

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataFromDatabase(currentPage, startDatePicker.Value, endDatePicker.Value);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadDataFromDatabase(currentPage, startDatePicker.Value, endDatePicker.Value);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = int.MaxValue; // 마지막 페이지는 실제 데이터 개수를 알아야 처리 가능
            LoadDataFromDatabase(currentPage, startDatePicker.Value, endDatePicker.Value);

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    LoadDataFromDatabase(currentPage, startDatePicker.Value, endDatePicker.Value);
                }
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                currentPage++;
                LoadDataFromDatabase(currentPage, startDatePicker.Value, endDatePicker.Value);
            }
        }
    }
}
