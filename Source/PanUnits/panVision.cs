using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.Display;

using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro.ToolGroup;
using Cognex.VisionPro;

using YujinTechnology;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panVision : UserControl
    {
        CodeSiteLogger logger;

        public frmMVS frmMVS;
        public bool exitConfirmed = false;

        public CogJobManager cogJobManager;
        public CogJob cogJob;
        public CogJobIndependent IndependentJob;
        public CogToolGroup cogToolGroup;

        public string DefaultVisionFile = "";
        public bool LoadDefaultVisionFile = false;

        public String NewVisionFile = "";
        public bool LoadNewVisionFile = false;

        public bool Align1SearchResultOK = false;
        public bool Align2SearchResultOK = false;
        public bool Align3SearchResultOK = false;
        public bool Align4SearchResultOK = false;

        public bool Align1SearchResultBad = false;
        public bool Align2SearchResultBad = false;
        public bool Align3SearchResultBad = false;
        public bool Align4SearchResultBad = false;

        public bool SearchOK = false;
        public double SearchScore = 0.0;
        public double SearchResultXPos = 0.0;
        public double SearchResultYPos = 0.0;

#if _VISION
        public Cognex.VisionPro.Display.CogDisplay cogDisplay;
        public Cognex.VisionPro.Display.CogDisplay cogModel;
        public Cognex.VisionPro.Display.CogDisplay cogResult;

        public CogImage8Root cogRoot = new CogImage8Root();
        public CogImage8Grey cogImage = new CogImage8Grey();
        public double Resolution = 0.0034191176470588;

        int MouseX = 0;
        int MouseY = 0;

        private PointF startPoint = PointF.Empty; // 시작점 저장
        private bool isCtrlPressed = false;      // Ctrl 키 눌림 상태 확인
        private Cognex.VisionPro.CogLineSegment measureLine = null; // 측정 선
#endif
        public panVision()
        {
            InitializeComponent();

            SetCodeSiteLogger();
        }

        public void SetCodeSiteLogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "Vision1";

            var fileDestination = new CodeSiteDestination();
            fileDestination.LogFile.FilePath = yjCommon.AppPath();
            fileDestination.LogFile.FileName = "LaserCutter";

            logger.Destination = fileDestination;
            logger.Destination.Viewer.Active = true;
        }

        public void ChangeLogFilePath(String szPath)
        {
            logger.Destination.LogFile.LogByDate = false;
            logger.Destination.LogFile.Active = false;

            logger.Destination.LogFile.FilePath = szPath;

            logger.Destination.LogFile.LogByDate = true;
            logger.Destination.LogFile.Active = true;
        }

        public CogPMAlignTool PMAlignTool()
        {
#if _VISION
            if (cogToolGroup != null)
            {
                if ((cbAlignIndex.SelectedIndex >= 0) && (cbAlignIndex.SelectedIndex < cbAlignIndex.Items.Count))
                {
                    return (CogPMAlignTool)cogToolGroup.Tools[cbAlignIndex.SelectedIndex + 1];
                }
                else 
                { return null; }
            }
            else
            { return null; }
#else
            return null;
#endif
        }

        public void UpdateThread_OnExecute(object sender, EventArgs e)
        {
            if (!exitConfirmed)
            {
#if _VISION

                lock (frmMVS.bitmapLock)
                {
                    UpdateCogImageWithBuffer(cogImage, frmMVS.imageData, frmMVS.frameWidth, frmMVS.frameHeight);
                    cogImage.SetRoot(cogRoot);
                    cogDisplay.Image = cogImage;
                 
                    if (edZoomRate.Value == 0)
                    {
                        edZoomRate.Value = 1;
                    }


                    cogDisplay.Zoom = edZoomRate.Value;

                    if ((cogDisplay != null) && (cogDisplay.Image != null)
                        && (PMAlignTool() != null) && (PMAlignTool().InputImage != null))
                    {
                        PMAlignTool().InputImage = cogDisplay.Image;
                    }


                }
#endif
            }
        }

        #region private void PatMaxTool_Changed(object sender, Cognex.VisionPro.CogChangedEventArgs e)
        public void PatMaxTool_Changed(object sender, Cognex.VisionPro.CogChangedEventArgs e)
        {
            if ((Cognex.VisionPro.Implementation.CogToolBase.SfCreateLastRunRecord
                | Cognex.VisionPro.Implementation.CogToolBase.SfRunStatus) > 0)
            {
#if _VISION
                if ((PMAlignTool() != null))
                {
                    SearchOK = false;
                    ledSearchResultGood.LED.Value = false;
                    ledSearchResultBad.LED.Value = false;

                    viSearchResultXPos.AsDouble = 0.0;
                    viSearchResultYPos.AsDouble = 0.0;
                    viSearchResultScore.AsDouble = 0.0;

                    if (PMAlignTool().Pattern.Trained)
                    {
                        if (PMAlignTool().Results != null)
                        {
                            cogDisplay.InteractiveGraphics.Clear();

                            SearchOK = (PMAlignTool().Results.Count > 0);
                            if (PMAlignTool().Results.Count > 0)
                            {
                                logger.SendMsg(String.Format("        Results.Count = {0}", PMAlignTool().Results.Count));
                                for (int nIndex = 0; nIndex < PMAlignTool().Results.Count; nIndex++)
                                {
                                    CogCompositeShape resultGraphics = default(CogCompositeShape);
                                    resultGraphics = PMAlignTool().Results[0].CreateResultGraphics(CogPMAlignResultGraphicConstants.MatchRegion);

                                    cogDisplay.InteractiveGraphics.Add(resultGraphics, "        Find", false);

                                   // if (sender == cogToolGroup.Tools[1])
                                   // {
                                       // var aligntool = (Cognex.VisionPro.PMAlign.CogPMAlignTool)cogToolGroup.Tools[1];
                                        var aligntool = PMAlignTool();
                                        SearchScore = aligntool.Results[nIndex].Score;
                                        SearchResultXPos = aligntool.Results[nIndex].GetPose().TranslationX;
                                        SearchResultYPos = aligntool.Results[nIndex].GetPose().TranslationY;

                                        SearchResultXPos = (SearchResultXPos - 2448 / 2) * Resolution;
                                        SearchResultYPos = (SearchResultYPos - 2048 / 2) * Resolution;

                                        viSearchResultXPos.AsDouble = SearchResultXPos;
                                        viSearchResultYPos.AsDouble = SearchResultYPos;
                                        viSearchResultScore.AsDouble = SearchScore;

                                        ledSearchResultGood.LED.Value = true;
                                        ledSearchResultBad.LED.Value = false;

                                        logger.SendMsg(String.Format("        Result[{0}].Score:{1:F3}", nIndex, SearchScore));
                                        logger.SendMsg(String.Format("        Result[{0}].Pos:{1:F3}, {2:F3}", nIndex, SearchResultXPos, SearchResultYPos));
                                  //  }
                                }
                            }
                            else
                            {
                                ledSearchResultBad.LED.Value = true;
                                logger.SendMsg("        Search Fail");
                            }
                        }
                        else
                        {
                            ledSearchResultBad.LED.Value = true;
                            logger.SendMsg("        Result == null");
                        }
                    }
                    else
                    {
                        ledSearchResultBad.LED.Value = true;
                        logger.SendMsg("        not model trained");
                    }
                }
#endif
            }
        }
        #endregion

        public void DisplayProperty()
        {
            cbAlignIndex.Items.Clear();
#if _VISION
            if (cogToolGroup.Tools.Count > 1)
            {
                /*
                 * cogToolGroup에 1개 이상의 Tool이 있어야 함.
                 */
                //szStr = String.Format("ToolGroup.Count = {0}", cogToolGroup.Tools.Count);
                //logger.SendMsg(szStr);

                /*
                 * cogToolGroup.Tools[0]에는 "Image Source"..
                 * cogToolGroup.Tools[1]에는 "PMAlign Tool"..
                 */


                if (cogToolGroup.Tools.Count >= 2)
                {                    
                    ledModel1Enabled.LED.Value = (cogToolGroup.Tools[1] is Cognex.VisionPro.PMAlign.CogPMAlignTool);

                    if (ledModel1Enabled.LED.Value)
                    {
                        cbAlignIndex.Items.Add(String.Format("#{0}", 1));
                        cbAlignIndex.SelectedIndex = 0;

                        var AlignTool = (CogPMAlignTool)cogToolGroup.Tools[1];
                        AlignTool.Changed += PatMaxTool_Changed;
                        AlignTool.InputImage = cogDisplay.Image;
                        ledModel1Trained.LED.Value = AlignTool.Pattern.Trained;
                    }
                }

                if (cogToolGroup.Tools.Count >= 3)
                {
                    ledModel2Enabled.LED.Value = (cogToolGroup.Tools[2] is Cognex.VisionPro.PMAlign.CogPMAlignTool);

                    if (ledModel2Enabled.LED.Value)
                    {
                        cbAlignIndex.Items.Add(String.Format("#{0}", 2));
                        cbAlignIndex.SelectedIndex = 1;

                        var AlignTool = (CogPMAlignTool)cogToolGroup.Tools[2];// 508-15-462387-1
                        AlignTool.Changed += PatMaxTool_Changed;
                        AlignTool.InputImage = cogDisplay.Image;
                        ledModel2Trained.LED.Value = AlignTool.Pattern.Trained;
                    }
                }

                if (cogToolGroup.Tools.Count >= 4)
                {
                    ledModel3Enabled.LED.Value = (cogToolGroup.Tools[3] is Cognex.VisionPro.PMAlign.CogPMAlignTool);

                    if (ledModel3Enabled.LED.Value)
                    {
                        cbAlignIndex.Items.Add(String.Format("#{0}", 3));
                        cbAlignIndex.SelectedIndex = 2;

                        var AlignTool = (CogPMAlignTool)cogToolGroup.Tools[3];
                        AlignTool.Changed += PatMaxTool_Changed;
                        AlignTool.InputImage = cogDisplay.Image;
                        ledModel3Trained.LED.Value = AlignTool.Pattern.Trained;
                    }
                }

                if (cogToolGroup.Tools.Count >= 5)
                {
                    ledModel4Enabled.LED.Value = (cogToolGroup.Tools[4] is Cognex.VisionPro.PMAlign.CogPMAlignTool);

                    if (ledModel4Enabled.LED.Value)
                    {
                        cbAlignIndex.Items.Add(String.Format("#{0}", 4));
                        cbAlignIndex.SelectedIndex = 3;

                        var AlignTool = (CogPMAlignTool)cogToolGroup.Tools[4];
                        AlignTool.Changed += PatMaxTool_Changed;
                        AlignTool.InputImage = cogDisplay.Image;
                        ledModel4Trained.LED.Value = AlignTool.Pattern.Trained;
                    }
                }

                // @@
                IndependentJob = cogJob.OwnedIndependent;
                cbAlignIndex.SelectedIndex = 0;
            }
#endif
        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "Quick Builder 응용 프로그램 (*.vpp)|*.vpp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
#if _VISION
                // 레시피 세팅
                NewVisionFile = openFileDialog.FileName;

                cogJobManager = (CogJobManager)CogSerializer.LoadObjectFromFile(NewVisionFile);
                cogJob = cogJobManager.Job(0);
                IndependentJob = cogJob.OwnedIndependent;

                cogToolGroup = (CogToolGroup)cogJob.VisionTool;

                // 기존 메모리 청소
                cogJobManager.UserQueueFlush();
                cogJobManager.FailureQueueFlush();
                cogJob.ImageQueueFlush();
                IndependentJob.RealTimeQueueFlush();

                LoadNewVisionFile = true;
                LoadDefaultVisionFile = false;

                DisplayProperty();
#endif
            }
        }

        public void btnLoadProject_Click(object sender, EventArgs e)
        {
#if _VISION
            if (yjCommon.FileExists(DefaultVisionFile))
            {
                DestroyCognexToolGroup();

                cogJobManager = (CogJobManager)CogSerializer.LoadObjectFromFile(DefaultVisionFile);
                cogJob = cogJobManager.Job(0);
                IndependentJob = cogJob.OwnedIndependent;

                cogToolGroup = (CogToolGroup)cogJob.VisionTool;

                // 기존 메모리 청소
                cogJobManager.UserQueueFlush();
                cogJobManager.FailureQueueFlush();
                cogJob.ImageQueueFlush();
                IndependentJob.RealTimeQueueFlush();

                DisplayProperty();

                LoadDefaultVisionFile = true;
                LoadNewVisionFile = false;
            }
#endif
            btnShowCross.PerformClick();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            if (LoadDefaultVisionFile)
            {
                if (yjCommon.FileExists(DefaultVisionFile))
                {
                    logger.SendMsg(String.Format("    Vision1.SaveDefaultProject({0})", DefaultVisionFile));
                    CogSerializer.SaveObjectToFile(cogJobManager, DefaultVisionFile);
                }
                else
                {
                    yjCommon.Inform("Default Vision File 경로가 올바르지 않습니다.", "오류");
                }
            }
            else
            if (LoadNewVisionFile)
            {
                if (yjCommon.FileExists(NewVisionFile))
                {
                    logger.SendMsg(String.Format("    Vision1.SaveNewProject({0})", NewVisionFile));
                    CogSerializer.SaveObjectToFile(cogJobManager, NewVisionFile);
                }
                else
                {
                    yjCommon.Inform("New Vision File의 경로가 올바르지 않습니다.", "오류");
                }
            }
        }

        private void btnShowROI_Click(object sender, EventArgs e)
        {
            logger.EnterMethod("btnShowROI_Click()");

#if _VISION
            var pmAlignTool = PMAlignTool();
            if (pmAlignTool != null && pmAlignTool.Pattern != null)
            {
                btnShowROI.LED.Value = !btnShowROI.LED.Value;

                if (btnShowROI.LED.Value)
                {
                    // 기존 그래픽 지우기
                    cogDisplay.InteractiveGraphics.Clear();
                    cogDisplay.StaticGraphics.Clear();

                    // TrainRegion 추가 (null 여부 확인)
                    if (pmAlignTool.Pattern.TrainRegion is ICogGraphicInteractive trainRegion)
                    {
                        cogDisplay.InteractiveGraphics.Add(trainRegion, "Model.ROI", false);
                    }
                    else
                    {
                        logger.SendMsg("TrainRegion이 설정되지 않았습니다.");
                    }

                    // SearchRegion 추가 (null 여부 확인)
                    if (pmAlignTool.SearchRegion is ICogGraphicInteractive searchRegion)
                    {
                        cogDisplay.InteractiveGraphics.Add(searchRegion, "Search.ROI", false);
                    }
                    else
                    {
                        logger.SendMsg("SearchRegion이 설정되지 않았습니다.");
                    }
                }
                else
                {
                    // 그래픽 지우기
                    cogDisplay.InteractiveGraphics.Clear();
                    cogDisplay.StaticGraphics.Clear();
                }
            }
            else
            {
                logger.SendMsg("PMAlignTool 또는 Pattern이 null입니다.");
            }
 #endif
            logger.ExitMethod("btnShowROI_Click()");
        }

        private void btnModelTrain_Click(object sender, EventArgs e)
        {
            if (!LoadDefaultVisionFile && !LoadNewVisionFile)
            {
                yjCommon.Inform("Vision Project File Loading 오류", "Error");
                return;
            }

            logger.EnterMethod("btnModelTrain_Click()");

#if _VISION

            /*
             * Train을 하면 등록되어 있는 Model.Search()를 하여
             * PatMaxTool_Changed() Event가 발생한다.
             */
            var pmAlignTool = PMAlignTool();
            if (pmAlignTool != null && pmAlignTool.Pattern != null)
            {
                if (pmAlignTool.InputImage != null)
                {
                    pmAlignTool.Pattern.TrainImage = pmAlignTool.InputImage;

                    pmAlignTool.Pattern.Train();

                    if (pmAlignTool.Pattern.TrainRegion is CogCircle circleRegion)
                    {
                        SetOrigin(circleRegion.CenterX, circleRegion.CenterY);
                    }
                    else
                    if (pmAlignTool.Pattern.TrainRegion is CogRectangle rectangleRegion)
                    {
                        SetOrigin(rectangleRegion.CenterX, rectangleRegion.CenterY);
                    }
                    else if(pmAlignTool.Pattern.TrainRegion is CogEllipse ellipseRegion)
                    {
                        SetOrigin(ellipseRegion.CenterX, ellipseRegion.CenterY);
                    }
                    else if (pmAlignTool.Pattern.TrainRegion is CogPolygon polygonRegion)
                    {
                        double centerX = 0;
                        double centerY = 0;
                        int pointCount = polygonRegion.NumVertices;

                        

                        for (int i = 0; i < pointCount; i++)
                        {
                            centerX += polygonRegion.GetVertexX(i);
                            centerY += polygonRegion.GetVertexY(i);
                        }

                        centerX /= pointCount;
                        centerY /= pointCount;

                        SetOrigin(centerX, centerY);
                    }                     
                    else if (pmAlignTool.Pattern.TrainRegion is CogLineSegment lineSegment)
                    {
                        double centerX = (lineSegment.StartX + lineSegment.EndX) / 2;
                        double centerY = (lineSegment.StartY + lineSegment.EndY) / 2;

                        SetOrigin(centerX, centerY);
                    }     

                    /*
                     * TrainImage를 화면에 표시
                     */
                    cogModel.Image = pmAlignTool.Pattern.GetTrainedPatternImage();
                }
            }
#endif
            logger.ExitMethod("btnModelTrain_Click()");
        }

        public void SetOrigin(double centerX, double centerY)
        {
            var pmAlignTool = PMAlignTool();
            if (pmAlignTool != null && pmAlignTool.Pattern != null)
            {
                pmAlignTool.Pattern.Origin.TranslationX = centerX;
                pmAlignTool.Pattern.Origin.TranslationY = centerY;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!LoadDefaultVisionFile && !LoadNewVisionFile)
            {
                yjCommon.Inform("Vision Project File Loading 오류", "Error");
                return;
            }

#if _VISION
            cogDisplay.InteractiveGraphics.Clear();
            cogDisplay.StaticGraphics.Clear();

            logger.SendMsg(String.Format("    Vision1.Search{0}()", cbAlignIndex.SelectedIndex + 1));

            var pmAlignTool = PMAlignTool();
            if (pmAlignTool != null && pmAlignTool.Pattern != null)
            {
                try
                {
                    pmAlignTool.Run();

                    if (pmAlignTool.RunStatus.Exception != null)
                    {
                        throw pmAlignTool.RunStatus.Exception;
                    }

                    // 검색 결과 이미지 설정
                    if (pmAlignTool.Results != null && pmAlignTool.Results.Count > 0)
                    {
                        var resultImage = pmAlignTool.Pattern.GetTrainedPatternImage();
                        cogResult.Image = resultImage;
                        cogResult.Fit(true);

                        cogResult.Zoom = cogModel.Zoom;
                    }
                    else
                    {
                        logger.SendMsg("검색 결과가 없습니다.");
                    }
                }
                catch (Exception ex)
                {
                    logger.SendMsg($"검색 중 오류 발생: {ex.Message}");
                }
            }
#endif
        }

        #region public static byte[] GetRawData(Bitmap bitmap)
        public static byte[] GetRawData(Bitmap bitmap)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                throw new ArgumentException("이미지는 8비트 포맷이어야 합니다.");
            }

            if (bitmap.Width != frmMVS.frameWidth || bitmap.Height != frmMVS.frameHeight)
            {
                throw new ArgumentException($"이미지 크기는 {frmMVS.frameWidth}x{frmMVS.frameHeight}이어야 합니다.");
            }

            // BitmapData 객체를 통해 비트맵의 메모리 블록에 접근
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, frmMVS.frameWidth, frmMVS.frameHeight),
                                                    ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);

            // 프레임 크기에 맞는 바이트 배열 생성
            byte[] pixels = new byte[frmMVS.frameSize];

            // 이미지를 바이트 배열로 복사 (stride를 고려해야 함)
            int stride = bitmapData.Stride;
            for (int y = 0; y < frmMVS.frameHeight; y++)
            {
                // 각 라인의 시작 위치
                IntPtr ptr = IntPtr.Add(bitmapData.Scan0, y * stride);
                Marshal.Copy(ptr, pixels, y * frmMVS.frameWidth, frmMVS.frameWidth);
            }

            // BitmapData 객체 잠금 해제
            bitmap.UnlockBits(bitmapData);

            return pixels;
        }
        #endregion

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
#if _VISION
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btnGrab_Click(null, null);

                    try
                    {
                        string filePath = openFileDialog.FileName;
                        using (Bitmap bitmap = new Bitmap(filePath))
                        {
                            frmMVS.imageData = GetRawData(bitmap);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
#endif
        }

        private void cbAlignIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
#if _VISION
            var pmAlignTool = PMAlignTool();
            if (pmAlignTool != null && pmAlignTool.Pattern != null)
            {
                // 훈련된 모델 이미지 설정
                if (pmAlignTool.Pattern.Trained)
                {
                    lblCogModel.Visible = false;

                    cogModel.Visible = true;

                    cogModel.Image = pmAlignTool.Pattern.GetTrainedPatternImage();
                    cogModel.Fit(true); // 디스플레이에 맞게 조정
                    cogModel.Zoom = cogModel.Zoom * 0.95; // 약간 축소하여 보기 좋게
                }
                else
                {
                    lblCogModel.Visible = true;
                    lblCogModel.Text = "등록된 모델이 없습니다.";

                    cogModel.Visible = false;
                    cogModel.Image = null; // 훈련되지 않은 경우 초기화
                }
            }
            else
            {
                lblCogModel.Visible = true;
                lblCogModel.Text = "등록된 모델이 없습니다.";

                cogModel.Visible = false;
                cogModel.Image = null; // Tool이 없거나 Pattern이 없는 경우 초기화
            }
#endif
        }

        private void lblCogDisplay1_MouseMove(object sender, MouseEventArgs e)
        {
#if _VISION
            if (cogDisplay.Image == null) return;

            // 1. 마우스 위치 (화면 좌표)
            MouseX = e.X;
            MouseY = e.Y;

            ICogTransform2D mapper = cogDisplay.GetTransform("#", "*");
            mapper.MapPoint(e.X, e.Y, out double imageX, out double imageY);

            // 좌표를 정수로 변환 (픽셀 좌표)
            int pixelX = (int)Math.Round(imageX);
            int pixelY = (int)Math.Round(imageY);

            if (pixelX < 0 || pixelY < 0 || pixelX >= cogDisplay.Image.Width || pixelY >= cogDisplay.Image.Height)
            {
                return;
            }

            // 이미지 데이터를 가져오기
            if (cogDisplay.Image is CogImage8Grey greyImage)
            {
                byte pixelValue = greyImage.GetPixel(pixelX, pixelY);

                lblInfo.Text = String.Format("X({0}), Y({1}), GV({2})", pixelX, pixelY, pixelValue);
            }
#endif

#if _VISION
            if (isCtrlPressed && measureLine != null)
            {
                // 현재 마우스 위치 (이미지 좌표)
                mapper = cogDisplay.GetTransform("#", "*");
                mapper.MapPoint(e.X, e.Y, out double currentX, out double currentY);

                PointF currentPoint = new PointF((float)currentX, (float)currentY);

                // 점선 업데이트 (Start ~ End 제한)
                measureLine.SetStartEnd(startPoint.X, startPoint.Y, currentPoint.X, currentPoint.Y);

                // 거리 계산
                double distance = Math.Sqrt(
                    Math.Pow(currentPoint.X - startPoint.X, 2) +
                    Math.Pow(currentPoint.Y - startPoint.Y, 2)
                );

                lblInfo.Text = String.Format("{0}, distance = {1:F3}", lblInfo.Text, distance / 1000);
            }
#endif
        }

        private void btnShowMVS_Click(object sender, EventArgs e)
        {
            if (!frmMVS.Visible)
            {
                frmMVS.Show();
            }
        }

        private void btnShowCross_Click(object sender, EventArgs e)
        {
            btnShowCross.LED.Value = !btnShowCross.LED.Value;

#if _VISION
            if (btnShowCross.LED.Value)
            {
                SetStaticCrossLine(cogDisplay, "cogDisplay1", CogColorConstants.Red);
            }
            else
            {
                cogDisplay.StaticGraphics.Clear();
            }
#endif
        }

        private async void btnLive_Click(object sender, EventArgs e)
        {
            btnLive.LED.Value = !btnLive.LED.Value;
            btnGrab.LED.Value = !btnLive.LED.Value;

            frmMVS.rdoTriggerMode.Checked = btnGrab.LED.Value;
            await Task.Delay(50); // 0.05초 동안 대기

            frmMVS.rdoContinuesMode.Checked = btnLive.LED.Value;
            await Task.Delay(50); // 0.05초 동안 대기
        }

        private async void btnGrab_Click(object sender, EventArgs e)
        {
            btnLive.LED.Value = false;
            btnGrab.LED.Value = true;

            frmMVS.rdoTriggerMode.Checked = btnGrab.LED.Value;

            await Task.Delay(50); // 0.05초 동안 대기
            frmMVS.chkSoftTrigger.Checked = true;

            await Task.Delay(50); // 0.05초 동안 대기
            frmMVS.rdoContinuesMode.Checked = btnLive.LED.Value;

            await Task.Delay(50); // 0.5초 동안 대기
            frmMVS.btnSoftTrigger_Click(null, null);
        }

        public void InitCognexControl()
        {
#if _VISION
            cogDisplay = new Cognex.VisionPro.Display.CogDisplay();
            cogDisplay.Location = lblCogDisplay1.Location;
            cogDisplay.Size = lblCogDisplay1.Size;

            cogDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            cogDisplay.ColorMapLowerRoiLimit = 0D;
            cogDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            cogDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            cogDisplay.ColorMapUpperRoiLimit = 1D;
            cogDisplay.DoubleTapZoomCycleLength = 2;
            cogDisplay.DoubleTapZoomSensitivity = 2.5D;
            cogDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.None;
            cogDisplay.MouseWheelSensitivity = 1D;
            cogDisplay.Name = "cogDisplay1";

            cogDisplay.Click        += lblCogDisplay1_Click;
            cogDisplay.MouseDown    += lblCogDisplay1_MouseDown;
            cogDisplay.MouseMove    += lblCogDisplay1_MouseMove;
            cogDisplay.MouseUp      += lblCogDisplay1_MouseUp;
            cogDisplay.DoubleClick  += lblCogDisplay1_DoubleClick;

            cogDisplay.BackColor = Color.DarkGray;
            cogDisplay.Refresh();

            lblCogDisplay1.Visible = false;

            panClient.Controls.Add(cogDisplay);

            /*
             * 
             */
            cogModel = new Cognex.VisionPro.Display.CogDisplay();
            cogModel.Location = lblCogModel.Location;
            cogModel.Size = lblCogModel.Size;

            cogModel.ColorMapLowerClipColor = System.Drawing.Color.Black;
            cogModel.ColorMapLowerRoiLimit = 0D;
            cogModel.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            cogModel.ColorMapUpperClipColor = System.Drawing.Color.Black;
            cogModel.ColorMapUpperRoiLimit = 1D;
            cogModel.DoubleTapZoomCycleLength = 2;
            cogModel.DoubleTapZoomSensitivity = 2.5D;
            cogModel.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.None;
            cogModel.MouseWheelSensitivity = 1D;
            cogModel.Name = "cogModel";

            cogModel.BackColor = Color.DarkGray;
            cogModel.Refresh();

            lblCogModel.Visible = false;

            cogModel.Location = lblCogModel.Location;
            cogModel.Size = lblCogModel.Size;
            panClient.Controls.Add(cogModel);

            /*
             * 
             */
            cogResult = new Cognex.VisionPro.Display.CogDisplay();
            cogResult.Location = lblCogModel.Location;
            cogResult.Size = lblCogModel.Size;
               
            cogResult.ColorMapLowerClipColor = System.Drawing.Color.Black;
            cogResult.ColorMapLowerRoiLimit = 0D;
            cogResult.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            cogResult.ColorMapUpperClipColor = System.Drawing.Color.Black;
            cogResult.ColorMapUpperRoiLimit = 1D;
            cogResult.DoubleTapZoomCycleLength = 2;
            cogResult.DoubleTapZoomSensitivity = 2.5D;
            cogResult.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.None;
            cogResult.MouseWheelSensitivity = 1D;
            cogResult.Name = "cogModel";
               
            cogResult.BackColor = Color.DarkGray;
            cogResult.Refresh();

            lblCogResult.Visible = false;

            cogResult.Location = lblCogResult.Location;
            cogResult.Size = lblCogResult.Size;
            panClient.Controls.Add(cogResult);
#endif
        }

        private void CogDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CogDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void DestroyCognexToolGroup()
        {
            if ((cogToolGroup != null) && (cogToolGroup.Tools.Count >= 0))
            {
                for (int nIndex = 0; nIndex < cogToolGroup.Tools.Count; nIndex++)
                {
                    if ((cogToolGroup.Tools[nIndex] is Cognex.VisionPro.PMAlign.CogPMAlignTool))
                    {
                        var AlignTool = (CogPMAlignTool)cogToolGroup.Tools[nIndex];
                        AlignTool.Changed -= PatMaxTool_Changed;
                        AlignTool.Dispose();
                    }
                }
            }

            if (cogJobManager != null)
            {
                cogJobManager.Shutdown();
            }
        }


        #region public static void SetStaticCrossLine(CogDisplay cogDisplay, string szTag, CogColorConstants AColor = CogColorConst.White)
        public static void SetStaticCrossLine(CogDisplay cogDisplay, string szTag, CogColorConstants AColor = CogColorConstants.White)
        {
            if (cogDisplay.Image != null)
            {
                using (CogLine vLine = new CogLine())
                {
                    vLine.Color = AColor;

                    vLine.LineWidthInScreenPixels = 1;
                    vLine.LineStyle = CogGraphicLineStyleConstants.DashDot;
                    vLine.SetFromStartXYEndXY(cogDisplay.Image.Width / 2, 0, cogDisplay.Image.Width / 2, cogDisplay.Image.Height);
                    cogDisplay.StaticGraphics.Add(vLine, szTag);
                }

                using (CogLine hLine = new CogLine())
                {
                    hLine.Color = AColor;

                    hLine.LineWidthInScreenPixels = 1;
                    hLine.LineStyle = CogGraphicLineStyleConstants.DashDot;
                    hLine.SetFromStartXYEndXY(0, cogDisplay.Image.Height / 2, cogDisplay.Image.Width, cogDisplay.Image.Height / 2);
                    cogDisplay.StaticGraphics.Add(hLine, szTag);
                }
            }
        }
        #endregion

        public void UpdateCogImageWithBuffer(CogImage8Grey cogImage, byte[] buffer, int width, int height)
        {
#if _VISION
            IntPtr bufferPtr = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0);
            cogRoot.Initialize(width, height, bufferPtr, width, null);
#endif
        }

        public void Search1()
        {
            logger.SendMsg("        Search1()");

            ledSearchResultGood.LED.Value = false;
            ledSearchResultBad.LED.Value = false;

            viSearchResultXPos.AsDouble = 0.0;
            viSearchResultYPos.AsDouble = 0.0;
            viSearchResultScore.AsDouble = 0.0;

            cbAlignIndex.SelectedIndex = 0;

#if _VISION
            if (ledModel1Enabled.LED.Value)
            {
                cogDisplay.InteractiveGraphics.Clear();
                cogDisplay.StaticGraphics.Clear();

                cogToolGroup.Tools[1].Run();

                if (cogToolGroup.Tools[1].RunStatus.Exception != null)
                {
                    MessageBox.Show(cogToolGroup.Tools[1].RunStatus.Exception.Message, "PatMax Run Error");
                }
            }
            else
            {
                logger.SendMsg("        Align#1Enabled = false");
            }
#endif
        }

        public void Search2()
        {
            logger.SendMsg("        Search2()");

            ledSearchResultGood.LED.Value = false;
            ledSearchResultBad.LED.Value = false;

            viSearchResultXPos.AsDouble = 0.0;
            viSearchResultYPos.AsDouble = 0.0;
            viSearchResultScore.AsDouble = 0.0;

            cbAlignIndex.SelectedIndex = 1;

#if _VISION
            if (ledModel2Enabled.LED.Value)
            {
                cogDisplay.InteractiveGraphics.Clear();
                cogDisplay.StaticGraphics.Clear();

                cogToolGroup.Tools[2].Run();

                if (cogToolGroup.Tools[2].RunStatus.Exception != null)
                {
                    MessageBox.Show(cogToolGroup.Tools[2].RunStatus.Exception.Message, "PatMax Run Error");
                }
            }
            else
            {
                logger.SendMsg("        Align#2Enabled = false");
            }
#endif
        }

        public void Search3()
        {
            logger.SendMsg("        Search3()");

            ledSearchResultGood.LED.Value = false;
            ledSearchResultBad.LED.Value = false;

            viSearchResultXPos.AsDouble = 0.0;
            viSearchResultYPos.AsDouble = 0.0;
            viSearchResultScore.AsDouble = 0.0;

            cbAlignIndex.SelectedIndex = 2;

#if _VISION
            if (ledModel3Enabled.LED.Value)
            {
                cogDisplay.InteractiveGraphics.Clear();
                cogDisplay.StaticGraphics.Clear();

                cogToolGroup.Tools[3].Run();

                if (cogToolGroup.Tools[3].RunStatus.Exception != null)
                {
                    MessageBox.Show(cogToolGroup.Tools[3].RunStatus.Exception.Message, "PatMax Run Error");
                }
            }
            else
            {
                logger.SendMsg("        Align#3Enabled = false");
            }
#endif
        }

        public void Search4()
        {
            logger.SendMsg("        Search4()");

            ledSearchResultGood.LED.Value = false;
            ledSearchResultBad.LED.Value = false;

            viSearchResultXPos.AsDouble = 0.0;
            viSearchResultYPos.AsDouble = 0.0;
            viSearchResultScore.AsDouble = 0.0;

            cbAlignIndex.SelectedIndex = 3;

#if _VISION
            if (ledModel3Enabled.LED.Value)
            {
                cogDisplay.InteractiveGraphics.Clear();
                cogDisplay.StaticGraphics.Clear();

                cogToolGroup.Tools[4].Run();

                if (cogToolGroup.Tools[4].RunStatus.Exception != null)
                {
                    MessageBox.Show(cogToolGroup.Tools[4].RunStatus.Exception.Message, "PatMax Run Error");
                }
            }
            else
            {
                logger.SendMsg("        Align#4Enabled = false");
            }
#endif
        }

        private void lblCogDisplay1_DoubleClick(object sender, EventArgs e)
        {
#if _VISION
            if (cogDisplay.Image == null) return;

            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                // 1. 마우스 위치 (화면 좌표)
                // 2. 화면 좌표를 이미지 좌표로 변환하는 맵퍼 가져오기
                ICogTransform2D mapper = cogDisplay.GetTransform("#", "*");

                // 3. 이미지 좌표 계산
                double imageX, imageY;
                mapper.MapPoint(MouseX, MouseY, out imageX, out imageY);

                // 4. 좌표를 정수형으로 변환 (필요한 경우)
                int pixelX = (int)Math.Round(imageX) - 2448 / 2;
                int pixelY = ((int)Math.Round(imageY) - 2048 / 2);

                double XOffset = pixelX * Resolution;
                double YOffset = pixelY * Resolution;

                Pmac.XMoveInc(XOffset);
                Pmac.Y1MoveInc(YOffset);
            }
#endif
        }

        private void lblCogDisplay1_Click(object sender, EventArgs e)
        {
#if _VISION
            if (btnManualSet.LED.Value)
            {
                double modelRadius = (PMAlignTool().Pattern.TrainRegion as CogCircle)?.Radius ?? 50; // 기본 반경 50

                ICogTransform2D mapper = cogDisplay.GetTransform("#", "*");
                double imageX, imageY;
                mapper.MapPoint(MouseX, MouseY, out imageX, out imageY);

                cogDisplay.InteractiveGraphics.Clear();

                var clickedCircle = new CogCircle
                {
                    CenterX = imageX,
                    CenterY = imageY,
                    Radius = modelRadius,
                    Color = CogColorConstants.Red,
                    SelectedSpaceName = "#", // 좌표 공간 설정
                };

                cogDisplay.InteractiveGraphics.Add(clickedCircle as ICogGraphicInteractive, "ManualSet#1", true);

                var innerCircle = new CogCircle
                {
                    CenterX = imageX,
                    CenterY = imageY,
                    Radius = modelRadius * 4 / 5,  // 큰 Circle의 반지름의 절반
                    Color = CogColorConstants.Green,
                    SelectedSpaceName = "#"
                };

                // 작은 Circle을 Interactive Graphics에 추가
                cogDisplay.InteractiveGraphics.Add(innerCircle as ICogGraphicInteractive, "ManualSet#2", false);


                // 4. 좌표를 정수형으로 변환 (필요한 경우)
                int pixelX = (int)Math.Round(imageX) - 2448 / 2;
                int pixelY = ((int)Math.Round(imageY) - 2048 / 2);

                double XOffset = pixelX * Resolution;
                double YOffset = pixelY * Resolution;

                viSearchResultXPos.AsDouble = XOffset;
                viSearchResultYPos.AsDouble = YOffset;

                SearchResultXPos = viSearchResultXPos.AsDouble;
                SearchResultYPos = viSearchResultYPos.AsDouble;

                ledSearchResultGood.LED.Value = true;
                ledSearchResultBad.LED.Value = false;

                SearchOK = true;
            }
#endif
        }

        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnModelTrain.Text = Global.iniEng.ReadString("panVision1", "btnModelTrain.Text", "Model Train");
            btnSearch.Text = Global.iniEng.ReadString("panVision1", "btnSearch.Text", "Search");
            btnSelectProject.Text = Global.iniEng.ReadString("panVision1", "btnSelectProject.Text", "Select Project");
            btnLoadProject.Text = Global.iniEng.ReadString("panVision1", "btnLoadProject.Text", "Load Project");
            btnSaveProject.Text = Global.iniEng.ReadString("panVision1", "btnSaveProject.Text", "Save Project");
            btnShowMVS.Text = Global.iniEng.ReadString("panVision1", "btnShowMVS.Text", "MVS");
            btnShowROI.Text = Global.iniEng.ReadString("panVision1", "btnShowROI.Text", "Show ROI");
            btnShowCross.Text = Global.iniEng.ReadString("panVision1", "btnShowCross.Text", "Cross Line");
            btnOpenImage.Text = Global.iniEng.ReadString("panVision1", "btnOpenImage.Text", "Open Image");
            btnSave8Image.Text = Global.iniEng.ReadString("panVision1", "btnSaveImage.Text", "Save Image");
            btnLive.Text = Global.iniEng.ReadString("panVision1", "btnLive.Text", "Live");
            btnGrab.Text = Global.iniEng.ReadString("panVision1", "btnGrab.Text", "Grab");
        }

        public void ChangeLanguageKorea()
        {
            btnModelTrain.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnModelTrain.Text");
            btnSearch.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnSearch.Text");
            btnSelectProject.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnSelectProject.Text");
            btnLoadProject.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnLoadProject.Text");
            btnSaveProject.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnSaveProject.Text");
            btnShowMVS.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnShowMVS.Text");
            btnShowROI.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnShowROI.Text");
            btnShowCross.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnShowCross.Text");
            btnOpenImage.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnOpenImage.Text");
            btnSave8Image.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnSaveImage.Text");
            btnLive.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnLive.Text");
            btnGrab.Text = Global.GetIniLanguageValue(Global.iniKor, "panVision1", "btnGrab.Text");
        }

        public void ChangeLanguageVietnam()
        {
            btnModelTrain.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnModelTrain.Text");
            btnSearch.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnSearch.Text");
            btnSelectProject.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnSelectProject.Text");
            btnLoadProject.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnLoadProject.Text");
            btnSaveProject.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnSaveProject.Text");
            btnShowMVS.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnShowMVS.Text");
            btnShowROI.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnShowROI.Text");
            btnShowCross.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnShowCross.Text");
            btnOpenImage.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnOpenImage.Text");
            btnSave8Image.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnSaveImage.Text");
            btnLive.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnLive.Text");
            btnGrab.Text = Global.GetIniLanguageValue(Global.iniVie, "panVision1", "btnGrab.Text");
        }
        #endregion

        private void btnManualSet_Click(object sender, EventArgs e)
        {
            btnManualSet.LED.Value = !btnManualSet.LED.Value;

            if (btnManualSet.LED.Value)
            {
                ledSearchResultGood.LED.Value = false;
                ledSearchResultBad.LED.Value = false;

                viSearchResultXPos.AsDouble = 0.0;
                viSearchResultYPos.AsDouble = 0.0;
                viSearchResultScore.AsDouble = 0.0;
            }
        }

        public void ChangeZoomRate(object sender, EventArgs e)
        {
            btnZoomX1.LED.Value = (sender == btnZoomX1);
            btnZoomX1_5.LED.Value = (sender == btnZoomX1_5);
            btnZoomX2.LED.Value = (sender == btnZoomX2);
            btnZoomX2_5.LED.Value = (sender == btnZoomX2_5);
            btnZoomX3.LED.Value = (sender == btnZoomX3);

            if (sender == btnZoomX1)
            {
            #if _VISION
                cogDisplay.Fit(true);
            #endif
                edZoomRate.Value = Const.VISION_ZOOM_FIT * 1.0;
            }
            else
            if (sender == btnZoomX1_5)
            {
                edZoomRate.Value = Const.VISION_ZOOM_FIT * 1.5;
            }
            else
            if (sender == btnZoomX2)
            {
                edZoomRate.Value = Const.VISION_ZOOM_FIT * 2.0;
            }
            else
            if (sender == btnZoomX2_5)
            {
                edZoomRate.Value = Const.VISION_ZOOM_FIT * 2.5;
            }
            else
            if (sender == btnZoomX3)
            {
                edZoomRate.Value = Const.VISION_ZOOM_FIT * 3.0;
            }
        }

        private void btnZoomX1_Click(object sender, EventArgs e)
        {
            ChangeZoomRate(sender, e);
        }

        private void btnZoomX1_5_Click(object sender, EventArgs e)
        {
            ChangeZoomRate(sender, e);
        }

        private void btnZoomX2_Click(object sender, EventArgs e)
        {
            ChangeZoomRate(sender, e);
        }

        private void btnZoomX2_5_Click(object sender, EventArgs e)
        {
            ChangeZoomRate(sender, e);
        }

        private void btnZoomX3_Click(object sender, EventArgs e)
        {
            ChangeZoomRate(sender, e);
        }

        private void panVision1_Load(object sender, EventArgs e)
        {
            btnLive_Click(null, null);
        }


        public void EnableControl(bool enable)
        {
            btnLoadProject.Enabled = enable;
            btnSaveProject.Enabled = enable;
            btnSelectProject.Enabled = enable;
            btnShowMVS.Enabled = enable;
            btnShowROI.Enabled = enable;
            btnSearch.Enabled = enable;

            btnModelTrain.Enabled = enable;
            btnManualSet.Enabled = enable;  

            btnOpenImage.Enabled = enable;  
            btnSave8Image.Enabled = enable;
            btnSave24Image.Enabled = enable;
            
            btnLive.Enabled = enable;
            btnGrab.Enabled = enable;
        }

        private void lblCogDisplay1_MouseDown(object sender, MouseEventArgs e)
        {
#if _VISION
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                isCtrlPressed = true;

                // 시작점 설정 (이미지 좌표)
                ICogTransform2D mapper = cogDisplay.GetTransform("#", "*");
                mapper.MapPoint(e.X, e.Y, out double startX, out double startY);
                startPoint = new PointF((float)startX, (float)startY);

                // 점선 생성
                measureLine = new Cognex.VisionPro.CogLineSegment
                {
                    Color = Cognex.VisionPro.CogColorConstants.Red,
                    LineStyle = Cognex.VisionPro.CogGraphicLineStyleConstants.Dot,
                    LineWidthInScreenPixels = 2
                };

                // 시작점과 끝점을 동일하게 초기화
                measureLine.SetStartEnd(startPoint.X, startPoint.Y, startPoint.X, startPoint.Y);

                // 점선 추가
                cogDisplay.InteractiveGraphics.Add(measureLine, "MeasureLine", false);
            }
#endif
        }

        private void lblCogDisplay1_MouseUp(object sender, MouseEventArgs e)
        {
#if _VISION
            if (isCtrlPressed)
            {
                // 종료점 설정
                ICogTransform2D mapper = cogDisplay.GetTransform("#", "*");
                mapper.MapPoint(e.X, e.Y, out double endX, out double endY);

                PointF endPoint = new PointF((float)endX, (float)endY);

                // 최종 거리 계산
                double distance = Math.Sqrt(
                    Math.Pow(endPoint.X - startPoint.X, 2) +
                    Math.Pow(endPoint.Y - startPoint.Y, 2)
                );

        //        MessageBox.Show($"총 이동 거리: {distance:F2} units", "거리 계산 완료");
                logger.SendMsg($"총 이동 거리: {distance:F2} units");

                // 초기화
                isCtrlPressed = false;
                startPoint = PointF.Empty;

                // 점선 제거
                cogDisplay.InteractiveGraphics.Remove("MeasureLine");
                measureLine = null;
            }
#endif
        }

        private void btnSave8Image_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sd = new System.Windows.Forms.SaveFileDialog();
            sd.InitialDirectory = "D:";
            sd.Title = "이미지 저장 위치 지정";
            sd.DefaultExt = "bmp";
            sd.Filter = "bmp files(*.bmp)|*.bmp";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                // imageData를 8비트 Bitmap으로 저장
                Bitmap bitmap = frmMVS.RawData2Bitmap(frmMVS.imageData, frmMVS.frameWidth, frmMVS.frameHeight);

                string fname = sd.FileName;
                bitmap.Save(fname, ImageFormat.Bmp);

                // 리소스 해제
                bitmap.Dispose();
            }
        }

        private void btnSave24Image_Click(object sender, EventArgs e)
        {
#if _VISION
            if (cogDisplay.Image != null)
            {
                System.Windows.Forms.SaveFileDialog sd = new System.Windows.Forms.SaveFileDialog();
                sd.InitialDirectory = "D:";
                sd.Title = "이미지 저장 위치 지정";
                sd.DefaultExt = "bmp";
                sd.Filter = "bmp files(*.bmp)|*.bmp";

                if (sd.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Bitmap bmpResult = cogDisplay.Image.ToBitmap();
                    string fname = sd.FileName.ToString();
                    bmpResult.Save(fname);
                }
            }
#endif
        }

    }
}
