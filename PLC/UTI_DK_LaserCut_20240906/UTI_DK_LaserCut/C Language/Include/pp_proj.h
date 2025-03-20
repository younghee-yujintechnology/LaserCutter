
#ifndef _PP_PROJ_H_
#define _PP_PROJ_H_
//***********************************************************************************
// C header for accessing PMAC Global, CSGlobal, Ptr vars
// _PPScriptMode_ for Pmac Script like access global & csglobal
// global Mypvar - access with "Mypvar"
// global Myparray(32) - access with "Myparray(i)"
// csglobal Myqvar - access with "Myqvar(i)" where "i" is Coord #
// csglobal Myqarray(16) - access with "Myqvar(i,j)" where "j" is index
// _EnumMode_ for Pmac enum data type checking on Set & Get global functions
// Example
// global Mypvar
// csglobal Myqvar
// "SetGlobalVar(Myqvar, data)" will give a compile error because its a csglobal var.
// "SetCSGlobalVar(Mypvar, data)" will give a compile error because its a global var.
//************************************************************************************

#ifdef _PPScriptMode_
enum globalP {_globalP_=-1};
enum globalParray {_globalParray_=-1};
enum csglobalQ {_csglobalQ_=-1};
enum csglobalQarray {_csglobalQarray_=-1};

enum ptrM {_ptrM_=-1
,diTable1Start=7004
,diTable1Vacuum=7005
,diTable1Stop=7006
,diTable1Reset=7007
,diTable2Start=7010
,diTable2Vacuum=7011
,diTable2Stop=7012
,diTable2Reset=7013
,doTable1StartLamp=7106
,doTable1VacuumLamp=7107
,doTable1StopLamp=7108
,doTable1ResetLamp=7109
,doTable2StartLamp=7110
,doTable2VacuumLamp=7111
,doTable2StopLamp=7112
,doTable2ResetLamp=7113
,doTable1Pump1=7125
,doTable1Pump2=7128
,In_Main_PowerOn=7000
,In_EMO01_Btn=7001
,In_EMO02_Btn=7002
,In_EMO03_Btn=7003
,In_LeftUnit_Start_Btn=7004
,In_LeftUnit_Vac_Btn=7005
,In_LeftUnit_Stop_Btn=7006
,In_LeftUnit_ReSet_Btn=7007
,In_LeftUnit_Pressure_Sen=7008
,In_LeftUnit_Vac_Sen=7009
,In_RightUnit_Start_Btn=7010
,In_RightUnit_Vac_Btn=7011
,In_RightUnit_Stop_Btn=7012
,In_RightUnit_ReSet_Btn=7013
,In_RightUnit_Pressure_Sen=7014
,In_RightUnit_Vac_Sen=7015
,In_Stage_PowerOn=7016
,In_Leak_Sen=7017
,In_Door01_Sen=7018
,In_Door02_Sen=7019
,In_Door03_Sen=7020
,In_Door04_Sen=7021
,In_Door05_Sen=7022
,In_Spare_UX024=7023
,In_LeftUnit_Ionizer=7024
,In_RightUnit_Ionizer=7025
,In_BeamShutter_Close=7026
,In_BeamShutter_Open=7027
,In_PowerMeter_Open=7028
,In_PowerMeter_Close=7029
,In_LeftUnit_Area_Sen=7030
,In_RightUnit_Area_Sen=7031
,In_Spare_UX033=7032
,In_Spare_UX034=7033
,In_Spare_UX035=7034
,In_Spare_UX036=7035
,In_Spare_UX037=7036
,In_Spare_UX038=7037
,In_Spare_UX039=7038
,In_Spare_UX040=7039
,In_Spare_UX041=7040
,In_Spare_UX042=7041
,In_Spare_UX043=7042
,In_Spare_UX044=7043
,In_Spare_UX045=7044
,In_Spare_UX046=7045
,In_Spare_UX047=7046
,In_Spare_UX048=7047
,Out_Soft_PowerOff=7100
,Out_LED_Light_On=7101
,Out_SignalTower_Red=7102
,Out_SignalTower_Yellow=7103
,Out_SignalTower_Green=7104
,Out_SinalTower_Buzzer=7105
,Out_LeftUnit_Start_Btn_Lamp=7106
,Out_LeftUnit_Vac_Btn_Lamp=7107
,Out_LeftUnit_Stop_Btn_Lamp=7108
,Out_LeftUnit_ReSet_Btn_Lamp=7109
,Out_RightUnit_Start_Btn_Lamp=7110
,Out_RightUnit_Vac_Btn_Lamp=7111
,Out_RightUnit_Stop_Btn_Lamp=7112
,Out_RightUnit_ReSet_Btn_Lamp=7113
,Out_LeftUnit_Ionizer=7114
,Out_LeftUnit_IonizerSol=7115
,Out_RightUnit_Ionizer=7116
,Out_RightUnit_IonizerSol=7117
,Out_BeamShutter_Sol=7118
,Out_Dust_Collector=7119
,Out_OpticBox_Purge=7120
,Out_PowerMeter_Up=7121
,Out_PowerMeter_Dw=7122
,Out_SelectBoard=7123
,Out_ADV_On=7124
,Out_LeftUnit_VacPump01=7125
,Out_LeftUnit_VacPumpSol01=7126
,Out_LeftUnit_VacPumpSol02=7127
,Out_LeftUnit_VacPump02=7128
,Out_LeftUnit_VacPumpSol03=7129
,Out_LeftUnit_VacPumpSol04=7130
,Out_RightUnit_VacPump01=7131
,Out_RightUnit_VacPumpSol01=7132
,Out_RightUnit_VacPumpSol02=7133
,Out_RightUnit_VacPump02=7134
,Out_RightUnit_VacPumpSol03=7135
,Out_RightUnit_VacPumpSol04=7136
,Out_Spare_UX038=7137
,Out_Spare_UX039=7138
,Out_Spare_UX040=7139
,Out_Spare_UX041=7140
,Out_Spare_UX042=7141
,Out_Spare_UX043=7142
,Out_Spare_UX044=7143
,Out_Spare_UX045=7144
,Out_Spare_UX046=7145
,Out_Spare_UX047=7146
,Out_Spare_UX048=7147};
enum ptrMarray {_ptrMarray_=-1
,IO_Out=8192
,IOIn=8242
,Mtr_GetHomeFlag=8292
,Mtr_SetEcatTouchprobeFunction=8325
,Mtr_SetEcatTouchprobeStatus=8358
,Mtr_SetEcatErrorReset=8391
,Mtr_SetEcatSerovoOut=8424};
#define	XBusy	pshm->P[8192]
#define	XOriginDone	pshm->P[8193]
#define	XMotionDone	pshm->P[8194]
#define	XInPosition	pshm->P[8195]
#define	XCurPos	pshm->P[8196]
#define	XVelocity	pshm->P[8197]
#define	XInTargetPos	pshm->P[8198]
#define	XPositionTolerance	pshm->P[8199]
#define	Y1Busy	pshm->P[8200]
#define	Y1OriginDone	pshm->P[8201]
#define	Y1MotionDone	pshm->P[8202]
#define	Y1InPosition	pshm->P[8203]
#define	Y1CurPos	pshm->P[8204]
#define	Y1Velocity	pshm->P[8205]
#define	Y1InLoadPos	pshm->P[8206]
#define	Y1PositionTolerance	pshm->P[8207]
#define	Y2Busy	pshm->P[8208]
#define	Y2OriginDone	pshm->P[8209]
#define	Y2MotionDone	pshm->P[8210]
#define	Y2InPosition	pshm->P[8211]
#define	Y2CurPos	pshm->P[8212]
#define	Y2Velocity	pshm->P[8213]
#define	Y2InLoadPos	pshm->P[8214]
#define	Y2PositionTolerance	pshm->P[8215]
#define	ZBusy	pshm->P[8216]
#define	ZOriginDone	pshm->P[8217]
#define	ZMotionDone	pshm->P[8218]
#define	ZInPosition	pshm->P[8219]
#define	ZCurPos	pshm->P[8220]
#define	ZVelocity	pshm->P[8221]
#define	ZInTargetPos	pshm->P[8222]
#define	ZPositionTolerance	pshm->P[8223]
#define	Timer1	pshm->P[8224]
#define	Timer11	pshm->P[8225]
#define	Timer2	pshm->P[8226]
#define	Timer21	pshm->P[8227]
#define	MotorMoveStartTimeOut	pshm->P[8228]
#define	MotorMoveTimeOut	pshm->P[8229]
#define	MotorStopTime	pshm->P[8230]
#define	Table1EMOStopSwitch	pshm->P[8231]
#define	Table2EMOStopSwitch	pshm->P[8232]
#define	Table1StopSwitch	pshm->P[8233]
#define	Table2StopSwitch	pshm->P[8234]
#define	DownloadTimeOut1	pshm->P[8235]
#define	DownloadTimeOut2	pshm->P[8236]
#define	Table1ExeCount	pshm->P[8237]
#define	Table1Film	pshm->P[8238]
#define	Table1New	pshm->P[8239]
#define	Table1Step	pshm->P[8240]
#define	Table1LastStep	pshm->P[8241]
#define	Table1ErrorCode	pshm->P[8242]
#define	Table1Busy	pshm->P[8243]
#define	Table1Unload	pshm->P[8244]
#define	Table1Stop	pshm->P[8245]
#define	Table1EMOStop	pshm->P[8246]
#define	TempTable1Unload	pshm->P[8247]
#define	OldTable1Stop	pshm->P[8248]
#define	OldTable1EMOStop	pshm->P[8249]
#define	Table1LoadXPos	pshm->P[8250]
#define	Table1LoadYPos	pshm->P[8251]
#define	Table2Film	pshm->P[8252]
#define	Table2New	pshm->P[8253]
#define	Table2Step	pshm->P[8254]
#define	Table2LastStep	pshm->P[8255]
#define	Table2ErrorCode	pshm->P[8256]
#define	Table2Busy	pshm->P[8257]
#define	Table2Unload	pshm->P[8258]
#define	Table2Stop	pshm->P[8259]
#define	Table2EMOStop	pshm->P[8260]
#define	TempTable2Unload	pshm->P[8261]
#define	OldTable2Stop	pshm->P[8262]
#define	OldTable2EMOStop	pshm->P[8263]
#define	Table2LoadXPos	pshm->P[8264]
#define	Table2LoadYPos	pshm->P[8265]
#define	AutoRun	pshm->P[8266]
#define	Temp_IO_Out(i)	pshm->P[(8267+i)%MAX_P]
#define	Temp_IOIn(i)	pshm->P[(8317+i)%MAX_P]
#define	Temp_In_Main_PowerOn	pshm->P[8367]
#define	Temp_In_EMO01_Btn	pshm->P[8368]
#define	Temp_In_EMO02_Btn	pshm->P[8369]
#define	Temp_In_EMO03_Btn	pshm->P[8370]
#define	Temp_In_LeftUnit_Start_Btn	pshm->P[8371]
#define	Temp_In_LeftUnit_Vac_Btn	pshm->P[8372]
#define	Temp_In_LeftUnit_Stop_Btn	pshm->P[8373]
#define	Temp_In_LeftUnit_ReSet_Btn	pshm->P[8374]
#define	Temp_In_LeftUnit_Pressure_Sen	pshm->P[8375]
#define	Temp_In_LeftUnit_Vac_Sen	pshm->P[8376]
#define	Temp_In_RightUnit_Start_Btn	pshm->P[8377]
#define	Temp_In_RightUnit_Vac_Btn	pshm->P[8378]
#define	Temp_In_RightUnit_Stop_Btn	pshm->P[8379]
#define	Temp_In_RightUnit_ReSet_Btn	pshm->P[8380]
#define	Temp_In_RightUnit_Pressure_Sen	pshm->P[8381]
#define	Temp_In_RightUnit_Vac_Sen	pshm->P[8382]
#define	Temp_In_Stage_PowerOn	pshm->P[8383]
#define	Temp_In_Leak_Sen	pshm->P[8384]
#define	Temp_In_Door01_Sen	pshm->P[8385]
#define	Temp_In_Door02_Sen	pshm->P[8386]
#define	Temp_In_Door03_Sen	pshm->P[8387]
#define	Temp_In_Door04_Sen	pshm->P[8388]
#define	Temp_In_Door05_Sen	pshm->P[8389]
#define	Temp_In_Spare_UX024	pshm->P[8390]
#define	Temp_In_LeftUnit_Ionizer	pshm->P[8391]
#define	Temp_In_RightUnit_Ionizer	pshm->P[8392]
#define	Temp_In_BeamShutter_Close	pshm->P[8393]
#define	Temp_In_BeamShutter_Open	pshm->P[8394]
#define	Temp_In_PowerMeter_Open	pshm->P[8395]
#define	Temp_In_PowerMeter_Close	pshm->P[8396]
#define	Temp_In_LeftUnit_Area_Sen	pshm->P[8397]
#define	Temp_In_RightUnit_Area_Sen	pshm->P[8398]
#define	Temp_In_Spare_UX033	pshm->P[8399]
#define	Temp_In_Spare_UX034	pshm->P[8400]
#define	Temp_In_Spare_UX035	pshm->P[8401]
#define	Temp_In_Spare_UX036	pshm->P[8402]
#define	Temp_In_Spare_UX037	pshm->P[8403]
#define	Temp_In_Spare_UX038	pshm->P[8404]
#define	Temp_In_Spare_UX039	pshm->P[8405]
#define	Temp_In_Spare_UX040	pshm->P[8406]
#define	Temp_In_Spare_UX041	pshm->P[8407]
#define	Temp_In_Spare_UX042	pshm->P[8408]
#define	Temp_In_Spare_UX043	pshm->P[8409]
#define	Temp_In_Spare_UX044	pshm->P[8410]
#define	Temp_In_Spare_UX045	pshm->P[8411]
#define	Temp_In_Spare_UX046	pshm->P[8412]
#define	Temp_In_Spare_UX047	pshm->P[8413]
#define	Temp_In_Spare_UX048	pshm->P[8414]
#define	P2U_Mach_AllHomeExe	pshm->P[5000]
#define	P2U_Mach_MtrAllServoOn	pshm->P[5002]
#define	P2U_Mach_MtrAllServoOff	pshm->P[5003]
#define	P2U_Mach_PowerMeterChk	pshm->P[5004]
#define	P2U_Mach_ReadyExe	pshm->P[5005]
#define	P2U_Mach_MainDoorUnUse	pshm->P[5006]
#define	P2U_Mach_AreaSenUnUse	pshm->P[5007]
#define	P2U_Mach_SideDoorUnUse	pshm->P[5008]
#define	P2U_Mach_BuzzerUnUse	pshm->P[5009]
#define	P2U_Mach_LEDLampOn	pshm->P[5010]
#define	P2U_Mach_MotionTimeOut	pshm->P[5011]
#define	P2U_Mach_BuzzerStopExe	pshm->P[5012]
#define	P2U_Mach_LstageProgStart	pshm->P[5013]
#define	P2U_Mach_RstageProgStart	pshm->P[5014]
#define	P2U_Mach_AutoStop	pshm->P[5015]
#define	P2U_Mach_ReSetStart	pshm->P[5016]
#define	P2U_Mach_ReadyStatus	pshm->P[5017]
#define	P2U_Mach_UnitStartDelayTime	pshm->P[5018]
#define	P2U_Mach_ReserveUnUse	pshm->P[5019]
#define	P2U_Mach_AutoCompVentUnUse	pshm->P[5021]
#define	P2U_Mach_VacErrCheckUnUse	pshm->P[5022]
#define	P2U_Mach_AreaSenVentUnUse	pshm->P[5023]
#define	P2U_Mach_LookAheadAcc	pshm->P[5025]
#define	Temp_Mach_AllHomeExe	pshm->P[8415]
#define	Temp_Mach_MtrAllServoOn	pshm->P[8416]
#define	Temp_Mach_MtrAllServoOff	pshm->P[8417]
#define	Temp_Mach_PowerMeterChk	pshm->P[8418]
#define	Temp_Mach_ReadyExe	pshm->P[8419]
#define	Temp_Mach_MainDoorUnUse	pshm->P[8420]
#define	Temp_Mach_AreaSenUnUse	pshm->P[8421]
#define	Temp_Mach_SideDoorUnUse	pshm->P[8422]
#define	Temp_Mach_LED_Light_On	pshm->P[8423]
#define	Temp_Mach_BuzzerStopExe	pshm->P[8424]
#define	Temp_Mach_BuzzerUnUse	pshm->P[8425]
#define	Temp_Mach_UnitStartDelayTime	pshm->P[8426]
#define	Temp_Mach_ReserveUnUse	pshm->P[8427]
#define	Temp_Mach_AutoCompVentUnUse	pshm->P[8428]
#define	Temp_Mach_VacErrCheckUnUse	pshm->P[8429]
#define	Temp_Mach_AreaSenVentUnUse	pshm->P[8430]
#define	U2P_Mach_BitData01	pshm->P[5154]
#define	U2P_Mach_BitData02	pshm->P[5155]
#define	U2P_Mach_Status	pshm->P[5100]
#define	U2P_Mach_AllHomming	pshm->P[5101]
#define	U2P_Mach_AllHomeComp	pshm->P[5102]
#define	U2P_Mach_PowerMoterChkComp	pshm->P[5104]
#define	U2P_Mach_ReadyPosComp	pshm->P[5105]
#define	MotionEnd	pshm->P[8000]
#define	Temp_Mach_Status	pshm->P[8431]
#define	Temp_Mach_AllHomming	pshm->P[8432]
#define	Temp_Mach_AllHomeComp	pshm->P[8433]
#define	Temp_Mach_MotionTimeOut	pshm->P[8434]
#define	U2P_Lstage_BitData01	pshm->P[6154]
#define	U2P_Lstage_BitData02	pshm->P[6155]
#define	P2U_Lstage_ReadySt	pshm->P[6000]
#define	P2U_Lstage_AutoStart	pshm->P[6001]
#define	P2U_Lstage_MotionDownroadComp	pshm->P[6002]
#define	P2U_Lstage_Glessthickness	pshm->P[6004]
#define	Temp_Lstage_ReadySt	pshm->P[8435]
#define	Temp_Lstage_AutoStart	pshm->P[8436]
#define	Temp_Lstage_MotionDownroadComp	pshm->P[8437]
#define	Temp_Lstage_Glessthickness	pshm->P[8438]
#define	P2U_Lstage_ViAilgnUnUse	pshm->P[6009]
#define	P2U_Lstage_ViAilgnCts	pshm->P[6010]
#define	P2U_Lstage_ViAilgn01TrigComp	pshm->P[6011]
#define	P2U_Lstage_ViAilgn02TrigComp	pshm->P[6012]
#define	P2U_Lstage_ViAilgn03TrigComp	pshm->P[6013]
#define	P2U_Lstage_ViAilgn04TrigComp	pshm->P[6014]
#define	Temp_Lstage_ViAilgnUnUse	pshm->P[8439]
#define	Temp_Lstage_ViAilgnCts	pshm->P[8440]
#define	Temp_Lstage_ViAilgn01TrigComp	pshm->P[8441]
#define	Temp_Lstage_ViAilgn02TrigComp	pshm->P[8442]
#define	Temp_Lstage_ViAilgn03TrigComp	pshm->P[8443]
#define	Temp_Lstage_ViAilgn04TrigComp	pshm->P[8444]
#define	P2U_Lstage_VacUseCts	pshm->P[6016]
#define	Temp_Lstage_VacUseCts	pshm->P[8445]
#define	P2U_Lstage_Vac01Time	pshm->P[6018]
#define	P2U_Lstage_Vac02Time	pshm->P[6019]
#define	P2U_Lstage_Vac03Time	pshm->P[6020]
#define	P2U_Lstage_Vac04Time	pshm->P[6021]
#define	Temp_Lstage_Vac01Time	pshm->P[8446]
#define	Temp_Lstage_Vac02Time	pshm->P[8447]
#define	Temp_Lstage_Vac03Time	pshm->P[8448]
#define	Temp_Lstage_Vac04Time	pshm->P[8449]
#define	P2U_Lstage_AilgnMvStart	pshm->P[6023]
#define	P2U_Lstage_WorkPosMvStart	pshm->P[6024]
#define	P2U_Lstage_LoadingPosMvStart	pshm->P[6025]
#define	P2U_Lstage_VacStart	pshm->P[6026]
#define	P2U_Lstage_ReadyMvStart	pshm->P[6028]
#define	Temp_Lstage_AilgnMvStart	pshm->P[8450]
#define	Temp_Lstage_WorkPosMvStart	pshm->P[8451]
#define	Temp_Lstage_LoadingPosMvStart	pshm->P[8452]
#define	Temp_Lstage_ReadyMvStart	pshm->P[8453]
#define	U2P_Lstage_VacReadySt	pshm->P[6100]
#define	U2P_Lstage_AutoReadySt	pshm->P[6101]
#define	U2P_Lstage_MotionDownroadExe	pshm->P[6102]
#define	U2P_Lstage_Motioning	pshm->P[6103]
#define	U2P_Lstage_MotionComp	pshm->P[6104]
#define	U2P_Lstage_AutoRunComp	pshm->P[6105]
#define	Temp_Lstage_VacReadySt	pshm->P[8454]
#define	Temp_Lstage_AutoReadySt	pshm->P[8455]
#define	Temp_Lstage_MotionDownroadExe	pshm->P[8456]
#define	Temp_Lstage_Motioning	pshm->P[8457]
#define	Temp_Lstage_MotionComp	pshm->P[8458]
#define	Temp_Lstage_AutoRunComp	pshm->P[8459]
#define	U2P_Lstage_ViAilgnSeqComp	pshm->P[6109]
#define	U2P_Lstage_ViAilgn01TrigExe	pshm->P[6110]
#define	U2P_Lstage_ViAilgn02TrigExe	pshm->P[6111]
#define	U2P_Lstage_ViAilgn03TrigExe	pshm->P[6112]
#define	U2P_Lstage_ViAilgn04TrigExe	pshm->P[6113]
#define	Temp_Lstage_ViAilgnSeqComp	pshm->P[8460]
#define	Temp_Lstage_ViAilgn01TrigExe	pshm->P[8461]
#define	Temp_Lstage_ViAilgn02TrigExe	pshm->P[8462]
#define	Temp_Lstage_ViAilgn03TrigExe	pshm->P[8463]
#define	Temp_Lstage_ViAilgn04TrigExe	pshm->P[8464]
#define	U2P_Lstage_MachStatus	pshm->P[6116]
#define	U2P_Lstage_AilgnMvComp	pshm->P[6123]
#define	U2P_Lstage_WorkPosMvComp	pshm->P[6124]
#define	U2P_Lstage_LoadingPosMvComp	pshm->P[6125]
#define	U2P_Lstage_ReadyMvComp	pshm->P[6128]
#define	Temp_Lstage_MachStatus	pshm->P[8465]
#define	P2U_Rstage_ReadySt	pshm->P[7000]
#define	P2U_Rstage_AutoStart	pshm->P[7001]
#define	P2U_Rstage_MotionDownroadComp	pshm->P[7002]
#define	P2U_Rstage_Glessthickness	pshm->P[7004]
#define	Temp_Rstage_ReadySt	pshm->P[8466]
#define	Temp_Rstage_AutoStart	pshm->P[8467]
#define	Temp_Rstage_MotionDownroadComp	pshm->P[8468]
#define	Temp_Rstage_Glessthickness	pshm->P[8469]
#define	P2U_Rstage_ViAilgnUnUse	pshm->P[7009]
#define	P2U_Rstage_ViAilgnCts	pshm->P[7010]
#define	P2U_Rstage_ViAilgn01TrigComp	pshm->P[7011]
#define	P2U_Rstage_ViAilgn02TrigComp	pshm->P[7012]
#define	P2U_Rstage_ViAilgn03TrigComp	pshm->P[7013]
#define	P2U_Rstage_ViAilgn04TrigComp	pshm->P[7014]
#define	Temp_Rstage_ViAilgnUnUse	pshm->P[8470]
#define	Temp_Rstage_ViAilgnCts	pshm->P[8471]
#define	Temp_Rstage_ViAilgn01TrigComp	pshm->P[8472]
#define	Temp_Rstage_ViAilgn02TrigComp	pshm->P[8473]
#define	Temp_Rstage_ViAilgn03TrigComp	pshm->P[8474]
#define	Temp_Rstage_ViAilgn04TrigComp	pshm->P[8475]
#define	P2U_Rstage_VacUseCts	pshm->P[7016]
#define	Temp_Rstage_VacUseCts	pshm->P[8476]
#define	P2U_Rstage_Vac01Time	pshm->P[7018]
#define	P2U_Rstage_Vac02Time	pshm->P[7019]
#define	P2U_Rstage_Vac03Time	pshm->P[7020]
#define	P2U_Rstage_Vac04Time	pshm->P[7021]
#define	Temp_Rstage_Vac01Time	pshm->P[8477]
#define	Temp_Rstage_Vac02Time	pshm->P[8478]
#define	Temp_Rstage_Vac03Time	pshm->P[8479]
#define	Temp_Rstage_Vac04Time	pshm->P[8480]
#define	P2U_Rstage_AilgnMvStart	pshm->P[7023]
#define	P2U_Rstage_WorkPosMvStart	pshm->P[7024]
#define	P2U_Rstage_LoadingPosMvStart	pshm->P[7025]
#define	P2U_Rstage_VacStart	pshm->P[7026]
#define	P2U_Rstage_ReadyMvStart	pshm->P[7028]
#define	Temp_Rstage_AilgnMvStart	pshm->P[8481]
#define	Temp_Rstage_WorkPosMvStart	pshm->P[8482]
#define	Temp_Rstage_LoadingPosMvStart	pshm->P[8483]
#define	Temp_Rstage_ReadyMvStart	pshm->P[8484]
#define	U2P_Rstage_BitData01	pshm->P[7154]
#define	U2P_Rstage_BitData02	pshm->P[7155]
#define	U2P_Rstage_VacReadySt	pshm->P[7100]
#define	U2P_Rstage_AutoReadySt	pshm->P[7101]
#define	U2P_Rstage_MotionDownroadExe	pshm->P[7102]
#define	U2P_Rstage_Motioning	pshm->P[7103]
#define	U2P_Rstage_MotionComp	pshm->P[7104]
#define	U2P_Rstage_AutoRunComp	pshm->P[7105]
#define	Temp_Rstage_VacReadySt	pshm->P[8485]
#define	Temp_Rstage_AutoReadySt	pshm->P[8486]
#define	Temp_Rstage_MotionDownroadExe	pshm->P[8487]
#define	Temp_Rstage_Motioning	pshm->P[8488]
#define	Temp_Rstage_MotionComp	pshm->P[8489]
#define	Temp_Rstage_AutoRunComp	pshm->P[8490]
#define	U2P_Rstage_ViAilgnSeqComp	pshm->P[7109]
#define	U2P_Rstage_ViAilgn01TrigExe	pshm->P[7110]
#define	U2P_Rstage_ViAilgn02TrigExe	pshm->P[7111]
#define	U2P_Rstage_ViAilgn03TrigExe	pshm->P[7112]
#define	U2P_Rstage_ViAilgn04TrigExe	pshm->P[7113]
#define	Temp_Rstage_ViAilgnSeqComp	pshm->P[8491]
#define	Temp_Rstage_ViAilgn01TrigExe	pshm->P[8492]
#define	Temp_Rstage_ViAilgn02TrigExe	pshm->P[8493]
#define	Temp_Rstage_ViAilgn03TrigExe	pshm->P[8494]
#define	Temp_Rstage_ViAilgn04TrigExe	pshm->P[8495]
#define	U2P_Rstage_MachStatus	pshm->P[7116]
#define	U2P_Rstage_AilgnMvComp	pshm->P[7123]
#define	U2P_Rstage_WorkPosMvComp	pshm->P[7124]
#define	U2P_Rstage_LoadingPosMvComp	pshm->P[7125]
#define	U2P_Rstage_ReadyMvComp	pshm->P[7128]
#define	Temp_Rstage_MachStatus	pshm->P[8496]
#define	LinearX_SetMtReadyPos	pshm->P[4100]
#define	LinearX_SetMtLWorkStartPos	pshm->P[4101]
#define	LinearX_SetMtRWorkStartPos	pshm->P[4102]
#define	LinearX_SetMtLLoadingPos	pshm->P[4103]
#define	LinearX_SetMtRLoadingPos	pshm->P[4104]
#define	LinearX_SetMtLViAilgn01Pos	pshm->P[4105]
#define	LinearX_SetMtLViAilgn02Pos	pshm->P[4106]
#define	LinearX_SetMtLViAilgn03Pos	pshm->P[4107]
#define	LinearX_SetMtLViAilgn04Pos	pshm->P[4108]
#define	LinearX_SetMtRViAilgn01Pos	pshm->P[4109]
#define	LinearX_SetMtRViAilgn02Pos	pshm->P[4110]
#define	LinearX_SetMtRViAilgn03Pos	pshm->P[4111]
#define	LinearX_SetMtRViAilgn04Pos	pshm->P[4112]
#define	LinearX_SetMtPowerMeterPos	pshm->P[4113]
#define	LinearX_SetMtSpare10Pos	pshm->P[4114]
#define	LinearX_SetMtPosMvSpd	pshm->P[4115]
#define	LinearX_SetMtPosMvTA	pshm->P[4116]
#define	LinearX_SetReadyPosMvSpd	pshm->P[4117]
#define	LinearX_SetReadyPosMvTA	pshm->P[4118]
#define	LinearX_SetMtWorkStartPosMvSpd	pshm->P[4119]
#define	LinearX_SetMtWorkStartPosMvTA	pshm->P[4120]
#define	LinearX_SetAlignPosMvSpd	pshm->P[4121]
#define	LinearX_SetAlignPosMvTA	pshm->P[4122]
#define	LinearX_SetLoadingPosMvSpd	pshm->P[4123]
#define	LinearX_SetLoadingPosMvTA	pshm->P[4124]
#define	LinearX_SetPowerMeterPosMvSpd	pshm->P[4125]
#define	LinearX_SetPowerMeterPosMvTA	pshm->P[4126]
#define	Temp_LinearX_SetMtReadyPos	pshm->P[8497]
#define	Temp_LinearX_SetMtLWorkStartPos	pshm->P[8498]
#define	Temp_LinearX_SetMtRWorkStartPos	pshm->P[8499]
#define	Temp_LinearX_SetMtLLoadingPos	pshm->P[8500]
#define	Temp_LinearX_SetMtRLoadingPos	pshm->P[8501]
#define	Temp_LinearX_SetMtLViAilgn01Pos	pshm->P[8502]
#define	Temp_LinearX_SetMtLViAilgn02Pos	pshm->P[8503]
#define	Temp_LinearX_SetMtLViAilgn03Pos	pshm->P[8504]
#define	Temp_LinearX_SetMtLViAilgn04Pos	pshm->P[8505]
#define	Temp_LinearX_SetMtRViAilgn01Pos	pshm->P[8506]
#define	Temp_LinearX_SetMtRViAilgn02Pos	pshm->P[8507]
#define	Temp_LinearX_SetMtRViAilgn03Pos	pshm->P[8508]
#define	Temp_LinearX_SetMtRViAilgn04Pos	pshm->P[8509]
#define	Temp_LinearX_SetMtPowerMeterPos	pshm->P[8510]
#define	Temp_LinearX_SetMtSpare10Pos	pshm->P[8511]
#define	Temp_LinearX_SetMtPosMvSpd	pshm->P[8512]
#define	Temp_LinearX_SetMtPosMvTA	pshm->P[8513]
#define	Temp_LinearX_SetReadyPosMvSpd	pshm->P[8514]
#define	Temp_LinearX_SetReadyPosMvTA	pshm->P[8515]
#define	Temp_LinearX_SetMtWorkStartPosMvSpd	pshm->P[8516]
#define	Temp_LinearX_SetMtWorkStartPosMvTA	pshm->P[8517]
#define	Temp_LinearX_SetAlignPosMvSpd	pshm->P[8518]
#define	Temp_LinearX_SetAlignPosMvTA	pshm->P[8519]
#define	Temp_LinearX_SetLoadingPosMvSpd	pshm->P[8520]
#define	Temp_LinearX_SetLoadingPosMvTA	pshm->P[8521]
#define	Temp_LinearX_SetPowerMeterPosMvSpd	pshm->P[8522]
#define	Temp_LinearX_SetPowerMeterPosMvTA	pshm->P[8523]
#define	LStageY_SetMtReadyPos	pshm->P[4200]
#define	LStageY_SetMtWorkStartPos	pshm->P[4201]
#define	LStageY_SetMtSpare03Pos	pshm->P[4202]
#define	LStageY_SetMtLoadingPos	pshm->P[4203]
#define	LStageY_SetMtSpare04Pos	pshm->P[4204]
#define	LStageY_SetMtViAilgn01Pos	pshm->P[4205]
#define	LStageY_SetMtViAilgn02Pos	pshm->P[4206]
#define	LStageY_SetMtViAilgn03Pos	pshm->P[4207]
#define	LStageY_SetMtViAilgn04Pos	pshm->P[4208]
#define	LStageY_SetMtSpare05Pos	pshm->P[4209]
#define	LStageY_SetMtSpare06Pos	pshm->P[4210]
#define	LStageY_SetMtSpare07Pos	pshm->P[4211]
#define	LStageY_SetMtSpare08Pos	pshm->P[4212]
#define	LStageY_SetMtSpare09Pos	pshm->P[4213]
#define	LStageY_SetMtSafePos	pshm->P[4214]
#define	LStageY_SetMtPosMvSpd	pshm->P[4215]
#define	LStageY_SetMtPosMvTA	pshm->P[4216]
#define	LStageY_SetReadyPosMvSpd	pshm->P[4217]
#define	LStageY_SetReadyPosMvTA	pshm->P[4218]
#define	LStageY_SetMtWorkStartPosMvSpd	pshm->P[4219]
#define	LStageY_SetMtWorkStartPosMvTA	pshm->P[4220]
#define	LStageY_SetAlignPosMvSpd	pshm->P[4221]
#define	LStageY_SetAlignPosMvTA	pshm->P[4222]
#define	LStageY_SetLoadingPosMvSpd	pshm->P[4223]
#define	LStageY_SetLoadingPosMvTA	pshm->P[4224]
#define	Temp_LStageY_SetMtReadyPos	pshm->P[8524]
#define	Temp_LStageY_SetMtWorkStartPos	pshm->P[8525]
#define	Temp_LStageY_SetMtSpare03Pos	pshm->P[8526]
#define	Temp_LStageY_SetMtLoadingPos	pshm->P[8527]
#define	Temp_LStageY_SetMtSpare04Pos	pshm->P[8528]
#define	Temp_LStageY_SetMtViAilgn01Pos	pshm->P[8529]
#define	Temp_LStageY_SetMtViAilgn02Pos	pshm->P[8530]
#define	Temp_LStageY_SetMtViAilgn03Pos	pshm->P[8531]
#define	Temp_LStageY_SetMtViAilgn04Pos	pshm->P[8532]
#define	Temp_LStageY_SetMtSpare05Pos	pshm->P[8533]
#define	Temp_LStageY_SetMtSpare06Pos	pshm->P[8534]
#define	Temp_LStageY_SetMtSpare07Pos	pshm->P[8535]
#define	Temp_LStageY_SetMtSpare08Pos	pshm->P[8536]
#define	Temp_LStageY_SetMtSpare09Pos	pshm->P[8537]
#define	Temp_LStageY_SetMtSafePos	pshm->P[8538]
#define	Temp_LStageY_SetMtPosMvSpd	pshm->P[8539]
#define	Temp_LStageY_SetMtPosMvTA	pshm->P[8540]
#define	Temp_LStageY_SetReadyPosMvSpd	pshm->P[8541]
#define	Temp_LStageY_SetReadyPosMvTA	pshm->P[8542]
#define	Temp_LStageY_SetMtWorkStartPosMvSpd	pshm->P[8543]
#define	Temp_LStageY_SetMtWorkStartPosMvTA	pshm->P[8544]
#define	Temp_LStageY_SetAlignPosMvSpd	pshm->P[8545]
#define	Temp_LStageY_SetAlignPosMvTA	pshm->P[8546]
#define	Temp_LStageY_SetLoadingPosMvSpd	pshm->P[8547]
#define	Temp_LStageY_SetLoadingPosMvTA	pshm->P[8548]
#define	RStageY_SetMtReadyPos	pshm->P[4300]
#define	RStageY_SetMtWorkStartPos	pshm->P[4301]
#define	RStageY_SetMtSpare03Pos	pshm->P[4302]
#define	RStageY_SetMtLoadingPos	pshm->P[4303]
#define	RStageY_SetMtSpare04Pos	pshm->P[4304]
#define	RStageY_SetMtViAilgn01Pos	pshm->P[4305]
#define	RStageY_SetMtViAilgn02Pos	pshm->P[4306]
#define	RStageY_SetMtViAilgn03Pos	pshm->P[4307]
#define	RStageY_SetMtViAilgn04Pos	pshm->P[4308]
#define	RStageY_SetMtSpare05Pos	pshm->P[4309]
#define	RStageY_SetMtSpare06Pos	pshm->P[4310]
#define	RStageY_SetMtSpare07Pos	pshm->P[4311]
#define	RStageY_SetMtSpare08Pos	pshm->P[4312]
#define	RStageY_SetMtSpare09Pos	pshm->P[4313]
#define	RStageY_SetMtSafePos	pshm->P[4314]
#define	RStageY_SetMtPosMvSpd	pshm->P[4315]
#define	RStageY_SetMtPosMvTA	pshm->P[4316]
#define	RStageY_SetReadyPosMvSpd	pshm->P[4317]
#define	RStageY_SetReadyPosMvTA	pshm->P[4318]
#define	RStageY_SetMtWorkStartPosMvSpd	pshm->P[4319]
#define	RStageY_SetMtWorkStartPosMvTA	pshm->P[4320]
#define	RStageY_SetAlignPosMvSpd	pshm->P[4321]
#define	RStageY_SetAlignPosMvTA	pshm->P[4322]
#define	RStageY_SetLoadingPosMvSpd	pshm->P[4323]
#define	RStageY_SetLoadingPosMvTA	pshm->P[4324]
#define	Temp_RStageY_SetMtReadyPos	pshm->P[8549]
#define	Temp_RStageY_SetMtWorkStartPos	pshm->P[8550]
#define	Temp_RStageY_SetMtSpare03Pos	pshm->P[8551]
#define	Temp_RStageY_SetMtLoadingPos	pshm->P[8552]
#define	Temp_RStageY_SetMtSpare04Pos	pshm->P[8553]
#define	Temp_RStageY_SetMtViAilgn01Pos	pshm->P[8554]
#define	Temp_RStageY_SetMtViAilgn02Pos	pshm->P[8555]
#define	Temp_RStageY_SetMtViAilgn03Pos	pshm->P[8556]
#define	Temp_RStageY_SetMtViAilgn04Pos	pshm->P[8557]
#define	Temp_RStageY_SetMtSpare05Pos	pshm->P[8558]
#define	Temp_RStageY_SetMtSpare06Pos	pshm->P[8559]
#define	Temp_RStageY_SetMtSpare07Pos	pshm->P[8560]
#define	Temp_RStageY_SetMtSpare08Pos	pshm->P[8561]
#define	Temp_RStageY_SetMtSpare09Pos	pshm->P[8562]
#define	Temp_RStageY_SetMtSafePos	pshm->P[8563]
#define	Temp_RStageY_SetMtPosMvSpd	pshm->P[8564]
#define	Temp_RStageY_SetMtPosMvTA	pshm->P[8565]
#define	Temp_RStageY_SetReadyPosMvSpd	pshm->P[8566]
#define	Temp_RStageY_SetReadyPosMvTA	pshm->P[8567]
#define	Temp_RStageY_SetMtWorkStartPosMvSpd	pshm->P[8568]
#define	Temp_RStageY_SetMtWorkStartPosMvTA	pshm->P[8569]
#define	Temp_RStageY_SetAlignPosMvSpd	pshm->P[8570]
#define	Temp_RStageY_SetAlignPosMvTA	pshm->P[8571]
#define	Temp_RStageY_SetLoadingPosMvSpd	pshm->P[8572]
#define	Temp_RStageY_SetLoadingPosMvTA	pshm->P[8573]
#define	ServoZ_SetMtReadyPos	pshm->P[4500]
#define	ServoZ_SetMtWorkStartPos	pshm->P[4501]
#define	ServoZ_SetMtSpare03Pos	pshm->P[4502]
#define	ServoZ_SetMtLoadingPos	pshm->P[4503]
#define	ServoZ_SetMtSpare04Pos	pshm->P[4504]
#define	ServoZ_SetMtLeftViAilgnPos	pshm->P[4505]
#define	ServoZ_SetMtRightViAilgnPos	pshm->P[4506]
#define	ServoZ_SetMtLeftLaserFocusPos	pshm->P[4507]
#define	ServoZ_SetMtRigntLaserFocusPos	pshm->P[4508]
#define	ServoZ_SetMtSpare05Pos	pshm->P[4509]
#define	ServoZ_SetMtSpare06Pos	pshm->P[4510]
#define	ServoZ_SetMtSpare07Pos	pshm->P[4511]
#define	ServoZ_SetMtSpare08Pos	pshm->P[4512]
#define	ServoZ_SetMtPowerMeterPos	pshm->P[4513]
#define	ServoZ_SetMtSpare10Pos	pshm->P[4514]
#define	ServoZ_SetMtPosMvSpd	pshm->P[4515]
#define	ServoZ_SetMtPosMvTA	pshm->P[4516]
#define	ServoZ_SetReadyPosMvSpd	pshm->P[4517]
#define	ServoZ_SetReadyPosMvTA	pshm->P[4518]
#define	ServoZ_SetMtWorkStartPosMvSpd	pshm->P[4519]
#define	ServoZ_SetMtWorkStartPosMvTA	pshm->P[4520]
#define	ServoZ_SetAlignPosMvSpd	pshm->P[4521]
#define	ServoZ_SetAlignPosMvTA	pshm->P[4522]
#define	ServoZ_SetLoadingPosMvSpd	pshm->P[4523]
#define	ServoZ_SetLoadingPosMvTA	pshm->P[4524]
#define	ServoZ_SetPowerMeterPosMvSpd	pshm->P[4525]
#define	ServoZ_SetPowerMeterPosMvTA	pshm->P[4526]
#define	Temp_ServoZ_SetMtReadyPos	pshm->P[8574]
#define	Temp_ServoZ_SetMtWorkStartPos	pshm->P[8575]
#define	Temp_ServoZ_SetMtSpare03Pos	pshm->P[8576]
#define	Temp_ServoZ_SetMtLoadingPos	pshm->P[8577]
#define	Temp_ServoZ_SetMtSpare04Pos	pshm->P[8578]
#define	Temp_ServoZ_SetMtLeftViAilgnPos	pshm->P[8579]
#define	Temp_ServoZ_SetMtRightViAilgnPos	pshm->P[8580]
#define	Temp_ServoZ_SetMtLeftLaserFocusPos	pshm->P[8581]
#define	Temp_ServoZ_SetMtRigntLaserFocusPos	pshm->P[8582]
#define	Temp_ServoZ_SetMtSpare05Pos	pshm->P[8583]
#define	Temp_ServoZ_SetMtSpare06Pos	pshm->P[8584]
#define	Temp_ServoZ_SetMtSpare07Pos	pshm->P[8585]
#define	Temp_ServoZ_SetMtSpare08Pos	pshm->P[8586]
#define	Temp_ServoZ_SetMtPowerMeterPos	pshm->P[8587]
#define	Temp_ServoZ_SetMtSpare10Pos	pshm->P[8588]
#define	Temp_ServoZ_SetMtPosMvSpd	pshm->P[8589]
#define	Temp_ServoZ_SetMtPosMvTA	pshm->P[8590]
#define	Temp_ServoZ_SetReadyPosMvSpd	pshm->P[8591]
#define	Temp_ServoZ_SetReadyPosMvTA	pshm->P[8592]
#define	Temp_ServoZ_SetMtWorkStartPosMvSpd	pshm->P[8593]
#define	Temp_ServoZ_SetMtWorkStartPosMvTA	pshm->P[8594]
#define	Temp_ServoZ_SetAlignPosMvSpd	pshm->P[8595]
#define	Temp_ServoZ_SetAlignPosMvTA	pshm->P[8596]
#define	Temp_ServoZ_SetLoadingPosMvSpd	pshm->P[8597]
#define	Temp_ServoZ_SetLoadingPosMvTA	pshm->P[8598]
#define	Temp_ServoZ_SetPowerMeterPosMvSpd	pshm->P[8599]
#define	Temp_ServoZ_SetPowerMeterPosMvTA	pshm->P[8600]
#define	P2U_LstageY_MvPos	pshm->P[1205]
#define	P2U_RstageY_MvPos	pshm->P[1305]
#define	CalSlewRateForm	pshm->P[8601]
#define	Plc_SetUpdateTime(i)	pshm->P[(8602+i)%MAX_P]
#define	Plc_SetExeCount(i)	pshm->P[(8607+i)%MAX_P]
#define	Plc_SetUpdateCycle(i)	pshm->P[(8612+i)%MAX_P]
#define	Plc_ChkUpdateCount(i)	pshm->P[(8617+i)%MAX_P]
#define	Temp_Plc_ChkUpdateCount(i)	pshm->P[(8622+i)%MAX_P]
#define	Mach_CalPlcCycleTime	pshm->P[8627]
#define	Mach_CalAverPlcCycleTime	pshm->P[8628]
#define	SetChkInposBand	pshm->P[8629]
#define	Mtr_ExeCmd(i)	pshm->P[(8630+i)%MAX_P]
#define	Temp_Mtr_ExeCmd(i)	pshm->P[(8663+i)%MAX_P]
#define	Mtr_CmdLock(i)	pshm->P[(8696+i)%MAX_P]
#define	Mtr_StCompHome(i)	pshm->P[(8729+i)%MAX_P]
#define	Mtr_CmdErrorCode(i)	pshm->P[(8762+i)%MAX_P]
#define	Mtr_SetMachScale(i)	pshm->P[(8795+i)%MAX_P]
#define	Mtr_SetScale(i)	pshm->P[(8828+i)%MAX_P]
#define	Mtr_SetScaleOffset(i)	pshm->P[(8861+i)%MAX_P]
#define	Mtr_CalDivFactVel(i)	pshm->P[(8894+i)%MAX_P]
#define	Mtr_SetSoftLimP(i)	pshm->P[(8927+i)%MAX_P]
#define	Mtr_SetSoftLimN(i)	pshm->P[(8960+i)%MAX_P]
#define	Mtr_SetAbortAcc(i)	pshm->P[(8993+i)%MAX_P]
#define	Mtr_SetMaxAccG(i)	pshm->P[(9026+i)%MAX_P]
#define	Mtr_SetJogTa(i)	pshm->P[(9059+i)%MAX_P]
#define	Mtr_SetJogVel(i)	pshm->P[(9092+i)%MAX_P]
#define	Mtr_ChkJogCmd(i)	pshm->P[(9125+i)%MAX_P]
#define	Mtr_SetMoveTa(i)	pshm->P[(9158+i)%MAX_P]
#define	Mtr_SetMoveSpd(i)	pshm->P[(9191+i)%MAX_P]
#define	Mtr_SetMovePos(i)	pshm->P[(9224+i)%MAX_P]
#define	Mtr_SetPosRdy(i)	pshm->P[(9257+i)%MAX_P]
#define	Mtr_SetHomeTa(i)	pshm->P[(9290+i)%MAX_P]
#define	Mtr_SetHomeJVel(i)	pshm->P[(9323+i)%MAX_P]
#define	Mtr_SetHomeSVel(i)	pshm->P[(9356+i)%MAX_P]
#define	Mtr_SetHomeOffsetPos(i)	pshm->P[(9389+i)%MAX_P]
#define	Mtr_SetHomeOverTime(i)	pshm->P[(9422+i)%MAX_P]
#define	Mtr_SetMaxPos(i)	pshm->P[(9455+i)%MAX_P]
#define	Mtr_SetMinPos(i)	pshm->P[(9488+i)%MAX_P]
#define	Mtr_GetActPos(i)	pshm->P[(9521+i)%MAX_P]
#define	Mtr_GetDesPos(i)	pshm->P[(9554+i)%MAX_P]
#define	Temp_Mtr_GetActPos(i)	pshm->P[(9587+i)%MAX_P]
#define	Mtr_SavOffsetPos(i)	pshm->P[(9620+i)%MAX_P]
#define	Mtr_GetActSpd(i)	pshm->P[(9653+i)%MAX_P]
#define	Mtr_GetDesSpd(i)	pshm->P[(9686+i)%MAX_P]
#define	Mtr_StIngMove(i)	pshm->P[(9719+i)%MAX_P]
#define	Mtr_StIngHome(i)	pshm->P[(9752+i)%MAX_P]
#define	Mtr_StPosHome(i)	pshm->P[(9785+i)%MAX_P]
#define	Mtr_CalDacOut(i)	pshm->P[(9818+i)%MAX_P]
#define	Mtr_SetStopTd(i)	pshm->P[(9851+i)%MAX_P]
#define	Mtr_SetMotor_Type(i)	pshm->P[(9884+i)%MAX_P]
#define	Mtr_SetUSE_LIMIT_ERR(i)	pshm->P[(9917+i)%MAX_P]
#define	Mtr_SetMotorEcat(i)	pshm->P[(9950+i)%MAX_P]
#define	Mtr_ChkAmpEnable(i)	pshm->P[(9983+i)%MAX_P]
#define	Mtr_ChkMotorUnuse(i)	pshm->P[(10016+i)%MAX_P]
#define	Mach_StError	pshm->P[10049]
#define	Temp_Cts_Mach_StError	pshm->P[10050]
#define	Temp_Chk_Mach_StError(i)	pshm->P[(10051+i)%MAX_P]
#define	Mach_Bit_0200_MsecToggle	pshm->P[10101]
#define	Mach_Bit_0250_MsecToggle	pshm->P[10102]
#define	Mach_Bit_0500_MsecToggle	pshm->P[10103]
#define	Mach_Bit_1000_MsecToggle	pshm->P[10104]
#define	Mach_CmdTime	pshm->P[10105]
#define	Mach_WaitCycle	pshm->P[10106]
#define	Mach_Cmd	pshm->P[10107]
#define	Mach_CmdLock	pshm->P[10108]
#define	Temp_Mach_ChkErr	pshm->P[10109]
#define	Temp_Mach_Cmd	pshm->P[10110]
#define	Mach_CmdErrCode	pshm->P[10111]
#define	Mach_StIngMove	pshm->P[10112]
#define	Mach_StAmpEnable	pshm->P[10113]
#define	Mach_StAmpDisable	pshm->P[10114]
#define	Mach_StCompHome	pshm->P[10115]
#define	Mtr_ExeCmdStep(i)	pshm->P[(10116+i)%MAX_P]
#define	Mtr_ChkCmdStepReady(i)	pshm->P[(10149+i)%MAX_P]
#define	Mtr_BitCmdStepNotReady(i)	pshm->P[(10182+i)%MAX_P]
#define	Mtr_GetCmdError(i)	pshm->P[(10215+i)%MAX_P]
#define	Mtr_StAutoRdy(i)	pshm->P[(10248+i)%MAX_P]
#define	Mtr_StServoRdy(i)	pshm->P[(10281+i)%MAX_P]
#define	Mtr_CompExeProgRun(i)	pshm->P[(10314+i)%MAX_P]
#define	Mtr_CompProgRun(i)	pshm->P[(10347+i)%MAX_P]
#define	Mtr_CompExtraWindProgRun	pshm->P[10380]
#define	Mach_SetMoveRdyTa	pshm->P[10381]
#define	Mach_SetMoveRdySpd	pshm->P[10382]
#define	Mtr_ChkMoveRdyPos(i)	pshm->P[(10383+i)%MAX_P]
#define	Mtr_SetMoveRdyTa(i)	pshm->P[(10416+i)%MAX_P]
#define	Mtr_SetMoveRdySpd(i)	pshm->P[(10449+i)%MAX_P]
#define	Mtr_SetMoveRdyPos(i)	pshm->P[(10482+i)%MAX_P]
#define	Mtr_SetMoveTargetPos(i)	pshm->P[(10515+i)%MAX_P]
#define	Mtr_SetMoveRemainDist(i)	pshm->P[(10548+i)%MAX_P]
#define	Mtr_CompMovePos(i)	pshm->P[(10581+i)%MAX_P]
#define	Mtr_ChkPosSetPos(i)	pshm->P[(10614+i)%MAX_P]
#define	Mtr_ChkPosMoveRdyPos(i)	pshm->P[(10647+i)%MAX_P]
#define	Mtr_SetBasicTa	pshm->P[10680]
#define	Mtr_SetBasicMoveSpd	pshm->P[10681]
#define	Mtr_SetBasicJogMoveSpd	pshm->P[10682]
#define	Mtr_SetBasicHomeSpd	pshm->P[10683]
#define	HomeAllComplete	pshm->P[10684]
#define	LSTAGE_AreaSenPauseCmd	pshm->P[10685]
#define	RSTAGE_AreaSenPauseCmd	pshm->P[10686]
#define	Mtr_SetTouchprobeFunctionValue(i)	pshm->P[(10687+i)%MAX_P]
#define	Mtr_SaftyCheckTargetPos(i)	pshm->P[(10720+i)%MAX_P]
#define	Mach_GetStatus	pshm->P[10753]
#define	Mtr_ExeManualCmd(i)	pshm->P[(10754+i)%MAX_P]
#define	Temp_Mtr_ExeManualCmd(i)	pshm->P[(10787+i)%MAX_P]
#define	Part_StAutoReady(i)	pshm->P[(10820+i)%MAX_P]
#define	Part_BitStNotAutoReady(i)	pshm->P[(10853+i)%MAX_P]
#define	Mach_ExeCmdStep(i)	pshm->P[(10886+i)%MAX_P]
#define	Mach_Chk1CycleCmd(i)	pshm->P[(10956+i)%MAX_P]
#define	Mach_ChkCmdStepReady(i)	pshm->P[(11026+i)%MAX_P]
#define	Mach_CmdErrorCode(i)	pshm->P[(11096+i)%MAX_P]
#define	Mach_CtsChkPartError	pshm->P[11166]
#define	Mach_CtsChkMtrError	pshm->P[11167]
#define	Mach_CtsChkUnitError	pshm->P[11168]
#define	Mach_CtsChkSeqError	pshm->P[11169]
#define	Mach_CtsChkRobotPosError	pshm->P[11170]
#define	Mach_ExeCmdErrorReset	pshm->P[11171]
#define	Mach_ExeCmdReset	pshm->P[11172]
#define	Mach_ExeRcpDataUpdate	pshm->P[11173]
#define	Seq_ExeCmdStep(i)	pshm->P[(11174+i)%MAX_P]
#define	Temp_Seq_ExeCmdStep(i)	pshm->P[(11244+i)%MAX_P]
#define	Test_Seq_ExeCmdStep(i)	pshm->P[(11314+i)%MAX_P]
#define	Part_ExeCmdStep(i)	pshm->P[(11384+i)%MAX_P]
#define	Part_ChkCmdStepReady(i)	pshm->P[(11454+i)%MAX_P]
#define	Part_BitCmdStepNotReady(i)	pshm->P[(11524+i)%MAX_P]
#define	Part_CmdErrorCode(i)	pshm->P[(11594+i)%MAX_P]
#define	Part_StAmpEnable(i)	pshm->P[(11664+i)%MAX_P]
#define	Part_StCompHome(i)	pshm->P[(11734+i)%MAX_P]
#define	Part_StCompServoRdy(i)	pshm->P[(11804+i)%MAX_P]
#define	Part_StCompAutoRdy(i)	pshm->P[(11874+i)%MAX_P]
#define	Temp_Part_StAmpEnable(i)	pshm->P[(11944+i)%MAX_P]
#define	Temp_Part_StCompHome(i)	pshm->P[(12014+i)%MAX_P]
#define	Temp_Part_StCompServoRdy(i)	pshm->P[(12084+i)%MAX_P]
#define	Temp_Part_StCompAutoRdy(i)	pshm->P[(12154+i)%MAX_P]
#define	Unit_ExeCmdStep(i)	pshm->P[(12224+i)%MAX_P]
#define	Temp_Unit_ExeCmdStep(i)	pshm->P[(12294+i)%MAX_P]
#define	Unit_ReqCmd(i)	pshm->P[(12364+i)%MAX_P]
#define	Unit_LockCmd(i)	pshm->P[(12434+i)%MAX_P]
#define	Unit_StErrorStatus(i)	pshm->P[(12504+i)%MAX_P]
#define	Temp_Unit_StErrorStatus(i)	pshm->P[(12574+i)%MAX_P]
#define	Unit_CmdErrorCode(i)	pshm->P[(12644+i)%MAX_P]
#define	Ready_ExeCmdStep(i)	pshm->P[(12714+i)%MAX_P]
#define	Temp_Ready_ExeCmdStep(i)	pshm->P[(12784+i)%MAX_P]
#define	Part_StAutoRdy(i)	pshm->P[(12854+i)%MAX_P]
#define	Part_StMtrServoRdy(i)	pshm->P[(12924+i)%MAX_P]
#define	Part_StErrorStatus(i)	pshm->P[(12994+i)%MAX_P]
#define	Temp_Part_StErrorStatus(i)	pshm->P[(13064+i)%MAX_P]
#define	Part_ExeCmdReadyStep(i)	pshm->P[(13134+i)%MAX_P]
#define	Temp_Part_ExeCmdReadyStep(i)	pshm->P[(13204+i)%MAX_P]
#define	Part_CmdReadyError(i)	pshm->P[(13274+i)%MAX_P]
#define	Temp_CtsStCompHome	pshm->P[13344]
#define	Temp_ChkMotorErr	pshm->P[13345]
#define	Temp_CtsStCompReady	pshm->P[13346]
#define	Temp_ChkReadyMotorErr	pshm->P[13347]
#define	Unit_AutoStartReadySt(i)	pshm->P[(13348+i)%MAX_P]
#define	Mach_MotorAllServoOn	pshm->P[13418]
#define	Mach_MotorAllServoOff	pshm->P[13419]
#define	Mach_ReadyStatus	pshm->P[13420]
#define	Exe_ResetLamp_On	pshm->P[13421]
#define	Exe_ResetLamp_FlickOn	pshm->P[13422]
#define	Temp_Exe_ResetLamp_FlickOn	pshm->P[13423]
#define	Exe_LeftStartLamp_On	pshm->P[13424]
#define	Exe_LeftStartLamp_FlickOn	pshm->P[13425]
#define	Temp_Exe_LeftStartLamp_FlickOn	pshm->P[13426]
#define	Exe_LeftStartLamp_RdyFlickOn	pshm->P[13427]
#define	Temp_Exe_LeftStartLamp_RdyFlickOn	pshm->P[13428]
#define	Exe_RightStartLamp_On	pshm->P[13429]
#define	Exe_RightStartLamp_FlickOn	pshm->P[13430]
#define	Temp_Exe_RightStartLamp_FlickOn	pshm->P[13431]
#define	Exe_RightStartLamp_RdyFlickOn	pshm->P[13432]
#define	Temp_Exe_RightStartLamp_RdyFlickOn	pshm->P[13433]
#define	Temp_SinalTower_Buzzer	pshm->P[13434]
#define	Temp_AreaSenErrStatus	pshm->P[13435]
#define	Temp_MainDoorSenErrStatus	pshm->P[13436]
#define	Temp_SideDooerSenErrStatus	pshm->P[13437]
#define	Temp_LeftPressureSenErrStatus	pshm->P[13438]
#define	Temp_RightPressureSenErrStatus	pshm->P[13439]
#define	Temp_PressureSenErrStatus	pshm->P[13440]
#define	Temp_LeakSenErrStatus	pshm->P[13441]
#define	Temp_LstageSaftyMvErrStatus	pshm->P[13442]
#define	Temp_LstageSaftyValueErrStatus	pshm->P[13443]
#define	Temp_RstageSaftyMvErrStatus	pshm->P[13444]
#define	Temp_RstageSaftyValueErrStatus	pshm->P[13445]
#define	Safety_ErrorCheck	pshm->P[13446]
#define	AutoRun_NotStopErrBit	pshm->P[13447]
#define	Temp_SafetyStopErrNotClearStatus	pshm->P[13448]
#define	Temp_SafetyEMOErrNotClearStatus	pshm->P[13449]
#define	Temp_PressureSenUnUse	pshm->P[13450]
#define	Temp_LeakSenUnUse	pshm->P[13451]
#define	Temp_SaftyPosCheckUnUse	pshm->P[13452]
#define	test_Mode	pshm->P[13453]
#define	Half_test_Mode	pshm->P[13454]
#define	test_ModeDataUndate	pshm->P[13455]
#define	Temp_MaxAccData	pshm->P[13456]
#define	Temp_Lstage_SaftyMvCheck	pshm->P[13457]
#define	Temp_Rstage_SaftyMvCheck	pshm->P[13458]
#define	Temp_Lstage_SaftyValueCheck	pshm->P[13459]
#define	Temp_Rstage_SaftyValueCheck	pshm->P[13460]
#define	Temp_Lstage_AutoRunStatus	pshm->P[13461]
#define	Temp_Rstage_AutoRunStatus	pshm->P[13462]
#define	Temp_Lstage_AutoRdyServoZPos	pshm->P[13463]
#define	Temp_Rstage_AutoRdyServoZPos	pshm->P[13464]
#define	Temp_Mtr_CheckReadyPos(i)	pshm->P[(13465+i)%MAX_P]
#define	Temp_Mtr_CheckLAlign01Pos(i)	pshm->P[(13498+i)%MAX_P]
#define	Temp_Mtr_CheckLAlign02Pos(i)	pshm->P[(13531+i)%MAX_P]
#define	Temp_Mtr_CheckLAlign03Pos(i)	pshm->P[(13564+i)%MAX_P]
#define	Temp_Mtr_CheckLAlign04Pos(i)	pshm->P[(13597+i)%MAX_P]
#define	Temp_Mtr_CheckRAlign01Pos(i)	pshm->P[(13630+i)%MAX_P]
#define	Temp_Mtr_CheckRAlign02Pos(i)	pshm->P[(13663+i)%MAX_P]
#define	Temp_Mtr_CheckRAlign03Pos(i)	pshm->P[(13696+i)%MAX_P]
#define	Temp_Mtr_CheckRAlign04Pos(i)	pshm->P[(13729+i)%MAX_P]
#define	Temp_Mtr_CheckAlign01Pos(i)	pshm->P[(13762+i)%MAX_P]
#define	Temp_Mtr_CheckAlign02Pos(i)	pshm->P[(13795+i)%MAX_P]
#define	Temp_Mtr_CheckAlign03Pos(i)	pshm->P[(13828+i)%MAX_P]
#define	Temp_Mtr_CheckAlign04Pos(i)	pshm->P[(13861+i)%MAX_P]
#define	Temp_Mtr_CheckPowerMeterPos(i)	pshm->P[(13894+i)%MAX_P]
#define	Temp_Mtr_CheckLoadingPos(i)	pshm->P[(13927+i)%MAX_P]
#define	Temp_Mtr_CheckWorkStartPos(i)	pshm->P[(13960+i)%MAX_P]
#define	Temp_Mtr_CheckLLoadingPos(i)	pshm->P[(13993+i)%MAX_P]
#define	Temp_Mtr_CheckRLoadingPos(i)	pshm->P[(14026+i)%MAX_P]
#define	Temp_Mtr_CheckLWorkStartPos(i)	pshm->P[(14059+i)%MAX_P]
#define	Temp_Mtr_CheckRWorkStartPos(i)	pshm->P[(14092+i)%MAX_P]
#define	LeftStopSwitchCts	pshm->P[14125]
#define	RightStopSwitchCts	pshm->P[14126]
#define	OldLeftStopSwitchCts	pshm->P[14127]
#define	OldRightStopSwitchCts	pshm->P[14128]
#define	MotionDownloadTimeOut	pshm->P[14129]
#define	U2P_Mt01_ErrCode	pshm->P[3550]
#define	U2P_Mt02_ErrCode	pshm->P[3551]
#define	U2P_Mt03_ErrCode	pshm->P[3552]
#define	U2P_Mt05_ErrCode	pshm->P[3554]
#define	U2P_AllUnit_ErrCode	pshm->P[3650]
#define	U2P_LStage_ErrCode	pshm->P[3651]
#define	U2P_RStage_ErrCode	pshm->P[3652]
#define	U2P_Mach_ErrCode	pshm->P[3750]
#define	U2P_Part_ErrCode	pshm->P[3751]
#define	MC_MoveJogP_In_Axis(i)	pshm->P[(14130+i)%MAX_P]
#define	MC_MoveJogP_In_MaxPosition(i)	pshm->P[(14163+i)%MAX_P]
#define	MC_MoveJogP_In_AccTime(i)	pshm->P[(14196+i)%MAX_P]
#define	MC_MoveJogP_In_Velocity(i)	pshm->P[(14229+i)%MAX_P]
#define	MC_MoveJogN_In_Axis(i)	pshm->P[(14262+i)%MAX_P]
#define	MC_MoveJogN_In_MinPosition(i)	pshm->P[(14295+i)%MAX_P]
#define	MC_MoveJogN_In_AccTime(i)	pshm->P[(14328+i)%MAX_P]
#define	MC_MoveJogN_In_Velocity(i)	pshm->P[(14361+i)%MAX_P]
#define	MC_MoveAbs_In_Axis(i)	pshm->P[(14394+i)%MAX_P]
#define	MC_MoveAbs_In_MaxPosition(i)	pshm->P[(14427+i)%MAX_P]
#define	MC_MoveAbs_In_MinPosition(i)	pshm->P[(14460+i)%MAX_P]
#define	MC_MoveAbs_In_Position(i)	pshm->P[(14493+i)%MAX_P]
#define	MC_MoveAbs_In_AccTime(i)	pshm->P[(14526+i)%MAX_P]
#define	MC_MoveAbs_In_Velocity(i)	pshm->P[(14559+i)%MAX_P]
#define	MC_MoveAbs_Ot_DesMovePosition(i)	pshm->P[(14592+i)%MAX_P]
#define	MC_MoveAbs_Ot_MovePosition(i)	pshm->P[(14625+i)%MAX_P]
#define	MC_MoveInc_In_Axis(i)	pshm->P[(14658+i)%MAX_P]
#define	MC_MoveInc_In_MaxPosition(i)	pshm->P[(14691+i)%MAX_P]
#define	MC_MoveInc_In_MinPosition(i)	pshm->P[(14724+i)%MAX_P]
#define	MC_MoveInc_In_Position(i)	pshm->P[(14757+i)%MAX_P]
#define	MC_MoveInc_In_AccTime(i)	pshm->P[(14790+i)%MAX_P]
#define	MC_MoveInc_In_Velocity(i)	pshm->P[(14823+i)%MAX_P]
#define	MC_MoveInc_Ot_DesMovePosition(i)	pshm->P[(14856+i)%MAX_P]
#define	MC_MoveInc_Ot_MovePosition(i)	pshm->P[(14889+i)%MAX_P]
#define	MC_MoveStop_In_DecTime(i)	pshm->P[(14922+i)%MAX_P]
#define	Mtr_Chk_ExeRdyErr_In_Cmd(i)	pshm->P[(14955+i)%MAX_P]
#define	Mtr_Chk_ExeRdyErr_Ot_Error(i)	pshm->P[(14988+i)%MAX_P]
#define	Mtr_Chk_ExeRdyErr_Ot_ErrorID(i)	pshm->P[(15021+i)%MAX_P]
#define	Mtr_Chk_ExeEndErr_In_Cmd(i)	pshm->P[(15054+i)%MAX_P]
#define	Mtr_Chk_ExeEndErr_Ot_Error(i)	pshm->P[(15087+i)%MAX_P]
#define	Mtr_Chk_ExeEndErr_Ot_ErrorID(i)	pshm->P[(15120+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_HomeJogVel(i)	pshm->P[(15153+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_HomeJogTa(i)	pshm->P[(15186+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_HomeVel(i)	pshm->P[(15219+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_HomeOffset(i)	pshm->P[(15252+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_UseLimit(i)	pshm->P[(15285+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_TimeOutTime(i)	pshm->P[(15318+i)%MAX_P]
#define	Mtr_Chk_AllAmpEna_Ot_Ena(i)	pshm->P[(15351+i)%MAX_P]
#define	Mtr_Chk_AllAmpEna_Ot_Temp(i)	pshm->P[(15384+i)%MAX_P]
#define	Mtr_Chk_AllCompHome_Ot_Comp(i)	pshm->P[(15417+i)%MAX_P]
#define	Mtr_Chk_AllCompHome_Ot_Temp(i)	pshm->P[(15450+i)%MAX_P]
#define	Mtr_Chk_AllMoving_Ot_Moving(i)	pshm->P[(15483+i)%MAX_P]
#define	Mtr_Chk_AllMoving_Ot_Temp(i)	pshm->P[(15516+i)%MAX_P]
#define	Mtr_Chk_AllErr_Ot_Err(i)	pshm->P[(15549+i)%MAX_P]
#define	Mtr_Chk_AllErr_Ot_Temp(i)	pshm->P[(15582+i)%MAX_P]
#define	MTR_Err_LimitErr_Ot_State(i)	pshm->P[(15615+i)%MAX_P]
#define	Mtr_Set_GateSetup_In_Word_SetGate(i)	pshm->P[(15648+i)%MAX_P]
#define	Mtr_Set_GateSetup_In_GateNum(i)	pshm->P[(15681+i)%MAX_P]
#define	Mtr_Set_GateSetup_In_ChanNum(i)	pshm->P[(15714+i)%MAX_P]
#define	Mtr_Set_MtWord_Setup_In_AbortAcc(i)	pshm->P[(15747+i)%MAX_P]
#define	Mtr_Set_MtWord_Setup_In_ProgMaxSpeed(i)	pshm->P[(15780+i)%MAX_P]
#define	Mtr_Set_MtWord_Setup_In_ProgMaxAcc(i)	pshm->P[(15813+i)%MAX_P]
#define	Mtr_Set_HomeWord_Setup_In_CaptCtrl(i)	pshm->P[(15846+i)%MAX_P]
#define	Mtr_Set_HomeWord_Setup_In_CaptFlag(i)	pshm->P[(15879+i)%MAX_P]
#define	AUTO_CHK_MtCmdEnd_Ot_Temp(i)	pshm->P[(15912+i)%MAX_P]
#define	AUTO_CHK_MtCmdEnd_Ot_Comp(i)	pshm->P[(15945+i)%MAX_P]
#define	AUTO_CHK_MtCmdEnd_Ot_Error(i)	pshm->P[(15978+i)%MAX_P]
#define	AUTO_CHK_CmdEnd_Ot_Temp(i)	pshm->P[(16011+i)%MAX_P]
#define	AUTO_CHK_CmdEnd_Ot_Comp(i)	pshm->P[(16044+i)%MAX_P]
#define	AUTO_CHK_CmdEnd_Ot_Error(i)	pshm->P[(16077+i)%MAX_P]
#define	AUTO_CHK_HostTimeBaseDone_Ot_Temp(i)	pshm->P[(16110+i)%MAX_P]
#define	AUTO_CHK_HostTimeBaseDone_Ot_Comp(i)	pshm->P[(16143+i)%MAX_P]
#define	Mach_SetSubProgUpdateTime	pshm->P[16176]
#define	Mach_SetSubProgWaitCycle	pshm->P[16177]
#define	LinearX_Mtr_HomeOffset	pshm->P[1104]
#define	LStageY_Mtr_HomeOffset	pshm->P[1204]
#define	RStageY_Mtr_HomeOffset	pshm->P[1304]
#define	ServoZ_Mtr_HomeOffset	pshm->P[1504]
#ifndef _PP_PROJ_HDR_
  void SetEnumGlobalVar(enum globalP var, double data)
  {
    pshm->P[var] = data;
  }

  double GetEnumGlobalVar(enum globalP var)
  {
    return pshm->P[var];
  }

  void SetEnumGlobalArrayVar(enum globalParray var, unsigned index, double data)
  {
    pshm->P[(var + index)%MAX_P] = data;
  }

  double GetEnumGlobalArrayVar(enum globalParray var, unsigned index)
  {
    return pshm->P[(var + index)%MAX_P];
  }

  void SetEnumCSGlobalVar(enum csglobalQ var, unsigned cs, double data)
  {
    pshm->Coord[cs % MAX_COORDS].Q[var] = data;
  }

  double GetEnumCSGlobalVar(enum csglobalQ var, unsigned cs)
  {
    return pshm->Coord[cs % MAX_COORDS].Q[var];
  }

  void SetEnumCSGlobalArrayVar(enum csglobalQarray var, unsigned index, unsigned cs, double data)
  {
    pshm->Coord[cs % MAX_COORDS].Q[(var + index)%MAX_Q] = data;
  }

  double GetEnumCSGlobalArrayVar(enum csglobalQarray var, unsigned index, unsigned cs)
  {
    return pshm->Coord[cs % MAX_COORDS].Q[(var + index)%MAX_Q];
  }

  void SetEnumPtrVar(enum ptrM var, double data)
  {
    im_write(pshm->Mdef + var, data, &pshm->Ldata);
  }

  double GetEnumPtrVar(enum ptrM var)
  {
    return im_read(pshm->Mdef + var, &pshm->Ldata);
  }

  void SetEnumPtrArrayVar(enum ptrMarray var, unsigned index, double data)
  {
    im_write(pshm->Mdef + ((var + index)%MAX_M), data, &pshm->Ldata);
  }

  double GetEnumPtrArrayVar(enum ptrMarray var, unsigned index)
  {
    return im_read(pshm->Mdef + ((var + index)%MAX_M), &pshm->Ldata);
  }

  #define SetGlobalVar(i, x)              SetEnumGlobalVar(i, x)
  #define SetGlobalArrayVar(i, j, x)      SetEnumGlobalArrayVar(i, j, x)
  #define GetGlobalVar(i)                 GetEnumGlobalVar(i)
  #define GetGlobalArrayVar(i, j)         GetEnumGlobalArrayVar(i, j)

  #define SetCSGlobalVar(i, j, x)         SetEnumCSGlobalVar(i, j, x)
  #define SetCSGlobalArrayVar(i, j, k, x) SetEnumCSGlobalArrayVar(i, j, k, x)
  #define GetCSGlobalVar(i, j)            GetEnumCSGlobalVar(i, j)
  #define GetCSGlobalArrayVar(i, j, k)    GetEnumCSGlobalArrayVar(i, j, k)

  #define SetPtrVar(i, x)                 SetEnumPtrVar(i, x)
  #define SetPtrArrayVar(i, j, x)         SetEnumPtrArrayVar(i, j, x)
  #define GetPtrVar(i)                    GetEnumPtrVar(i)
  #define GetPtrArrayVar(i, j)            GetEnumPtrArrayVar(i, j)

#else

  void SetEnumGlobalVar(enum globalP var, double data);
  double GetEnumGlobalVar(enum globalP var);
  void SetEnumGlobalArrayVar(enum globalParray var, unsigned index, double data);
  double GetEnumGlobalArrayVar(enum globalParray var, unsigned index);
  void SetEnumCSGlobalVar(enum csglobalQ var, unsigned cs, double data);
  double GetEnumCSGlobalVar(enum csglobalQ var, unsigned cs);
  void SetEnumCSGlobalArrayVar(enum csglobalQarray var, unsigned index, unsigned cs, double data);
  double GetEnumCSGlobalArrayVar(enum csglobalQarray var, unsigned index, unsigned cs);
  void SetEnumPtrVar(enum ptrM var, double data);
  double GetEnumPtrVar(enum ptrM var);
  void SetEnumPtrArrayVar(enum ptrMarray var, unsigned index, double data);
  double GetEnumPtrArrayVar(enum ptrMarray var, unsigned index);

  #define SetGlobalVar(i, x)              SetEnumGlobalVar(i, x)
  #define SetGlobalArrayVar(i, j, x)      SetEnumGlobalArrayVar(i, j, x)
  #define GetGlobalVar(i)                 GetEnumGlobalVar(i)
  #define GetGlobalArrayVar(i, j)         GetEnumGlobalArrayVar(i, j)

  #define SetCSGlobalVar(i, j, x)         SetEnumCSGlobalVar(i, j, x)
  #define SetCSGlobalArrayVar(i, j, k, x) SetEnumCSGlobalArrayVar(i, j, k, x)
  #define GetCSGlobalVar(i, j)            GetEnumCSGlobalVar(i, j)
  #define GetCSGlobalArrayVar(i, j, k)    GetEnumCSGlobalArrayVar(i, j, k)

  #define SetPtrVar(i, x)                 SetEnumPtrVar(i, x)
  #define SetPtrArrayVar(i, j, x)         SetEnumPtrArrayVar(i, j, x)
  #define GetPtrVar(i)                    GetEnumPtrVar(i)
  #define GetPtrArrayVar(i, j)            GetEnumPtrArrayVar(i, j)

#endif
// end of #ifdef _PPScriptMode_
#else
#ifdef _EnumMode_
enum globalP {_globalP_=-1
,XBusy=8192
,XOriginDone=8193
,XMotionDone=8194
,XInPosition=8195
,XCurPos=8196
,XVelocity=8197
,XInTargetPos=8198
,XPositionTolerance=8199
,Y1Busy=8200
,Y1OriginDone=8201
,Y1MotionDone=8202
,Y1InPosition=8203
,Y1CurPos=8204
,Y1Velocity=8205
,Y1InLoadPos=8206
,Y1PositionTolerance=8207
,Y2Busy=8208
,Y2OriginDone=8209
,Y2MotionDone=8210
,Y2InPosition=8211
,Y2CurPos=8212
,Y2Velocity=8213
,Y2InLoadPos=8214
,Y2PositionTolerance=8215
,ZBusy=8216
,ZOriginDone=8217
,ZMotionDone=8218
,ZInPosition=8219
,ZCurPos=8220
,ZVelocity=8221
,ZInTargetPos=8222
,ZPositionTolerance=8223
,Timer1=8224
,Timer11=8225
,Timer2=8226
,Timer21=8227
,MotorMoveStartTimeOut=8228
,MotorMoveTimeOut=8229
,MotorStopTime=8230
,Table1EMOStopSwitch=8231
,Table2EMOStopSwitch=8232
,Table1StopSwitch=8233
,Table2StopSwitch=8234
,DownloadTimeOut1=8235
,DownloadTimeOut2=8236
,Table1ExeCount=8237
,Table1Film=8238
,Table1New=8239
,Table1Step=8240
,Table1LastStep=8241
,Table1ErrorCode=8242
,Table1Busy=8243
,Table1Unload=8244
,Table1Stop=8245
,Table1EMOStop=8246
,TempTable1Unload=8247
,OldTable1Stop=8248
,OldTable1EMOStop=8249
,Table1LoadXPos=8250
,Table1LoadYPos=8251
,Table2Film=8252
,Table2New=8253
,Table2Step=8254
,Table2LastStep=8255
,Table2ErrorCode=8256
,Table2Busy=8257
,Table2Unload=8258
,Table2Stop=8259
,Table2EMOStop=8260
,TempTable2Unload=8261
,OldTable2Stop=8262
,OldTable2EMOStop=8263
,Table2LoadXPos=8264
,Table2LoadYPos=8265
,AutoRun=8266
,Temp_In_Main_PowerOn=8367
,Temp_In_EMO01_Btn=8368
,Temp_In_EMO02_Btn=8369
,Temp_In_EMO03_Btn=8370
,Temp_In_LeftUnit_Start_Btn=8371
,Temp_In_LeftUnit_Vac_Btn=8372
,Temp_In_LeftUnit_Stop_Btn=8373
,Temp_In_LeftUnit_ReSet_Btn=8374
,Temp_In_LeftUnit_Pressure_Sen=8375
,Temp_In_LeftUnit_Vac_Sen=8376
,Temp_In_RightUnit_Start_Btn=8377
,Temp_In_RightUnit_Vac_Btn=8378
,Temp_In_RightUnit_Stop_Btn=8379
,Temp_In_RightUnit_ReSet_Btn=8380
,Temp_In_RightUnit_Pressure_Sen=8381
,Temp_In_RightUnit_Vac_Sen=8382
,Temp_In_Stage_PowerOn=8383
,Temp_In_Leak_Sen=8384
,Temp_In_Door01_Sen=8385
,Temp_In_Door02_Sen=8386
,Temp_In_Door03_Sen=8387
,Temp_In_Door04_Sen=8388
,Temp_In_Door05_Sen=8389
,Temp_In_Spare_UX024=8390
,Temp_In_LeftUnit_Ionizer=8391
,Temp_In_RightUnit_Ionizer=8392
,Temp_In_BeamShutter_Close=8393
,Temp_In_BeamShutter_Open=8394
,Temp_In_PowerMeter_Open=8395
,Temp_In_PowerMeter_Close=8396
,Temp_In_LeftUnit_Area_Sen=8397
,Temp_In_RightUnit_Area_Sen=8398
,Temp_In_Spare_UX033=8399
,Temp_In_Spare_UX034=8400
,Temp_In_Spare_UX035=8401
,Temp_In_Spare_UX036=8402
,Temp_In_Spare_UX037=8403
,Temp_In_Spare_UX038=8404
,Temp_In_Spare_UX039=8405
,Temp_In_Spare_UX040=8406
,Temp_In_Spare_UX041=8407
,Temp_In_Spare_UX042=8408
,Temp_In_Spare_UX043=8409
,Temp_In_Spare_UX044=8410
,Temp_In_Spare_UX045=8411
,Temp_In_Spare_UX046=8412
,Temp_In_Spare_UX047=8413
,Temp_In_Spare_UX048=8414
,P2U_Mach_AllHomeExe=5000
,P2U_Mach_MtrAllServoOn=5002
,P2U_Mach_MtrAllServoOff=5003
,P2U_Mach_PowerMeterChk=5004
,P2U_Mach_ReadyExe=5005
,P2U_Mach_MainDoorUnUse=5006
,P2U_Mach_AreaSenUnUse=5007
,P2U_Mach_SideDoorUnUse=5008
,P2U_Mach_BuzzerUnUse=5009
,P2U_Mach_LEDLampOn=5010
,P2U_Mach_MotionTimeOut=5011
,P2U_Mach_BuzzerStopExe=5012
,P2U_Mach_LstageProgStart=5013
,P2U_Mach_RstageProgStart=5014
,P2U_Mach_AutoStop=5015
,P2U_Mach_ReSetStart=5016
,P2U_Mach_ReadyStatus=5017
,P2U_Mach_UnitStartDelayTime=5018
,P2U_Mach_ReserveUnUse=5019
,P2U_Mach_AutoCompVentUnUse=5021
,P2U_Mach_VacErrCheckUnUse=5022
,P2U_Mach_AreaSenVentUnUse=5023
,P2U_Mach_LookAheadAcc=5025
,Temp_Mach_AllHomeExe=8415
,Temp_Mach_MtrAllServoOn=8416
,Temp_Mach_MtrAllServoOff=8417
,Temp_Mach_PowerMeterChk=8418
,Temp_Mach_ReadyExe=8419
,Temp_Mach_MainDoorUnUse=8420
,Temp_Mach_AreaSenUnUse=8421
,Temp_Mach_SideDoorUnUse=8422
,Temp_Mach_LED_Light_On=8423
,Temp_Mach_BuzzerStopExe=8424
,Temp_Mach_BuzzerUnUse=8425
,Temp_Mach_UnitStartDelayTime=8426
,Temp_Mach_ReserveUnUse=8427
,Temp_Mach_AutoCompVentUnUse=8428
,Temp_Mach_VacErrCheckUnUse=8429
,Temp_Mach_AreaSenVentUnUse=8430
,U2P_Mach_BitData01=5154
,U2P_Mach_BitData02=5155
,U2P_Mach_Status=5100
,U2P_Mach_AllHomming=5101
,U2P_Mach_AllHomeComp=5102
,U2P_Mach_PowerMoterChkComp=5104
,U2P_Mach_ReadyPosComp=5105
,MotionEnd=8000
,Temp_Mach_Status=8431
,Temp_Mach_AllHomming=8432
,Temp_Mach_AllHomeComp=8433
,Temp_Mach_MotionTimeOut=8434
,U2P_Lstage_BitData01=6154
,U2P_Lstage_BitData02=6155
,P2U_Lstage_ReadySt=6000
,P2U_Lstage_AutoStart=6001
,P2U_Lstage_MotionDownroadComp=6002
,P2U_Lstage_Glessthickness=6004
,Temp_Lstage_ReadySt=8435
,Temp_Lstage_AutoStart=8436
,Temp_Lstage_MotionDownroadComp=8437
,Temp_Lstage_Glessthickness=8438
,P2U_Lstage_ViAilgnUnUse=6009
,P2U_Lstage_ViAilgnCts=6010
,P2U_Lstage_ViAilgn01TrigComp=6011
,P2U_Lstage_ViAilgn02TrigComp=6012
,P2U_Lstage_ViAilgn03TrigComp=6013
,P2U_Lstage_ViAilgn04TrigComp=6014
,Temp_Lstage_ViAilgnUnUse=8439
,Temp_Lstage_ViAilgnCts=8440
,Temp_Lstage_ViAilgn01TrigComp=8441
,Temp_Lstage_ViAilgn02TrigComp=8442
,Temp_Lstage_ViAilgn03TrigComp=8443
,Temp_Lstage_ViAilgn04TrigComp=8444
,P2U_Lstage_VacUseCts=6016
,Temp_Lstage_VacUseCts=8445
,P2U_Lstage_Vac01Time=6018
,P2U_Lstage_Vac02Time=6019
,P2U_Lstage_Vac03Time=6020
,P2U_Lstage_Vac04Time=6021
,Temp_Lstage_Vac01Time=8446
,Temp_Lstage_Vac02Time=8447
,Temp_Lstage_Vac03Time=8448
,Temp_Lstage_Vac04Time=8449
,P2U_Lstage_AilgnMvStart=6023
,P2U_Lstage_WorkPosMvStart=6024
,P2U_Lstage_LoadingPosMvStart=6025
,P2U_Lstage_VacStart=6026
,P2U_Lstage_ReadyMvStart=6028
,Temp_Lstage_AilgnMvStart=8450
,Temp_Lstage_WorkPosMvStart=8451
,Temp_Lstage_LoadingPosMvStart=8452
,Temp_Lstage_ReadyMvStart=8453
,U2P_Lstage_VacReadySt=6100
,U2P_Lstage_AutoReadySt=6101
,U2P_Lstage_MotionDownroadExe=6102
,U2P_Lstage_Motioning=6103
,U2P_Lstage_MotionComp=6104
,U2P_Lstage_AutoRunComp=6105
,Temp_Lstage_VacReadySt=8454
,Temp_Lstage_AutoReadySt=8455
,Temp_Lstage_MotionDownroadExe=8456
,Temp_Lstage_Motioning=8457
,Temp_Lstage_MotionComp=8458
,Temp_Lstage_AutoRunComp=8459
,U2P_Lstage_ViAilgnSeqComp=6109
,U2P_Lstage_ViAilgn01TrigExe=6110
,U2P_Lstage_ViAilgn02TrigExe=6111
,U2P_Lstage_ViAilgn03TrigExe=6112
,U2P_Lstage_ViAilgn04TrigExe=6113
,Temp_Lstage_ViAilgnSeqComp=8460
,Temp_Lstage_ViAilgn01TrigExe=8461
,Temp_Lstage_ViAilgn02TrigExe=8462
,Temp_Lstage_ViAilgn03TrigExe=8463
,Temp_Lstage_ViAilgn04TrigExe=8464
,U2P_Lstage_MachStatus=6116
,U2P_Lstage_AilgnMvComp=6123
,U2P_Lstage_WorkPosMvComp=6124
,U2P_Lstage_LoadingPosMvComp=6125
,U2P_Lstage_ReadyMvComp=6128
,Temp_Lstage_MachStatus=8465
,P2U_Rstage_ReadySt=7000
,P2U_Rstage_AutoStart=7001
,P2U_Rstage_MotionDownroadComp=7002
,P2U_Rstage_Glessthickness=7004
,Temp_Rstage_ReadySt=8466
,Temp_Rstage_AutoStart=8467
,Temp_Rstage_MotionDownroadComp=8468
,Temp_Rstage_Glessthickness=8469
,P2U_Rstage_ViAilgnUnUse=7009
,P2U_Rstage_ViAilgnCts=7010
,P2U_Rstage_ViAilgn01TrigComp=7011
,P2U_Rstage_ViAilgn02TrigComp=7012
,P2U_Rstage_ViAilgn03TrigComp=7013
,P2U_Rstage_ViAilgn04TrigComp=7014
,Temp_Rstage_ViAilgnUnUse=8470
,Temp_Rstage_ViAilgnCts=8471
,Temp_Rstage_ViAilgn01TrigComp=8472
,Temp_Rstage_ViAilgn02TrigComp=8473
,Temp_Rstage_ViAilgn03TrigComp=8474
,Temp_Rstage_ViAilgn04TrigComp=8475
,P2U_Rstage_VacUseCts=7016
,Temp_Rstage_VacUseCts=8476
,P2U_Rstage_Vac01Time=7018
,P2U_Rstage_Vac02Time=7019
,P2U_Rstage_Vac03Time=7020
,P2U_Rstage_Vac04Time=7021
,Temp_Rstage_Vac01Time=8477
,Temp_Rstage_Vac02Time=8478
,Temp_Rstage_Vac03Time=8479
,Temp_Rstage_Vac04Time=8480
,P2U_Rstage_AilgnMvStart=7023
,P2U_Rstage_WorkPosMvStart=7024
,P2U_Rstage_LoadingPosMvStart=7025
,P2U_Rstage_VacStart=7026
,P2U_Rstage_ReadyMvStart=7028
,Temp_Rstage_AilgnMvStart=8481
,Temp_Rstage_WorkPosMvStart=8482
,Temp_Rstage_LoadingPosMvStart=8483
,Temp_Rstage_ReadyMvStart=8484
,U2P_Rstage_BitData01=7154
,U2P_Rstage_BitData02=7155
,U2P_Rstage_VacReadySt=7100
,U2P_Rstage_AutoReadySt=7101
,U2P_Rstage_MotionDownroadExe=7102
,U2P_Rstage_Motioning=7103
,U2P_Rstage_MotionComp=7104
,U2P_Rstage_AutoRunComp=7105
,Temp_Rstage_VacReadySt=8485
,Temp_Rstage_AutoReadySt=8486
,Temp_Rstage_MotionDownroadExe=8487
,Temp_Rstage_Motioning=8488
,Temp_Rstage_MotionComp=8489
,Temp_Rstage_AutoRunComp=8490
,U2P_Rstage_ViAilgnSeqComp=7109
,U2P_Rstage_ViAilgn01TrigExe=7110
,U2P_Rstage_ViAilgn02TrigExe=7111
,U2P_Rstage_ViAilgn03TrigExe=7112
,U2P_Rstage_ViAilgn04TrigExe=7113
,Temp_Rstage_ViAilgnSeqComp=8491
,Temp_Rstage_ViAilgn01TrigExe=8492
,Temp_Rstage_ViAilgn02TrigExe=8493
,Temp_Rstage_ViAilgn03TrigExe=8494
,Temp_Rstage_ViAilgn04TrigExe=8495
,U2P_Rstage_MachStatus=7116
,U2P_Rstage_AilgnMvComp=7123
,U2P_Rstage_WorkPosMvComp=7124
,U2P_Rstage_LoadingPosMvComp=7125
,U2P_Rstage_ReadyMvComp=7128
,Temp_Rstage_MachStatus=8496
,LinearX_SetMtReadyPos=4100
,LinearX_SetMtLWorkStartPos=4101
,LinearX_SetMtRWorkStartPos=4102
,LinearX_SetMtLLoadingPos=4103
,LinearX_SetMtRLoadingPos=4104
,LinearX_SetMtLViAilgn01Pos=4105
,LinearX_SetMtLViAilgn02Pos=4106
,LinearX_SetMtLViAilgn03Pos=4107
,LinearX_SetMtLViAilgn04Pos=4108
,LinearX_SetMtRViAilgn01Pos=4109
,LinearX_SetMtRViAilgn02Pos=4110
,LinearX_SetMtRViAilgn03Pos=4111
,LinearX_SetMtRViAilgn04Pos=4112
,LinearX_SetMtPowerMeterPos=4113
,LinearX_SetMtSpare10Pos=4114
,LinearX_SetMtPosMvSpd=4115
,LinearX_SetMtPosMvTA=4116
,LinearX_SetReadyPosMvSpd=4117
,LinearX_SetReadyPosMvTA=4118
,LinearX_SetMtWorkStartPosMvSpd=4119
,LinearX_SetMtWorkStartPosMvTA=4120
,LinearX_SetAlignPosMvSpd=4121
,LinearX_SetAlignPosMvTA=4122
,LinearX_SetLoadingPosMvSpd=4123
,LinearX_SetLoadingPosMvTA=4124
,LinearX_SetPowerMeterPosMvSpd=4125
,LinearX_SetPowerMeterPosMvTA=4126
,Temp_LinearX_SetMtReadyPos=8497
,Temp_LinearX_SetMtLWorkStartPos=8498
,Temp_LinearX_SetMtRWorkStartPos=8499
,Temp_LinearX_SetMtLLoadingPos=8500
,Temp_LinearX_SetMtRLoadingPos=8501
,Temp_LinearX_SetMtLViAilgn01Pos=8502
,Temp_LinearX_SetMtLViAilgn02Pos=8503
,Temp_LinearX_SetMtLViAilgn03Pos=8504
,Temp_LinearX_SetMtLViAilgn04Pos=8505
,Temp_LinearX_SetMtRViAilgn01Pos=8506
,Temp_LinearX_SetMtRViAilgn02Pos=8507
,Temp_LinearX_SetMtRViAilgn03Pos=8508
,Temp_LinearX_SetMtRViAilgn04Pos=8509
,Temp_LinearX_SetMtPowerMeterPos=8510
,Temp_LinearX_SetMtSpare10Pos=8511
,Temp_LinearX_SetMtPosMvSpd=8512
,Temp_LinearX_SetMtPosMvTA=8513
,Temp_LinearX_SetReadyPosMvSpd=8514
,Temp_LinearX_SetReadyPosMvTA=8515
,Temp_LinearX_SetMtWorkStartPosMvSpd=8516
,Temp_LinearX_SetMtWorkStartPosMvTA=8517
,Temp_LinearX_SetAlignPosMvSpd=8518
,Temp_LinearX_SetAlignPosMvTA=8519
,Temp_LinearX_SetLoadingPosMvSpd=8520
,Temp_LinearX_SetLoadingPosMvTA=8521
,Temp_LinearX_SetPowerMeterPosMvSpd=8522
,Temp_LinearX_SetPowerMeterPosMvTA=8523
,LStageY_SetMtReadyPos=4200
,LStageY_SetMtWorkStartPos=4201
,LStageY_SetMtSpare03Pos=4202
,LStageY_SetMtLoadingPos=4203
,LStageY_SetMtSpare04Pos=4204
,LStageY_SetMtViAilgn01Pos=4205
,LStageY_SetMtViAilgn02Pos=4206
,LStageY_SetMtViAilgn03Pos=4207
,LStageY_SetMtViAilgn04Pos=4208
,LStageY_SetMtSpare05Pos=4209
,LStageY_SetMtSpare06Pos=4210
,LStageY_SetMtSpare07Pos=4211
,LStageY_SetMtSpare08Pos=4212
,LStageY_SetMtSpare09Pos=4213
,LStageY_SetMtSafePos=4214
,LStageY_SetMtPosMvSpd=4215
,LStageY_SetMtPosMvTA=4216
,LStageY_SetReadyPosMvSpd=4217
,LStageY_SetReadyPosMvTA=4218
,LStageY_SetMtWorkStartPosMvSpd=4219
,LStageY_SetMtWorkStartPosMvTA=4220
,LStageY_SetAlignPosMvSpd=4221
,LStageY_SetAlignPosMvTA=4222
,LStageY_SetLoadingPosMvSpd=4223
,LStageY_SetLoadingPosMvTA=4224
,Temp_LStageY_SetMtReadyPos=8524
,Temp_LStageY_SetMtWorkStartPos=8525
,Temp_LStageY_SetMtSpare03Pos=8526
,Temp_LStageY_SetMtLoadingPos=8527
,Temp_LStageY_SetMtSpare04Pos=8528
,Temp_LStageY_SetMtViAilgn01Pos=8529
,Temp_LStageY_SetMtViAilgn02Pos=8530
,Temp_LStageY_SetMtViAilgn03Pos=8531
,Temp_LStageY_SetMtViAilgn04Pos=8532
,Temp_LStageY_SetMtSpare05Pos=8533
,Temp_LStageY_SetMtSpare06Pos=8534
,Temp_LStageY_SetMtSpare07Pos=8535
,Temp_LStageY_SetMtSpare08Pos=8536
,Temp_LStageY_SetMtSpare09Pos=8537
,Temp_LStageY_SetMtSafePos=8538
,Temp_LStageY_SetMtPosMvSpd=8539
,Temp_LStageY_SetMtPosMvTA=8540
,Temp_LStageY_SetReadyPosMvSpd=8541
,Temp_LStageY_SetReadyPosMvTA=8542
,Temp_LStageY_SetMtWorkStartPosMvSpd=8543
,Temp_LStageY_SetMtWorkStartPosMvTA=8544
,Temp_LStageY_SetAlignPosMvSpd=8545
,Temp_LStageY_SetAlignPosMvTA=8546
,Temp_LStageY_SetLoadingPosMvSpd=8547
,Temp_LStageY_SetLoadingPosMvTA=8548
,RStageY_SetMtReadyPos=4300
,RStageY_SetMtWorkStartPos=4301
,RStageY_SetMtSpare03Pos=4302
,RStageY_SetMtLoadingPos=4303
,RStageY_SetMtSpare04Pos=4304
,RStageY_SetMtViAilgn01Pos=4305
,RStageY_SetMtViAilgn02Pos=4306
,RStageY_SetMtViAilgn03Pos=4307
,RStageY_SetMtViAilgn04Pos=4308
,RStageY_SetMtSpare05Pos=4309
,RStageY_SetMtSpare06Pos=4310
,RStageY_SetMtSpare07Pos=4311
,RStageY_SetMtSpare08Pos=4312
,RStageY_SetMtSpare09Pos=4313
,RStageY_SetMtSafePos=4314
,RStageY_SetMtPosMvSpd=4315
,RStageY_SetMtPosMvTA=4316
,RStageY_SetReadyPosMvSpd=4317
,RStageY_SetReadyPosMvTA=4318
,RStageY_SetMtWorkStartPosMvSpd=4319
,RStageY_SetMtWorkStartPosMvTA=4320
,RStageY_SetAlignPosMvSpd=4321
,RStageY_SetAlignPosMvTA=4322
,RStageY_SetLoadingPosMvSpd=4323
,RStageY_SetLoadingPosMvTA=4324
,Temp_RStageY_SetMtReadyPos=8549
,Temp_RStageY_SetMtWorkStartPos=8550
,Temp_RStageY_SetMtSpare03Pos=8551
,Temp_RStageY_SetMtLoadingPos=8552
,Temp_RStageY_SetMtSpare04Pos=8553
,Temp_RStageY_SetMtViAilgn01Pos=8554
,Temp_RStageY_SetMtViAilgn02Pos=8555
,Temp_RStageY_SetMtViAilgn03Pos=8556
,Temp_RStageY_SetMtViAilgn04Pos=8557
,Temp_RStageY_SetMtSpare05Pos=8558
,Temp_RStageY_SetMtSpare06Pos=8559
,Temp_RStageY_SetMtSpare07Pos=8560
,Temp_RStageY_SetMtSpare08Pos=8561
,Temp_RStageY_SetMtSpare09Pos=8562
,Temp_RStageY_SetMtSafePos=8563
,Temp_RStageY_SetMtPosMvSpd=8564
,Temp_RStageY_SetMtPosMvTA=8565
,Temp_RStageY_SetReadyPosMvSpd=8566
,Temp_RStageY_SetReadyPosMvTA=8567
,Temp_RStageY_SetMtWorkStartPosMvSpd=8568
,Temp_RStageY_SetMtWorkStartPosMvTA=8569
,Temp_RStageY_SetAlignPosMvSpd=8570
,Temp_RStageY_SetAlignPosMvTA=8571
,Temp_RStageY_SetLoadingPosMvSpd=8572
,Temp_RStageY_SetLoadingPosMvTA=8573
,ServoZ_SetMtReadyPos=4500
,ServoZ_SetMtWorkStartPos=4501
,ServoZ_SetMtSpare03Pos=4502
,ServoZ_SetMtLoadingPos=4503
,ServoZ_SetMtSpare04Pos=4504
,ServoZ_SetMtLeftViAilgnPos=4505
,ServoZ_SetMtRightViAilgnPos=4506
,ServoZ_SetMtLeftLaserFocusPos=4507
,ServoZ_SetMtRigntLaserFocusPos=4508
,ServoZ_SetMtSpare05Pos=4509
,ServoZ_SetMtSpare06Pos=4510
,ServoZ_SetMtSpare07Pos=4511
,ServoZ_SetMtSpare08Pos=4512
,ServoZ_SetMtPowerMeterPos=4513
,ServoZ_SetMtSpare10Pos=4514
,ServoZ_SetMtPosMvSpd=4515
,ServoZ_SetMtPosMvTA=4516
,ServoZ_SetReadyPosMvSpd=4517
,ServoZ_SetReadyPosMvTA=4518
,ServoZ_SetMtWorkStartPosMvSpd=4519
,ServoZ_SetMtWorkStartPosMvTA=4520
,ServoZ_SetAlignPosMvSpd=4521
,ServoZ_SetAlignPosMvTA=4522
,ServoZ_SetLoadingPosMvSpd=4523
,ServoZ_SetLoadingPosMvTA=4524
,ServoZ_SetPowerMeterPosMvSpd=4525
,ServoZ_SetPowerMeterPosMvTA=4526
,Temp_ServoZ_SetMtReadyPos=8574
,Temp_ServoZ_SetMtWorkStartPos=8575
,Temp_ServoZ_SetMtSpare03Pos=8576
,Temp_ServoZ_SetMtLoadingPos=8577
,Temp_ServoZ_SetMtSpare04Pos=8578
,Temp_ServoZ_SetMtLeftViAilgnPos=8579
,Temp_ServoZ_SetMtRightViAilgnPos=8580
,Temp_ServoZ_SetMtLeftLaserFocusPos=8581
,Temp_ServoZ_SetMtRigntLaserFocusPos=8582
,Temp_ServoZ_SetMtSpare05Pos=8583
,Temp_ServoZ_SetMtSpare06Pos=8584
,Temp_ServoZ_SetMtSpare07Pos=8585
,Temp_ServoZ_SetMtSpare08Pos=8586
,Temp_ServoZ_SetMtPowerMeterPos=8587
,Temp_ServoZ_SetMtSpare10Pos=8588
,Temp_ServoZ_SetMtPosMvSpd=8589
,Temp_ServoZ_SetMtPosMvTA=8590
,Temp_ServoZ_SetReadyPosMvSpd=8591
,Temp_ServoZ_SetReadyPosMvTA=8592
,Temp_ServoZ_SetMtWorkStartPosMvSpd=8593
,Temp_ServoZ_SetMtWorkStartPosMvTA=8594
,Temp_ServoZ_SetAlignPosMvSpd=8595
,Temp_ServoZ_SetAlignPosMvTA=8596
,Temp_ServoZ_SetLoadingPosMvSpd=8597
,Temp_ServoZ_SetLoadingPosMvTA=8598
,Temp_ServoZ_SetPowerMeterPosMvSpd=8599
,Temp_ServoZ_SetPowerMeterPosMvTA=8600
,P2U_LstageY_MvPos=1205
,P2U_RstageY_MvPos=1305
,CalSlewRateForm=8601
,Mach_CalPlcCycleTime=8627
,Mach_CalAverPlcCycleTime=8628
,SetChkInposBand=8629
,Mach_StError=10049
,Temp_Cts_Mach_StError=10050
,Mach_Bit_0200_MsecToggle=10101
,Mach_Bit_0250_MsecToggle=10102
,Mach_Bit_0500_MsecToggle=10103
,Mach_Bit_1000_MsecToggle=10104
,Mach_CmdTime=10105
,Mach_WaitCycle=10106
,Mach_Cmd=10107
,Mach_CmdLock=10108
,Temp_Mach_ChkErr=10109
,Temp_Mach_Cmd=10110
,Mach_CmdErrCode=10111
,Mach_StIngMove=10112
,Mach_StAmpEnable=10113
,Mach_StAmpDisable=10114
,Mach_StCompHome=10115
,Mtr_CompExtraWindProgRun=10380
,Mach_SetMoveRdyTa=10381
,Mach_SetMoveRdySpd=10382
,Mtr_SetBasicTa=10680
,Mtr_SetBasicMoveSpd=10681
,Mtr_SetBasicJogMoveSpd=10682
,Mtr_SetBasicHomeSpd=10683
,HomeAllComplete=10684
,LSTAGE_AreaSenPauseCmd=10685
,RSTAGE_AreaSenPauseCmd=10686
,Mach_GetStatus=10753
,Mach_CtsChkPartError=11166
,Mach_CtsChkMtrError=11167
,Mach_CtsChkUnitError=11168
,Mach_CtsChkSeqError=11169
,Mach_CtsChkRobotPosError=11170
,Mach_ExeCmdErrorReset=11171
,Mach_ExeCmdReset=11172
,Mach_ExeRcpDataUpdate=11173
,Temp_CtsStCompHome=13344
,Temp_ChkMotorErr=13345
,Temp_CtsStCompReady=13346
,Temp_ChkReadyMotorErr=13347
,Mach_MotorAllServoOn=13418
,Mach_MotorAllServoOff=13419
,Mach_ReadyStatus=13420
,Exe_ResetLamp_On=13421
,Exe_ResetLamp_FlickOn=13422
,Temp_Exe_ResetLamp_FlickOn=13423
,Exe_LeftStartLamp_On=13424
,Exe_LeftStartLamp_FlickOn=13425
,Temp_Exe_LeftStartLamp_FlickOn=13426
,Exe_LeftStartLamp_RdyFlickOn=13427
,Temp_Exe_LeftStartLamp_RdyFlickOn=13428
,Exe_RightStartLamp_On=13429
,Exe_RightStartLamp_FlickOn=13430
,Temp_Exe_RightStartLamp_FlickOn=13431
,Exe_RightStartLamp_RdyFlickOn=13432
,Temp_Exe_RightStartLamp_RdyFlickOn=13433
,Temp_SinalTower_Buzzer=13434
,Temp_AreaSenErrStatus=13435
,Temp_MainDoorSenErrStatus=13436
,Temp_SideDooerSenErrStatus=13437
,Temp_LeftPressureSenErrStatus=13438
,Temp_RightPressureSenErrStatus=13439
,Temp_PressureSenErrStatus=13440
,Temp_LeakSenErrStatus=13441
,Temp_LstageSaftyMvErrStatus=13442
,Temp_LstageSaftyValueErrStatus=13443
,Temp_RstageSaftyMvErrStatus=13444
,Temp_RstageSaftyValueErrStatus=13445
,Safety_ErrorCheck=13446
,AutoRun_NotStopErrBit=13447
,Temp_SafetyStopErrNotClearStatus=13448
,Temp_SafetyEMOErrNotClearStatus=13449
,Temp_PressureSenUnUse=13450
,Temp_LeakSenUnUse=13451
,Temp_SaftyPosCheckUnUse=13452
,test_Mode=13453
,Half_test_Mode=13454
,test_ModeDataUndate=13455
,Temp_MaxAccData=13456
,Temp_Lstage_SaftyMvCheck=13457
,Temp_Rstage_SaftyMvCheck=13458
,Temp_Lstage_SaftyValueCheck=13459
,Temp_Rstage_SaftyValueCheck=13460
,Temp_Lstage_AutoRunStatus=13461
,Temp_Rstage_AutoRunStatus=13462
,Temp_Lstage_AutoRdyServoZPos=13463
,Temp_Rstage_AutoRdyServoZPos=13464
,LeftStopSwitchCts=14125
,RightStopSwitchCts=14126
,OldLeftStopSwitchCts=14127
,OldRightStopSwitchCts=14128
,MotionDownloadTimeOut=14129
,U2P_Mt01_ErrCode=3550
,U2P_Mt02_ErrCode=3551
,U2P_Mt03_ErrCode=3552
,U2P_Mt05_ErrCode=3554
,U2P_AllUnit_ErrCode=3650
,U2P_LStage_ErrCode=3651
,U2P_RStage_ErrCode=3652
,U2P_Mach_ErrCode=3750
,U2P_Part_ErrCode=3751
,Mach_SetSubProgUpdateTime=16176
,Mach_SetSubProgWaitCycle=16177
,LinearX_Mtr_HomeOffset=1104
,LStageY_Mtr_HomeOffset=1204
,RStageY_Mtr_HomeOffset=1304
,ServoZ_Mtr_HomeOffset=1504};
enum globalParray {_globalParray_=-1
,Temp_IO_Out=8267
,Temp_IOIn=8317
,Plc_SetUpdateTime=8602
,Plc_SetExeCount=8607
,Plc_SetUpdateCycle=8612
,Plc_ChkUpdateCount=8617
,Temp_Plc_ChkUpdateCount=8622
,Mtr_ExeCmd=8630
,Temp_Mtr_ExeCmd=8663
,Mtr_CmdLock=8696
,Mtr_StCompHome=8729
,Mtr_CmdErrorCode=8762
,Mtr_SetMachScale=8795
,Mtr_SetScale=8828
,Mtr_SetScaleOffset=8861
,Mtr_CalDivFactVel=8894
,Mtr_SetSoftLimP=8927
,Mtr_SetSoftLimN=8960
,Mtr_SetAbortAcc=8993
,Mtr_SetMaxAccG=9026
,Mtr_SetJogTa=9059
,Mtr_SetJogVel=9092
,Mtr_ChkJogCmd=9125
,Mtr_SetMoveTa=9158
,Mtr_SetMoveSpd=9191
,Mtr_SetMovePos=9224
,Mtr_SetPosRdy=9257
,Mtr_SetHomeTa=9290
,Mtr_SetHomeJVel=9323
,Mtr_SetHomeSVel=9356
,Mtr_SetHomeOffsetPos=9389
,Mtr_SetHomeOverTime=9422
,Mtr_SetMaxPos=9455
,Mtr_SetMinPos=9488
,Mtr_GetActPos=9521
,Mtr_GetDesPos=9554
,Temp_Mtr_GetActPos=9587
,Mtr_SavOffsetPos=9620
,Mtr_GetActSpd=9653
,Mtr_GetDesSpd=9686
,Mtr_StIngMove=9719
,Mtr_StIngHome=9752
,Mtr_StPosHome=9785
,Mtr_CalDacOut=9818
,Mtr_SetStopTd=9851
,Mtr_SetMotor_Type=9884
,Mtr_SetUSE_LIMIT_ERR=9917
,Mtr_SetMotorEcat=9950
,Mtr_ChkAmpEnable=9983
,Mtr_ChkMotorUnuse=10016
,Temp_Chk_Mach_StError=10051
,Mtr_ExeCmdStep=10116
,Mtr_ChkCmdStepReady=10149
,Mtr_BitCmdStepNotReady=10182
,Mtr_GetCmdError=10215
,Mtr_StAutoRdy=10248
,Mtr_StServoRdy=10281
,Mtr_CompExeProgRun=10314
,Mtr_CompProgRun=10347
,Mtr_ChkMoveRdyPos=10383
,Mtr_SetMoveRdyTa=10416
,Mtr_SetMoveRdySpd=10449
,Mtr_SetMoveRdyPos=10482
,Mtr_SetMoveTargetPos=10515
,Mtr_SetMoveRemainDist=10548
,Mtr_CompMovePos=10581
,Mtr_ChkPosSetPos=10614
,Mtr_ChkPosMoveRdyPos=10647
,Mtr_SetTouchprobeFunctionValue=10687
,Mtr_SaftyCheckTargetPos=10720
,Mtr_ExeManualCmd=10754
,Temp_Mtr_ExeManualCmd=10787
,Part_StAutoReady=10820
,Part_BitStNotAutoReady=10853
,Mach_ExeCmdStep=10886
,Mach_Chk1CycleCmd=10956
,Mach_ChkCmdStepReady=11026
,Mach_CmdErrorCode=11096
,Seq_ExeCmdStep=11174
,Temp_Seq_ExeCmdStep=11244
,Test_Seq_ExeCmdStep=11314
,Part_ExeCmdStep=11384
,Part_ChkCmdStepReady=11454
,Part_BitCmdStepNotReady=11524
,Part_CmdErrorCode=11594
,Part_StAmpEnable=11664
,Part_StCompHome=11734
,Part_StCompServoRdy=11804
,Part_StCompAutoRdy=11874
,Temp_Part_StAmpEnable=11944
,Temp_Part_StCompHome=12014
,Temp_Part_StCompServoRdy=12084
,Temp_Part_StCompAutoRdy=12154
,Unit_ExeCmdStep=12224
,Temp_Unit_ExeCmdStep=12294
,Unit_ReqCmd=12364
,Unit_LockCmd=12434
,Unit_StErrorStatus=12504
,Temp_Unit_StErrorStatus=12574
,Unit_CmdErrorCode=12644
,Ready_ExeCmdStep=12714
,Temp_Ready_ExeCmdStep=12784
,Part_StAutoRdy=12854
,Part_StMtrServoRdy=12924
,Part_StErrorStatus=12994
,Temp_Part_StErrorStatus=13064
,Part_ExeCmdReadyStep=13134
,Temp_Part_ExeCmdReadyStep=13204
,Part_CmdReadyError=13274
,Unit_AutoStartReadySt=13348
,Temp_Mtr_CheckReadyPos=13465
,Temp_Mtr_CheckLAlign01Pos=13498
,Temp_Mtr_CheckLAlign02Pos=13531
,Temp_Mtr_CheckLAlign03Pos=13564
,Temp_Mtr_CheckLAlign04Pos=13597
,Temp_Mtr_CheckRAlign01Pos=13630
,Temp_Mtr_CheckRAlign02Pos=13663
,Temp_Mtr_CheckRAlign03Pos=13696
,Temp_Mtr_CheckRAlign04Pos=13729
,Temp_Mtr_CheckAlign01Pos=13762
,Temp_Mtr_CheckAlign02Pos=13795
,Temp_Mtr_CheckAlign03Pos=13828
,Temp_Mtr_CheckAlign04Pos=13861
,Temp_Mtr_CheckPowerMeterPos=13894
,Temp_Mtr_CheckLoadingPos=13927
,Temp_Mtr_CheckWorkStartPos=13960
,Temp_Mtr_CheckLLoadingPos=13993
,Temp_Mtr_CheckRLoadingPos=14026
,Temp_Mtr_CheckLWorkStartPos=14059
,Temp_Mtr_CheckRWorkStartPos=14092
,MC_MoveJogP_In_Axis=14130
,MC_MoveJogP_In_MaxPosition=14163
,MC_MoveJogP_In_AccTime=14196
,MC_MoveJogP_In_Velocity=14229
,MC_MoveJogN_In_Axis=14262
,MC_MoveJogN_In_MinPosition=14295
,MC_MoveJogN_In_AccTime=14328
,MC_MoveJogN_In_Velocity=14361
,MC_MoveAbs_In_Axis=14394
,MC_MoveAbs_In_MaxPosition=14427
,MC_MoveAbs_In_MinPosition=14460
,MC_MoveAbs_In_Position=14493
,MC_MoveAbs_In_AccTime=14526
,MC_MoveAbs_In_Velocity=14559
,MC_MoveAbs_Ot_DesMovePosition=14592
,MC_MoveAbs_Ot_MovePosition=14625
,MC_MoveInc_In_Axis=14658
,MC_MoveInc_In_MaxPosition=14691
,MC_MoveInc_In_MinPosition=14724
,MC_MoveInc_In_Position=14757
,MC_MoveInc_In_AccTime=14790
,MC_MoveInc_In_Velocity=14823
,MC_MoveInc_Ot_DesMovePosition=14856
,MC_MoveInc_Ot_MovePosition=14889
,MC_MoveStop_In_DecTime=14922
,Mtr_Chk_ExeRdyErr_In_Cmd=14955
,Mtr_Chk_ExeRdyErr_Ot_Error=14988
,Mtr_Chk_ExeRdyErr_Ot_ErrorID=15021
,Mtr_Chk_ExeEndErr_In_Cmd=15054
,Mtr_Chk_ExeEndErr_Ot_Error=15087
,Mtr_Chk_ExeEndErr_Ot_ErrorID=15120
,Mtr_Cmd_StepHomeProg_In_HomeJogVel=15153
,Mtr_Cmd_StepHomeProg_In_HomeJogTa=15186
,Mtr_Cmd_StepHomeProg_In_HomeVel=15219
,Mtr_Cmd_StepHomeProg_In_HomeOffset=15252
,Mtr_Cmd_StepHomeProg_In_UseLimit=15285
,Mtr_Cmd_StepHomeProg_In_TimeOutTime=15318
,Mtr_Chk_AllAmpEna_Ot_Ena=15351
,Mtr_Chk_AllAmpEna_Ot_Temp=15384
,Mtr_Chk_AllCompHome_Ot_Comp=15417
,Mtr_Chk_AllCompHome_Ot_Temp=15450
,Mtr_Chk_AllMoving_Ot_Moving=15483
,Mtr_Chk_AllMoving_Ot_Temp=15516
,Mtr_Chk_AllErr_Ot_Err=15549
,Mtr_Chk_AllErr_Ot_Temp=15582
,MTR_Err_LimitErr_Ot_State=15615
,Mtr_Set_GateSetup_In_Word_SetGate=15648
,Mtr_Set_GateSetup_In_GateNum=15681
,Mtr_Set_GateSetup_In_ChanNum=15714
,Mtr_Set_MtWord_Setup_In_AbortAcc=15747
,Mtr_Set_MtWord_Setup_In_ProgMaxSpeed=15780
,Mtr_Set_MtWord_Setup_In_ProgMaxAcc=15813
,Mtr_Set_HomeWord_Setup_In_CaptCtrl=15846
,Mtr_Set_HomeWord_Setup_In_CaptFlag=15879
,AUTO_CHK_MtCmdEnd_Ot_Temp=15912
,AUTO_CHK_MtCmdEnd_Ot_Comp=15945
,AUTO_CHK_MtCmdEnd_Ot_Error=15978
,AUTO_CHK_CmdEnd_Ot_Temp=16011
,AUTO_CHK_CmdEnd_Ot_Comp=16044
,AUTO_CHK_CmdEnd_Ot_Error=16077
,AUTO_CHK_HostTimeBaseDone_Ot_Temp=16110
,AUTO_CHK_HostTimeBaseDone_Ot_Comp=16143};
enum csglobalQ {_csglobalQ_=-1};
enum csglobalQarray {_csglobalQarray_=-1};
enum ptrM {_ptrM_=-1
,diTable1Start=7004
,diTable1Vacuum=7005
,diTable1Stop=7006
,diTable1Reset=7007
,diTable2Start=7010
,diTable2Vacuum=7011
,diTable2Stop=7012
,diTable2Reset=7013
,doTable1StartLamp=7106
,doTable1VacuumLamp=7107
,doTable1StopLamp=7108
,doTable1ResetLamp=7109
,doTable2StartLamp=7110
,doTable2VacuumLamp=7111
,doTable2StopLamp=7112
,doTable2ResetLamp=7113
,doTable1Pump1=7125
,doTable1Pump2=7128
,In_Main_PowerOn=7000
,In_EMO01_Btn=7001
,In_EMO02_Btn=7002
,In_EMO03_Btn=7003
,In_LeftUnit_Start_Btn=7004
,In_LeftUnit_Vac_Btn=7005
,In_LeftUnit_Stop_Btn=7006
,In_LeftUnit_ReSet_Btn=7007
,In_LeftUnit_Pressure_Sen=7008
,In_LeftUnit_Vac_Sen=7009
,In_RightUnit_Start_Btn=7010
,In_RightUnit_Vac_Btn=7011
,In_RightUnit_Stop_Btn=7012
,In_RightUnit_ReSet_Btn=7013
,In_RightUnit_Pressure_Sen=7014
,In_RightUnit_Vac_Sen=7015
,In_Stage_PowerOn=7016
,In_Leak_Sen=7017
,In_Door01_Sen=7018
,In_Door02_Sen=7019
,In_Door03_Sen=7020
,In_Door04_Sen=7021
,In_Door05_Sen=7022
,In_Spare_UX024=7023
,In_LeftUnit_Ionizer=7024
,In_RightUnit_Ionizer=7025
,In_BeamShutter_Close=7026
,In_BeamShutter_Open=7027
,In_PowerMeter_Open=7028
,In_PowerMeter_Close=7029
,In_LeftUnit_Area_Sen=7030
,In_RightUnit_Area_Sen=7031
,In_Spare_UX033=7032
,In_Spare_UX034=7033
,In_Spare_UX035=7034
,In_Spare_UX036=7035
,In_Spare_UX037=7036
,In_Spare_UX038=7037
,In_Spare_UX039=7038
,In_Spare_UX040=7039
,In_Spare_UX041=7040
,In_Spare_UX042=7041
,In_Spare_UX043=7042
,In_Spare_UX044=7043
,In_Spare_UX045=7044
,In_Spare_UX046=7045
,In_Spare_UX047=7046
,In_Spare_UX048=7047
,Out_Soft_PowerOff=7100
,Out_LED_Light_On=7101
,Out_SignalTower_Red=7102
,Out_SignalTower_Yellow=7103
,Out_SignalTower_Green=7104
,Out_SinalTower_Buzzer=7105
,Out_LeftUnit_Start_Btn_Lamp=7106
,Out_LeftUnit_Vac_Btn_Lamp=7107
,Out_LeftUnit_Stop_Btn_Lamp=7108
,Out_LeftUnit_ReSet_Btn_Lamp=7109
,Out_RightUnit_Start_Btn_Lamp=7110
,Out_RightUnit_Vac_Btn_Lamp=7111
,Out_RightUnit_Stop_Btn_Lamp=7112
,Out_RightUnit_ReSet_Btn_Lamp=7113
,Out_LeftUnit_Ionizer=7114
,Out_LeftUnit_IonizerSol=7115
,Out_RightUnit_Ionizer=7116
,Out_RightUnit_IonizerSol=7117
,Out_BeamShutter_Sol=7118
,Out_Dust_Collector=7119
,Out_OpticBox_Purge=7120
,Out_PowerMeter_Up=7121
,Out_PowerMeter_Dw=7122
,Out_SelectBoard=7123
,Out_ADV_On=7124
,Out_LeftUnit_VacPump01=7125
,Out_LeftUnit_VacPumpSol01=7126
,Out_LeftUnit_VacPumpSol02=7127
,Out_LeftUnit_VacPump02=7128
,Out_LeftUnit_VacPumpSol03=7129
,Out_LeftUnit_VacPumpSol04=7130
,Out_RightUnit_VacPump01=7131
,Out_RightUnit_VacPumpSol01=7132
,Out_RightUnit_VacPumpSol02=7133
,Out_RightUnit_VacPump02=7134
,Out_RightUnit_VacPumpSol03=7135
,Out_RightUnit_VacPumpSol04=7136
,Out_Spare_UX038=7137
,Out_Spare_UX039=7138
,Out_Spare_UX040=7139
,Out_Spare_UX041=7140
,Out_Spare_UX042=7141
,Out_Spare_UX043=7142
,Out_Spare_UX044=7143
,Out_Spare_UX045=7144
,Out_Spare_UX046=7145
,Out_Spare_UX047=7146
,Out_Spare_UX048=7147};
enum ptrMarray {_ptrMarray_=-1
,IO_Out=8192
,IOIn=8242
,Mtr_GetHomeFlag=8292
,Mtr_SetEcatTouchprobeFunction=8325
,Mtr_SetEcatTouchprobeStatus=8358
,Mtr_SetEcatErrorReset=8391
,Mtr_SetEcatSerovoOut=8424};
#ifndef _PP_PROJ_HDR_
  void SetEnumGlobalVar(enum globalP var, double data)
  {
    pshm->P[var] = data;
  }

  double GetEnumGlobalVar(enum globalP var)
  {
    return pshm->P[var];
  }

  void SetEnumGlobalArrayVar(enum globalParray var, unsigned index, double data)
  {
    pshm->P[(var + index)%MAX_P] = data;
  }

  double GetEnumGlobalArrayVar(enum globalParray var, unsigned index)
  {
    return pshm->P[(var + index)%MAX_P];
  }

  void SetEnumCSGlobalVar(enum csglobalQ var, unsigned cs, double data)
  {
    pshm->Coord[cs % MAX_COORDS].Q[var] = data;
  }

  double GetEnumCSGlobalVar(enum csglobalQ var, unsigned cs)
  {
    return pshm->Coord[cs % MAX_COORDS].Q[var];
  }

  void SetEnumCSGlobalArrayVar(enum csglobalQarray var, unsigned index, unsigned cs, double data)
  {
    pshm->Coord[cs % MAX_COORDS].Q[(var + index)%MAX_Q] = data;
  }

  double GetEnumCSGlobalArrayVar(enum csglobalQarray var, unsigned index, unsigned cs)
  {
    return pshm->Coord[cs % MAX_COORDS].Q[(var + index)%MAX_Q];
  }

  void SetEnumPtrVar(enum ptrM var, double data)
  {
    im_write(pshm->Mdef + var, data, &pshm->Ldata);
  }

  double GetEnumPtrVar(enum ptrM var)
  {
    return im_read(pshm->Mdef + var, &pshm->Ldata);
  }

  void SetEnumPtrArrayVar(enum ptrMarray var, unsigned index, double data)
  {
    im_write(pshm->Mdef + ((var + index)%MAX_M), data, &pshm->Ldata);
  }

  double GetEnumPtrArrayVar(enum ptrMarray var, unsigned index)
  {
    return im_read(pshm->Mdef + ((var + index)%MAX_M), &pshm->Ldata);
  }

  #define SetGlobalVar(i, x)              SetEnumGlobalVar(i, x)
  #define SetGlobalArrayVar(i, j, x)      SetEnumGlobalArrayVar(i, j, x)
  #define GetGlobalVar(i)                 GetEnumGlobalVar(i)
  #define GetGlobalArrayVar(i, j)         GetEnumGlobalArrayVar(i, j)

  #define SetCSGlobalVar(i, j, x)         SetEnumCSGlobalVar(i, j, x)
  #define SetCSGlobalArrayVar(i, j, k, x) SetEnumCSGlobalArrayVar(i, j, k, x)
  #define GetCSGlobalVar(i, j)            GetEnumCSGlobalVar(i, j)
  #define GetCSGlobalArrayVar(i, j, k)    GetEnumCSGlobalArrayVar(i, j, k)

  #define SetPtrVar(i, x)                 SetEnumPtrVar(i, x)
  #define SetPtrArrayVar(i, j, x)         SetEnumPtrArrayVar(i, j, x)
  #define GetPtrVar(i)                    GetEnumPtrVar(i)
  #define GetPtrArrayVar(i, j)            GetEnumPtrArrayVar(i, j)

#else

  void SetEnumGlobalVar(enum globalP var, double data);
  double GetEnumGlobalVar(enum globalP var);
  void SetEnumGlobalArrayVar(enum globalParray var, unsigned index, double data);
  double GetEnumGlobalArrayVar(enum globalParray var, unsigned index);
  void SetEnumCSGlobalVar(enum csglobalQ var, unsigned cs, double data);
  double GetEnumCSGlobalVar(enum csglobalQ var, unsigned cs);
  void SetEnumCSGlobalArrayVar(enum csglobalQarray var, unsigned index, unsigned cs, double data);
  double GetEnumCSGlobalArrayVar(enum csglobalQarray var, unsigned index, unsigned cs);
  void SetEnumPtrVar(enum ptrM var, double data);
  double GetEnumPtrVar(enum ptrM var);
  void SetEnumPtrArrayVar(enum ptrMarray var, unsigned index, double data);
  double GetEnumPtrArrayVar(enum ptrMarray var, unsigned index);

  #define SetGlobalVar(i, x)              SetEnumGlobalVar(i, x)
  #define SetGlobalArrayVar(i, j, x)      SetEnumGlobalArrayVar(i, j, x)
  #define GetGlobalVar(i)                 GetEnumGlobalVar(i)
  #define GetGlobalArrayVar(i, j)         GetEnumGlobalArrayVar(i, j)

  #define SetCSGlobalVar(i, j, x)         SetEnumCSGlobalVar(i, j, x)
  #define SetCSGlobalArrayVar(i, j, k, x) SetEnumCSGlobalArrayVar(i, j, k, x)
  #define GetCSGlobalVar(i, j)            GetEnumCSGlobalVar(i, j)
  #define GetCSGlobalArrayVar(i, j, k)    GetEnumCSGlobalArrayVar(i, j, k)

  #define SetPtrVar(i, x)                 SetEnumPtrVar(i, x)
  #define SetPtrArrayVar(i, j, x)         SetEnumPtrArrayVar(i, j, x)
  #define GetPtrVar(i)                    GetEnumPtrVar(i)
  #define GetPtrArrayVar(i, j)            GetEnumPtrArrayVar(i, j)

#endif
// end of #ifdef _EnumMode_
#else
// ***** Standard default mode *****
#define diTable1Start 7004
#define diTable1Vacuum 7005
#define diTable1Stop 7006
#define diTable1Reset 7007
#define diTable2Start 7010
#define diTable2Vacuum 7011
#define diTable2Stop 7012
#define diTable2Reset 7013
#define doTable1StartLamp 7106
#define doTable1VacuumLamp 7107
#define doTable1StopLamp 7108
#define doTable1ResetLamp 7109
#define doTable2StartLamp 7110
#define doTable2VacuumLamp 7111
#define doTable2StopLamp 7112
#define doTable2ResetLamp 7113
#define doTable1Pump1 7125
#define doTable1Pump2 7128
#define XBusy 8192
#define XOriginDone 8193
#define XMotionDone 8194
#define XInPosition 8195
#define XCurPos 8196
#define XVelocity 8197
#define XInTargetPos 8198
#define XPositionTolerance 8199
#define Y1Busy 8200
#define Y1OriginDone 8201
#define Y1MotionDone 8202
#define Y1InPosition 8203
#define Y1CurPos 8204
#define Y1Velocity 8205
#define Y1InLoadPos 8206
#define Y1PositionTolerance 8207
#define Y2Busy 8208
#define Y2OriginDone 8209
#define Y2MotionDone 8210
#define Y2InPosition 8211
#define Y2CurPos 8212
#define Y2Velocity 8213
#define Y2InLoadPos 8214
#define Y2PositionTolerance 8215
#define ZBusy 8216
#define ZOriginDone 8217
#define ZMotionDone 8218
#define ZInPosition 8219
#define ZCurPos 8220
#define ZVelocity 8221
#define ZInTargetPos 8222
#define ZPositionTolerance 8223
#define Timer1 8224
#define Timer11 8225
#define Timer2 8226
#define Timer21 8227
#define MotorMoveStartTimeOut 8228
#define MotorMoveTimeOut 8229
#define MotorStopTime 8230
#define Table1EMOStopSwitch 8231
#define Table2EMOStopSwitch 8232
#define Table1StopSwitch 8233
#define Table2StopSwitch 8234
#define DownloadTimeOut1 8235
#define DownloadTimeOut2 8236
#define Table1ExeCount 8237
#define Table1Film 8238
#define Table1New 8239
#define Table1Step 8240
#define Table1LastStep 8241
#define Table1ErrorCode 8242
#define Table1Busy 8243
#define Table1Unload 8244
#define Table1Stop 8245
#define Table1EMOStop 8246
#define TempTable1Unload 8247
#define OldTable1Stop 8248
#define OldTable1EMOStop 8249
#define Table1LoadXPos 8250
#define Table1LoadYPos 8251
#define Table2Film 8252
#define Table2New 8253
#define Table2Step 8254
#define Table2LastStep 8255
#define Table2ErrorCode 8256
#define Table2Busy 8257
#define Table2Unload 8258
#define Table2Stop 8259
#define Table2EMOStop 8260
#define TempTable2Unload 8261
#define OldTable2Stop 8262
#define OldTable2EMOStop 8263
#define Table2LoadXPos 8264
#define Table2LoadYPos 8265
#define AutoRun 8266
#define IO_Out 8192
#define IOIn 8242
#define Temp_IO_Out 8267
#define Temp_IOIn 8317
#define In_Main_PowerOn 7000
#define In_EMO01_Btn 7001
#define In_EMO02_Btn 7002
#define In_EMO03_Btn 7003
#define In_LeftUnit_Start_Btn 7004
#define In_LeftUnit_Vac_Btn 7005
#define In_LeftUnit_Stop_Btn 7006
#define In_LeftUnit_ReSet_Btn 7007
#define In_LeftUnit_Pressure_Sen 7008
#define In_LeftUnit_Vac_Sen 7009
#define In_RightUnit_Start_Btn 7010
#define In_RightUnit_Vac_Btn 7011
#define In_RightUnit_Stop_Btn 7012
#define In_RightUnit_ReSet_Btn 7013
#define In_RightUnit_Pressure_Sen 7014
#define In_RightUnit_Vac_Sen 7015
#define In_Stage_PowerOn 7016
#define In_Leak_Sen 7017
#define In_Door01_Sen 7018
#define In_Door02_Sen 7019
#define In_Door03_Sen 7020
#define In_Door04_Sen 7021
#define In_Door05_Sen 7022
#define In_Spare_UX024 7023
#define In_LeftUnit_Ionizer 7024
#define In_RightUnit_Ionizer 7025
#define In_BeamShutter_Close 7026
#define In_BeamShutter_Open 7027
#define In_PowerMeter_Open 7028
#define In_PowerMeter_Close 7029
#define In_LeftUnit_Area_Sen 7030
#define In_RightUnit_Area_Sen 7031
#define In_Spare_UX033 7032
#define In_Spare_UX034 7033
#define In_Spare_UX035 7034
#define In_Spare_UX036 7035
#define In_Spare_UX037 7036
#define In_Spare_UX038 7037
#define In_Spare_UX039 7038
#define In_Spare_UX040 7039
#define In_Spare_UX041 7040
#define In_Spare_UX042 7041
#define In_Spare_UX043 7042
#define In_Spare_UX044 7043
#define In_Spare_UX045 7044
#define In_Spare_UX046 7045
#define In_Spare_UX047 7046
#define In_Spare_UX048 7047
#define Out_Soft_PowerOff 7100
#define Out_LED_Light_On 7101
#define Out_SignalTower_Red 7102
#define Out_SignalTower_Yellow 7103
#define Out_SignalTower_Green 7104
#define Out_SinalTower_Buzzer 7105
#define Out_LeftUnit_Start_Btn_Lamp 7106
#define Out_LeftUnit_Vac_Btn_Lamp 7107
#define Out_LeftUnit_Stop_Btn_Lamp 7108
#define Out_LeftUnit_ReSet_Btn_Lamp 7109
#define Out_RightUnit_Start_Btn_Lamp 7110
#define Out_RightUnit_Vac_Btn_Lamp 7111
#define Out_RightUnit_Stop_Btn_Lamp 7112
#define Out_RightUnit_ReSet_Btn_Lamp 7113
#define Out_LeftUnit_Ionizer 7114
#define Out_LeftUnit_IonizerSol 7115
#define Out_RightUnit_Ionizer 7116
#define Out_RightUnit_IonizerSol 7117
#define Out_BeamShutter_Sol 7118
#define Out_Dust_Collector 7119
#define Out_OpticBox_Purge 7120
#define Out_PowerMeter_Up 7121
#define Out_PowerMeter_Dw 7122
#define Out_SelectBoard 7123
#define Out_ADV_On 7124
#define Out_LeftUnit_VacPump01 7125
#define Out_LeftUnit_VacPumpSol01 7126
#define Out_LeftUnit_VacPumpSol02 7127
#define Out_LeftUnit_VacPump02 7128
#define Out_LeftUnit_VacPumpSol03 7129
#define Out_LeftUnit_VacPumpSol04 7130
#define Out_RightUnit_VacPump01 7131
#define Out_RightUnit_VacPumpSol01 7132
#define Out_RightUnit_VacPumpSol02 7133
#define Out_RightUnit_VacPump02 7134
#define Out_RightUnit_VacPumpSol03 7135
#define Out_RightUnit_VacPumpSol04 7136
#define Out_Spare_UX038 7137
#define Out_Spare_UX039 7138
#define Out_Spare_UX040 7139
#define Out_Spare_UX041 7140
#define Out_Spare_UX042 7141
#define Out_Spare_UX043 7142
#define Out_Spare_UX044 7143
#define Out_Spare_UX045 7144
#define Out_Spare_UX046 7145
#define Out_Spare_UX047 7146
#define Out_Spare_UX048 7147
#define Temp_In_Main_PowerOn 8367
#define Temp_In_EMO01_Btn 8368
#define Temp_In_EMO02_Btn 8369
#define Temp_In_EMO03_Btn 8370
#define Temp_In_LeftUnit_Start_Btn 8371
#define Temp_In_LeftUnit_Vac_Btn 8372
#define Temp_In_LeftUnit_Stop_Btn 8373
#define Temp_In_LeftUnit_ReSet_Btn 8374
#define Temp_In_LeftUnit_Pressure_Sen 8375
#define Temp_In_LeftUnit_Vac_Sen 8376
#define Temp_In_RightUnit_Start_Btn 8377
#define Temp_In_RightUnit_Vac_Btn 8378
#define Temp_In_RightUnit_Stop_Btn 8379
#define Temp_In_RightUnit_ReSet_Btn 8380
#define Temp_In_RightUnit_Pressure_Sen 8381
#define Temp_In_RightUnit_Vac_Sen 8382
#define Temp_In_Stage_PowerOn 8383
#define Temp_In_Leak_Sen 8384
#define Temp_In_Door01_Sen 8385
#define Temp_In_Door02_Sen 8386
#define Temp_In_Door03_Sen 8387
#define Temp_In_Door04_Sen 8388
#define Temp_In_Door05_Sen 8389
#define Temp_In_Spare_UX024 8390
#define Temp_In_LeftUnit_Ionizer 8391
#define Temp_In_RightUnit_Ionizer 8392
#define Temp_In_BeamShutter_Close 8393
#define Temp_In_BeamShutter_Open 8394
#define Temp_In_PowerMeter_Open 8395
#define Temp_In_PowerMeter_Close 8396
#define Temp_In_LeftUnit_Area_Sen 8397
#define Temp_In_RightUnit_Area_Sen 8398
#define Temp_In_Spare_UX033 8399
#define Temp_In_Spare_UX034 8400
#define Temp_In_Spare_UX035 8401
#define Temp_In_Spare_UX036 8402
#define Temp_In_Spare_UX037 8403
#define Temp_In_Spare_UX038 8404
#define Temp_In_Spare_UX039 8405
#define Temp_In_Spare_UX040 8406
#define Temp_In_Spare_UX041 8407
#define Temp_In_Spare_UX042 8408
#define Temp_In_Spare_UX043 8409
#define Temp_In_Spare_UX044 8410
#define Temp_In_Spare_UX045 8411
#define Temp_In_Spare_UX046 8412
#define Temp_In_Spare_UX047 8413
#define Temp_In_Spare_UX048 8414
#define P2U_Mach_AllHomeExe 5000
#define P2U_Mach_MtrAllServoOn 5002
#define P2U_Mach_MtrAllServoOff 5003
#define P2U_Mach_PowerMeterChk 5004
#define P2U_Mach_ReadyExe 5005
#define P2U_Mach_MainDoorUnUse 5006
#define P2U_Mach_AreaSenUnUse 5007
#define P2U_Mach_SideDoorUnUse 5008
#define P2U_Mach_BuzzerUnUse 5009
#define P2U_Mach_LEDLampOn 5010
#define P2U_Mach_MotionTimeOut 5011
#define P2U_Mach_BuzzerStopExe 5012
#define P2U_Mach_LstageProgStart 5013
#define P2U_Mach_RstageProgStart 5014
#define P2U_Mach_AutoStop 5015
#define P2U_Mach_ReSetStart 5016
#define P2U_Mach_ReadyStatus 5017
#define P2U_Mach_UnitStartDelayTime 5018
#define P2U_Mach_ReserveUnUse 5019
#define P2U_Mach_AutoCompVentUnUse 5021
#define P2U_Mach_VacErrCheckUnUse 5022
#define P2U_Mach_AreaSenVentUnUse 5023
#define P2U_Mach_LookAheadAcc 5025
#define Temp_Mach_AllHomeExe 8415
#define Temp_Mach_MtrAllServoOn 8416
#define Temp_Mach_MtrAllServoOff 8417
#define Temp_Mach_PowerMeterChk 8418
#define Temp_Mach_ReadyExe 8419
#define Temp_Mach_MainDoorUnUse 8420
#define Temp_Mach_AreaSenUnUse 8421
#define Temp_Mach_SideDoorUnUse 8422
#define Temp_Mach_LED_Light_On 8423
#define Temp_Mach_BuzzerStopExe 8424
#define Temp_Mach_BuzzerUnUse 8425
#define Temp_Mach_UnitStartDelayTime 8426
#define Temp_Mach_ReserveUnUse 8427
#define Temp_Mach_AutoCompVentUnUse 8428
#define Temp_Mach_VacErrCheckUnUse 8429
#define Temp_Mach_AreaSenVentUnUse 8430
#define U2P_Mach_BitData01 5154
#define U2P_Mach_BitData02 5155
#define U2P_Mach_Status 5100
#define U2P_Mach_AllHomming 5101
#define U2P_Mach_AllHomeComp 5102
#define U2P_Mach_PowerMoterChkComp 5104
#define U2P_Mach_ReadyPosComp 5105
#define MotionEnd 8000
#define Temp_Mach_Status 8431
#define Temp_Mach_AllHomming 8432
#define Temp_Mach_AllHomeComp 8433
#define Temp_Mach_MotionTimeOut 8434
#define U2P_Lstage_BitData01 6154
#define U2P_Lstage_BitData02 6155
#define P2U_Lstage_ReadySt 6000
#define P2U_Lstage_AutoStart 6001
#define P2U_Lstage_MotionDownroadComp 6002
#define P2U_Lstage_Glessthickness 6004
#define Temp_Lstage_ReadySt 8435
#define Temp_Lstage_AutoStart 8436
#define Temp_Lstage_MotionDownroadComp 8437
#define Temp_Lstage_Glessthickness 8438
#define P2U_Lstage_ViAilgnUnUse 6009
#define P2U_Lstage_ViAilgnCts 6010
#define P2U_Lstage_ViAilgn01TrigComp 6011
#define P2U_Lstage_ViAilgn02TrigComp 6012
#define P2U_Lstage_ViAilgn03TrigComp 6013
#define P2U_Lstage_ViAilgn04TrigComp 6014
#define Temp_Lstage_ViAilgnUnUse 8439
#define Temp_Lstage_ViAilgnCts 8440
#define Temp_Lstage_ViAilgn01TrigComp 8441
#define Temp_Lstage_ViAilgn02TrigComp 8442
#define Temp_Lstage_ViAilgn03TrigComp 8443
#define Temp_Lstage_ViAilgn04TrigComp 8444
#define P2U_Lstage_VacUseCts 6016
#define Temp_Lstage_VacUseCts 8445
#define P2U_Lstage_Vac01Time 6018
#define P2U_Lstage_Vac02Time 6019
#define P2U_Lstage_Vac03Time 6020
#define P2U_Lstage_Vac04Time 6021
#define Temp_Lstage_Vac01Time 8446
#define Temp_Lstage_Vac02Time 8447
#define Temp_Lstage_Vac03Time 8448
#define Temp_Lstage_Vac04Time 8449
#define P2U_Lstage_AilgnMvStart 6023
#define P2U_Lstage_WorkPosMvStart 6024
#define P2U_Lstage_LoadingPosMvStart 6025
#define P2U_Lstage_VacStart 6026
#define P2U_Lstage_ReadyMvStart 6028
#define Temp_Lstage_AilgnMvStart 8450
#define Temp_Lstage_WorkPosMvStart 8451
#define Temp_Lstage_LoadingPosMvStart 8452
#define Temp_Lstage_ReadyMvStart 8453
#define U2P_Lstage_VacReadySt 6100
#define U2P_Lstage_AutoReadySt 6101
#define U2P_Lstage_MotionDownroadExe 6102
#define U2P_Lstage_Motioning 6103
#define U2P_Lstage_MotionComp 6104
#define U2P_Lstage_AutoRunComp 6105
#define Temp_Lstage_VacReadySt 8454
#define Temp_Lstage_AutoReadySt 8455
#define Temp_Lstage_MotionDownroadExe 8456
#define Temp_Lstage_Motioning 8457
#define Temp_Lstage_MotionComp 8458
#define Temp_Lstage_AutoRunComp 8459
#define U2P_Lstage_ViAilgnSeqComp 6109
#define U2P_Lstage_ViAilgn01TrigExe 6110
#define U2P_Lstage_ViAilgn02TrigExe 6111
#define U2P_Lstage_ViAilgn03TrigExe 6112
#define U2P_Lstage_ViAilgn04TrigExe 6113
#define Temp_Lstage_ViAilgnSeqComp 8460
#define Temp_Lstage_ViAilgn01TrigExe 8461
#define Temp_Lstage_ViAilgn02TrigExe 8462
#define Temp_Lstage_ViAilgn03TrigExe 8463
#define Temp_Lstage_ViAilgn04TrigExe 8464
#define U2P_Lstage_MachStatus 6116
#define U2P_Lstage_AilgnMvComp 6123
#define U2P_Lstage_WorkPosMvComp 6124
#define U2P_Lstage_LoadingPosMvComp 6125
#define U2P_Lstage_ReadyMvComp 6128
#define Temp_Lstage_MachStatus 8465
#define P2U_Rstage_ReadySt 7000
#define P2U_Rstage_AutoStart 7001
#define P2U_Rstage_MotionDownroadComp 7002
#define P2U_Rstage_Glessthickness 7004
#define Temp_Rstage_ReadySt 8466
#define Temp_Rstage_AutoStart 8467
#define Temp_Rstage_MotionDownroadComp 8468
#define Temp_Rstage_Glessthickness 8469
#define P2U_Rstage_ViAilgnUnUse 7009
#define P2U_Rstage_ViAilgnCts 7010
#define P2U_Rstage_ViAilgn01TrigComp 7011
#define P2U_Rstage_ViAilgn02TrigComp 7012
#define P2U_Rstage_ViAilgn03TrigComp 7013
#define P2U_Rstage_ViAilgn04TrigComp 7014
#define Temp_Rstage_ViAilgnUnUse 8470
#define Temp_Rstage_ViAilgnCts 8471
#define Temp_Rstage_ViAilgn01TrigComp 8472
#define Temp_Rstage_ViAilgn02TrigComp 8473
#define Temp_Rstage_ViAilgn03TrigComp 8474
#define Temp_Rstage_ViAilgn04TrigComp 8475
#define P2U_Rstage_VacUseCts 7016
#define Temp_Rstage_VacUseCts 8476
#define P2U_Rstage_Vac01Time 7018
#define P2U_Rstage_Vac02Time 7019
#define P2U_Rstage_Vac03Time 7020
#define P2U_Rstage_Vac04Time 7021
#define Temp_Rstage_Vac01Time 8477
#define Temp_Rstage_Vac02Time 8478
#define Temp_Rstage_Vac03Time 8479
#define Temp_Rstage_Vac04Time 8480
#define P2U_Rstage_AilgnMvStart 7023
#define P2U_Rstage_WorkPosMvStart 7024
#define P2U_Rstage_LoadingPosMvStart 7025
#define P2U_Rstage_VacStart 7026
#define P2U_Rstage_ReadyMvStart 7028
#define Temp_Rstage_AilgnMvStart 8481
#define Temp_Rstage_WorkPosMvStart 8482
#define Temp_Rstage_LoadingPosMvStart 8483
#define Temp_Rstage_ReadyMvStart 8484
#define U2P_Rstage_BitData01 7154
#define U2P_Rstage_BitData02 7155
#define U2P_Rstage_VacReadySt 7100
#define U2P_Rstage_AutoReadySt 7101
#define U2P_Rstage_MotionDownroadExe 7102
#define U2P_Rstage_Motioning 7103
#define U2P_Rstage_MotionComp 7104
#define U2P_Rstage_AutoRunComp 7105
#define Temp_Rstage_VacReadySt 8485
#define Temp_Rstage_AutoReadySt 8486
#define Temp_Rstage_MotionDownroadExe 8487
#define Temp_Rstage_Motioning 8488
#define Temp_Rstage_MotionComp 8489
#define Temp_Rstage_AutoRunComp 8490
#define U2P_Rstage_ViAilgnSeqComp 7109
#define U2P_Rstage_ViAilgn01TrigExe 7110
#define U2P_Rstage_ViAilgn02TrigExe 7111
#define U2P_Rstage_ViAilgn03TrigExe 7112
#define U2P_Rstage_ViAilgn04TrigExe 7113
#define Temp_Rstage_ViAilgnSeqComp 8491
#define Temp_Rstage_ViAilgn01TrigExe 8492
#define Temp_Rstage_ViAilgn02TrigExe 8493
#define Temp_Rstage_ViAilgn03TrigExe 8494
#define Temp_Rstage_ViAilgn04TrigExe 8495
#define U2P_Rstage_MachStatus 7116
#define U2P_Rstage_AilgnMvComp 7123
#define U2P_Rstage_WorkPosMvComp 7124
#define U2P_Rstage_LoadingPosMvComp 7125
#define U2P_Rstage_ReadyMvComp 7128
#define Temp_Rstage_MachStatus 8496
#define LinearX_SetMtReadyPos 4100
#define LinearX_SetMtLWorkStartPos 4101
#define LinearX_SetMtRWorkStartPos 4102
#define LinearX_SetMtLLoadingPos 4103
#define LinearX_SetMtRLoadingPos 4104
#define LinearX_SetMtLViAilgn01Pos 4105
#define LinearX_SetMtLViAilgn02Pos 4106
#define LinearX_SetMtLViAilgn03Pos 4107
#define LinearX_SetMtLViAilgn04Pos 4108
#define LinearX_SetMtRViAilgn01Pos 4109
#define LinearX_SetMtRViAilgn02Pos 4110
#define LinearX_SetMtRViAilgn03Pos 4111
#define LinearX_SetMtRViAilgn04Pos 4112
#define LinearX_SetMtPowerMeterPos 4113
#define LinearX_SetMtSpare10Pos 4114
#define LinearX_SetMtPosMvSpd 4115
#define LinearX_SetMtPosMvTA 4116
#define LinearX_SetReadyPosMvSpd 4117
#define LinearX_SetReadyPosMvTA 4118
#define LinearX_SetMtWorkStartPosMvSpd 4119
#define LinearX_SetMtWorkStartPosMvTA 4120
#define LinearX_SetAlignPosMvSpd 4121
#define LinearX_SetAlignPosMvTA 4122
#define LinearX_SetLoadingPosMvSpd 4123
#define LinearX_SetLoadingPosMvTA 4124
#define LinearX_SetPowerMeterPosMvSpd 4125
#define LinearX_SetPowerMeterPosMvTA 4126
#define Temp_LinearX_SetMtReadyPos 8497
#define Temp_LinearX_SetMtLWorkStartPos 8498
#define Temp_LinearX_SetMtRWorkStartPos 8499
#define Temp_LinearX_SetMtLLoadingPos 8500
#define Temp_LinearX_SetMtRLoadingPos 8501
#define Temp_LinearX_SetMtLViAilgn01Pos 8502
#define Temp_LinearX_SetMtLViAilgn02Pos 8503
#define Temp_LinearX_SetMtLViAilgn03Pos 8504
#define Temp_LinearX_SetMtLViAilgn04Pos 8505
#define Temp_LinearX_SetMtRViAilgn01Pos 8506
#define Temp_LinearX_SetMtRViAilgn02Pos 8507
#define Temp_LinearX_SetMtRViAilgn03Pos 8508
#define Temp_LinearX_SetMtRViAilgn04Pos 8509
#define Temp_LinearX_SetMtPowerMeterPos 8510
#define Temp_LinearX_SetMtSpare10Pos 8511
#define Temp_LinearX_SetMtPosMvSpd 8512
#define Temp_LinearX_SetMtPosMvTA 8513
#define Temp_LinearX_SetReadyPosMvSpd 8514
#define Temp_LinearX_SetReadyPosMvTA 8515
#define Temp_LinearX_SetMtWorkStartPosMvSpd 8516
#define Temp_LinearX_SetMtWorkStartPosMvTA 8517
#define Temp_LinearX_SetAlignPosMvSpd 8518
#define Temp_LinearX_SetAlignPosMvTA 8519
#define Temp_LinearX_SetLoadingPosMvSpd 8520
#define Temp_LinearX_SetLoadingPosMvTA 8521
#define Temp_LinearX_SetPowerMeterPosMvSpd 8522
#define Temp_LinearX_SetPowerMeterPosMvTA 8523
#define LStageY_SetMtReadyPos 4200
#define LStageY_SetMtWorkStartPos 4201
#define LStageY_SetMtSpare03Pos 4202
#define LStageY_SetMtLoadingPos 4203
#define LStageY_SetMtSpare04Pos 4204
#define LStageY_SetMtViAilgn01Pos 4205
#define LStageY_SetMtViAilgn02Pos 4206
#define LStageY_SetMtViAilgn03Pos 4207
#define LStageY_SetMtViAilgn04Pos 4208
#define LStageY_SetMtSpare05Pos 4209
#define LStageY_SetMtSpare06Pos 4210
#define LStageY_SetMtSpare07Pos 4211
#define LStageY_SetMtSpare08Pos 4212
#define LStageY_SetMtSpare09Pos 4213
#define LStageY_SetMtSafePos 4214
#define LStageY_SetMtPosMvSpd 4215
#define LStageY_SetMtPosMvTA 4216
#define LStageY_SetReadyPosMvSpd 4217
#define LStageY_SetReadyPosMvTA 4218
#define LStageY_SetMtWorkStartPosMvSpd 4219
#define LStageY_SetMtWorkStartPosMvTA 4220
#define LStageY_SetAlignPosMvSpd 4221
#define LStageY_SetAlignPosMvTA 4222
#define LStageY_SetLoadingPosMvSpd 4223
#define LStageY_SetLoadingPosMvTA 4224
#define Temp_LStageY_SetMtReadyPos 8524
#define Temp_LStageY_SetMtWorkStartPos 8525
#define Temp_LStageY_SetMtSpare03Pos 8526
#define Temp_LStageY_SetMtLoadingPos 8527
#define Temp_LStageY_SetMtSpare04Pos 8528
#define Temp_LStageY_SetMtViAilgn01Pos 8529
#define Temp_LStageY_SetMtViAilgn02Pos 8530
#define Temp_LStageY_SetMtViAilgn03Pos 8531
#define Temp_LStageY_SetMtViAilgn04Pos 8532
#define Temp_LStageY_SetMtSpare05Pos 8533
#define Temp_LStageY_SetMtSpare06Pos 8534
#define Temp_LStageY_SetMtSpare07Pos 8535
#define Temp_LStageY_SetMtSpare08Pos 8536
#define Temp_LStageY_SetMtSpare09Pos 8537
#define Temp_LStageY_SetMtSafePos 8538
#define Temp_LStageY_SetMtPosMvSpd 8539
#define Temp_LStageY_SetMtPosMvTA 8540
#define Temp_LStageY_SetReadyPosMvSpd 8541
#define Temp_LStageY_SetReadyPosMvTA 8542
#define Temp_LStageY_SetMtWorkStartPosMvSpd 8543
#define Temp_LStageY_SetMtWorkStartPosMvTA 8544
#define Temp_LStageY_SetAlignPosMvSpd 8545
#define Temp_LStageY_SetAlignPosMvTA 8546
#define Temp_LStageY_SetLoadingPosMvSpd 8547
#define Temp_LStageY_SetLoadingPosMvTA 8548
#define RStageY_SetMtReadyPos 4300
#define RStageY_SetMtWorkStartPos 4301
#define RStageY_SetMtSpare03Pos 4302
#define RStageY_SetMtLoadingPos 4303
#define RStageY_SetMtSpare04Pos 4304
#define RStageY_SetMtViAilgn01Pos 4305
#define RStageY_SetMtViAilgn02Pos 4306
#define RStageY_SetMtViAilgn03Pos 4307
#define RStageY_SetMtViAilgn04Pos 4308
#define RStageY_SetMtSpare05Pos 4309
#define RStageY_SetMtSpare06Pos 4310
#define RStageY_SetMtSpare07Pos 4311
#define RStageY_SetMtSpare08Pos 4312
#define RStageY_SetMtSpare09Pos 4313
#define RStageY_SetMtSafePos 4314
#define RStageY_SetMtPosMvSpd 4315
#define RStageY_SetMtPosMvTA 4316
#define RStageY_SetReadyPosMvSpd 4317
#define RStageY_SetReadyPosMvTA 4318
#define RStageY_SetMtWorkStartPosMvSpd 4319
#define RStageY_SetMtWorkStartPosMvTA 4320
#define RStageY_SetAlignPosMvSpd 4321
#define RStageY_SetAlignPosMvTA 4322
#define RStageY_SetLoadingPosMvSpd 4323
#define RStageY_SetLoadingPosMvTA 4324
#define Temp_RStageY_SetMtReadyPos 8549
#define Temp_RStageY_SetMtWorkStartPos 8550
#define Temp_RStageY_SetMtSpare03Pos 8551
#define Temp_RStageY_SetMtLoadingPos 8552
#define Temp_RStageY_SetMtSpare04Pos 8553
#define Temp_RStageY_SetMtViAilgn01Pos 8554
#define Temp_RStageY_SetMtViAilgn02Pos 8555
#define Temp_RStageY_SetMtViAilgn03Pos 8556
#define Temp_RStageY_SetMtViAilgn04Pos 8557
#define Temp_RStageY_SetMtSpare05Pos 8558
#define Temp_RStageY_SetMtSpare06Pos 8559
#define Temp_RStageY_SetMtSpare07Pos 8560
#define Temp_RStageY_SetMtSpare08Pos 8561
#define Temp_RStageY_SetMtSpare09Pos 8562
#define Temp_RStageY_SetMtSafePos 8563
#define Temp_RStageY_SetMtPosMvSpd 8564
#define Temp_RStageY_SetMtPosMvTA 8565
#define Temp_RStageY_SetReadyPosMvSpd 8566
#define Temp_RStageY_SetReadyPosMvTA 8567
#define Temp_RStageY_SetMtWorkStartPosMvSpd 8568
#define Temp_RStageY_SetMtWorkStartPosMvTA 8569
#define Temp_RStageY_SetAlignPosMvSpd 8570
#define Temp_RStageY_SetAlignPosMvTA 8571
#define Temp_RStageY_SetLoadingPosMvSpd 8572
#define Temp_RStageY_SetLoadingPosMvTA 8573
#define ServoZ_SetMtReadyPos 4500
#define ServoZ_SetMtWorkStartPos 4501
#define ServoZ_SetMtSpare03Pos 4502
#define ServoZ_SetMtLoadingPos 4503
#define ServoZ_SetMtSpare04Pos 4504
#define ServoZ_SetMtLeftViAilgnPos 4505
#define ServoZ_SetMtRightViAilgnPos 4506
#define ServoZ_SetMtLeftLaserFocusPos 4507
#define ServoZ_SetMtRigntLaserFocusPos 4508
#define ServoZ_SetMtSpare05Pos 4509
#define ServoZ_SetMtSpare06Pos 4510
#define ServoZ_SetMtSpare07Pos 4511
#define ServoZ_SetMtSpare08Pos 4512
#define ServoZ_SetMtPowerMeterPos 4513
#define ServoZ_SetMtSpare10Pos 4514
#define ServoZ_SetMtPosMvSpd 4515
#define ServoZ_SetMtPosMvTA 4516
#define ServoZ_SetReadyPosMvSpd 4517
#define ServoZ_SetReadyPosMvTA 4518
#define ServoZ_SetMtWorkStartPosMvSpd 4519
#define ServoZ_SetMtWorkStartPosMvTA 4520
#define ServoZ_SetAlignPosMvSpd 4521
#define ServoZ_SetAlignPosMvTA 4522
#define ServoZ_SetLoadingPosMvSpd 4523
#define ServoZ_SetLoadingPosMvTA 4524
#define ServoZ_SetPowerMeterPosMvSpd 4525
#define ServoZ_SetPowerMeterPosMvTA 4526
#define Temp_ServoZ_SetMtReadyPos 8574
#define Temp_ServoZ_SetMtWorkStartPos 8575
#define Temp_ServoZ_SetMtSpare03Pos 8576
#define Temp_ServoZ_SetMtLoadingPos 8577
#define Temp_ServoZ_SetMtSpare04Pos 8578
#define Temp_ServoZ_SetMtLeftViAilgnPos 8579
#define Temp_ServoZ_SetMtRightViAilgnPos 8580
#define Temp_ServoZ_SetMtLeftLaserFocusPos 8581
#define Temp_ServoZ_SetMtRigntLaserFocusPos 8582
#define Temp_ServoZ_SetMtSpare05Pos 8583
#define Temp_ServoZ_SetMtSpare06Pos 8584
#define Temp_ServoZ_SetMtSpare07Pos 8585
#define Temp_ServoZ_SetMtSpare08Pos 8586
#define Temp_ServoZ_SetMtPowerMeterPos 8587
#define Temp_ServoZ_SetMtSpare10Pos 8588
#define Temp_ServoZ_SetMtPosMvSpd 8589
#define Temp_ServoZ_SetMtPosMvTA 8590
#define Temp_ServoZ_SetReadyPosMvSpd 8591
#define Temp_ServoZ_SetReadyPosMvTA 8592
#define Temp_ServoZ_SetMtWorkStartPosMvSpd 8593
#define Temp_ServoZ_SetMtWorkStartPosMvTA 8594
#define Temp_ServoZ_SetAlignPosMvSpd 8595
#define Temp_ServoZ_SetAlignPosMvTA 8596
#define Temp_ServoZ_SetLoadingPosMvSpd 8597
#define Temp_ServoZ_SetLoadingPosMvTA 8598
#define Temp_ServoZ_SetPowerMeterPosMvSpd 8599
#define Temp_ServoZ_SetPowerMeterPosMvTA 8600
#define P2U_LstageY_MvPos 1205
#define P2U_RstageY_MvPos 1305
#define CalSlewRateForm 8601
#define Plc_SetUpdateTime 8602
#define Plc_SetExeCount 8607
#define Plc_SetUpdateCycle 8612
#define Plc_ChkUpdateCount 8617
#define Temp_Plc_ChkUpdateCount 8622
#define Mach_CalPlcCycleTime 8627
#define Mach_CalAverPlcCycleTime 8628
#define SetChkInposBand 8629
#define Mtr_ExeCmd 8630
#define Temp_Mtr_ExeCmd 8663
#define Mtr_CmdLock 8696
#define Mtr_StCompHome 8729
#define Mtr_CmdErrorCode 8762
#define Mtr_SetMachScale 8795
#define Mtr_SetScale 8828
#define Mtr_SetScaleOffset 8861
#define Mtr_CalDivFactVel 8894
#define Mtr_SetSoftLimP 8927
#define Mtr_SetSoftLimN 8960
#define Mtr_SetAbortAcc 8993
#define Mtr_SetMaxAccG 9026
#define Mtr_SetJogTa 9059
#define Mtr_SetJogVel 9092
#define Mtr_ChkJogCmd 9125
#define Mtr_SetMoveTa 9158
#define Mtr_SetMoveSpd 9191
#define Mtr_SetMovePos 9224
#define Mtr_SetPosRdy 9257
#define Mtr_SetHomeTa 9290
#define Mtr_SetHomeJVel 9323
#define Mtr_SetHomeSVel 9356
#define Mtr_SetHomeOffsetPos 9389
#define Mtr_SetHomeOverTime 9422
#define Mtr_SetMaxPos 9455
#define Mtr_SetMinPos 9488
#define Mtr_GetActPos 9521
#define Mtr_GetDesPos 9554
#define Temp_Mtr_GetActPos 9587
#define Mtr_SavOffsetPos 9620
#define Mtr_GetActSpd 9653
#define Mtr_GetDesSpd 9686
#define Mtr_StIngMove 9719
#define Mtr_StIngHome 9752
#define Mtr_StPosHome 9785
#define Mtr_CalDacOut 9818
#define Mtr_SetStopTd 9851
#define Mtr_SetMotor_Type 9884
#define Mtr_SetUSE_LIMIT_ERR 9917
#define Mtr_SetMotorEcat 9950
#define Mtr_ChkAmpEnable 9983
#define Mtr_ChkMotorUnuse 10016
#define Mach_StError 10049
#define Temp_Cts_Mach_StError 10050
#define Temp_Chk_Mach_StError 10051
#define Mach_Bit_0200_MsecToggle 10101
#define Mach_Bit_0250_MsecToggle 10102
#define Mach_Bit_0500_MsecToggle 10103
#define Mach_Bit_1000_MsecToggle 10104
#define Mach_CmdTime 10105
#define Mach_WaitCycle 10106
#define Mach_Cmd 10107
#define Mach_CmdLock 10108
#define Temp_Mach_ChkErr 10109
#define Temp_Mach_Cmd 10110
#define Mach_CmdErrCode 10111
#define Mach_StIngMove 10112
#define Mach_StAmpEnable 10113
#define Mach_StAmpDisable 10114
#define Mach_StCompHome 10115
#define Mtr_ExeCmdStep 10116
#define Mtr_ChkCmdStepReady 10149
#define Mtr_BitCmdStepNotReady 10182
#define Mtr_GetCmdError 10215
#define Mtr_StAutoRdy 10248
#define Mtr_StServoRdy 10281
#define Mtr_CompExeProgRun 10314
#define Mtr_CompProgRun 10347
#define Mtr_CompExtraWindProgRun 10380
#define Mach_SetMoveRdyTa 10381
#define Mach_SetMoveRdySpd 10382
#define Mtr_ChkMoveRdyPos 10383
#define Mtr_SetMoveRdyTa 10416
#define Mtr_SetMoveRdySpd 10449
#define Mtr_SetMoveRdyPos 10482
#define Mtr_SetMoveTargetPos 10515
#define Mtr_SetMoveRemainDist 10548
#define Mtr_CompMovePos 10581
#define Mtr_ChkPosSetPos 10614
#define Mtr_ChkPosMoveRdyPos 10647
#define Mtr_SetBasicTa 10680
#define Mtr_SetBasicMoveSpd 10681
#define Mtr_SetBasicJogMoveSpd 10682
#define Mtr_SetBasicHomeSpd 10683
#define Mtr_GetHomeFlag 8292
#define HomeAllComplete 10684
#define LSTAGE_AreaSenPauseCmd 10685
#define RSTAGE_AreaSenPauseCmd 10686
#define Mtr_SetEcatTouchprobeFunction 8325
#define Mtr_SetEcatTouchprobeStatus 8358
#define Mtr_SetEcatErrorReset 8391
#define Mtr_SetEcatSerovoOut 8424
#define Mtr_SetTouchprobeFunctionValue 10687
#define Mtr_SaftyCheckTargetPos 10720
#define Mach_GetStatus 10753
#define Mtr_ExeManualCmd 10754
#define Temp_Mtr_ExeManualCmd 10787
#define Part_StAutoReady 10820
#define Part_BitStNotAutoReady 10853
#define Mach_ExeCmdStep 10886
#define Mach_Chk1CycleCmd 10956
#define Mach_ChkCmdStepReady 11026
#define Mach_CmdErrorCode 11096
#define Mach_CtsChkPartError 11166
#define Mach_CtsChkMtrError 11167
#define Mach_CtsChkUnitError 11168
#define Mach_CtsChkSeqError 11169
#define Mach_CtsChkRobotPosError 11170
#define Mach_ExeCmdErrorReset 11171
#define Mach_ExeCmdReset 11172
#define Mach_ExeRcpDataUpdate 11173
#define Seq_ExeCmdStep 11174
#define Temp_Seq_ExeCmdStep 11244
#define Test_Seq_ExeCmdStep 11314
#define Part_ExeCmdStep 11384
#define Part_ChkCmdStepReady 11454
#define Part_BitCmdStepNotReady 11524
#define Part_CmdErrorCode 11594
#define Part_StAmpEnable 11664
#define Part_StCompHome 11734
#define Part_StCompServoRdy 11804
#define Part_StCompAutoRdy 11874
#define Temp_Part_StAmpEnable 11944
#define Temp_Part_StCompHome 12014
#define Temp_Part_StCompServoRdy 12084
#define Temp_Part_StCompAutoRdy 12154
#define Unit_ExeCmdStep 12224
#define Temp_Unit_ExeCmdStep 12294
#define Unit_ReqCmd 12364
#define Unit_LockCmd 12434
#define Unit_StErrorStatus 12504
#define Temp_Unit_StErrorStatus 12574
#define Unit_CmdErrorCode 12644
#define Ready_ExeCmdStep 12714
#define Temp_Ready_ExeCmdStep 12784
#define Part_StAutoRdy 12854
#define Part_StMtrServoRdy 12924
#define Part_StErrorStatus 12994
#define Temp_Part_StErrorStatus 13064
#define Part_ExeCmdReadyStep 13134
#define Temp_Part_ExeCmdReadyStep 13204
#define Part_CmdReadyError 13274
#define Temp_CtsStCompHome 13344
#define Temp_ChkMotorErr 13345
#define Temp_CtsStCompReady 13346
#define Temp_ChkReadyMotorErr 13347
#define Unit_AutoStartReadySt 13348
#define Mach_MotorAllServoOn 13418
#define Mach_MotorAllServoOff 13419
#define Mach_ReadyStatus 13420
#define Exe_ResetLamp_On 13421
#define Exe_ResetLamp_FlickOn 13422
#define Temp_Exe_ResetLamp_FlickOn 13423
#define Exe_LeftStartLamp_On 13424
#define Exe_LeftStartLamp_FlickOn 13425
#define Temp_Exe_LeftStartLamp_FlickOn 13426
#define Exe_LeftStartLamp_RdyFlickOn 13427
#define Temp_Exe_LeftStartLamp_RdyFlickOn 13428
#define Exe_RightStartLamp_On 13429
#define Exe_RightStartLamp_FlickOn 13430
#define Temp_Exe_RightStartLamp_FlickOn 13431
#define Exe_RightStartLamp_RdyFlickOn 13432
#define Temp_Exe_RightStartLamp_RdyFlickOn 13433
#define Temp_SinalTower_Buzzer 13434
#define Temp_AreaSenErrStatus 13435
#define Temp_MainDoorSenErrStatus 13436
#define Temp_SideDooerSenErrStatus 13437
#define Temp_LeftPressureSenErrStatus 13438
#define Temp_RightPressureSenErrStatus 13439
#define Temp_PressureSenErrStatus 13440
#define Temp_LeakSenErrStatus 13441
#define Temp_LstageSaftyMvErrStatus 13442
#define Temp_LstageSaftyValueErrStatus 13443
#define Temp_RstageSaftyMvErrStatus 13444
#define Temp_RstageSaftyValueErrStatus 13445
#define Safety_ErrorCheck 13446
#define AutoRun_NotStopErrBit 13447
#define Temp_SafetyStopErrNotClearStatus 13448
#define Temp_SafetyEMOErrNotClearStatus 13449
#define Temp_PressureSenUnUse 13450
#define Temp_LeakSenUnUse 13451
#define Temp_SaftyPosCheckUnUse 13452
#define test_Mode 13453
#define Half_test_Mode 13454
#define test_ModeDataUndate 13455
#define Temp_MaxAccData 13456
#define Temp_Lstage_SaftyMvCheck 13457
#define Temp_Rstage_SaftyMvCheck 13458
#define Temp_Lstage_SaftyValueCheck 13459
#define Temp_Rstage_SaftyValueCheck 13460
#define Temp_Lstage_AutoRunStatus 13461
#define Temp_Rstage_AutoRunStatus 13462
#define Temp_Lstage_AutoRdyServoZPos 13463
#define Temp_Rstage_AutoRdyServoZPos 13464
#define Temp_Mtr_CheckReadyPos 13465
#define Temp_Mtr_CheckLAlign01Pos 13498
#define Temp_Mtr_CheckLAlign02Pos 13531
#define Temp_Mtr_CheckLAlign03Pos 13564
#define Temp_Mtr_CheckLAlign04Pos 13597
#define Temp_Mtr_CheckRAlign01Pos 13630
#define Temp_Mtr_CheckRAlign02Pos 13663
#define Temp_Mtr_CheckRAlign03Pos 13696
#define Temp_Mtr_CheckRAlign04Pos 13729
#define Temp_Mtr_CheckAlign01Pos 13762
#define Temp_Mtr_CheckAlign02Pos 13795
#define Temp_Mtr_CheckAlign03Pos 13828
#define Temp_Mtr_CheckAlign04Pos 13861
#define Temp_Mtr_CheckPowerMeterPos 13894
#define Temp_Mtr_CheckLoadingPos 13927
#define Temp_Mtr_CheckWorkStartPos 13960
#define Temp_Mtr_CheckLLoadingPos 13993
#define Temp_Mtr_CheckRLoadingPos 14026
#define Temp_Mtr_CheckLWorkStartPos 14059
#define Temp_Mtr_CheckRWorkStartPos 14092
#define LeftStopSwitchCts 14125
#define RightStopSwitchCts 14126
#define OldLeftStopSwitchCts 14127
#define OldRightStopSwitchCts 14128
#define MotionDownloadTimeOut 14129
#define U2P_Mt01_ErrCode 3550
#define U2P_Mt02_ErrCode 3551
#define U2P_Mt03_ErrCode 3552
#define U2P_Mt05_ErrCode 3554
#define U2P_AllUnit_ErrCode 3650
#define U2P_LStage_ErrCode 3651
#define U2P_RStage_ErrCode 3652
#define U2P_Mach_ErrCode 3750
#define U2P_Part_ErrCode 3751
#define MC_MoveJogP_In_Axis 14130
#define MC_MoveJogP_In_MaxPosition 14163
#define MC_MoveJogP_In_AccTime 14196
#define MC_MoveJogP_In_Velocity 14229
#define MC_MoveJogN_In_Axis 14262
#define MC_MoveJogN_In_MinPosition 14295
#define MC_MoveJogN_In_AccTime 14328
#define MC_MoveJogN_In_Velocity 14361
#define MC_MoveAbs_In_Axis 14394
#define MC_MoveAbs_In_MaxPosition 14427
#define MC_MoveAbs_In_MinPosition 14460
#define MC_MoveAbs_In_Position 14493
#define MC_MoveAbs_In_AccTime 14526
#define MC_MoveAbs_In_Velocity 14559
#define MC_MoveAbs_Ot_DesMovePosition 14592
#define MC_MoveAbs_Ot_MovePosition 14625
#define MC_MoveInc_In_Axis 14658
#define MC_MoveInc_In_MaxPosition 14691
#define MC_MoveInc_In_MinPosition 14724
#define MC_MoveInc_In_Position 14757
#define MC_MoveInc_In_AccTime 14790
#define MC_MoveInc_In_Velocity 14823
#define MC_MoveInc_Ot_DesMovePosition 14856
#define MC_MoveInc_Ot_MovePosition 14889
#define MC_MoveStop_In_DecTime 14922
#define Mtr_Chk_ExeRdyErr_In_Cmd 14955
#define Mtr_Chk_ExeRdyErr_Ot_Error 14988
#define Mtr_Chk_ExeRdyErr_Ot_ErrorID 15021
#define Mtr_Chk_ExeEndErr_In_Cmd 15054
#define Mtr_Chk_ExeEndErr_Ot_Error 15087
#define Mtr_Chk_ExeEndErr_Ot_ErrorID 15120
#define Mtr_Cmd_StepHomeProg_In_HomeJogVel 15153
#define Mtr_Cmd_StepHomeProg_In_HomeJogTa 15186
#define Mtr_Cmd_StepHomeProg_In_HomeVel 15219
#define Mtr_Cmd_StepHomeProg_In_HomeOffset 15252
#define Mtr_Cmd_StepHomeProg_In_UseLimit 15285
#define Mtr_Cmd_StepHomeProg_In_TimeOutTime 15318
#define Mtr_Chk_AllAmpEna_Ot_Ena 15351
#define Mtr_Chk_AllAmpEna_Ot_Temp 15384
#define Mtr_Chk_AllCompHome_Ot_Comp 15417
#define Mtr_Chk_AllCompHome_Ot_Temp 15450
#define Mtr_Chk_AllMoving_Ot_Moving 15483
#define Mtr_Chk_AllMoving_Ot_Temp 15516
#define Mtr_Chk_AllErr_Ot_Err 15549
#define Mtr_Chk_AllErr_Ot_Temp 15582
#define MTR_Err_LimitErr_Ot_State 15615
#define Mtr_Set_GateSetup_In_Word_SetGate 15648
#define Mtr_Set_GateSetup_In_GateNum 15681
#define Mtr_Set_GateSetup_In_ChanNum 15714
#define Mtr_Set_MtWord_Setup_In_AbortAcc 15747
#define Mtr_Set_MtWord_Setup_In_ProgMaxSpeed 15780
#define Mtr_Set_MtWord_Setup_In_ProgMaxAcc 15813
#define Mtr_Set_HomeWord_Setup_In_CaptCtrl 15846
#define Mtr_Set_HomeWord_Setup_In_CaptFlag 15879
#define AUTO_CHK_MtCmdEnd_Ot_Temp 15912
#define AUTO_CHK_MtCmdEnd_Ot_Comp 15945
#define AUTO_CHK_MtCmdEnd_Ot_Error 15978
#define AUTO_CHK_CmdEnd_Ot_Temp 16011
#define AUTO_CHK_CmdEnd_Ot_Comp 16044
#define AUTO_CHK_CmdEnd_Ot_Error 16077
#define AUTO_CHK_HostTimeBaseDone_Ot_Temp 16110
#define AUTO_CHK_HostTimeBaseDone_Ot_Comp 16143
#define Mach_SetSubProgUpdateTime 16176
#define Mach_SetSubProgWaitCycle 16177
#define LinearX_Mtr_HomeOffset 1104
#define LStageY_Mtr_HomeOffset 1204
#define RStageY_Mtr_HomeOffset 1304
#define ServoZ_Mtr_HomeOffset 1504
#endif
#endif
#endif //_PP_PROJ_H_
