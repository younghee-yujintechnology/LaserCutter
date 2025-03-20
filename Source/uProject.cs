using System;
using System.Collections;
using System.ComponentModel;

using DaekhonSystem;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    #region Define.. 
    public enum Direction
    {
        CW,
        CCW
    };
    public enum Tool
    {
        Scanner,
        Nozzle
    };

    #endregion

    public enum SortMethod
    {
        Method1 = 0,
        Method2,
        Method3,
        Method4,
    }

    public enum AlignMethod
    {
        Align2P_1_2 = 0,
        Align2P_1_3,
        Align2P_1_4,
        Align4P
    }

    #region public class LayerInfo
    public class LayerInfo
    {
        public String szColor;
    
        public LayerInfo() 
        {
            // logger.SendMsg("LayerInfo.Create()");
        }

        public void Dispose()
        {
            // logger.SendMsg($"LayerInfo.Dispose(): {Name}");
        }

        public LayerInfo(string aName, bool aUsed, Tool atool, Direction aDirection, StartPoint aStartPoint, double aLaserPower, double aPulsePitch, double aZOffset, bool sort)
        {
            Name = aName;
            Used = aUsed;
            Tool = atool;
            Direction = aDirection;
            LaserPower = aLaserPower;
            PulsePitch = aPulsePitch;
            ZOffset = aZOffset;
            Sort = sort;
            // logger.SendMsg("LayerInfo.Create(aName, aUsed..)");
        }

        public string Name { get; set; }

        public bool Used { get; set; }

        public Tool Tool { get; set; }


        public Direction Direction { get; set; }

        public double LaserPower { get; set; }

        public double PulsePitch { get; set; }

        public double ZOffset { get; set; }

        public bool Sort { get; set; }

        public int Count;

        public override string ToString() //**
        {
            return $"{Name}, {szColor}, {Used}, {Tool}, {Direction}, {LaserPower}, {PulsePitch}, {ZOffset}, {Sort}"; //**
        }
    }
    #endregion

    #region public class LayerCollection : CollectionBase
    public class LayerCollection : CollectionBase
    {
        public event EventHandler CollectionChanged;

        public void Add(LayerInfo layerInfo)
        {
            if (layerInfo != null)
            {
                List.Add(layerInfo);
                OnCollectionChanged(); // 컬렉션이 변경되었음을 알림
            }
            else
            {
                throw new ArgumentNullException(nameof(layerInfo));
            }
        }

        public new void Clear()
        {
            foreach (LayerInfo layerInfo in List)
            {
                layerInfo.Dispose(); // 각 LayerInfo의 Dispose 호출
            }
            base.Clear();
            OnCollectionChanged();
        }

        public void Remove(string aName)
        {
            for (int i = 0; i < List.Count; i++)
            {
                LayerInfo layer = (LayerInfo)List[i];
                if (layer.Name == aName)
                {
                    layer.Dispose(); // LayerInfo의 Dispose 호출
                    List.Remove(layer);
                    OnCollectionChanged(); // 컬렉션 변경 알림
                    return;
                }
            }
        }

        protected virtual void OnCollectionChanged()
        {
            CollectionChanged?.Invoke(this, EventArgs.Empty);
        }

        public LayerInfo GetLayer(string aName)
        {
            foreach (LayerInfo layer in List)
            {
                if (layer.Name == aName)
                {
                    return layer;
                }
            }
            return null;
        }

        public LayerInfo this[int index]
        {
            get { return (LayerInfo)List[index]; }
        }

        // 새로 추가된 메서드: 항목을 위로 이동
        public void MoveUp(int index)
        {
            if (index <= 0 || index >= List.Count)
            {
                return;
            }

            var item = List[index];
            List.RemoveAt(index);
            List.Insert(index - 1, item);
        }

        // 새로 추가된 메서드: 항목을 아래로 이동
        public void MoveDown(int index)
        {
            if (index < 0 || index >= List.Count - 1)
            {
                return;
            }

            var item = List[index];
            List.RemoveAt(index);
            List.Insert(index + 1, item);
        }
    }
    #endregion

    #region public class MotionParameter
    public class MotionParameter
    {
        public MotionParameter() 
        { 
        }

        public MotionParameter(string axis, double jogSpeedLow, double jogTALow, double jogTSLow,
                               double jogSpeedMiddle, double jogTAMiddle, double jogTSMiddle,
                               double jogSpeedHigh, double jogTAHigh, double jogTSHigh,
                               double moveSpeed, double limitMinus, double limitPlus)
        {
            Axis = axis;
            JogSpeedLow = jogSpeedLow;
            JogTALow = jogTALow;
            JogTSLow = jogTSLow;
            JogSpeedMiddle = jogSpeedMiddle;
            JogTAMiddle = jogTAMiddle;
            JogTSMiddle = jogTSMiddle;
            JogSpeedHigh = jogSpeedHigh;
            JogTAHigh = jogTAHigh;
            JogTSHigh = jogTSHigh;
            LimitMinus = limitMinus;
            LimitPlus = limitPlus;
        }
        public string Axis { get; set; }
        public double JogSpeedLow { get; set; }
        public double JogTALow { get; set; }
        public double JogTSLow { get; set; }
        public double JogSpeedMiddle { get; set; }
        public double JogTAMiddle { get; set; }
        public double JogTSMiddle { get; set; }
        public double JogSpeedHigh { get; set; }
        public double JogTAHigh { get; set; }
        public double JogTSHigh { get; set; }
        public double LimitMinus { get; set; }
        public double LimitPlus { get; set; }
    }

    #endregion

    #region public class Model1
    public class Model1
    {
        private LayerCollection layerCollection = new LayerCollection();

        private int mVacuumIterval;
        private int mUseVacuumCount;

        public Model1() { }

        public void Clear()
        {
            // LayerCollection을 비우고 각 LayerInfo의 Dispose를 호출
            layerCollection.Clear();

            // 다른 멤버 변수들을 초기화
            mLaserPower = 0;
            mPulsePitch = 0;
            mRepeatCount = 0;
            mZOffset = 0;
            mManualShiftX = 0;
            mManualShiftY = 0;
            mGlassSizeX = 0;
            mGlassSizeY = 0;

            mAlignMethod = AlignMethod.Align2P_1_2;
            mAlignUse = false;
            
            mVacuumIterval = 0;
            mUseVacuumCount = 0;
        }

        #region property public LayerCollection Layers 
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public LayerCollection Layers
        {
            get { return layerCollection; }
            set { layerCollection = value; }
        }
        #endregion

        #region property public bool AlignUse
        private bool mAlignUse = false;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool AlignUse
        {
            get { return mAlignUse; }
            set { mAlignUse = value; }
        }
        #endregion

        #region property public AlignMethod AlignMethod
        private AlignMethod mAlignMethod = AlignMethod.Align2P_1_2;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AlignMethod AlignMethod
        {
            get { return mAlignMethod; }
            set { mAlignMethod = value; }
        }
        #endregion

        #region property public double GlassSizeX
        private double mGlassSizeX;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GlassSizeX
        {
            get { return mGlassSizeX; }
            set { mGlassSizeX = value; }
        }
        #endregion

        #region property public double GlassSizeY
        private double mGlassSizeY;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GlassSizeY
        {
            get { return mGlassSizeY; }
            set { mGlassSizeY = value; }
        }
        #endregion

        #region property public double LaserPower
        private double mLaserPower;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double LaserPower
        {
            get { return mLaserPower; }
            set { mLaserPower = value; }
        }
        #endregion

        #region property public double ManualShiftX
        private double mManualShiftX;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double ManualShiftX
        {
            get { return mManualShiftX; }
            set { mManualShiftX = value; }
        }
        #endregion

        #region property public double ManualShiftY
        private double mManualShiftY;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double ManualShiftY
        {
            get { return mManualShiftY; }
            set { mManualShiftY = value; }
        }
        #endregion

        #region property public double PulsePitch
        private double mPulsePitch;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double PulsePitch
        {
            get { return mPulsePitch; }
            set { mPulsePitch = value; }
        }
        #endregion

        #region property public int RepeatCount
        private int mRepeatCount;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int RepeatCount
        {
            get
            {
                if (mRepeatCount <= 0) mRepeatCount = 1;
                return mRepeatCount;
            }

            set { mRepeatCount = value; }
        }
        #endregion

        #region property public StartPoint StartPoint
        private StartPoint mStartPoint;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public StartPoint StartPoint
        {
            get { return mStartPoint; }
            set { mStartPoint = value; }
        }
        #endregion

        public double VisionShiftX;
        public double VisionShiftY;

        public double ShiftX
        {
            get
            {
                return ManualShiftX + VisionShiftX;
            }
        }

        public double ShiftY
        {
            get
            {
                return ManualShiftY + VisionShiftY;
            }
        }

        #region property public Thickness
        private double mThickness;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double Thickness
        {
            get
            {
                if (mThickness <= 0) mThickness = 1;
                return mThickness;
            }
            set { mThickness = value; }
        }
        #endregion

        #region property public double VacuumIterval
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int VacuumIterval
            {
            get { return mVacuumIterval; }
            set { mVacuumIterval = value; }
        }
        #endregion

        #region property public double UseVacuumCount
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int UseVacuumCount
        {
            get { return mUseVacuumCount; }
            set { mUseVacuumCount = value; }
        }
        #endregion

        #region property public double ZOffset
        private double mZOffset;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double ZOffset
        {
            get { return mZOffset; }
            set { mZOffset = value; }
        }
        #endregion

        public int UsedCount()
        {
            int Result = 0;

            for (int nIndex = 0; nIndex < Layers.Count; nIndex++)
            {
                if ((Layers[nIndex].Name != "0") && (Layers[nIndex].Used == true))
                {
                    Result = Result + 1;
                }
            }

            return Result;
        }
        public StringList ToStringList()
        {
            StringList Result = new StringList();

            Result.Add(String.Format("    Model1"));
            Result.Add("    {");
            Result.Add(String.Format("        LaserPower = {0:F3}", LaserPower));
            Result.Add(String.Format("        StartPoint = {0}", StartPoint.ToString()));
            Result.Add(String.Format("        PulsePitch = {0:F3}", PulsePitch));
            Result.Add(String.Format("        Thickness = {0:F3}", Thickness));
            Result.Add(String.Format("        ZOffset = {0:F3}", ZOffset));
            Result.Add(String.Format("        ShiftXY = {0:F3}, {1:F3}", ManualShiftX, ManualShiftY));
            Result.Add(String.Format("        GlassSizeXY = {0:F3}, {1:F3}", GlassSizeX, GlassSizeY));
            Result.Add("    }");

            return Result;
        }
    }
    #endregion

    #region public class Model2
    public class Model2
    {
        private LayerCollection layerCollection = new LayerCollection();
        
        private string mComment1;

        public Model2()
        {
        }

        public void Clear()
        {
            // LayerCollection을 비우고 각 LayerInfo의 Dispose를 호출
            layerCollection.Clear();

            // 다른 멤버 변수들을 초기화

            mXCount = 1;
            mYCount = 1;
            mGapX = 0.0;
            mGapY = 0.0;

            mComment1 = string.Empty;
            mSortMethod = SortMethod.Method1; // 기본값으로 초기화
        }


        #region property public LayerCollection Layers 
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public LayerCollection Layers
        {
            get { return layerCollection; }
            set { layerCollection = value; }
        }
        #endregion

        #region property public bool AlignUse
        private bool mAlignUse = false;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool AlignUse
        {
            get { return mAlignUse; }
            set { mAlignUse = value; }
        }
        #endregion

        #region property public AlignMethod AlignMethod
        private AlignMethod mAlignMethod = AlignMethod.Align2P_1_2;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AlignMethod AlignMethod
        {
            get { return mAlignMethod; }
            set { mAlignMethod = value; }
        }
        #endregion

        #region property public string Comment1
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Comment1
        {
            get { return mComment1; }
            set { mComment1 = value; }
        }
        #endregion

        #region property public double GapX
        private double mGapX;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GapX
        {
            get { return mGapX; }
            set { mGapX = value; }
        }
        #endregion

        #region property public double GapY
        private double mGapY;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GapY
        {
            get { return mGapY; }
            set { mGapY = value; }
        }
        #endregion

        #region property public double GlassSizeX
        private double mGlassSizeX;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GlassSizeX
        {
            get { return mGlassSizeX; }
            set { mGlassSizeX = value; }
        }
        #endregion

        #region property public double GlassSizeY
        private double mGlassSizeY;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GlassSizeY
        {
            get { return mGlassSizeY; }
            set { mGlassSizeY = value; }
        }
        #endregion

        #region property public double LaserPower
        private double mLaserPower;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double LaserPower
        {
            get { return mLaserPower; }
            set { mLaserPower = value; }
        }
        #endregion

        #region property public double ManualShiftX
        private double mManualShiftX;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double ManualShiftX
        {
            get { return mManualShiftX; }
            set { mManualShiftX = value; }
        }
        #endregion

        #region property public double ManualShiftY
        private double mManualShiftY;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double ManualShiftY
        {
            get { return mManualShiftY; }
            set { mManualShiftY = value; }
        }
        #endregion

        #region property public double PulsePitch
        private double mPulsePitch;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double PulsePitch
        {
            get { return mPulsePitch; }
            set { mPulsePitch = value; }
        }
        #endregion

        #region property public SortMethod SortMethod
        private SortMethod mSortMethod = SortMethod.Method1;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SortMethod SortMethod
        {
            get { return mSortMethod; }
            set { mSortMethod = value; }
        }
        #endregion

        #region property public StartPoint StartPoint
        private StartPoint mStartPoint;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public StartPoint StartPoint
        {
            get { return mStartPoint; }
            set { mStartPoint = value; }
        }
        #endregion

        #region property public Thickness
        private double mThickness;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double Thickness
        {
            get
            {
                if (mThickness <= 0) mThickness = 1;
                return mThickness;
            }
            set { mThickness = value; }
        }
        #endregion

        #region property public int XCount
        private int mXCount = 1;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int XCount
        {
            get
            {
                if (mXCount <= 1)
                {
                    mXCount = 1;
                }
                return mXCount;
            }
            set
            {
                if (mXCount >= 1)
                {
                    mXCount = value;
                }
            }
        }
        #endregion

        #region property public int YCount
        private int mYCount = 1;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int YCount
        {
            get
            {
                if (mYCount <= 1)
                {
                    mYCount = 1;
                }
                return mYCount;
            }
            set
            {
                if (mYCount >= 1)
                {
                    mYCount = value;
                }
            }
        }
        #endregion

        #region property public double ZOffset
        private double mZOffset;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double ZOffset
        {
            get { return mZOffset; }
            set { mZOffset = value; }
        }
        #endregion


        public int UsedCount()
        {
            int Result = 0;

            for (int nIndex = 0; nIndex < Layers.Count; nIndex++)
            {
                if ((Layers[nIndex].Name != "0") && (Layers[nIndex].Used == true) && Layers[nIndex].Count != 0)
                {
                    Result = Result + 1;
                }
            }

            return Result;
        }

        public StringList ToStringList()
        {
            StringList Result = new StringList();

            Result.Add(String.Format("    Model2"));
            Result.Add("    {");
            Result.Add(String.Format("        LaserPower = {0:F3}", LaserPower));
            Result.Add(String.Format("        StartPoint = {0}", StartPoint.ToString()));
            Result.Add(String.Format("        PulsePitch = {0:F3}", PulsePitch));
            Result.Add(String.Format("        Thickness = {0:F3}", Thickness));
            Result.Add(String.Format("        ZOffset = {0:F3}", ZOffset));
            Result.Add(String.Format("        ArrayXY = {0}, {1}", XCount, YCount));
            Result.Add(String.Format("        ShiftXY = {0:F3}, {1:F3}", ManualShiftX, ManualShiftY));
            Result.Add(String.Format("        GapXY = {0:F3}, {1:F3}", GapX, GapY));
            Result.Add("    }");

            return Result;
        }
    }
    #endregion

    #region public class Model3
    public class Model3
    {
        private LayerCollection layerCollection = new LayerCollection();

        //0이면 cell, 1이면 Circle
        private int mStartPos;
        private double mGapX;
        private double mGapY;
        private double mWidth;
        private double mHeight;
        private double mRadius;

        private bool mUseBreakingLine;
        private bool mLineDir;
        private double mBreakingLineLength;
        private double mBreakingLineOffset;

        private string mComment1;
        private string mComment2;

        private SortMethod mSortMethod = SortMethod.Method1;

        public Model3() 
        { 
        }

        public void Clear()
        {
            // LayerCollection을 비우고 각 LayerInfo의 Dispose를 호출
            layerCollection.Clear();

            // 다른 멤버 변수들을 기본값으로 초기화
            mCadFile = string.Empty;
            mLaserPower = 0;
            mPulsePitch = 0;
            mRepeatCount = 1;
            mZOffset = 0;

            mSelectType = 0;
            mStartPos = 0;
            mXCount = 1;
            mYCount = 1;
            mGapX = 0;
            mGapY = 0;
            mWidth = 0;
            mHeight = 0;
            mRadius = 0;

            mGlassSizeX = 0.0;
            mGlassSizeY = 0.0;  

            mUseBreakingLine = false;
            mLineDir = false;
            mBreakingLineLength = 0;
            mBreakingLineOffset = 0;

            mComment1 = string.Empty;
            mComment2 = string.Empty;
        }

        #region property public LayerCollection Layers 
  //      [Browsable(true)]
  //      [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public LayerCollection Layers
        {
            get { return layerCollection; }
            set { layerCollection = value; }
        }
        #endregion

        #region property public string CadFile
        private string mCadFile;

        [Browsable(true)]
        public string CadFile
        {
            get { return mCadFile; }
            set { mCadFile = value; }
        }
        #endregion

        #region property public double GapX
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GapX
        {
            get { return mGapX; }
            set { mGapX = value; }
        }
        #endregion

        #region property public double GapY
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GapY
        {
            get { return mGapY; }
            set { mGapY = value; }
        }
        #endregion

        #region property public double GlassSizeX
        private double mGlassSizeX;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GlassSizeX
        {
            get 
            {
                if (mGlassSizeX <= 0) mGlassSizeX = 0;
                return mGlassSizeX; 
            }
            set { mGlassSizeX = value; }
        }
        #endregion

        #region property public double GlassSizeY
        private double mGlassSizeY;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double GlassSizeY
        {
            get 
            {
                if (mGlassSizeY <= 0) mGlassSizeY = 0;
                return mGlassSizeY; 
            }
            set { mGlassSizeY = value; }
        }
        #endregion
        
        #region property public double LaserPower
        private double mLaserPower;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double LaserPower
        {
            get { return mLaserPower; }
            set { mLaserPower = value; }
        }
        #endregion

        #region property public double PulsePitch
        private double mPulsePitch;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double PulsePitch
        {
            get { return mPulsePitch; }
            set { mPulsePitch = value; }
        }
        #endregion

        #region property public int RepeatCount
        private int mRepeatCount;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int RepeatCount
        {
            get
            {
                if (mRepeatCount <= 0) mRepeatCount = 1;
                return mRepeatCount;
            }
            set { mRepeatCount = value; }
        }
        #endregion

        #region property public int SelectType
        private int mSelectType;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int SelectType
        {
            get { return mSelectType; }
            set { mSelectType = value; }
        }
        #endregion

        #region property public int StartPos
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int StartPos
        {
            get { return mStartPos; }
            set { mStartPos = value; }
        }
        #endregion


        #region property public StartPoint StartPoint
        private StartPoint mStartPoint;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public StartPoint StartPoint
        {
            get { return mStartPoint; }
            set { mStartPoint = value; }
        }
        #endregion

        #region property public Thickness
        private double mThickness;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double Thickness
        {
            get
            {
                if (mThickness <= 0) mThickness = 1;
                return mThickness;
            }
            set { mThickness = value; }
        }
        #endregion

        #region property public double ZOffset
        private double mZOffset;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double ZOffset
        {
            get { return mZOffset; }
            set { mZOffset = value; }
        }
        #endregion


        #region property public int XCount
        private int mXCount;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int XCount
        {
            get 
            {
                if (mXCount <= 1) mXCount = 1;
                return mXCount; 
            }
            set { mXCount = value; }
        }
        #endregion

        #region property public int YCount
        private int mYCount;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int YCount
        {
            get 
            {
                if (mYCount <= 1) mYCount = 1;
                return mYCount; 
            }
            set { mYCount = value; }
        }
        #endregion

        #region property public double Width
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double Width
        {
            get 
            {
                if (mWidth <= 0) mWidth = 10.0;
                return mWidth; 
            }
            set { mWidth = value; }
        }
        #endregion

        #region property public double Height
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double Height
        {
            get 
            {
                if (mHeight <= 0) mHeight = 10.0;
                return mHeight; 
            }
            set { mHeight = value; }
        }
        #endregion

        #region property public double Radius
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double Radius
        {
            get 
            {
                if (mRadius <= 0) mRadius = 3.0;
                return mRadius; 
            }
            set { mRadius = value; }
        }
        #endregion

        #region property public bool UseBreakingLine
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool UseBreakingLine
        {
            get { return mUseBreakingLine; }
            set { mUseBreakingLine = value; }
        }
        #endregion

        #region property public bool LineDir
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool LineDir
        {
            get { return mLineDir; }
            set { mLineDir = value; }
        }
        #endregion

        #region property public double BreakingLineLength
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double BreakingLineLength
        {
            get 
            {
                if (mBreakingLineLength <= 0.0) mBreakingLineLength = 1.0;
                return mBreakingLineLength; 
            }
            set { mBreakingLineLength = value; }
        }
        #endregion

        #region property public double BreakingLineOffset
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double BreakingLineOffset
        {
            get { return mBreakingLineOffset; }
            set { mBreakingLineOffset = value; }
        }
        #endregion

        #region property public string Comment1
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Comment1
        {
            get { return mComment1; }
            set { mComment1 = value; }
        }
        #endregion

        #region property public string Comment2
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Comment2
        {
            get { return mComment2; }
            set { mComment2 = value; }
        }
        #endregion

        #region property public SortMethod SortMethod
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SortMethod SortMethod
        {
            get { return mSortMethod; }
            set { mSortMethod = value; }
        }
        #endregion


        public int UsedCount()
        {
            int Result = 0;

            for (int nIndex = 0; nIndex < Layers.Count; nIndex++)
            {
                if ((Layers[nIndex].Name != "0") && (Layers[nIndex].Used == true))
                {
                    Result = Result + 1;
                }
            }

            return Result;
        }

        public StringList ToStringList()
        {
            StringList Result = new StringList();

            Result.Add(String.Format("    Model3"));
            Result.Add("    {");
            Result.Add(String.Format("        LaserPower = {0:F3}", LaserPower));
            Result.Add(String.Format("        StartPoint = {0}", StartPoint.ToString()));
            Result.Add(String.Format("        PulsePitch = {0:F3}", PulsePitch));
            Result.Add(String.Format("        Thickness = {0:F3}", Thickness));
            Result.Add(String.Format("        ZOffset = {0:F3}", ZOffset));
            Result.Add(String.Format("        ArrayXY = {0}, {1}", XCount, YCount));
            Result.Add(String.Format("        GapXY = {0:F3}, {1:F3}", GapX, GapY));
            Result.Add(String.Format("        Size = {0:F3}, {1:F3}", Width, Height));
            Result.Add(String.Format("        Radius = {0:F3}", Radius));
            Result.Add("    }");

            return Result;
        }
    }
    #endregion

    #region public class LaserProject : dkProject 
    public class LaserProject : dkProject
    {
        private Model1 mModel1 = new Model1();
        private Model2 mModel2 = new Model2();
        private Model3 mModel3 = new Model3();

        public LaserProject ()
        {
            mCadFile = string.Empty;
        }

        #region property public double NozzleOffsetX
        private double mNozzleOffsetX;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double NozzleOffsetX
        {
            get { return mNozzleOffsetX; }
            set { mNozzleOffsetX = value; }
        }
        #endregion

        #region property public double NozzleOffsetY
        private double mNozzleOffsetY;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public double NozzleOffsetY
        {
            get { return mNozzleOffsetY; }
            set { mNozzleOffsetY = value; }
        }
        #endregion

        #region property public DateTime DateTime
        private DateTime mDateTime;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DateTime DateTime
        {
            get { return mDateTime; }
            set { mDateTime = value; }
        }
        #endregion

        #region property public string CadFile
        private string mCadFile;

        [Browsable(true)]
        public string CadFile
        {
            get { return mCadFile; }
            set { mCadFile = value; }
        }
        #endregion


        #region property public int MenuIndex
        private int mMenuIndex;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int MenuIndex
        {
            get { return mMenuIndex; }
            set { mMenuIndex = value; }
        }
        #endregion

        #region property public Model1 Model1
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Model1 Model1
        {
            get { return mModel1; }
            set { mModel1 = value; }
        }
        #endregion

        #region property public Model2 Model2
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Model2 Model2
        {
            get { return mModel2; }
            set { mModel2 = value; }
        }
        #endregion

        #region property public Model3 Model3
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Model3 Model3
        {
            get { return mModel3; }
            set { mModel3 = value; }
        }
        #endregion
    }
#endregion
}

