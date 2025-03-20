using DaekhonSystem;

using System;
using System.Collections.Generic;

using System.IO;

using System.Text;
using System.Windows.Forms;

using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panConfigMotor : UserControl
    {
        public panManualMotion Motion;
        public panConfigMotor()
        {
            // logger.SendMsg("panConfigMotor()");

            InitializeComponent();
            InitDataGridViewControl();
            LoadMotorParamInfo();

            Motion = panManualMotion.StaticInstance;
        }

        public void InitDataGridViewControl()
        {
            dgMotorParameter.RowHeadersVisible = false;

            dgMotorParameter.Rows.Clear();
            dgMotorParameter.Columns.Clear();

            // 1. Axis
            dgMotorParameter.Columns.Add("Axis", "Axis");
            dgMotorParameter.Columns["Axis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Axis"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 2. Jog Speed Low
            var jogSpeedLowColumn = new DataGridViewTextBoxColumn();
            jogSpeedLowColumn.Name = "Jog Speed Low";
            jogSpeedLowColumn.HeaderText = "Jog Speed Low";
            //dgMotorParameter.Columns.Add("Jog Speed Low", "Jog Speed Low");
            jogSpeedLowColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            jogSpeedLowColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns.Add(jogSpeedLowColumn);

            // 3. Jog Speed Middle
            dgMotorParameter.Columns.Add("Jog Speed Middle", "Jog Speed Middle");
            dgMotorParameter.Columns["Jog Speed Middle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Jog Speed Middle"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 4. Jog Speed High
            dgMotorParameter.Columns.Add("Jog Speed High", "Jog Speed High");
            dgMotorParameter.Columns["Jog Speed High"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Jog Speed High"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 5. Jog TA Low            
            dgMotorParameter.Columns.Add("Jog TA Low", "Jog TA Low");
            dgMotorParameter.Columns["Jog TA Low"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Jog TA Low"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 6. Jog TA Middle            
            dgMotorParameter.Columns.Add("Jog TA Middle", "Jog TA Middle");
            dgMotorParameter.Columns["Jog TA Middle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Jog TA Middle"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 7. Jog TA High            
            dgMotorParameter.Columns.Add("Jog TA High", "Jog TA High");
            dgMotorParameter.Columns["Jog TA High"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Jog TA High"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 8.Jog TS Low
            dgMotorParameter.Columns.Add("Jog TS Low", "Jog TS Low");
            dgMotorParameter.Columns["Jog TS Low"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Jog TS Low"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
 

            // 9.Jog TS Middle
            dgMotorParameter.Columns.Add("Jog TS Middle", "Jog TS Middle");
            dgMotorParameter.Columns["Jog TS Middle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Jog TS Middle"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
 

            // 10.Jog TS High
            dgMotorParameter.Columns.Add("Jog TS High", "Jog TS High");
            dgMotorParameter.Columns["Jog TS High"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Jog TS High"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 11. Limit Minus
            dgMotorParameter.Columns.Add("Limit Minus", "Limit Minus");
            dgMotorParameter.Columns["Limit Minus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Limit Minus"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 12. Limit Plus
            dgMotorParameter.Columns.Add("Limit Plus", "Limit Plus");
            dgMotorParameter.Columns["Limit Plus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgMotorParameter.Columns["Limit Plus"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgMotorParameter.AllowUserToResizeRows = false;
        }

        private void LoadMotorParamInfo()
        {
            //motionParameters.Clear();
            String szPath = String.Format("{0}Config\\ConfigMotorParam.INI", dkCommon.AppPath());
            if (dkCommon.FileExists(szPath))
            {
                Global.MotionParameters = ParseINIFile(szPath);
                UpdatAxisConfig();
            }
        }

        private static List<MotionParameter> ParseINIFile(string filePath)
        {
            List<MotionParameter> parameters = new List<MotionParameter>();
            MotionParameter currentParameter = null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line.StartsWith("["))
                    {
                        if (currentParameter != null)
                        {
                            parameters.Add(currentParameter);
                        }
                        currentParameter = new MotionParameter();
                    }
                    else 
                    if (currentParameter != null)
                    {
                        string[] keyValue = line.Split('=');
                        if (keyValue.Length == 2)
                        {
                            string key = keyValue[0].Trim();
                            string value = keyValue[1].Trim();

                            switch (key)
                            {
                                case "Axis":
                                    currentParameter.Axis = value;
                                    break;

                                case "Jog Speed Low":
                                    currentParameter.JogSpeedLow = double.Parse(value);
                                    break;
                                
                                case "Jog TA Low":
                                    currentParameter.JogTALow = double.Parse(value);
                                    break;
                                
                                case "Jog TS Low":
                                    currentParameter.JogTSLow = double.Parse(value);
                                    break;
                                
                                case "Jog Speed Middle":
                                    currentParameter.JogSpeedMiddle = double.Parse(value);
                                    break;
                                
                                case "Jog TA Middle":
                                    currentParameter.JogTAMiddle = double.Parse(value);
                                    break;
                                
                                case "Jog TS Middle":
                                    currentParameter.JogTSMiddle = double.Parse(value);
                                    break;
                                
                                case "Jog Speed High":
                                    currentParameter.JogSpeedHigh = double.Parse(value);
                                    break;
                                
                                case "Jog TA High":
                                    currentParameter.JogTAHigh = double.Parse(value);
                                    break;
                                
                                case "Jog TS High":
                                    currentParameter.JogTSHigh = double.Parse(value);
                                    break;
                                
                                case "Limit Minus":
                                    currentParameter.LimitMinus = double.Parse(value);
                                    break;
                                
                                case "Limit Plus":
                                    currentParameter.LimitPlus = double.Parse(value);
                                    break;
                            }
                        }
                    }
                }

                if (currentParameter != null)
                {
                    parameters.Add(currentParameter);
                }
            }

            return parameters;
        }

        private void UpdatAxisConfig()
        {
            dgMotorParameter.Rows.Clear();

            foreach (MotionParameter item in Global.MotionParameters)
            {
                int idx = dgMotorParameter.Rows.Add();
                DataGridViewRowHeaderCell headerCell = dgMotorParameter.Rows[idx].HeaderCell;
                headerCell.Value = (idx + 1).ToString();

                dgMotorParameter.Rows[idx].Cells[0].Value = item.Axis;
                dgMotorParameter.Rows[idx].Cells[1].Value = item.JogSpeedLow;
                dgMotorParameter.Rows[idx].Cells[2].Value = item.JogSpeedMiddle;
                dgMotorParameter.Rows[idx].Cells[3].Value = item.JogSpeedHigh;
                dgMotorParameter.Rows[idx].Cells[4].Value = item.JogTALow;
                dgMotorParameter.Rows[idx].Cells[5].Value = item.JogTAMiddle;
                dgMotorParameter.Rows[idx].Cells[6].Value = item.JogTAHigh;
                dgMotorParameter.Rows[idx].Cells[7].Value = item.JogTSLow;
                dgMotorParameter.Rows[idx].Cells[8].Value = item.JogTSMiddle;
                dgMotorParameter.Rows[idx].Cells[9].Value = item.JogTSHigh;
                dgMotorParameter.Rows[idx].Cells[10].Value = item.LimitMinus;
                dgMotorParameter.Rows[idx].Cells[11].Value = item.LimitPlus;
            }
        }    
     

        private void btnSave_Click(object sender, EventArgs e)
        {
            String szPath = String.Format("{0}Config\\ConfigMotorParam.INI", dkCommon.AppPath());
            SaveDataGridViewToIni(szPath);
            LoadMotorParamInfo();
        }    

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // 11번째 또는 12번째 열에서만 -와 소수점 기호를 허용
            if (dgMotorParameter.CurrentCell.ColumnIndex == 10 || dgMotorParameter.CurrentCell.ColumnIndex == 11)
            {
                // '-' 기호는 첫 번째 위치에만 허용
                if (e.KeyChar == '-' && textBox.SelectionStart != 0)
                {
                    e.Handled = true; // 첫 번째 위치가 아니면 입력 차단
                }

                // '-' 기호가 이미 입력되어 있으면 입력 차단
                if (e.KeyChar == '-' && textBox.Text.Contains("-"))
                {
                    e.Handled = true; // 중복된 - 기호 차단
                }

                // 소수점은 하나만 허용
                if (e.KeyChar == '.' && textBox.Text.Contains("."))
                {
                    e.Handled = true; // 중복된 소수점 차단
                }

                // 숫자, 백스페이스, 소수점, 마이너스 기호 외에는 입력 차단
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
            else
            {
                // 다른 열에서는 마이너스 기호는 허용되지 않음
                if (e.KeyChar == '-')
                {
                    e.Handled = true; // 마이너스 기호 입력 차단
                }

                // 숫자와 소수점만 허용
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // 숫자와 백스페이스, 소수점 이외 차단
                }

                // 소수점은 하나만 허용
                if (e.KeyChar == '.' && textBox.Text.Contains("."))
                {
                    e.Handled = true; // 중복된 소수점 차단
                }
            }
        }
   
        private void dgMotorParameter_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {   
            TextBox txtBox = e.Control as TextBox;

            if (dgMotorParameter.CurrentCell.ColumnIndex == 0)
            {
                if (txtBox != null)
                {
                    txtBox.ReadOnly = true; // 0번째 열의 셀을 수정 불가능하게 설정
                }
            }
            else
            {
                if (txtBox != null)
                {
                    txtBox.ReadOnly = false; // 다른 열의 셀을 수정 가능하게 설정
                    {
                        txtBox.KeyPress -= txtBox_KeyPress; //new KeyPressEventHandler(txtBox_KeyPress);
                        txtBox.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);
                    }
                }
            }
        }

        private void SaveDataGridViewToIni(string filePath)
        {
            var motorParameters = new Dictionary<string, MotionParameter>();

            foreach (DataGridViewRow row in dgMotorParameter.Rows)
            {
                if (!row.IsNewRow)
                {
                    var axis = row.Cells["Axis"].Value?.ToString();
                    if (!string.IsNullOrEmpty(axis))
                    {
                        var motorParameter = new MotionParameter
                        {
                            Axis = axis,
                            JogSpeedLow = Convert.ToDouble(row.Cells["Jog Speed Low"].Value),
                            JogTALow = Convert.ToDouble(row.Cells["Jog TA Low"].Value),
                            JogTSLow = Convert.ToDouble(row.Cells["Jog TS Low"].Value),
                            JogSpeedMiddle = Convert.ToDouble(row.Cells["Jog Speed Middle"].Value),
                            JogTAMiddle = Convert.ToDouble(row.Cells["Jog TA Middle"].Value),
                            JogTSMiddle = Convert.ToDouble(row.Cells["Jog TS Middle"].Value),
                            JogSpeedHigh = Convert.ToDouble(row.Cells["Jog Speed High"].Value),
                            JogTAHigh = Convert.ToDouble(row.Cells["Jog TA High"].Value),
                            JogTSHigh = Convert.ToDouble(row.Cells["Jog TS High"].Value),
                            LimitMinus = Convert.ToDouble(row.Cells["Limit Minus"].Value),
                            LimitPlus = Convert.ToDouble(row.Cells["Limit Plus"].Value)
                        };

                        motorParameters[axis] = motorParameter;
                    }
                }
            }

            WriteIniFile(filePath, motorParameters);
        }

        private void WriteIniFile(string filePath, Dictionary<string, MotionParameter> motorParameters)
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var kvp in motorParameters)
                {
                    var axis = kvp.Key;
                    var param = kvp.Value;

                    writer.WriteLine($"[{axis}]");
                    writer.WriteLine($"Axis={param.Axis}");
                    writer.WriteLine($"Jog Speed Low={param.JogSpeedLow}");
                    writer.WriteLine($"Jog TA Low={param.JogTALow}");
                    writer.WriteLine($"Jog TS Low={param.JogTSLow}");
                    writer.WriteLine($"Jog Speed Middle={param.JogSpeedMiddle}");
                    writer.WriteLine($"Jog TA Middle={param.JogTAMiddle}");
                    writer.WriteLine($"Jog TS Middle={param.JogTSMiddle}");
                    writer.WriteLine($"Jog Speed High={param.JogSpeedHigh}");
                    writer.WriteLine($"Jog TA High={param.JogTAHigh}");
                    writer.WriteLine($"Jog TS High={param.JogTSHigh}");
                    writer.WriteLine($"Limit Minus={param.LimitMinus}");
                    writer.WriteLine($"Limit Plus={param.LimitPlus}");
                    writer.WriteLine(); // 섹션 구분을 위한 빈 줄
                }
            }
        }

        public void SetSoftLimit()
        {
            //CodeSite.SendMsg(String.Format("Motor[1].MinPos = {0}", Global.MotionParameters[0].LimitMinus));
            //CodeSite.SendMsg(String.Format("Motor[1].MaxPos = {0}", Global.MotionParameters[0].LimitPlus));

            //CodeSite.SendMsg(String.Format("Motor[2].MinPos = {0}", Global.MotionParameters[1].LimitMinus));
            //CodeSite.SendMsg(String.Format("Motor[2].MaxPos = {0}", Global.MotionParameters[1].LimitPlus));

            //CodeSite.SendMsg(String.Format("Motor[3].MinPos = {0}", Global.MotionParameters[2].LimitMinus));
            //CodeSite.SendMsg(String.Format("Motor[3].MaxPos = {0}", Global.MotionParameters[2].LimitPlus));

            //CodeSite.SendMsg(String.Format("Motor[5].MinPos = {0}", Global.MotionParameters[3].LimitMinus));
            //CodeSite.SendMsg(String.Format("Motor[5].MaxPos = {0}", Global.MotionParameters[3].LimitPlus));

            Pmac.QueryCommand(String.Format("Motor[1].MinPos = {0}", Global.MotionParameters[0].LimitMinus * Const.XY_LINEAR_SCALE));
            Pmac.QueryCommand(String.Format("Motor[1].MaxPos = {0}", Global.MotionParameters[0].LimitPlus * Const.XY_LINEAR_SCALE));

            Pmac.QueryCommand(String.Format("Motor[2].MinPos = {0}", Global.MotionParameters[1].LimitMinus * Const.XY_LINEAR_SCALE));
            Pmac.QueryCommand(String.Format("Motor[2].MaxPos = {0}", Global.MotionParameters[1].LimitPlus * Const.XY_LINEAR_SCALE));

            Pmac.QueryCommand(String.Format("Motor[3].MinPos = {0}", Global.MotionParameters[2].LimitMinus * Const.XY_LINEAR_SCALE));
            Pmac.QueryCommand(String.Format("Motor[3].MaxPos = {0}", Global.MotionParameters[2].LimitPlus * Const.XY_LINEAR_SCALE));

            Pmac.QueryCommand(String.Format("Motor[5].MinPos = {0}", Global.MotionParameters[3].LimitMinus * Const.XY_LINEAR_SCALE));
            Pmac.QueryCommand(String.Format("Motor[5].MaxPos = {0}", Global.MotionParameters[3].LimitPlus * Const.XY_LINEAR_SCALE));
        }

        public void ResetSoftLimit()
        {
            //CodeSite.SendMsg(String.Format("Motor[1].MinPos = {0}", Global.MotionParameters[0].LimitMinus));
            //CodeSite.SendMsg(String.Format("Motor[1].MaxPos = {0}", Global.MotionParameters[0].LimitPlus));

            //CodeSite.SendMsg(String.Format("Motor[2].MinPos = {0}", Global.MotionParameters[1].LimitMinus));
            //CodeSite.SendMsg(String.Format("Motor[2].MaxPos = {0}", Global.MotionParameters[1].LimitPlus));

            //CodeSite.SendMsg(String.Format("Motor[3].MinPos = {0}", Global.MotionParameters[2].LimitMinus));
            //CodeSite.SendMsg(String.Format("Motor[3].MaxPos = {0}", Global.MotionParameters[2].LimitPlus));

            //CodeSite.SendMsg(String.Format("Motor[5].MinPos = {0}", Global.MotionParameters[3].LimitMinus));
            //CodeSite.SendMsg(String.Format("Motor[5].MaxPos = {0}", Global.MotionParameters[3].LimitPlus));

            Pmac.QueryCommand(String.Format("Motor[1].MinPos = {0}", 0.0));
            Pmac.QueryCommand(String.Format("Motor[1].MaxPos = {0}", 0.0));

            Pmac.QueryCommand(String.Format("Motor[2].MinPos = {0}", 0.0));
            Pmac.QueryCommand(String.Format("Motor[2].MaxPos = {0}", 0.0));

            Pmac.QueryCommand(String.Format("Motor[3].MinPos = {0}", 0.0));
            Pmac.QueryCommand(String.Format("Motor[3].MaxPos = {0}", 0.0));

            Pmac.QueryCommand(String.Format("Motor[5].MinPos = {0}", 0.0));
            Pmac.QueryCommand(String.Format("Motor[5].MaxPos = {0}", 0.0));
        }
    }
}

/*
 * 
 X :-3.2mm ~ 1704mm
Y1:-45.3mm ~ 864mm
Y2:-44mm ~ 866mm
Z :-13.5mm ~ 35mm-3
 * 
 */