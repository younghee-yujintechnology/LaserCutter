using Newtonsoft.Json;
using Raize.CodeSiteLogging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LaserCutter.Advanced;

namespace LaserCutter
{

    public partial class frmCarbide : Form
    {
#if _CARBIDE
        private readonly string _baseUrl = "http://192.168.240.10:20018/v1";
        int nIndex = 0;
        int LiveIndex = 0;
#endif
        public panAuto Auto;

        public Basic Basic;
        public StretcherCompressor StretcherCompressor;
        public ExternalControl ExternalControl;
        public Advanced Advanced;
        public Bust Burst; 
        public Chiller Chiller;

        public frmCarbide()
        {
            InitializeComponent();

            FormClosing += _FormClosing;

            Auto = panAuto.StaticInstance;
        }

        #region public static frmCarbide StaticInstance
        private static frmCarbide staticForm;

        public static frmCarbide StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmCarbide();
                }
                return staticForm;
            }
        }
        #endregion

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            ReadThread.Enabled = false;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void ReadThread_OnExecute(object sender, EventArgs e)
        {
#if _CARBIDE
            switch (nIndex)
            {
                case 0:

                    propertyGrid1.SelectedObject = Basic.Read();
                    nIndex = 10;
                    break;

                case 10:

                    propertyGrid2.SelectedObject = StretcherCompressor.Read();
                    nIndex = 20;
                    break;

                case 20:

                    propertyGrid3.SelectedObject = ExternalControl.Read();
                    nIndex = 30;
                    break;

                case 30:

                    propertyGrid4.SelectedObject = Advanced.Read();
                    nIndex = 40;
                    break;

                case 40:

                    propertyGrid5.SelectedObject = Chiller.Read();
                    nIndex = 0;
                    break;
            }

            LiveIndex = LiveIndex + 1;
            LiveIndex = LiveIndex % 4;

            switch (LiveIndex)
            {
                case 0:
                    ledRX.LED.Value = true;
                    ledTX.LED.Value = false;
                    break;

                case 1:
                    ledRX.LED.Value = true;
                    ledTX.LED.Value = true;
                    break;

                case 2:
                    ledRX.LED.Value = false;
                    ledTX.LED.Value = true;
                    break;

                case 3:
                    ledRX.LED.Value = false;
                    ledTX.LED.Value = false;
                    break;

            }

#endif

        }

        public void Connect()
        {
            Basic = new Basic();
            StretcherCompressor = new StretcherCompressor();
            ExternalControl = new ExternalControl();
            Advanced = new Advanced();
            Burst = new Bust();
            Chiller = new Chiller();

#if _CARBIDE
            Basic.Open(_baseUrl);
            StretcherCompressor.Open(_baseUrl);
            ExternalControl.Open(_baseUrl);
            Advanced.Open(_baseUrl);
            Burst.Open(_baseUrl);
            Chiller.Open(_baseUrl);
#endif
        }

        public void Disconnect()
        {
#if _CARBIDE
            // Basic 모듈 종료
            if (Basic != null)
            {
                Basic.Close();
            }

            // StretcherCompressor 모듈 종료
            if (StretcherCompressor != null)
            {
                StretcherCompressor.Close();
            }

            // ExternalControl 모듈 종료
            if (ExternalControl != null)
            {
                ExternalControl.Close();
            }

            // Advanced 모듈 종료
            if (Advanced != null)
            {
                Advanced.Close(); 
            }

            // Burst 모듈 종료
            if (Burst != null)
            {
                Burst.Close();
            }

            // Chiller 모듈 종료
            if (Chiller != null)
            {
                Chiller.Close();
            }

            // 읽기 스레드 비활성화
            ReadThread.Enabled = false;
#endif
        }

    }

    public static class Laser
    {

    }


    #region public class Basic
    public class Basic
    {
        private panAuto Auto;
        private RestClient restClient;
        private string _baseUrl;

        public Basic()
        {
            Warnings = new List<Warning>();
            Errors = new List<Error>();

            Auto = panAuto.StaticInstance;
        }

        public void Open(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
            _baseUrl = baseUrl;
        }

        public void Close()
        {
            if (restClient != null)
            {
                restClient = null; // RestClient 자원 해제
            }
        }

        public string SerialNumber { get; set; }
        public string LaserIdentificationNumber { get; set; }
        public string FirmwareVersion { get; set; }
        public double ActualOutputPower { get; set; }
        public int ActualPpDivider { get; set; }
        public double ActualOutputFrequency { get; set; }
        public double ActualOutputEnergy { get; set; }
        public int ActualHarmonic { get; set; }
        public int SelectedPresetIndex { get; set; }
        public int LastExecutedPresetIndex { get; set; }
        public double ActualAttenuatorPercentage { get; set; }
        public int ActualBurstPulseCount { get; set; }
        public double ActualPulseDuration { get; set; }
        public double TargetPulseDuration { get; set; }
        public bool IsOutputEnabled { get; set; }
        public bool IsEmissionWarningActive { get; set; }
        public bool IsPowerlockEnabled { get; set; }
        public string ActualStateName { get; set; }
        public int TargetPpDivider { get; set; }
        public double TargetAttenuatorPercentage { get; set; }
        public int TargetBurstPulseCount { get; set; }
        public string GeneralStatus { get; set; }
        public string ActualShutterState { get; set; }
        public double TargetRaEnergy { get; set; }
        public List<Error> Errors { get; set; }
        public List<Warning> Warnings { get; set; }
        public double ActualPulseEnvelope { get; set; }
        public double TargetPulseEnvelope { get; set; }

        public bool waitFlag = false;
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public void CancelPreviousRequest()
        {
            cancellationTokenSource.Cancel();//이전 요청 취소
            cancellationTokenSource = new CancellationTokenSource();
        }
        public Basic Read()
        {
            try
            {
                var StateCheck = restClient.Execute(new RestRequest("Basic", Method.GET));

                if (StateCheck.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = JsonConvert.DeserializeObject<Basic>(StateCheck.Content);

                    // 필요한 데이터 할당
                    ActualAttenuatorPercentage = response.ActualAttenuatorPercentage;
                    SerialNumber = response.SerialNumber;
                    ActualOutputPower = response.ActualOutputPower;
                    ActualOutputFrequency = response.ActualOutputFrequency;
                    ActualPpDivider = response.ActualPpDivider;
                    ActualStateName = response.ActualStateName;
                    ActualPulseDuration = response.ActualPulseDuration;
                    IsEmissionWarningActive = response.IsEmissionWarningActive;
                    SelectedPresetIndex = response.SelectedPresetIndex;
                    IsOutputEnabled = response.IsOutputEnabled;
                    ActualBurstPulseCount = response.ActualBurstPulseCount;
                    TargetPpDivider = response.TargetPpDivider;
                    ActualShutterState = response.ActualShutterState;

                    return response;
                }
                else
                {
                    Auto.AddError(Const.ERROR_LASER_COMMUNICATION_ERROR);
                }
            }

            catch (Exception _)
            {
            }

            return null;
        }

        public void ReadAsync()
        {
            CancelPreviousRequest();
            waitFlag = true;
            var request = new RestRequest("Basic", Method.GET);

            restClient.ExecuteAsync(request, (response) =>
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var basicResponse = JsonConvert.DeserializeObject<Basic>(response.Content);

                    // 필요한 데이터 할당
                    ActualAttenuatorPercentage = basicResponse.ActualAttenuatorPercentage;
                    SerialNumber = basicResponse.SerialNumber;
                    ActualOutputPower = basicResponse.ActualOutputPower;
                    ActualOutputFrequency = basicResponse.ActualOutputFrequency;
                    ActualPpDivider = basicResponse.ActualPpDivider;
                    ActualStateName = basicResponse.ActualStateName;
                    ActualPulseDuration = basicResponse.ActualPulseDuration;
                    IsEmissionWarningActive = basicResponse.IsEmissionWarningActive;
                    SelectedPresetIndex = basicResponse.SelectedPresetIndex;
                    IsOutputEnabled = basicResponse.IsOutputEnabled;
                    ActualBurstPulseCount = basicResponse.ActualBurstPulseCount;
                    TargetPpDivider = basicResponse.TargetPpDivider;
                    ActualShutterState = basicResponse.ActualShutterState;

                    waitFlag = false;
                    // 추가적인 로직 (UI 업데이트 등)
                }
                else
                {
                    // 오류 처리
                    Console.WriteLine("Failed to fetch data: " + response.StatusCode);
                }
            });
        }

        public string Read(string szItemName)
        {
            var request = new RestRequest($"Basic/{szItemName}", Method.GET);
            var StateCheck = restClient.Execute(request);

            if (StateCheck.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic response = JsonConvert.DeserializeObject<dynamic>(StateCheck.Content);
                return response.ToString();
            }
            else
            {
                return null;
            }
        }

        public bool Write(string szItemName, object Obj)
        {
            var request = new RestRequest($"Basic/{szItemName}", Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(Obj);

            var response = restClient.Execute(request);
            return (response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        public bool Write(string szItemName)
        {
            var request = new RestRequest($"Basic/{szItemName}", Method.POST);
            var response = restClient.Execute(request);
            return (response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        public bool SetTargetAttenuatorPercentage(double value)
        {
            return Write("TargetAttenuatorPercentage", value);
        }

        public bool SetTargetBurstPulseCount(int value)
        {
            return Write("TargetBurstPulseCount", value);
        }

        public bool SetTargetPpDivider(int value)
        {
            return Write("TargetPpDivider", value);
        }

        public bool ShutterClose()
        {
            return Write("CloseOutput");
        }

        public bool ShutterOpen()
        {
            return Write("EnableOutput");
        }

        public bool SetSelectedPresetIndex(int value)
        {
            return Write("SelectedPresetIndex", value);
        }

        public bool ApplySelectedPreset()
        {
            return Write("ApplySelectedPreset");
        }

        public bool Standby()
        {
            return Write("GoToStandby");
        }

        public bool SetTargetPulseDuration(double value)
        {
            return Write("TargetPulseDuration", value);
        }
    }

    #endregion

    #region public class Warning
    public class Warning
    {
        public string Code { get; set; }

        public int CodeNumber { get; set; }

        public string Description { get; set; }
    }
    #endregion

    #region public class Error
    public class Error
    {
        public string Code { get; set; }

        public int CodeNumber { get; set; }

        public string Description { get; set; }
    }
    #endregion

    #region public class StretcherCompressor
    public class StretcherCompressor
    {
        private RestClient restClient;
        private string _baseUrl;

        public StretcherCompressor()
        {
            PulseDurationPositiveChirpRanges = new List<PulseDurationPositiveChirpRange>();
            PulseDurationNegativeChirpRanges = new List<PulseDurationNegativeChirpRange>();
            PositionRanges = new List<PositionRange>();
            // 생성자에서 필요한 리스트 등을 초기화할 수 있습니다.
        }

        public void Open(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
            _baseUrl = baseUrl;
        }

        public void Close()
        {
            if (restClient != null)
            {
                restClient = null; // RestClient 자원 해제
            }

            // 비동기 작업 취소
            cancellationTokenSource.Cancel();
            Console.WriteLine("StretcherCompressor module closed.");
        }


        public double ActualPulseDuration { get; set; }

        public double TargetPulseDuration { get; set; }

        public double ActualPosition { get; set; }

        public double TargetPosition { get; set; }

        public List<PulseDurationPositiveChirpRange> PulseDurationPositiveChirpRanges { get; set; }

        public List<PulseDurationNegativeChirpRange> PulseDurationNegativeChirpRanges { get; set; }

        public List<PositionRange> PositionRanges { get; set; }

        public bool waitFlag = false;

        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public void CancelPreviousRequest()
        {
            cancellationTokenSource.Cancel();//이전 요청 취소
            cancellationTokenSource = new CancellationTokenSource();
        }
        public StretcherCompressor Read()
        {
            var StateCheck = restClient.Execute(new RestRequest("StretcherCompressor", Method.GET));

            // logger.SendMsg(StateCheck.Content.ToString());

            var response = JsonConvert.DeserializeObject<StretcherCompressor>(StateCheck.Content);
            ActualPulseDuration = response.ActualPulseDuration;
            TargetPulseDuration = response.TargetPulseDuration;
            ActualPosition = response.ActualPosition;
            TargetPosition = response.ActualPosition;
            PulseDurationPositiveChirpRanges = response.PulseDurationPositiveChirpRanges;
            PulseDurationNegativeChirpRanges = response.PulseDurationNegativeChirpRanges;
            PositionRanges = response.PositionRanges;

            return response;
        }
        public void ReadAsync()
        {
            CancelPreviousRequest();
            var request = new RestRequest("StretcherCompressor", Method.GET);
            waitFlag = true;
            restClient.ExecuteAsync(request, (response) =>
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseData = JsonConvert.DeserializeObject<StretcherCompressor>(response.Content);

                    // 데이터 할당
                    ActualPulseDuration = responseData.ActualPulseDuration;
                    TargetPulseDuration = responseData.TargetPulseDuration;
                    ActualPosition = responseData.ActualPosition;
                    TargetPosition = responseData.TargetPosition;
                    PulseDurationPositiveChirpRanges = responseData.PulseDurationPositiveChirpRanges;
                    PulseDurationNegativeChirpRanges = responseData.PulseDurationNegativeChirpRanges;
                    PositionRanges = responseData.PositionRanges;

                    waitFlag = false;
                    // 필요한 추가 작업
                }
                else
                {
                    // 오류 처리
                    Console.WriteLine("Failed to fetch data: " + response.StatusCode);
                }
            });
        }

        public string Read(String szItemName)
        {
            var request = new RestRequest($"StretcherCompressor/{szItemName}", Method.GET);
            var StateCheck = restClient.Execute(request);
            if (StateCheck.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic response = JsonConvert.DeserializeObject<dynamic>(StateCheck.Content);                
                return response.ToString();
            }
            else
            {
                return null;
            }
        }

        public bool Write(String szItemName, Object Obj)
        {
            var request = new RestRequest($"StretcherCompressor/{szItemName}", Method.PUT); // PUT 메서드를 사용하여 업데이트
            request.RequestFormat = DataFormat.Json;
            request.AddBody(Obj); // StretcherCompressor 객체를 JSON으로 직렬화하여 요청 본문에 추가

            var response = restClient.Execute(request);
            return (response.StatusCode == System.Net.HttpStatusCode.OK);
            //{
            //    throw new Exception("Failed to update StretcherCompressor data on the server.");
            //}
        }

        public class PulseDurationNegativeChirpRange
        {
            public double From { get; set; }
            public double To { get; set; }
        }
        public class PulseDurationPositiveChirpRange
        {
            public double From { get; set; }
            public double To { get; set; }
        }
        public class PositionRange
        {
            public double From { get; set; }
            public double To { get; set; }
        }
    }
    #endregion

    #region public class ExternalControl
    public class ExternalControl
    {
        private RestClient restClient;
        private string _baseUrl;

        public ExternalControl()
        {
            // 생성자에서 필요한 리스트 등을 초기화할 수 있습니다.
        }


        public void Open(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
            _baseUrl = baseUrl;
        }

        public void Close()
        {
            if (restClient != null)
            {
                restClient = null; // RestClient 자원 해제
            }
        }
        public string AomTriggerSource { get; set; }

        public string AnalogControlSource { get; set; }

        public string ExternalSyncConfiguration { get; set; }

        public string FastEnergyControlSource { get; set; }

        public string HvFastEnergyControlSource { get; set; }
        public string SynchronousPpTriggerMode { get; set; }
        public bool waitFlag = false;

        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public void CancelPreviousRequest()
        {
            cancellationTokenSource.Cancel();//이전 요청 취소
            cancellationTokenSource = new CancellationTokenSource();
        }

        public void ReadAsync()
        {
            CancelPreviousRequest();
            var request = new RestRequest("ExternalControl", Method.GET);
            waitFlag = true;
            restClient.ExecuteAsync(request, (response) =>
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseData = JsonConvert.DeserializeObject<ExternalControl>(response.Content);

                    // 데이터 할당
                    AomTriggerSource = responseData.AomTriggerSource;
                    AnalogControlSource = responseData.AnalogControlSource;
                    ExternalSyncConfiguration = responseData.ExternalSyncConfiguration;
                    FastEnergyControlSource = responseData.FastEnergyControlSource;
                    HvFastEnergyControlSource = responseData.HvFastEnergyControlSource;
                    SynchronousPpTriggerMode = responseData.SynchronousPpTriggerMode;

                    waitFlag = false;
                    // 추가적인 로직 처리 가능
                }
                else
                {
                    // 오류 처리
                    Console.WriteLine("Failed to fetch data: " + response.StatusCode);
                }
            });
        }

        public ExternalControl Read()
        {
            var StateCheck = restClient.Execute(new RestRequest("ExternalControl", Method.GET));

            // logger.SendMsg(StateCheck.Content.ToString());

            var response = JsonConvert.DeserializeObject<ExternalControl>(StateCheck.Content);

            AomTriggerSource = response.AomTriggerSource;
            AnalogControlSource = response.AnalogControlSource;
            ExternalSyncConfiguration = response.ExternalSyncConfiguration;
            FastEnergyControlSource = response.FastEnergyControlSource;
            HvFastEnergyControlSource = response.HvFastEnergyControlSource;
            SynchronousPpTriggerMode = response.SynchronousPpTriggerMode;

            return response;
        }
        public string Read(String szItemName)
        {
            var request = new RestRequest($"ExternalControl/{szItemName}", Method.GET);
            var StateCheck = restClient.Execute(request);
            if (StateCheck.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic response = JsonConvert.DeserializeObject<dynamic>(StateCheck.Content);
                return response.ToString();
            }
            else
            {
                return null;
            }
        }
        public bool Write(String szItemName, Object Obj)
        {
            var request = new RestRequest($"ExternalControl/{szItemName}", Method.PUT); // PUT 메서드를 사용하여 업데이트
            request.RequestFormat = DataFormat.Json;
            request.AddBody(Obj); // Basic 객체를 JSON으로 직렬화하여 요청 본문에 추가

            var response = restClient.Execute(request);
            return (response.StatusCode == System.Net.HttpStatusCode.OK);
            //{
            //    throw new Exception("Failed to update Basic data on the server.");
            //}
        }
        public bool SetTriggerSource(string value)
        {
            return Write("AomTriggerSource", value);
        }
    }
    #endregion

    #region public class Bust
    public class Bust
    {
        private RestClient restClient;
        private string _baseUrl;

        public Bust()
        {
            // 생성자에서 필요한 리스트 등을 초기화할 수 있습니다.
        }


        public void Open(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
            _baseUrl = baseUrl;
        }

        public void Close()
        {
            if (restClient != null)
            {
                restClient = null; // RestClient 자원 해제
            }
        }
        public string ActualParameterP { get; set; }

        public string ActualParameterN { get; set; }

        public string TargetParameterP { get; set; }

        public string TargetParameterN { get; set; }

        public string ActualEnvelopeParameterP { get; set; }
        public string ActualEnvelopeParameterN { get; set; }

        public string TargetEnvelopeParameterP { get; set; }
        public string TargetEnvelopeParameterN { get; set; }

        public bool waitFlag = false;
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public void CancelPreviousRequest()
        {
            cancellationTokenSource.Cancel();//이전 요청 취소
            cancellationTokenSource = new CancellationTokenSource();
        }


        public Bust Read()
        {
            var StateCheck = restClient.Execute(new RestRequest("Burst", Method.GET));

            // logger.SendMsg(StateCheck.Content.ToString());

            var response = JsonConvert.DeserializeObject<Bust>(StateCheck.Content);

            ActualParameterP = response.ActualParameterP;
            ActualParameterN = response.ActualParameterN; 
            TargetParameterP = response.TargetParameterP;
            TargetParameterN = response.TargetParameterN;
            ActualEnvelopeParameterP = response.ActualEnvelopeParameterP;
            ActualEnvelopeParameterN = response.ActualEnvelopeParameterN;
            TargetEnvelopeParameterP = response.TargetEnvelopeParameterP;
            TargetEnvelopeParameterN = response.TargetEnvelopeParameterN;

            return response;
        }
        public void ReadAsync()
        {
            CancelPreviousRequest();
            var request = new RestRequest("Burst", Method.GET);
            waitFlag= true;
            restClient.ExecuteAsync(request, (response) =>
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseData = JsonConvert.DeserializeObject<Bust>(response.Content);

                    // 데이터 할당
                    ActualParameterP = responseData.ActualParameterP;
                    ActualParameterN = responseData.ActualParameterN;
                    TargetParameterP = responseData.TargetParameterP;
                    TargetParameterN = responseData.TargetParameterN;
                    ActualEnvelopeParameterP = responseData.ActualEnvelopeParameterP;
                    ActualEnvelopeParameterN = responseData.ActualEnvelopeParameterN;
                    TargetEnvelopeParameterP = responseData.TargetEnvelopeParameterP;
                    TargetEnvelopeParameterN = responseData.TargetEnvelopeParameterN;

                    waitFlag = false;
                    // 추가 로직 처리 가능
                }
                else
                {
                    // 오류 처리
                    Console.WriteLine("Failed to fetch data: " + response.StatusCode);
                }
            });
        }
        public string Read(String szItemName)
        {
            var request = new RestRequest($"Burst/{szItemName}", Method.GET);
            var StateCheck = restClient.Execute(request);
            if (StateCheck.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic response = JsonConvert.DeserializeObject<dynamic>(StateCheck.Content);
                return response.ToString();
            }
            else
            {
                return null;
            }
        }
        public bool Write(String szItemName, Object Obj)
        {
            var request = new RestRequest($"Burst/{szItemName}", Method.PUT); // PUT 메서드를 사용하여 업데이트
            request.RequestFormat = DataFormat.Json;
            request.AddBody(Obj); // Basic 객체를 JSON으로 직렬화하여 요청 본문에 추가

            var response = restClient.Execute(request);
            return (response.StatusCode == System.Net.HttpStatusCode.OK);
            //{
            //    throw new Exception("Failed to update Basic data on the server.");
            //}
        }   
        public bool SetTargetParameterN(double nValue)
        {
            return Write("TargetParameterN", nValue);
        }
        public bool SetTargetEnvelopeParameterN(double dValue)
        {
            return Write("TargetEnvelopeParameterN", dValue);
        }
        public bool SetTargetParameterP(double nValue)
        {
            return Write("TargetParameterP", nValue);
        }
        public bool SetTargetEnvelopeParameterP(double dValue)
        {
            return Write("TargetEnvelopeParameterP", dValue);
        }
    }
    #endregion

    #region public class Advanced
    public class Advanced
    {
        private RestClient restClient;
        private string _baseUrl;

        public Advanced()
        {
            // 생성자에서 필요한 리스트 등을 초기화할 수 있습니다.
        }

        public void Open(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
            _baseUrl = baseUrl;
            PresetList = new List<Preset>();
        }

        public void Close()
        {
            if (restClient != null)
            {
                restClient = null; // RestClient 자원 해제
            }
        }

        public int ActualStateId { get; set; }

        public AvailableFeature AvailableFeatures { get; set; }

        public Range AvailableAttenuatorPercentageRange { get; set; }

        public CurrentStateAsPreset CurrentStateAsPresets { get; set; }

        public double ActualRaFrequency { get; set; }

        public double TargetRaFrequency { get; set; }

        public bool IsPpEnabled { get; set; }

        public bool IsRemoteInterlockActive { get; set; }

        public bool IsInNanosecondMode { get; set; }

        public PresetLink Presets { get; set; }
        public List<Preset> PresetList { get; set; }
        public Range AvailablePulseDurationRange { get; set; }
        public double ActualHarmonicPower { get; set; }

        public bool waitFlag = false;
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public void CancelPreviousRequest()
        {
            cancellationTokenSource.Cancel();//이전 요청 취소
            cancellationTokenSource = new CancellationTokenSource();
        }
        public Advanced Read()
        {
            var StateCheck = restClient.Execute(new RestRequest("Advanced", Method.GET));

            // logger.SendMsg(StateCheck.Content.ToString());

            var response = JsonConvert.DeserializeObject<Advanced>(StateCheck.Content);
            ActualStateId = response.ActualStateId;
            AvailableFeatures = response.AvailableFeatures;
            AvailableAttenuatorPercentageRange = response.AvailableAttenuatorPercentageRange;
            CurrentStateAsPresets = response.CurrentStateAsPresets;
            ActualRaFrequency = response.ActualRaFrequency;
            TargetRaFrequency = response.TargetRaFrequency;
            IsPpEnabled = response.IsPpEnabled;
            IsRemoteInterlockActive = response.IsRemoteInterlockActive;
            IsInNanosecondMode = response.IsInNanosecondMode;
            Presets = response.Presets;
            PresetList = response.PresetList;
            AvailablePulseDurationRange = response.AvailablePulseDurationRange;
            ActualHarmonicPower = response.ActualHarmonicPower;

            return response;
        }
        public void ReadAsync()
        {
            CancelPreviousRequest();
            var request = new RestRequest("Advanced", Method.GET);
            waitFlag = true;
            restClient.ExecuteAsync(request, (response) =>
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseData = JsonConvert.DeserializeObject<Advanced>(response.Content);

                    // 데이터 할당
                    ActualStateId = responseData.ActualStateId;
                    AvailableFeatures = responseData.AvailableFeatures;
                    AvailableAttenuatorPercentageRange = responseData.AvailableAttenuatorPercentageRange;
                    CurrentStateAsPresets = responseData.CurrentStateAsPresets;
                    ActualRaFrequency = responseData.ActualRaFrequency;
                    TargetRaFrequency = responseData.TargetRaFrequency;
                    IsPpEnabled = responseData.IsPpEnabled;
                    IsRemoteInterlockActive = responseData.IsRemoteInterlockActive;
                    IsInNanosecondMode = responseData.IsInNanosecondMode;
                    Presets = responseData.Presets;
                    PresetList = responseData.PresetList;
                    AvailablePulseDurationRange = responseData.AvailablePulseDurationRange;
                    ActualHarmonicPower = responseData.ActualHarmonicPower;

                    waitFlag = false;
                    // 추가적인 로직 처리 가능
                }
                else
                {
                    // 오류 처리
                    Console.WriteLine("Failed to fetch data: " + response.StatusCode);
                }
            });
        }

        public string Read(String szItemName)
        {
            var request = new RestRequest($"Advanced/{szItemName}", Method.GET);
            var StateCheck = restClient.Execute(request);
            if (StateCheck.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic response = JsonConvert.DeserializeObject<dynamic>(StateCheck.Content);
                return response.ToString();
            }
            else
            {
                return null;
            }
        }
        public List<Preset> ReadPresets(string szItemName)
        {
        #if _CARBIDE
            var request = new RestRequest($"Advanced/{szItemName}", Method.GET);
            var StateCheck = restClient.Execute(request);

            if (StateCheck.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var presets = JsonConvert.DeserializeObject<List<Preset>>(StateCheck.Content);
                return presets;
            }
            else
            {
                return null; // 오류 발생 시 null 반환
            }
        #else
            return null;
        #endif
        }

        public bool Write(String szItemName, Object Obj)
        {
            var request = new RestRequest($"Advanced/{szItemName}", Method.PUT); // PUT 메서드를 사용하여 데이터를 서버에 업데이트
            request.RequestFormat = DataFormat.Json;
            request.AddBody(Obj); // Advanced 객체를 JSON으로 직렬화하여 요청 본문에 추가

            var response = restClient.Execute(request);
            return (response.StatusCode == System.Net.HttpStatusCode.OK);
            //{
            //    throw new Exception("Failed to update Advanced data on the server.");
            //}
        }

        public class Burst
        {
            public bool IsAvailable { get; set; }
        }

        public class Sppt
        {
            public bool IsAvailable { get; set; }
        }

        public class Scim
        {
            public bool IsAvailable { get; set; }
        }

        public class NsModeSwitcher
        {
            public bool IsAdjustablePulseDuration { get; set; }
            public bool IsAvailable { get; set; }
        }

        public class StaticCompressor
        {
            public int PulseDuration { get; set; }
            public bool IsAvailable { get; set; }
        }

        public class AvailableAttenuator
        {
            public string Type { get; set; }
            public bool IsMaster { get; set; }
        }

        public class Attenuation
        {
            public List<AvailableAttenuator> AvailableAttenuators { get; set; }
        }

        public class HarmonicsModule
        {
            public List<object> AvailableHarmonics { get; set; }
            public bool HasPowerMeter { get; set; }
        }

        public class OptionalFeatures
        {
            public Burst Burst { get; set; }
            public Sppt Sppt { get; set; }
            public Scim Scim { get; set; }
            public NsModeSwitcher NsModeSwitcher { get; set; }
            public StaticCompressor StaticCompressor { get; set; }
            public Attenuation Attenuation { get; set; }
            public HarmonicsModule HarmonicsModule { get; set; }
        }

        public class AvailableFeature
        {
            public List<string> PermanentFeatures { get; set; }
            public OptionalFeatures OptionalFeatures { get; set; }
        }

        public class CurrentStateAsPreset
        {
            public string Name { get; set; }
            public double TargetPower { get; set; }
            public double RaFrequency { get; set; }
            public double PulseDuration { get; set; }
            public int PpDivider { get; set; }
            public int PpOffTiming { get; set; }
            public int RaOnDelayTiming { get; set; }
            public int HvVoltage { get; set; }
            public double PhotodiodeFactor { get; set; }
            public int PhotodiodeOffset { get; set; }
            public int Harmonic { get; set; }
            public int AttenuatorPercentage { get; set; }
            public double BurstParameterN { get; set; }
            public double BurstParameterP { get; set; }
            public double BurstEnvelopeControlParameterN { get; set; }
            public double BurstEnvelopeControlParameterP { get; set; }
            public bool NanosecondMode { get; set; }
            public int PulseEnvelope { get; set; }
        }

        public class PresetLink
        {
            public string Href { get; set; }
        }
        public class Preset
        {
            public string Name { get; set; }
            public double TargetPower { get; set; }
            public double RaFrequency { get; set; }
            public double PulseDuration { get; set; }
            public int PpDivider { get; set; }
            public int PpOffTiming { get; set; }
            public int RaOnDelayTiming { get; set; }
            public int HvVoltage { get; set; }
            public double PhotodiodeFactor { get; set; }
            public int PhotodiodeOffset { get; set; }
            public int Harmonic { get; set; }
            public int AttenuatorPercentage { get; set; }
            public double BurstParameterN { get; set; }
            public double BurstParameterP { get; set; }
            public double BurstEnvelopeControlParameterN { get; set; }
            public double BurstEnvelopeControlParameterP { get; set; }
            public bool NanosecondMode { get; set; }
            public int PulseEnvelope { get; set; }
        }

        public class Range
        {
            public int From { get; set; }
            public int To { get; set; }
        }

    }
    #endregion

    #region public class Chiller
    public class Chiller
    {
        private RestClient restClient;
        private string _baseUrl;

        public bool Physical = false;
        public Chiller()
        {
            // 생성자에서 필요한 리스트 등을 초기화할 수 있습니다.
        }

        public void Open(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
            _baseUrl = baseUrl;
        }

        public void Close()
        {
            if (restClient != null)
            {
                restClient = null; // RestClient 자원 해제
                Console.WriteLine("Chiller module closed.");
            }
        }

        public bool IsOn { get; set; }

        public double ActualTemperature { get; set; }

        public double TargetTemperature { get; set; }

        public bool waitFlag = false;
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public void CancelPreviousRequest()
        {
            cancellationTokenSource.Cancel();//이전 요청 취소
            cancellationTokenSource = new CancellationTokenSource();
        }
        public Chiller Read()
        {
            //logger.EnterMethod("Chiller_Read");
            var StateCheck = restClient.Execute(new RestRequest("Chiller", Method.GET));

            // logger.SendMsg(StateCheck.Content.ToString());

            var response = JsonConvert.DeserializeObject<Chiller>(StateCheck.Content);
            IsOn = response.IsOn;
            ActualTemperature = response.ActualTemperature;
            TargetTemperature = response.TargetTemperature;
            //logger.ExitMethod("Chiller_Read");
            return response;
        }

        public void ReadAsync()
        {
            CancelPreviousRequest();
            var request = new RestRequest("Chiller", Method.GET);
            waitFlag = true;
            restClient.ExecuteAsync(request, (response) =>
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseData = JsonConvert.DeserializeObject<Chiller>(response.Content);

                    // 데이터 할당
                    IsOn = responseData.IsOn;
                    ActualTemperature = responseData.ActualTemperature;
                    TargetTemperature = responseData.TargetTemperature;
                    // 추가적인 로직 처리 가능
                    waitFlag = false;
                }
                else
                {
                    // 오류 처리
                    Console.WriteLine("Failed to fetch data: " + response.StatusCode);
                }
            });
        }

        public string Read(String szItemName)
        {
            var request = new RestRequest($"Chiller/{szItemName}", Method.GET);
            var StateCheck = restClient.Execute(request);
            if (StateCheck.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic response = JsonConvert.DeserializeObject<dynamic>(StateCheck.Content);
                return response.ToString();
            }
            else
            {
                return null;
            }
        }
        public bool Write(String szItemName)
        {
            var request = new RestRequest($"Chiller/{szItemName}", Method.POST); // PUT 메서드를 사용하여 데이터를 서버에 업데이트            
            var response = restClient.Execute(request);
            return (response.StatusCode == System.Net.HttpStatusCode.OK);
            //{
            //    throw new Exception("Failed to update Advanced data on the server.");
            //}
        }

        public bool Write(String szItemName, Object Obj)
        {
            var request = new RestRequest($"Chiller/{szItemName}", Method.PUT); // PUT 메서드를 사용하여 데이터를 서버에 업데이트
            request.RequestFormat = DataFormat.Json;
            request.AddBody(Obj); // Advanced 객체를 JSON으로 직렬화하여 요청 본문에 추가

            var response = restClient.Execute(request);
            return (response.StatusCode == System.Net.HttpStatusCode.OK);
            //{
            //    throw new Exception("Failed to update Advanced data on the server.");
            //}
        }

        public bool TurnOn()
        {
            return Write("TurnOn");
        }

        public bool TurnOff()
        {
            return Write("TurnOff");
        }

        public bool SetTargetTemperature(double value)
        {
            return Write("TargetTemperature", value);
        }

    }
    #endregion
}
