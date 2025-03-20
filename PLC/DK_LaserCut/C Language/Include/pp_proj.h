
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
#define	Temp_IO_Out(i)	pshm->P[(8192+i)%MAX_P]
#define	Temp_IOIn(i)	pshm->P[(8242+i)%MAX_P]
#define	Temp_In_Main_PowerOn	pshm->P[8292]
#define	Temp_In_EMO01_Btn	pshm->P[8293]
#define	Temp_In_EMO02_Btn	pshm->P[8294]
#define	Temp_In_EMO03_Btn	pshm->P[8295]
#define	Temp_In_LeftUnit_Start_Btn	pshm->P[8296]
#define	Temp_In_LeftUnit_Vac_Btn	pshm->P[8297]
#define	Temp_In_LeftUnit_Stop_Btn	pshm->P[8298]
#define	Temp_In_LeftUnit_ReSet_Btn	pshm->P[8299]
#define	Temp_In_LeftUnit_Pressure_Sen	pshm->P[8300]
#define	Temp_In_LeftUnit_Vac_Sen	pshm->P[8301]
#define	Temp_In_RightUnit_Start_Btn	pshm->P[8302]
#define	Temp_In_RightUnit_Vac_Btn	pshm->P[8303]
#define	Temp_In_RightUnit_Stop_Btn	pshm->P[8304]
#define	Temp_In_RightUnit_ReSet_Btn	pshm->P[8305]
#define	Temp_In_RightUnit_Pressure_Sen	pshm->P[8306]
#define	Temp_In_RightUnit_Vac_Sen	pshm->P[8307]
#define	Temp_In_Stage_PowerOn	pshm->P[8308]
#define	Temp_In_Leak_Sen	pshm->P[8309]
#define	Temp_In_Door01_Sen	pshm->P[8310]
#define	Temp_In_Door02_Sen	pshm->P[8311]
#define	Temp_In_Door03_Sen	pshm->P[8312]
#define	Temp_In_Door04_Sen	pshm->P[8313]
#define	Temp_In_Door05_Sen	pshm->P[8314]
#define	Temp_In_Spare_UX024	pshm->P[8315]
#define	Temp_In_LeftUnit_Ionizer	pshm->P[8316]
#define	Temp_In_RightUnit_Ionizer	pshm->P[8317]
#define	Temp_In_BeamShutter_Close	pshm->P[8318]
#define	Temp_In_BeamShutter_Open	pshm->P[8319]
#define	Temp_In_PowerMeter_Open	pshm->P[8320]
#define	Temp_In_PowerMeter_Close	pshm->P[8321]
#define	Temp_In_LeftUnit_Area_Sen	pshm->P[8322]
#define	Temp_In_RightUnit_Area_Sen	pshm->P[8323]
#define	Temp_In_Spare_UX033	pshm->P[8324]
#define	Temp_In_Spare_UX034	pshm->P[8325]
#define	Temp_In_Spare_UX035	pshm->P[8326]
#define	Temp_In_Spare_UX036	pshm->P[8327]
#define	Temp_In_Spare_UX037	pshm->P[8328]
#define	Temp_In_Spare_UX038	pshm->P[8329]
#define	Temp_In_Spare_UX039	pshm->P[8330]
#define	Temp_In_Spare_UX040	pshm->P[8331]
#define	Temp_In_Spare_UX041	pshm->P[8332]
#define	Temp_In_Spare_UX042	pshm->P[8333]
#define	Temp_In_Spare_UX043	pshm->P[8334]
#define	Temp_In_Spare_UX044	pshm->P[8335]
#define	Temp_In_Spare_UX045	pshm->P[8336]
#define	Temp_In_Spare_UX046	pshm->P[8337]
#define	Temp_In_Spare_UX047	pshm->P[8338]
#define	Temp_In_Spare_UX048	pshm->P[8339]
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
#define	Temp_Mach_AllHomeExe	pshm->P[8340]
#define	Temp_Mach_MtrAllServoOn	pshm->P[8341]
#define	Temp_Mach_MtrAllServoOff	pshm->P[8342]
#define	Temp_Mach_PowerMeterChk	pshm->P[8343]
#define	Temp_Mach_ReadyExe	pshm->P[8344]
#define	Temp_Mach_MainDoorUnUse	pshm->P[8345]
#define	Temp_Mach_AreaSenUnUse	pshm->P[8346]
#define	Temp_Mach_SideDoorUnUse	pshm->P[8347]
#define	Temp_Mach_LED_Light_On	pshm->P[8348]
#define	Temp_Mach_BuzzerStopExe	pshm->P[8349]
#define	Temp_Mach_BuzzerUnUse	pshm->P[8350]
#define	Temp_Mach_UnitStartDelayTime	pshm->P[8351]
#define	Temp_Mach_ReserveUnUse	pshm->P[8352]
#define	Temp_Mach_AutoCompVentUnUse	pshm->P[8353]
#define	Temp_Mach_VacErrCheckUnUse	pshm->P[8354]
#define	Temp_Mach_AreaSenVentUnUse	pshm->P[8355]
#define	U2P_Mach_BitData01	pshm->P[5154]
#define	U2P_Mach_BitData02	pshm->P[5155]
#define	U2P_Mach_Status	pshm->P[5100]
#define	U2P_Mach_AllHomming	pshm->P[5101]
#define	U2P_Mach_AllHomeComp	pshm->P[5102]
#define	U2P_Mach_PowerMoterChkComp	pshm->P[5104]
#define	U2P_Mach_ReadyPosComp	pshm->P[5105]
#define	MotionEnd	pshm->P[8000]
#define	Temp_Mach_Status	pshm->P[8356]
#define	Temp_Mach_AllHomming	pshm->P[8357]
#define	Temp_Mach_AllHomeComp	pshm->P[8358]
#define	Temp_Mach_MotionTimeOut	pshm->P[8359]
#define	U2P_Lstage_BitData01	pshm->P[6154]
#define	U2P_Lstage_BitData02	pshm->P[6155]
#define	P2U_Lstage_ReadySt	pshm->P[6000]
#define	P2U_Lstage_AutoStart	pshm->P[6001]
#define	P2U_Lstage_MotionDownroadComp	pshm->P[6002]
#define	P2U_Lstage_Glessthickness	pshm->P[6004]
#define	Temp_Lstage_ReadySt	pshm->P[8360]
#define	Temp_Lstage_AutoStart	pshm->P[8361]
#define	Temp_Lstage_MotionDownroadComp	pshm->P[8362]
#define	Temp_Lstage_Glessthickness	pshm->P[8363]
#define	P2U_Lstage_ViAilgnUnUse	pshm->P[6009]
#define	P2U_Lstage_ViAilgnCts	pshm->P[6010]
#define	P2U_Lstage_ViAilgn01TrigComp	pshm->P[6011]
#define	P2U_Lstage_ViAilgn02TrigComp	pshm->P[6012]
#define	P2U_Lstage_ViAilgn03TrigComp	pshm->P[6013]
#define	P2U_Lstage_ViAilgn04TrigComp	pshm->P[6014]
#define	Temp_Lstage_ViAilgnUnUse	pshm->P[8364]
#define	Temp_Lstage_ViAilgnCts	pshm->P[8365]
#define	Temp_Lstage_ViAilgn01TrigComp	pshm->P[8366]
#define	Temp_Lstage_ViAilgn02TrigComp	pshm->P[8367]
#define	Temp_Lstage_ViAilgn03TrigComp	pshm->P[8368]
#define	Temp_Lstage_ViAilgn04TrigComp	pshm->P[8369]
#define	P2U_Lstage_VacUseCts	pshm->P[6016]
#define	Temp_Lstage_VacUseCts	pshm->P[8370]
#define	P2U_Lstage_Vac01Time	pshm->P[6018]
#define	P2U_Lstage_Vac02Time	pshm->P[6019]
#define	P2U_Lstage_Vac03Time	pshm->P[6020]
#define	P2U_Lstage_Vac04Time	pshm->P[6021]
#define	Temp_Lstage_Vac01Time	pshm->P[8371]
#define	Temp_Lstage_Vac02Time	pshm->P[8372]
#define	Temp_Lstage_Vac03Time	pshm->P[8373]
#define	Temp_Lstage_Vac04Time	pshm->P[8374]
#define	P2U_Lstage_AilgnMvStart	pshm->P[6023]
#define	P2U_Lstage_WorkPosMvStart	pshm->P[6024]
#define	P2U_Lstage_LoadingPosMvStart	pshm->P[6025]
#define	P2U_Lstage_VacStart	pshm->P[6026]
#define	P2U_Lstage_ReadyMvStart	pshm->P[6028]
#define	Temp_Lstage_AilgnMvStart	pshm->P[8375]
#define	Temp_Lstage_WorkPosMvStart	pshm->P[8376]
#define	Temp_Lstage_LoadingPosMvStart	pshm->P[8377]
#define	Temp_Lstage_ReadyMvStart	pshm->P[8378]
#define	U2P_Lstage_VacReadySt	pshm->P[6100]
#define	U2P_Lstage_AutoReadySt	pshm->P[6101]
#define	U2P_Lstage_MotionDownroadExe	pshm->P[6102]
#define	U2P_Lstage_Motioning	pshm->P[6103]
#define	U2P_Lstage_MotionComp	pshm->P[6104]
#define	U2P_Lstage_AutoRunComp	pshm->P[6105]
#define	Temp_Lstage_VacReadySt	pshm->P[8379]
#define	Temp_Lstage_AutoReadySt	pshm->P[8380]
#define	Temp_Lstage_MotionDownroadExe	pshm->P[8381]
#define	Temp_Lstage_Motioning	pshm->P[8382]
#define	Temp_Lstage_MotionComp	pshm->P[8383]
#define	Temp_Lstage_AutoRunComp	pshm->P[8384]
#define	U2P_Lstage_ViAilgnSeqComp	pshm->P[6109]
#define	U2P_Lstage_ViAilgn01TrigExe	pshm->P[6110]
#define	U2P_Lstage_ViAilgn02TrigExe	pshm->P[6111]
#define	U2P_Lstage_ViAilgn03TrigExe	pshm->P[6112]
#define	U2P_Lstage_ViAilgn04TrigExe	pshm->P[6113]
#define	Temp_Lstage_ViAilgnSeqComp	pshm->P[8385]
#define	Temp_Lstage_ViAilgn01TrigExe	pshm->P[8386]
#define	Temp_Lstage_ViAilgn02TrigExe	pshm->P[8387]
#define	Temp_Lstage_ViAilgn03TrigExe	pshm->P[8388]
#define	Temp_Lstage_ViAilgn04TrigExe	pshm->P[8389]
#define	U2P_Lstage_MachStatus	pshm->P[6116]
#define	U2P_Lstage_AilgnMvComp	pshm->P[6123]
#define	U2P_Lstage_WorkPosMvComp	pshm->P[6124]
#define	U2P_Lstage_LoadingPosMvComp	pshm->P[6125]
#define	U2P_Lstage_ReadyMvComp	pshm->P[6128]
#define	Temp_Lstage_MachStatus	pshm->P[8390]
#define	P2U_Rstage_ReadySt	pshm->P[7000]
#define	P2U_Rstage_AutoStart	pshm->P[7001]
#define	P2U_Rstage_MotionDownroadComp	pshm->P[7002]
#define	P2U_Rstage_Glessthickness	pshm->P[7004]
#define	Temp_Rstage_ReadySt	pshm->P[8391]
#define	Temp_Rstage_AutoStart	pshm->P[8392]
#define	Temp_Rstage_MotionDownroadComp	pshm->P[8393]
#define	Temp_Rstage_Glessthickness	pshm->P[8394]
#define	P2U_Rstage_ViAilgnUnUse	pshm->P[7009]
#define	P2U_Rstage_ViAilgnCts	pshm->P[7010]
#define	P2U_Rstage_ViAilgn01TrigComp	pshm->P[7011]
#define	P2U_Rstage_ViAilgn02TrigComp	pshm->P[7012]
#define	P2U_Rstage_ViAilgn03TrigComp	pshm->P[7013]
#define	P2U_Rstage_ViAilgn04TrigComp	pshm->P[7014]
#define	Temp_Rstage_ViAilgnUnUse	pshm->P[8395]
#define	Temp_Rstage_ViAilgnCts	pshm->P[8396]
#define	Temp_Rstage_ViAilgn01TrigComp	pshm->P[8397]
#define	Temp_Rstage_ViAilgn02TrigComp	pshm->P[8398]
#define	Temp_Rstage_ViAilgn03TrigComp	pshm->P[8399]
#define	Temp_Rstage_ViAilgn04TrigComp	pshm->P[8400]
#define	P2U_Rstage_VacUseCts	pshm->P[7016]
#define	Temp_Rstage_VacUseCts	pshm->P[8401]
#define	P2U_Rstage_Vac01Time	pshm->P[7018]
#define	P2U_Rstage_Vac02Time	pshm->P[7019]
#define	P2U_Rstage_Vac03Time	pshm->P[7020]
#define	P2U_Rstage_Vac04Time	pshm->P[7021]
#define	Temp_Rstage_Vac01Time	pshm->P[8402]
#define	Temp_Rstage_Vac02Time	pshm->P[8403]
#define	Temp_Rstage_Vac03Time	pshm->P[8404]
#define	Temp_Rstage_Vac04Time	pshm->P[8405]
#define	P2U_Rstage_AilgnMvStart	pshm->P[7023]
#define	P2U_Rstage_WorkPosMvStart	pshm->P[7024]
#define	P2U_Rstage_LoadingPosMvStart	pshm->P[7025]
#define	P2U_Rstage_VacStart	pshm->P[7026]
#define	P2U_Rstage_ReadyMvStart	pshm->P[7028]
#define	Temp_Rstage_AilgnMvStart	pshm->P[8406]
#define	Temp_Rstage_WorkPosMvStart	pshm->P[8407]
#define	Temp_Rstage_LoadingPosMvStart	pshm->P[8408]
#define	Temp_Rstage_ReadyMvStart	pshm->P[8409]
#define	U2P_Rstage_BitData01	pshm->P[7154]
#define	U2P_Rstage_BitData02	pshm->P[7155]
#define	U2P_Rstage_VacReadySt	pshm->P[7100]
#define	U2P_Rstage_AutoReadySt	pshm->P[7101]
#define	U2P_Rstage_MotionDownroadExe	pshm->P[7102]
#define	U2P_Rstage_Motioning	pshm->P[7103]
#define	U2P_Rstage_MotionComp	pshm->P[7104]
#define	U2P_Rstage_AutoRunComp	pshm->P[7105]
#define	Temp_Rstage_VacReadySt	pshm->P[8410]
#define	Temp_Rstage_AutoReadySt	pshm->P[8411]
#define	Temp_Rstage_MotionDownroadExe	pshm->P[8412]
#define	Temp_Rstage_Motioning	pshm->P[8413]
#define	Temp_Rstage_MotionComp	pshm->P[8414]
#define	Temp_Rstage_AutoRunComp	pshm->P[8415]
#define	U2P_Rstage_ViAilgnSeqComp	pshm->P[7109]
#define	U2P_Rstage_ViAilgn01TrigExe	pshm->P[7110]
#define	U2P_Rstage_ViAilgn02TrigExe	pshm->P[7111]
#define	U2P_Rstage_ViAilgn03TrigExe	pshm->P[7112]
#define	U2P_Rstage_ViAilgn04TrigExe	pshm->P[7113]
#define	Temp_Rstage_ViAilgnSeqComp	pshm->P[8416]
#define	Temp_Rstage_ViAilgn01TrigExe	pshm->P[8417]
#define	Temp_Rstage_ViAilgn02TrigExe	pshm->P[8418]
#define	Temp_Rstage_ViAilgn03TrigExe	pshm->P[8419]
#define	Temp_Rstage_ViAilgn04TrigExe	pshm->P[8420]
#define	U2P_Rstage_MachStatus	pshm->P[7116]
#define	U2P_Rstage_AilgnMvComp	pshm->P[7123]
#define	U2P_Rstage_WorkPosMvComp	pshm->P[7124]
#define	U2P_Rstage_LoadingPosMvComp	pshm->P[7125]
#define	U2P_Rstage_ReadyMvComp	pshm->P[7128]
#define	Temp_Rstage_MachStatus	pshm->P[8421]
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
#define	Temp_LinearX_SetMtReadyPos	pshm->P[8422]
#define	Temp_LinearX_SetMtLWorkStartPos	pshm->P[8423]
#define	Temp_LinearX_SetMtRWorkStartPos	pshm->P[8424]
#define	Temp_LinearX_SetMtLLoadingPos	pshm->P[8425]
#define	Temp_LinearX_SetMtRLoadingPos	pshm->P[8426]
#define	Temp_LinearX_SetMtLViAilgn01Pos	pshm->P[8427]
#define	Temp_LinearX_SetMtLViAilgn02Pos	pshm->P[8428]
#define	Temp_LinearX_SetMtLViAilgn03Pos	pshm->P[8429]
#define	Temp_LinearX_SetMtLViAilgn04Pos	pshm->P[8430]
#define	Temp_LinearX_SetMtRViAilgn01Pos	pshm->P[8431]
#define	Temp_LinearX_SetMtRViAilgn02Pos	pshm->P[8432]
#define	Temp_LinearX_SetMtRViAilgn03Pos	pshm->P[8433]
#define	Temp_LinearX_SetMtRViAilgn04Pos	pshm->P[8434]
#define	Temp_LinearX_SetMtPowerMeterPos	pshm->P[8435]
#define	Temp_LinearX_SetMtSpare10Pos	pshm->P[8436]
#define	Temp_LinearX_SetMtPosMvSpd	pshm->P[8437]
#define	Temp_LinearX_SetMtPosMvTA	pshm->P[8438]
#define	Temp_LinearX_SetReadyPosMvSpd	pshm->P[8439]
#define	Temp_LinearX_SetReadyPosMvTA	pshm->P[8440]
#define	Temp_LinearX_SetMtWorkStartPosMvSpd	pshm->P[8441]
#define	Temp_LinearX_SetMtWorkStartPosMvTA	pshm->P[8442]
#define	Temp_LinearX_SetAlignPosMvSpd	pshm->P[8443]
#define	Temp_LinearX_SetAlignPosMvTA	pshm->P[8444]
#define	Temp_LinearX_SetLoadingPosMvSpd	pshm->P[8445]
#define	Temp_LinearX_SetLoadingPosMvTA	pshm->P[8446]
#define	Temp_LinearX_SetPowerMeterPosMvSpd	pshm->P[8447]
#define	Temp_LinearX_SetPowerMeterPosMvTA	pshm->P[8448]
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
#define	Temp_LStageY_SetMtReadyPos	pshm->P[8449]
#define	Temp_LStageY_SetMtWorkStartPos	pshm->P[8450]
#define	Temp_LStageY_SetMtSpare03Pos	pshm->P[8451]
#define	Temp_LStageY_SetMtLoadingPos	pshm->P[8452]
#define	Temp_LStageY_SetMtSpare04Pos	pshm->P[8453]
#define	Temp_LStageY_SetMtViAilgn01Pos	pshm->P[8454]
#define	Temp_LStageY_SetMtViAilgn02Pos	pshm->P[8455]
#define	Temp_LStageY_SetMtViAilgn03Pos	pshm->P[8456]
#define	Temp_LStageY_SetMtViAilgn04Pos	pshm->P[8457]
#define	Temp_LStageY_SetMtSpare05Pos	pshm->P[8458]
#define	Temp_LStageY_SetMtSpare06Pos	pshm->P[8459]
#define	Temp_LStageY_SetMtSpare07Pos	pshm->P[8460]
#define	Temp_LStageY_SetMtSpare08Pos	pshm->P[8461]
#define	Temp_LStageY_SetMtSpare09Pos	pshm->P[8462]
#define	Temp_LStageY_SetMtSafePos	pshm->P[8463]
#define	Temp_LStageY_SetMtPosMvSpd	pshm->P[8464]
#define	Temp_LStageY_SetMtPosMvTA	pshm->P[8465]
#define	Temp_LStageY_SetReadyPosMvSpd	pshm->P[8466]
#define	Temp_LStageY_SetReadyPosMvTA	pshm->P[8467]
#define	Temp_LStageY_SetMtWorkStartPosMvSpd	pshm->P[8468]
#define	Temp_LStageY_SetMtWorkStartPosMvTA	pshm->P[8469]
#define	Temp_LStageY_SetAlignPosMvSpd	pshm->P[8470]
#define	Temp_LStageY_SetAlignPosMvTA	pshm->P[8471]
#define	Temp_LStageY_SetLoadingPosMvSpd	pshm->P[8472]
#define	Temp_LStageY_SetLoadingPosMvTA	pshm->P[8473]
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
#define	Temp_RStageY_SetMtReadyPos	pshm->P[8474]
#define	Temp_RStageY_SetMtWorkStartPos	pshm->P[8475]
#define	Temp_RStageY_SetMtSpare03Pos	pshm->P[8476]
#define	Temp_RStageY_SetMtLoadingPos	pshm->P[8477]
#define	Temp_RStageY_SetMtSpare04Pos	pshm->P[8478]
#define	Temp_RStageY_SetMtViAilgn01Pos	pshm->P[8479]
#define	Temp_RStageY_SetMtViAilgn02Pos	pshm->P[8480]
#define	Temp_RStageY_SetMtViAilgn03Pos	pshm->P[8481]
#define	Temp_RStageY_SetMtViAilgn04Pos	pshm->P[8482]
#define	Temp_RStageY_SetMtSpare05Pos	pshm->P[8483]
#define	Temp_RStageY_SetMtSpare06Pos	pshm->P[8484]
#define	Temp_RStageY_SetMtSpare07Pos	pshm->P[8485]
#define	Temp_RStageY_SetMtSpare08Pos	pshm->P[8486]
#define	Temp_RStageY_SetMtSpare09Pos	pshm->P[8487]
#define	Temp_RStageY_SetMtSafePos	pshm->P[8488]
#define	Temp_RStageY_SetMtPosMvSpd	pshm->P[8489]
#define	Temp_RStageY_SetMtPosMvTA	pshm->P[8490]
#define	Temp_RStageY_SetReadyPosMvSpd	pshm->P[8491]
#define	Temp_RStageY_SetReadyPosMvTA	pshm->P[8492]
#define	Temp_RStageY_SetMtWorkStartPosMvSpd	pshm->P[8493]
#define	Temp_RStageY_SetMtWorkStartPosMvTA	pshm->P[8494]
#define	Temp_RStageY_SetAlignPosMvSpd	pshm->P[8495]
#define	Temp_RStageY_SetAlignPosMvTA	pshm->P[8496]
#define	Temp_RStageY_SetLoadingPosMvSpd	pshm->P[8497]
#define	Temp_RStageY_SetLoadingPosMvTA	pshm->P[8498]
#define	ServoZ_SetMtReadyPos	pshm->P[4500]
#define	ServoZ_SetMtWorkStartPos	pshm->P[4501]
#define	ServoZ_SetMtSpare03Pos	pshm->P[4502]
#define	ServoZ_SetMtLoadingPos	pshm->P[4503]
#define	ServoZ_SetMtSpare04Pos	pshm->P[4504]
#define	ServoZ_SetMtViAilgn01Pos	pshm->P[4505]
#define	ServoZ_SetMtViAilgn02Pos	pshm->P[4506]
#define	ServoZ_SetMtViAilgn03Pos	pshm->P[4507]
#define	ServoZ_SetMtViAilgn04Pos	pshm->P[4508]
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
#define	Temp_ServoZ_SetMtReadyPos	pshm->P[8499]
#define	Temp_ServoZ_SetMtWorkStartPos	pshm->P[8500]
#define	Temp_ServoZ_SetMtSpare03Pos	pshm->P[8501]
#define	Temp_ServoZ_SetMtLoadingPos	pshm->P[8502]
#define	Temp_ServoZ_SetMtSpare04Pos	pshm->P[8503]
#define	Temp_ServoZ_SetMtViAilgn01Pos	pshm->P[8504]
#define	Temp_ServoZ_SetMtViAilgn02Pos	pshm->P[8505]
#define	Temp_ServoZ_SetMtViAilgn03Pos	pshm->P[8506]
#define	Temp_ServoZ_SetMtViAilgn04Pos	pshm->P[8507]
#define	Temp_ServoZ_SetMtSpare05Pos	pshm->P[8508]
#define	Temp_ServoZ_SetMtSpare06Pos	pshm->P[8509]
#define	Temp_ServoZ_SetMtSpare07Pos	pshm->P[8510]
#define	Temp_ServoZ_SetMtSpare08Pos	pshm->P[8511]
#define	Temp_ServoZ_SetMtPowerMeterPos	pshm->P[8512]
#define	Temp_ServoZ_SetMtSpare10Pos	pshm->P[8513]
#define	Temp_ServoZ_SetMtPosMvSpd	pshm->P[8514]
#define	Temp_ServoZ_SetMtPosMvTA	pshm->P[8515]
#define	Temp_ServoZ_SetReadyPosMvSpd	pshm->P[8516]
#define	Temp_ServoZ_SetReadyPosMvTA	pshm->P[8517]
#define	Temp_ServoZ_SetMtWorkStartPosMvSpd	pshm->P[8518]
#define	Temp_ServoZ_SetMtWorkStartPosMvTA	pshm->P[8519]
#define	Temp_ServoZ_SetAlignPosMvSpd	pshm->P[8520]
#define	Temp_ServoZ_SetAlignPosMvTA	pshm->P[8521]
#define	Temp_ServoZ_SetLoadingPosMvSpd	pshm->P[8522]
#define	Temp_ServoZ_SetLoadingPosMvTA	pshm->P[8523]
#define	Temp_ServoZ_SetPowerMeterPosMvSpd	pshm->P[8524]
#define	Temp_ServoZ_SetPowerMeterPosMvTA	pshm->P[8525]
#define	P2U_LstageY_MvPos	pshm->P[1205]
#define	P2U_RstageY_MvPos	pshm->P[1305]
#define	CalSlewRateForm	pshm->P[8526]
#define	Plc_SetUpdateTime(i)	pshm->P[(8527+i)%MAX_P]
#define	Plc_SetExeCount(i)	pshm->P[(8532+i)%MAX_P]
#define	Plc_SetUpdateCycle(i)	pshm->P[(8537+i)%MAX_P]
#define	Plc_ChkUpdateCount(i)	pshm->P[(8542+i)%MAX_P]
#define	Temp_Plc_ChkUpdateCount(i)	pshm->P[(8547+i)%MAX_P]
#define	Mach_CalPlcCycleTime	pshm->P[8552]
#define	Mach_CalAverPlcCycleTime	pshm->P[8553]
#define	SetChkInposBand	pshm->P[8554]
#define	Mtr_ExeCmd(i)	pshm->P[(8555+i)%MAX_P]
#define	Temp_Mtr_ExeCmd(i)	pshm->P[(8588+i)%MAX_P]
#define	Mtr_CmdLock(i)	pshm->P[(8621+i)%MAX_P]
#define	Mtr_StCompHome(i)	pshm->P[(8654+i)%MAX_P]
#define	Mtr_CmdErrorCode(i)	pshm->P[(8687+i)%MAX_P]
#define	Mtr_SetMachScale(i)	pshm->P[(8720+i)%MAX_P]
#define	Mtr_SetScale(i)	pshm->P[(8753+i)%MAX_P]
#define	Mtr_SetScaleOffset(i)	pshm->P[(8786+i)%MAX_P]
#define	Mtr_CalDivFactVel(i)	pshm->P[(8819+i)%MAX_P]
#define	Mtr_SetSoftLimP(i)	pshm->P[(8852+i)%MAX_P]
#define	Mtr_SetSoftLimN(i)	pshm->P[(8885+i)%MAX_P]
#define	Mtr_SetAbortAcc(i)	pshm->P[(8918+i)%MAX_P]
#define	Mtr_SetMaxAccG(i)	pshm->P[(8951+i)%MAX_P]
#define	Mtr_SetJogTa(i)	pshm->P[(8984+i)%MAX_P]
#define	Mtr_SetJogVel(i)	pshm->P[(9017+i)%MAX_P]
#define	Mtr_ChkJogCmd(i)	pshm->P[(9050+i)%MAX_P]
#define	Mtr_SetMoveTa(i)	pshm->P[(9083+i)%MAX_P]
#define	Mtr_SetMoveSpd(i)	pshm->P[(9116+i)%MAX_P]
#define	Mtr_SetMovePos(i)	pshm->P[(9149+i)%MAX_P]
#define	Mtr_SetPosRdy(i)	pshm->P[(9182+i)%MAX_P]
#define	Mtr_SetHomeTa(i)	pshm->P[(9215+i)%MAX_P]
#define	Mtr_SetHomeJVel(i)	pshm->P[(9248+i)%MAX_P]
#define	Mtr_SetHomeSVel(i)	pshm->P[(9281+i)%MAX_P]
#define	Mtr_SetHomeOffsetPos(i)	pshm->P[(9314+i)%MAX_P]
#define	Mtr_SetHomeOverTime(i)	pshm->P[(9347+i)%MAX_P]
#define	Mtr_SetMaxPos(i)	pshm->P[(9380+i)%MAX_P]
#define	Mtr_SetMinPos(i)	pshm->P[(9413+i)%MAX_P]
#define	Mtr_GetActPos(i)	pshm->P[(9446+i)%MAX_P]
#define	Mtr_GetDesPos(i)	pshm->P[(9479+i)%MAX_P]
#define	Temp_Mtr_GetActPos(i)	pshm->P[(9512+i)%MAX_P]
#define	Mtr_SavOffsetPos(i)	pshm->P[(9545+i)%MAX_P]
#define	Mtr_GetActSpd(i)	pshm->P[(9578+i)%MAX_P]
#define	Mtr_GetDesSpd(i)	pshm->P[(9611+i)%MAX_P]
#define	Mtr_StIngMove(i)	pshm->P[(9644+i)%MAX_P]
#define	Mtr_StIngHome(i)	pshm->P[(9677+i)%MAX_P]
#define	Mtr_StPosHome(i)	pshm->P[(9710+i)%MAX_P]
#define	Mtr_CalDacOut(i)	pshm->P[(9743+i)%MAX_P]
#define	Mtr_SetStopTd(i)	pshm->P[(9776+i)%MAX_P]
#define	Mtr_SetMotor_Type(i)	pshm->P[(9809+i)%MAX_P]
#define	Mtr_SetUSE_LIMIT_ERR(i)	pshm->P[(9842+i)%MAX_P]
#define	Mtr_SetMotorEcat(i)	pshm->P[(9875+i)%MAX_P]
#define	Mtr_ChkAmpEnable(i)	pshm->P[(9908+i)%MAX_P]
#define	Mtr_ChkMotorUnuse(i)	pshm->P[(9941+i)%MAX_P]
#define	Mach_StError	pshm->P[9974]
#define	Temp_Cts_Mach_StError	pshm->P[9975]
#define	Temp_Chk_Mach_StError(i)	pshm->P[(9976+i)%MAX_P]
#define	Mach_Bit_0200_MsecToggle	pshm->P[10026]
#define	Mach_Bit_0500_MsecToggle	pshm->P[10027]
#define	Mach_Bit_1000_MsecToggle	pshm->P[10028]
#define	Mach_CmdTime	pshm->P[10029]
#define	Mach_WaitCycle	pshm->P[10030]
#define	Mach_Cmd	pshm->P[10031]
#define	Mach_CmdLock	pshm->P[10032]
#define	Temp_Mach_ChkErr	pshm->P[10033]
#define	Temp_Mach_Cmd	pshm->P[10034]
#define	Mach_CmdErrCode	pshm->P[10035]
#define	Mach_StIngMove	pshm->P[10036]
#define	Mach_StAmpEnable	pshm->P[10037]
#define	Mach_StAmpDisable	pshm->P[10038]
#define	Mach_StCompHome	pshm->P[10039]
#define	Mtr_ExeCmdStep(i)	pshm->P[(10040+i)%MAX_P]
#define	Mtr_ChkCmdStepReady(i)	pshm->P[(10073+i)%MAX_P]
#define	Mtr_BitCmdStepNotReady(i)	pshm->P[(10106+i)%MAX_P]
#define	Mtr_GetCmdError(i)	pshm->P[(10139+i)%MAX_P]
#define	Mtr_StAutoRdy(i)	pshm->P[(10172+i)%MAX_P]
#define	Mtr_StServoRdy(i)	pshm->P[(10205+i)%MAX_P]
#define	Mtr_CompExeProgRun(i)	pshm->P[(10238+i)%MAX_P]
#define	Mtr_CompProgRun(i)	pshm->P[(10271+i)%MAX_P]
#define	Mtr_CompExtraWindProgRun	pshm->P[10304]
#define	Mach_SetMoveRdyTa	pshm->P[10305]
#define	Mach_SetMoveRdySpd	pshm->P[10306]
#define	Mtr_ChkMoveRdyPos(i)	pshm->P[(10307+i)%MAX_P]
#define	Mtr_SetMoveRdyTa(i)	pshm->P[(10340+i)%MAX_P]
#define	Mtr_SetMoveRdySpd(i)	pshm->P[(10373+i)%MAX_P]
#define	Mtr_SetMoveRdyPos(i)	pshm->P[(10406+i)%MAX_P]
#define	Mtr_SetMoveTargetPos(i)	pshm->P[(10439+i)%MAX_P]
#define	Mtr_SetMoveRemainDist(i)	pshm->P[(10472+i)%MAX_P]
#define	Mtr_CompMovePos(i)	pshm->P[(10505+i)%MAX_P]
#define	Mtr_ChkPosSetPos(i)	pshm->P[(10538+i)%MAX_P]
#define	Mtr_ChkPosMoveRdyPos(i)	pshm->P[(10571+i)%MAX_P]
#define	Mtr_SetBasicTa	pshm->P[10604]
#define	Mtr_SetBasicMoveSpd	pshm->P[10605]
#define	Mtr_SetBasicJogMoveSpd	pshm->P[10606]
#define	Mtr_SetBasicHomeSpd	pshm->P[10607]
#define	HomeAllComplete	pshm->P[10608]
#define	LSTAGE_AreaSenPauseCmd	pshm->P[10609]
#define	RSTAGE_AreaSenPauseCmd	pshm->P[10610]
#define	Mtr_SetTouchprobeFunctionValue(i)	pshm->P[(10611+i)%MAX_P]
#define	Mtr_SaftyCheckTargetPos(i)	pshm->P[(10644+i)%MAX_P]
#define	Mach_GetStatus	pshm->P[10677]
#define	Mtr_ExeManualCmd(i)	pshm->P[(10678+i)%MAX_P]
#define	Temp_Mtr_ExeManualCmd(i)	pshm->P[(10711+i)%MAX_P]
#define	Part_StAutoReady(i)	pshm->P[(10744+i)%MAX_P]
#define	Part_BitStNotAutoReady(i)	pshm->P[(10777+i)%MAX_P]
#define	Mach_ExeCmdStep(i)	pshm->P[(10810+i)%MAX_P]
#define	Mach_Chk1CycleCmd(i)	pshm->P[(10880+i)%MAX_P]
#define	Mach_ChkCmdStepReady(i)	pshm->P[(10950+i)%MAX_P]
#define	Mach_CmdErrorCode(i)	pshm->P[(11020+i)%MAX_P]
#define	Mach_CtsChkPartError	pshm->P[11090]
#define	Mach_CtsChkMtrError	pshm->P[11091]
#define	Mach_CtsChkUnitError	pshm->P[11092]
#define	Mach_CtsChkSeqError	pshm->P[11093]
#define	Mach_CtsChkRobotPosError	pshm->P[11094]
#define	Mach_ExeCmdErrorReset	pshm->P[11095]
#define	Mach_ExeCmdReset	pshm->P[11096]
#define	Mach_ExeRcpDataUpdate	pshm->P[11097]
#define	Seq_ExeCmdStep(i)	pshm->P[(11098+i)%MAX_P]
#define	Temp_Seq_ExeCmdStep(i)	pshm->P[(11168+i)%MAX_P]
#define	Test_Seq_ExeCmdStep(i)	pshm->P[(11238+i)%MAX_P]
#define	Part_ExeCmdStep(i)	pshm->P[(11308+i)%MAX_P]
#define	Part_ChkCmdStepReady(i)	pshm->P[(11378+i)%MAX_P]
#define	Part_BitCmdStepNotReady(i)	pshm->P[(11448+i)%MAX_P]
#define	Part_CmdErrorCode(i)	pshm->P[(11518+i)%MAX_P]
#define	Part_StAmpEnable(i)	pshm->P[(11588+i)%MAX_P]
#define	Part_StCompHome(i)	pshm->P[(11658+i)%MAX_P]
#define	Part_StCompServoRdy(i)	pshm->P[(11728+i)%MAX_P]
#define	Part_StCompAutoRdy(i)	pshm->P[(11798+i)%MAX_P]
#define	Temp_Part_StAmpEnable(i)	pshm->P[(11868+i)%MAX_P]
#define	Temp_Part_StCompHome(i)	pshm->P[(11938+i)%MAX_P]
#define	Temp_Part_StCompServoRdy(i)	pshm->P[(12008+i)%MAX_P]
#define	Temp_Part_StCompAutoRdy(i)	pshm->P[(12078+i)%MAX_P]
#define	Unit_ExeCmdStep(i)	pshm->P[(12148+i)%MAX_P]
#define	Temp_Unit_ExeCmdStep(i)	pshm->P[(12218+i)%MAX_P]
#define	Unit_ReqCmd(i)	pshm->P[(12288+i)%MAX_P]
#define	Unit_LockCmd(i)	pshm->P[(12358+i)%MAX_P]
#define	Unit_StErrorStatus(i)	pshm->P[(12428+i)%MAX_P]
#define	Temp_Unit_StErrorStatus(i)	pshm->P[(12498+i)%MAX_P]
#define	Unit_CmdErrorCode(i)	pshm->P[(12568+i)%MAX_P]
#define	Ready_ExeCmdStep(i)	pshm->P[(12638+i)%MAX_P]
#define	Temp_Ready_ExeCmdStep(i)	pshm->P[(12708+i)%MAX_P]
#define	Part_StAutoRdy(i)	pshm->P[(12778+i)%MAX_P]
#define	Part_StMtrServoRdy(i)	pshm->P[(12848+i)%MAX_P]
#define	Part_StErrorStatus(i)	pshm->P[(12918+i)%MAX_P]
#define	Temp_Part_StErrorStatus(i)	pshm->P[(12988+i)%MAX_P]
#define	Part_ExeCmdReadyStep(i)	pshm->P[(13058+i)%MAX_P]
#define	Temp_Part_ExeCmdReadyStep(i)	pshm->P[(13128+i)%MAX_P]
#define	Part_CmdReadyError(i)	pshm->P[(13198+i)%MAX_P]
#define	Temp_CtsStCompHome	pshm->P[13268]
#define	Temp_ChkMotorErr	pshm->P[13269]
#define	Temp_CtsStCompReady	pshm->P[13270]
#define	Temp_ChkReadyMotorErr	pshm->P[13271]
#define	Unit_AutoStartReadySt(i)	pshm->P[(13272+i)%MAX_P]
#define	Mach_MotorAllServoOn	pshm->P[13342]
#define	Mach_MotorAllServoOff	pshm->P[13343]
#define	Exe_ResetLamp_On	pshm->P[13344]
#define	Exe_ResetLamp_FlickOn	pshm->P[13345]
#define	Temp_Exe_ResetLamp_FlickOn	pshm->P[13346]
#define	Exe_LeftStartLamp_On	pshm->P[13347]
#define	Exe_LeftStartLamp_FlickOn	pshm->P[13348]
#define	Temp_Exe_LeftStartLamp_FlickOn	pshm->P[13349]
#define	Exe_RightStartLamp_On	pshm->P[13350]
#define	Exe_RightStartLamp_FlickOn	pshm->P[13351]
#define	Temp_Exe_RightStartLamp_FlickOn	pshm->P[13352]
#define	Temp_SinalTower_Buzzer	pshm->P[13353]
#define	Temp_AreaSenErrStatus	pshm->P[13354]
#define	Temp_MainDoorSenErrStatus	pshm->P[13355]
#define	Temp_SideDooerSenErrStatus	pshm->P[13356]
#define	Temp_LeftPressureSenErrStatus	pshm->P[13357]
#define	Temp_RightPressureSenErrStatus	pshm->P[13358]
#define	Temp_PressureSenErrStatus	pshm->P[13359]
#define	Temp_LeakSenErrStatus	pshm->P[13360]
#define	Temp_LstageSaftyMvErrStatus	pshm->P[13361]
#define	Temp_LstageSaftyValueErrStatus	pshm->P[13362]
#define	Temp_RstageSaftyMvErrStatus	pshm->P[13363]
#define	Temp_RstageSaftyValueErrStatus	pshm->P[13364]
#define	Safety_ErrorCheck	pshm->P[13365]
#define	AutoRun_NotStopErrBit	pshm->P[13366]
#define	Temp_SafetyStopErrNotClearStatus	pshm->P[13367]
#define	Temp_SafetyEMOErrNotClearStatus	pshm->P[13368]
#define	Temp_PressureSenUnUse	pshm->P[13369]
#define	Temp_LeakSenUnUse	pshm->P[13370]
#define	Temp_SaftyPosCheckUnUse	pshm->P[13371]
#define	test_Mode	pshm->P[13372]
#define	Half_test_Mode	pshm->P[13373]
#define	test_ModeDataUndate	pshm->P[13374]
#define	Temp_MaxAccData	pshm->P[13375]
#define	Temp_Lstage_SaftyMvCheck	pshm->P[13376]
#define	Temp_Rstage_SaftyMvCheck	pshm->P[13377]
#define	Temp_Lstage_SaftyValueCheck	pshm->P[13378]
#define	Temp_Rstage_SaftyValueCheck	pshm->P[13379]
#define	Temp_Lstage_AutoRunStatus	pshm->P[13380]
#define	Temp_Rstage_AutoRunStatus	pshm->P[13381]
#define	Temp_Lstage_AutoRdyServoZPos	pshm->P[13382]
#define	Temp_Rstage_AutoRdyServoZPos	pshm->P[13383]
#define	Temp_Mtr_CheckReadyPos(i)	pshm->P[(13384+i)%MAX_P]
#define	Temp_Mtr_CheckLAlign01Pos(i)	pshm->P[(13417+i)%MAX_P]
#define	Temp_Mtr_CheckLAlign02Pos(i)	pshm->P[(13450+i)%MAX_P]
#define	Temp_Mtr_CheckLAlign03Pos(i)	pshm->P[(13483+i)%MAX_P]
#define	Temp_Mtr_CheckLAlign04Pos(i)	pshm->P[(13516+i)%MAX_P]
#define	Temp_Mtr_CheckRAlign01Pos(i)	pshm->P[(13549+i)%MAX_P]
#define	Temp_Mtr_CheckRAlign02Pos(i)	pshm->P[(13582+i)%MAX_P]
#define	Temp_Mtr_CheckRAlign03Pos(i)	pshm->P[(13615+i)%MAX_P]
#define	Temp_Mtr_CheckRAlign04Pos(i)	pshm->P[(13648+i)%MAX_P]
#define	Temp_Mtr_CheckAlign01Pos(i)	pshm->P[(13681+i)%MAX_P]
#define	Temp_Mtr_CheckAlign02Pos(i)	pshm->P[(13714+i)%MAX_P]
#define	Temp_Mtr_CheckAlign03Pos(i)	pshm->P[(13747+i)%MAX_P]
#define	Temp_Mtr_CheckAlign04Pos(i)	pshm->P[(13780+i)%MAX_P]
#define	Temp_Mtr_CheckPowerMeterPos(i)	pshm->P[(13813+i)%MAX_P]
#define	Temp_Mtr_CheckLoadingPos(i)	pshm->P[(13846+i)%MAX_P]
#define	Temp_Mtr_CheckWorkStartPos(i)	pshm->P[(13879+i)%MAX_P]
#define	Temp_Mtr_CheckLLoadingPos(i)	pshm->P[(13912+i)%MAX_P]
#define	Temp_Mtr_CheckRLoadingPos(i)	pshm->P[(13945+i)%MAX_P]
#define	Temp_Mtr_CheckLWorkStartPos(i)	pshm->P[(13978+i)%MAX_P]
#define	Temp_Mtr_CheckRWorkStartPos(i)	pshm->P[(14011+i)%MAX_P]
#define	MotionDownloadTimeOut	pshm->P[14044]
#define	U2P_Mt01_ErrCode	pshm->P[3550]
#define	U2P_Mt02_ErrCode	pshm->P[3551]
#define	U2P_Mt03_ErrCode	pshm->P[3552]
#define	U2P_Mt05_ErrCode	pshm->P[3554]
#define	U2P_AllUnit_ErrCode	pshm->P[3650]
#define	U2P_LStage_ErrCode	pshm->P[3651]
#define	U2P_RStage_ErrCode	pshm->P[3652]
#define	U2P_Mach_ErrCode	pshm->P[3750]
#define	U2P_Part_ErrCode	pshm->P[3751]
#define	MC_MoveJogP_In_Axis(i)	pshm->P[(14045+i)%MAX_P]
#define	MC_MoveJogP_In_MaxPosition(i)	pshm->P[(14078+i)%MAX_P]
#define	MC_MoveJogP_In_AccTime(i)	pshm->P[(14111+i)%MAX_P]
#define	MC_MoveJogP_In_Velocity(i)	pshm->P[(14144+i)%MAX_P]
#define	MC_MoveJogN_In_Axis(i)	pshm->P[(14177+i)%MAX_P]
#define	MC_MoveJogN_In_MinPosition(i)	pshm->P[(14210+i)%MAX_P]
#define	MC_MoveJogN_In_AccTime(i)	pshm->P[(14243+i)%MAX_P]
#define	MC_MoveJogN_In_Velocity(i)	pshm->P[(14276+i)%MAX_P]
#define	MC_MoveAbs_In_Axis(i)	pshm->P[(14309+i)%MAX_P]
#define	MC_MoveAbs_In_MaxPosition(i)	pshm->P[(14342+i)%MAX_P]
#define	MC_MoveAbs_In_MinPosition(i)	pshm->P[(14375+i)%MAX_P]
#define	MC_MoveAbs_In_Position(i)	pshm->P[(14408+i)%MAX_P]
#define	MC_MoveAbs_In_AccTime(i)	pshm->P[(14441+i)%MAX_P]
#define	MC_MoveAbs_In_Velocity(i)	pshm->P[(14474+i)%MAX_P]
#define	MC_MoveAbs_Ot_DesMovePosition(i)	pshm->P[(14507+i)%MAX_P]
#define	MC_MoveAbs_Ot_MovePosition(i)	pshm->P[(14540+i)%MAX_P]
#define	MC_MoveInc_In_Axis(i)	pshm->P[(14573+i)%MAX_P]
#define	MC_MoveInc_In_MaxPosition(i)	pshm->P[(14606+i)%MAX_P]
#define	MC_MoveInc_In_MinPosition(i)	pshm->P[(14639+i)%MAX_P]
#define	MC_MoveInc_In_Position(i)	pshm->P[(14672+i)%MAX_P]
#define	MC_MoveInc_In_AccTime(i)	pshm->P[(14705+i)%MAX_P]
#define	MC_MoveInc_In_Velocity(i)	pshm->P[(14738+i)%MAX_P]
#define	MC_MoveInc_Ot_DesMovePosition(i)	pshm->P[(14771+i)%MAX_P]
#define	MC_MoveInc_Ot_MovePosition(i)	pshm->P[(14804+i)%MAX_P]
#define	MC_MoveStop_In_DecTime(i)	pshm->P[(14837+i)%MAX_P]
#define	Mtr_Chk_ExeRdyErr_In_Cmd(i)	pshm->P[(14870+i)%MAX_P]
#define	Mtr_Chk_ExeRdyErr_Ot_Error(i)	pshm->P[(14903+i)%MAX_P]
#define	Mtr_Chk_ExeRdyErr_Ot_ErrorID(i)	pshm->P[(14936+i)%MAX_P]
#define	Mtr_Chk_ExeEndErr_In_Cmd(i)	pshm->P[(14969+i)%MAX_P]
#define	Mtr_Chk_ExeEndErr_Ot_Error(i)	pshm->P[(15002+i)%MAX_P]
#define	Mtr_Chk_ExeEndErr_Ot_ErrorID(i)	pshm->P[(15035+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_HomeJogVel(i)	pshm->P[(15068+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_HomeJogTa(i)	pshm->P[(15101+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_HomeVel(i)	pshm->P[(15134+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_HomeOffset(i)	pshm->P[(15167+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_UseLimit(i)	pshm->P[(15200+i)%MAX_P]
#define	Mtr_Cmd_StepHomeProg_In_TimeOutTime(i)	pshm->P[(15233+i)%MAX_P]
#define	Mtr_Chk_AllAmpEna_Ot_Ena(i)	pshm->P[(15266+i)%MAX_P]
#define	Mtr_Chk_AllAmpEna_Ot_Temp(i)	pshm->P[(15299+i)%MAX_P]
#define	Mtr_Chk_AllCompHome_Ot_Comp(i)	pshm->P[(15332+i)%MAX_P]
#define	Mtr_Chk_AllCompHome_Ot_Temp(i)	pshm->P[(15365+i)%MAX_P]
#define	Mtr_Chk_AllMoving_Ot_Moving(i)	pshm->P[(15398+i)%MAX_P]
#define	Mtr_Chk_AllMoving_Ot_Temp(i)	pshm->P[(15431+i)%MAX_P]
#define	Mtr_Chk_AllErr_Ot_Err(i)	pshm->P[(15464+i)%MAX_P]
#define	Mtr_Chk_AllErr_Ot_Temp(i)	pshm->P[(15497+i)%MAX_P]
#define	MTR_Err_LimitErr_Ot_State(i)	pshm->P[(15530+i)%MAX_P]
#define	Mtr_Set_GateSetup_In_Word_SetGate(i)	pshm->P[(15563+i)%MAX_P]
#define	Mtr_Set_GateSetup_In_GateNum(i)	pshm->P[(15596+i)%MAX_P]
#define	Mtr_Set_GateSetup_In_ChanNum(i)	pshm->P[(15629+i)%MAX_P]
#define	Mtr_Set_MtWord_Setup_In_AbortAcc(i)	pshm->P[(15662+i)%MAX_P]
#define	Mtr_Set_MtWord_Setup_In_ProgMaxSpeed(i)	pshm->P[(15695+i)%MAX_P]
#define	Mtr_Set_MtWord_Setup_In_ProgMaxAcc(i)	pshm->P[(15728+i)%MAX_P]
#define	Mtr_Set_HomeWord_Setup_In_CaptCtrl(i)	pshm->P[(15761+i)%MAX_P]
#define	Mtr_Set_HomeWord_Setup_In_CaptFlag(i)	pshm->P[(15794+i)%MAX_P]
#define	AUTO_CHK_MtCmdEnd_Ot_Temp(i)	pshm->P[(15827+i)%MAX_P]
#define	AUTO_CHK_MtCmdEnd_Ot_Comp(i)	pshm->P[(15860+i)%MAX_P]
#define	AUTO_CHK_MtCmdEnd_Ot_Error(i)	pshm->P[(15893+i)%MAX_P]
#define	AUTO_CHK_CmdEnd_Ot_Temp(i)	pshm->P[(15926+i)%MAX_P]
#define	AUTO_CHK_CmdEnd_Ot_Comp(i)	pshm->P[(15959+i)%MAX_P]
#define	AUTO_CHK_CmdEnd_Ot_Error(i)	pshm->P[(15992+i)%MAX_P]
#define	AUTO_CHK_HostTimeBaseDone_Ot_Temp(i)	pshm->P[(16025+i)%MAX_P]
#define	AUTO_CHK_HostTimeBaseDone_Ot_Comp(i)	pshm->P[(16058+i)%MAX_P]
#define	Mach_SetSubProgUpdateTime	pshm->P[16091]
#define	Mach_SetSubProgWaitCycle	pshm->P[16092]
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
,Temp_In_Main_PowerOn=8292
,Temp_In_EMO01_Btn=8293
,Temp_In_EMO02_Btn=8294
,Temp_In_EMO03_Btn=8295
,Temp_In_LeftUnit_Start_Btn=8296
,Temp_In_LeftUnit_Vac_Btn=8297
,Temp_In_LeftUnit_Stop_Btn=8298
,Temp_In_LeftUnit_ReSet_Btn=8299
,Temp_In_LeftUnit_Pressure_Sen=8300
,Temp_In_LeftUnit_Vac_Sen=8301
,Temp_In_RightUnit_Start_Btn=8302
,Temp_In_RightUnit_Vac_Btn=8303
,Temp_In_RightUnit_Stop_Btn=8304
,Temp_In_RightUnit_ReSet_Btn=8305
,Temp_In_RightUnit_Pressure_Sen=8306
,Temp_In_RightUnit_Vac_Sen=8307
,Temp_In_Stage_PowerOn=8308
,Temp_In_Leak_Sen=8309
,Temp_In_Door01_Sen=8310
,Temp_In_Door02_Sen=8311
,Temp_In_Door03_Sen=8312
,Temp_In_Door04_Sen=8313
,Temp_In_Door05_Sen=8314
,Temp_In_Spare_UX024=8315
,Temp_In_LeftUnit_Ionizer=8316
,Temp_In_RightUnit_Ionizer=8317
,Temp_In_BeamShutter_Close=8318
,Temp_In_BeamShutter_Open=8319
,Temp_In_PowerMeter_Open=8320
,Temp_In_PowerMeter_Close=8321
,Temp_In_LeftUnit_Area_Sen=8322
,Temp_In_RightUnit_Area_Sen=8323
,Temp_In_Spare_UX033=8324
,Temp_In_Spare_UX034=8325
,Temp_In_Spare_UX035=8326
,Temp_In_Spare_UX036=8327
,Temp_In_Spare_UX037=8328
,Temp_In_Spare_UX038=8329
,Temp_In_Spare_UX039=8330
,Temp_In_Spare_UX040=8331
,Temp_In_Spare_UX041=8332
,Temp_In_Spare_UX042=8333
,Temp_In_Spare_UX043=8334
,Temp_In_Spare_UX044=8335
,Temp_In_Spare_UX045=8336
,Temp_In_Spare_UX046=8337
,Temp_In_Spare_UX047=8338
,Temp_In_Spare_UX048=8339
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
,Temp_Mach_AllHomeExe=8340
,Temp_Mach_MtrAllServoOn=8341
,Temp_Mach_MtrAllServoOff=8342
,Temp_Mach_PowerMeterChk=8343
,Temp_Mach_ReadyExe=8344
,Temp_Mach_MainDoorUnUse=8345
,Temp_Mach_AreaSenUnUse=8346
,Temp_Mach_SideDoorUnUse=8347
,Temp_Mach_LED_Light_On=8348
,Temp_Mach_BuzzerStopExe=8349
,Temp_Mach_BuzzerUnUse=8350
,Temp_Mach_UnitStartDelayTime=8351
,Temp_Mach_ReserveUnUse=8352
,Temp_Mach_AutoCompVentUnUse=8353
,Temp_Mach_VacErrCheckUnUse=8354
,Temp_Mach_AreaSenVentUnUse=8355
,U2P_Mach_BitData01=5154
,U2P_Mach_BitData02=5155
,U2P_Mach_Status=5100
,U2P_Mach_AllHomming=5101
,U2P_Mach_AllHomeComp=5102
,U2P_Mach_PowerMoterChkComp=5104
,U2P_Mach_ReadyPosComp=5105
,MotionEnd=8000
,Temp_Mach_Status=8356
,Temp_Mach_AllHomming=8357
,Temp_Mach_AllHomeComp=8358
,Temp_Mach_MotionTimeOut=8359
,U2P_Lstage_BitData01=6154
,U2P_Lstage_BitData02=6155
,P2U_Lstage_ReadySt=6000
,P2U_Lstage_AutoStart=6001
,P2U_Lstage_MotionDownroadComp=6002
,P2U_Lstage_Glessthickness=6004
,Temp_Lstage_ReadySt=8360
,Temp_Lstage_AutoStart=8361
,Temp_Lstage_MotionDownroadComp=8362
,Temp_Lstage_Glessthickness=8363
,P2U_Lstage_ViAilgnUnUse=6009
,P2U_Lstage_ViAilgnCts=6010
,P2U_Lstage_ViAilgn01TrigComp=6011
,P2U_Lstage_ViAilgn02TrigComp=6012
,P2U_Lstage_ViAilgn03TrigComp=6013
,P2U_Lstage_ViAilgn04TrigComp=6014
,Temp_Lstage_ViAilgnUnUse=8364
,Temp_Lstage_ViAilgnCts=8365
,Temp_Lstage_ViAilgn01TrigComp=8366
,Temp_Lstage_ViAilgn02TrigComp=8367
,Temp_Lstage_ViAilgn03TrigComp=8368
,Temp_Lstage_ViAilgn04TrigComp=8369
,P2U_Lstage_VacUseCts=6016
,Temp_Lstage_VacUseCts=8370
,P2U_Lstage_Vac01Time=6018
,P2U_Lstage_Vac02Time=6019
,P2U_Lstage_Vac03Time=6020
,P2U_Lstage_Vac04Time=6021
,Temp_Lstage_Vac01Time=8371
,Temp_Lstage_Vac02Time=8372
,Temp_Lstage_Vac03Time=8373
,Temp_Lstage_Vac04Time=8374
,P2U_Lstage_AilgnMvStart=6023
,P2U_Lstage_WorkPosMvStart=6024
,P2U_Lstage_LoadingPosMvStart=6025
,P2U_Lstage_VacStart=6026
,P2U_Lstage_ReadyMvStart=6028
,Temp_Lstage_AilgnMvStart=8375
,Temp_Lstage_WorkPosMvStart=8376
,Temp_Lstage_LoadingPosMvStart=8377
,Temp_Lstage_ReadyMvStart=8378
,U2P_Lstage_VacReadySt=6100
,U2P_Lstage_AutoReadySt=6101
,U2P_Lstage_MotionDownroadExe=6102
,U2P_Lstage_Motioning=6103
,U2P_Lstage_MotionComp=6104
,U2P_Lstage_AutoRunComp=6105
,Temp_Lstage_VacReadySt=8379
,Temp_Lstage_AutoReadySt=8380
,Temp_Lstage_MotionDownroadExe=8381
,Temp_Lstage_Motioning=8382
,Temp_Lstage_MotionComp=8383
,Temp_Lstage_AutoRunComp=8384
,U2P_Lstage_ViAilgnSeqComp=6109
,U2P_Lstage_ViAilgn01TrigExe=6110
,U2P_Lstage_ViAilgn02TrigExe=6111
,U2P_Lstage_ViAilgn03TrigExe=6112
,U2P_Lstage_ViAilgn04TrigExe=6113
,Temp_Lstage_ViAilgnSeqComp=8385
,Temp_Lstage_ViAilgn01TrigExe=8386
,Temp_Lstage_ViAilgn02TrigExe=8387
,Temp_Lstage_ViAilgn03TrigExe=8388
,Temp_Lstage_ViAilgn04TrigExe=8389
,U2P_Lstage_MachStatus=6116
,U2P_Lstage_AilgnMvComp=6123
,U2P_Lstage_WorkPosMvComp=6124
,U2P_Lstage_LoadingPosMvComp=6125
,U2P_Lstage_ReadyMvComp=6128
,Temp_Lstage_MachStatus=8390
,P2U_Rstage_ReadySt=7000
,P2U_Rstage_AutoStart=7001
,P2U_Rstage_MotionDownroadComp=7002
,P2U_Rstage_Glessthickness=7004
,Temp_Rstage_ReadySt=8391
,Temp_Rstage_AutoStart=8392
,Temp_Rstage_MotionDownroadComp=8393
,Temp_Rstage_Glessthickness=8394
,P2U_Rstage_ViAilgnUnUse=7009
,P2U_Rstage_ViAilgnCts=7010
,P2U_Rstage_ViAilgn01TrigComp=7011
,P2U_Rstage_ViAilgn02TrigComp=7012
,P2U_Rstage_ViAilgn03TrigComp=7013
,P2U_Rstage_ViAilgn04TrigComp=7014
,Temp_Rstage_ViAilgnUnUse=8395
,Temp_Rstage_ViAilgnCts=8396
,Temp_Rstage_ViAilgn01TrigComp=8397
,Temp_Rstage_ViAilgn02TrigComp=8398
,Temp_Rstage_ViAilgn03TrigComp=8399
,Temp_Rstage_ViAilgn04TrigComp=8400
,P2U_Rstage_VacUseCts=7016
,Temp_Rstage_VacUseCts=8401
,P2U_Rstage_Vac01Time=7018
,P2U_Rstage_Vac02Time=7019
,P2U_Rstage_Vac03Time=7020
,P2U_Rstage_Vac04Time=7021
,Temp_Rstage_Vac01Time=8402
,Temp_Rstage_Vac02Time=8403
,Temp_Rstage_Vac03Time=8404
,Temp_Rstage_Vac04Time=8405
,P2U_Rstage_AilgnMvStart=7023
,P2U_Rstage_WorkPosMvStart=7024
,P2U_Rstage_LoadingPosMvStart=7025
,P2U_Rstage_VacStart=7026
,P2U_Rstage_ReadyMvStart=7028
,Temp_Rstage_AilgnMvStart=8406
,Temp_Rstage_WorkPosMvStart=8407
,Temp_Rstage_LoadingPosMvStart=8408
,Temp_Rstage_ReadyMvStart=8409
,U2P_Rstage_BitData01=7154
,U2P_Rstage_BitData02=7155
,U2P_Rstage_VacReadySt=7100
,U2P_Rstage_AutoReadySt=7101
,U2P_Rstage_MotionDownroadExe=7102
,U2P_Rstage_Motioning=7103
,U2P_Rstage_MotionComp=7104
,U2P_Rstage_AutoRunComp=7105
,Temp_Rstage_VacReadySt=8410
,Temp_Rstage_AutoReadySt=8411
,Temp_Rstage_MotionDownroadExe=8412
,Temp_Rstage_Motioning=8413
,Temp_Rstage_MotionComp=8414
,Temp_Rstage_AutoRunComp=8415
,U2P_Rstage_ViAilgnSeqComp=7109
,U2P_Rstage_ViAilgn01TrigExe=7110
,U2P_Rstage_ViAilgn02TrigExe=7111
,U2P_Rstage_ViAilgn03TrigExe=7112
,U2P_Rstage_ViAilgn04TrigExe=7113
,Temp_Rstage_ViAilgnSeqComp=8416
,Temp_Rstage_ViAilgn01TrigExe=8417
,Temp_Rstage_ViAilgn02TrigExe=8418
,Temp_Rstage_ViAilgn03TrigExe=8419
,Temp_Rstage_ViAilgn04TrigExe=8420
,U2P_Rstage_MachStatus=7116
,U2P_Rstage_AilgnMvComp=7123
,U2P_Rstage_WorkPosMvComp=7124
,U2P_Rstage_LoadingPosMvComp=7125
,U2P_Rstage_ReadyMvComp=7128
,Temp_Rstage_MachStatus=8421
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
,Temp_LinearX_SetMtReadyPos=8422
,Temp_LinearX_SetMtLWorkStartPos=8423
,Temp_LinearX_SetMtRWorkStartPos=8424
,Temp_LinearX_SetMtLLoadingPos=8425
,Temp_LinearX_SetMtRLoadingPos=8426
,Temp_LinearX_SetMtLViAilgn01Pos=8427
,Temp_LinearX_SetMtLViAilgn02Pos=8428
,Temp_LinearX_SetMtLViAilgn03Pos=8429
,Temp_LinearX_SetMtLViAilgn04Pos=8430
,Temp_LinearX_SetMtRViAilgn01Pos=8431
,Temp_LinearX_SetMtRViAilgn02Pos=8432
,Temp_LinearX_SetMtRViAilgn03Pos=8433
,Temp_LinearX_SetMtRViAilgn04Pos=8434
,Temp_LinearX_SetMtPowerMeterPos=8435
,Temp_LinearX_SetMtSpare10Pos=8436
,Temp_LinearX_SetMtPosMvSpd=8437
,Temp_LinearX_SetMtPosMvTA=8438
,Temp_LinearX_SetReadyPosMvSpd=8439
,Temp_LinearX_SetReadyPosMvTA=8440
,Temp_LinearX_SetMtWorkStartPosMvSpd=8441
,Temp_LinearX_SetMtWorkStartPosMvTA=8442
,Temp_LinearX_SetAlignPosMvSpd=8443
,Temp_LinearX_SetAlignPosMvTA=8444
,Temp_LinearX_SetLoadingPosMvSpd=8445
,Temp_LinearX_SetLoadingPosMvTA=8446
,Temp_LinearX_SetPowerMeterPosMvSpd=8447
,Temp_LinearX_SetPowerMeterPosMvTA=8448
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
,Temp_LStageY_SetMtReadyPos=8449
,Temp_LStageY_SetMtWorkStartPos=8450
,Temp_LStageY_SetMtSpare03Pos=8451
,Temp_LStageY_SetMtLoadingPos=8452
,Temp_LStageY_SetMtSpare04Pos=8453
,Temp_LStageY_SetMtViAilgn01Pos=8454
,Temp_LStageY_SetMtViAilgn02Pos=8455
,Temp_LStageY_SetMtViAilgn03Pos=8456
,Temp_LStageY_SetMtViAilgn04Pos=8457
,Temp_LStageY_SetMtSpare05Pos=8458
,Temp_LStageY_SetMtSpare06Pos=8459
,Temp_LStageY_SetMtSpare07Pos=8460
,Temp_LStageY_SetMtSpare08Pos=8461
,Temp_LStageY_SetMtSpare09Pos=8462
,Temp_LStageY_SetMtSafePos=8463
,Temp_LStageY_SetMtPosMvSpd=8464
,Temp_LStageY_SetMtPosMvTA=8465
,Temp_LStageY_SetReadyPosMvSpd=8466
,Temp_LStageY_SetReadyPosMvTA=8467
,Temp_LStageY_SetMtWorkStartPosMvSpd=8468
,Temp_LStageY_SetMtWorkStartPosMvTA=8469
,Temp_LStageY_SetAlignPosMvSpd=8470
,Temp_LStageY_SetAlignPosMvTA=8471
,Temp_LStageY_SetLoadingPosMvSpd=8472
,Temp_LStageY_SetLoadingPosMvTA=8473
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
,Temp_RStageY_SetMtReadyPos=8474
,Temp_RStageY_SetMtWorkStartPos=8475
,Temp_RStageY_SetMtSpare03Pos=8476
,Temp_RStageY_SetMtLoadingPos=8477
,Temp_RStageY_SetMtSpare04Pos=8478
,Temp_RStageY_SetMtViAilgn01Pos=8479
,Temp_RStageY_SetMtViAilgn02Pos=8480
,Temp_RStageY_SetMtViAilgn03Pos=8481
,Temp_RStageY_SetMtViAilgn04Pos=8482
,Temp_RStageY_SetMtSpare05Pos=8483
,Temp_RStageY_SetMtSpare06Pos=8484
,Temp_RStageY_SetMtSpare07Pos=8485
,Temp_RStageY_SetMtSpare08Pos=8486
,Temp_RStageY_SetMtSpare09Pos=8487
,Temp_RStageY_SetMtSafePos=8488
,Temp_RStageY_SetMtPosMvSpd=8489
,Temp_RStageY_SetMtPosMvTA=8490
,Temp_RStageY_SetReadyPosMvSpd=8491
,Temp_RStageY_SetReadyPosMvTA=8492
,Temp_RStageY_SetMtWorkStartPosMvSpd=8493
,Temp_RStageY_SetMtWorkStartPosMvTA=8494
,Temp_RStageY_SetAlignPosMvSpd=8495
,Temp_RStageY_SetAlignPosMvTA=8496
,Temp_RStageY_SetLoadingPosMvSpd=8497
,Temp_RStageY_SetLoadingPosMvTA=8498
,ServoZ_SetMtReadyPos=4500
,ServoZ_SetMtWorkStartPos=4501
,ServoZ_SetMtSpare03Pos=4502
,ServoZ_SetMtLoadingPos=4503
,ServoZ_SetMtSpare04Pos=4504
,ServoZ_SetMtViAilgn01Pos=4505
,ServoZ_SetMtViAilgn02Pos=4506
,ServoZ_SetMtViAilgn03Pos=4507
,ServoZ_SetMtViAilgn04Pos=4508
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
,Temp_ServoZ_SetMtReadyPos=8499
,Temp_ServoZ_SetMtWorkStartPos=8500
,Temp_ServoZ_SetMtSpare03Pos=8501
,Temp_ServoZ_SetMtLoadingPos=8502
,Temp_ServoZ_SetMtSpare04Pos=8503
,Temp_ServoZ_SetMtViAilgn01Pos=8504
,Temp_ServoZ_SetMtViAilgn02Pos=8505
,Temp_ServoZ_SetMtViAilgn03Pos=8506
,Temp_ServoZ_SetMtViAilgn04Pos=8507
,Temp_ServoZ_SetMtSpare05Pos=8508
,Temp_ServoZ_SetMtSpare06Pos=8509
,Temp_ServoZ_SetMtSpare07Pos=8510
,Temp_ServoZ_SetMtSpare08Pos=8511
,Temp_ServoZ_SetMtPowerMeterPos=8512
,Temp_ServoZ_SetMtSpare10Pos=8513
,Temp_ServoZ_SetMtPosMvSpd=8514
,Temp_ServoZ_SetMtPosMvTA=8515
,Temp_ServoZ_SetReadyPosMvSpd=8516
,Temp_ServoZ_SetReadyPosMvTA=8517
,Temp_ServoZ_SetMtWorkStartPosMvSpd=8518
,Temp_ServoZ_SetMtWorkStartPosMvTA=8519
,Temp_ServoZ_SetAlignPosMvSpd=8520
,Temp_ServoZ_SetAlignPosMvTA=8521
,Temp_ServoZ_SetLoadingPosMvSpd=8522
,Temp_ServoZ_SetLoadingPosMvTA=8523
,Temp_ServoZ_SetPowerMeterPosMvSpd=8524
,Temp_ServoZ_SetPowerMeterPosMvTA=8525
,P2U_LstageY_MvPos=1205
,P2U_RstageY_MvPos=1305
,CalSlewRateForm=8526
,Mach_CalPlcCycleTime=8552
,Mach_CalAverPlcCycleTime=8553
,SetChkInposBand=8554
,Mach_StError=9974
,Temp_Cts_Mach_StError=9975
,Mach_Bit_0200_MsecToggle=10026
,Mach_Bit_0500_MsecToggle=10027
,Mach_Bit_1000_MsecToggle=10028
,Mach_CmdTime=10029
,Mach_WaitCycle=10030
,Mach_Cmd=10031
,Mach_CmdLock=10032
,Temp_Mach_ChkErr=10033
,Temp_Mach_Cmd=10034
,Mach_CmdErrCode=10035
,Mach_StIngMove=10036
,Mach_StAmpEnable=10037
,Mach_StAmpDisable=10038
,Mach_StCompHome=10039
,Mtr_CompExtraWindProgRun=10304
,Mach_SetMoveRdyTa=10305
,Mach_SetMoveRdySpd=10306
,Mtr_SetBasicTa=10604
,Mtr_SetBasicMoveSpd=10605
,Mtr_SetBasicJogMoveSpd=10606
,Mtr_SetBasicHomeSpd=10607
,HomeAllComplete=10608
,LSTAGE_AreaSenPauseCmd=10609
,RSTAGE_AreaSenPauseCmd=10610
,Mach_GetStatus=10677
,Mach_CtsChkPartError=11090
,Mach_CtsChkMtrError=11091
,Mach_CtsChkUnitError=11092
,Mach_CtsChkSeqError=11093
,Mach_CtsChkRobotPosError=11094
,Mach_ExeCmdErrorReset=11095
,Mach_ExeCmdReset=11096
,Mach_ExeRcpDataUpdate=11097
,Temp_CtsStCompHome=13268
,Temp_ChkMotorErr=13269
,Temp_CtsStCompReady=13270
,Temp_ChkReadyMotorErr=13271
,Mach_MotorAllServoOn=13342
,Mach_MotorAllServoOff=13343
,Exe_ResetLamp_On=13344
,Exe_ResetLamp_FlickOn=13345
,Temp_Exe_ResetLamp_FlickOn=13346
,Exe_LeftStartLamp_On=13347
,Exe_LeftStartLamp_FlickOn=13348
,Temp_Exe_LeftStartLamp_FlickOn=13349
,Exe_RightStartLamp_On=13350
,Exe_RightStartLamp_FlickOn=13351
,Temp_Exe_RightStartLamp_FlickOn=13352
,Temp_SinalTower_Buzzer=13353
,Temp_AreaSenErrStatus=13354
,Temp_MainDoorSenErrStatus=13355
,Temp_SideDooerSenErrStatus=13356
,Temp_LeftPressureSenErrStatus=13357
,Temp_RightPressureSenErrStatus=13358
,Temp_PressureSenErrStatus=13359
,Temp_LeakSenErrStatus=13360
,Temp_LstageSaftyMvErrStatus=13361
,Temp_LstageSaftyValueErrStatus=13362
,Temp_RstageSaftyMvErrStatus=13363
,Temp_RstageSaftyValueErrStatus=13364
,Safety_ErrorCheck=13365
,AutoRun_NotStopErrBit=13366
,Temp_SafetyStopErrNotClearStatus=13367
,Temp_SafetyEMOErrNotClearStatus=13368
,Temp_PressureSenUnUse=13369
,Temp_LeakSenUnUse=13370
,Temp_SaftyPosCheckUnUse=13371
,test_Mode=13372
,Half_test_Mode=13373
,test_ModeDataUndate=13374
,Temp_MaxAccData=13375
,Temp_Lstage_SaftyMvCheck=13376
,Temp_Rstage_SaftyMvCheck=13377
,Temp_Lstage_SaftyValueCheck=13378
,Temp_Rstage_SaftyValueCheck=13379
,Temp_Lstage_AutoRunStatus=13380
,Temp_Rstage_AutoRunStatus=13381
,Temp_Lstage_AutoRdyServoZPos=13382
,Temp_Rstage_AutoRdyServoZPos=13383
,MotionDownloadTimeOut=14044
,U2P_Mt01_ErrCode=3550
,U2P_Mt02_ErrCode=3551
,U2P_Mt03_ErrCode=3552
,U2P_Mt05_ErrCode=3554
,U2P_AllUnit_ErrCode=3650
,U2P_LStage_ErrCode=3651
,U2P_RStage_ErrCode=3652
,U2P_Mach_ErrCode=3750
,U2P_Part_ErrCode=3751
,Mach_SetSubProgUpdateTime=16091
,Mach_SetSubProgWaitCycle=16092
,LinearX_Mtr_HomeOffset=1104
,LStageY_Mtr_HomeOffset=1204
,RStageY_Mtr_HomeOffset=1304
,ServoZ_Mtr_HomeOffset=1504};
enum globalParray {_globalParray_=-1
,Temp_IO_Out=8192
,Temp_IOIn=8242
,Plc_SetUpdateTime=8527
,Plc_SetExeCount=8532
,Plc_SetUpdateCycle=8537
,Plc_ChkUpdateCount=8542
,Temp_Plc_ChkUpdateCount=8547
,Mtr_ExeCmd=8555
,Temp_Mtr_ExeCmd=8588
,Mtr_CmdLock=8621
,Mtr_StCompHome=8654
,Mtr_CmdErrorCode=8687
,Mtr_SetMachScale=8720
,Mtr_SetScale=8753
,Mtr_SetScaleOffset=8786
,Mtr_CalDivFactVel=8819
,Mtr_SetSoftLimP=8852
,Mtr_SetSoftLimN=8885
,Mtr_SetAbortAcc=8918
,Mtr_SetMaxAccG=8951
,Mtr_SetJogTa=8984
,Mtr_SetJogVel=9017
,Mtr_ChkJogCmd=9050
,Mtr_SetMoveTa=9083
,Mtr_SetMoveSpd=9116
,Mtr_SetMovePos=9149
,Mtr_SetPosRdy=9182
,Mtr_SetHomeTa=9215
,Mtr_SetHomeJVel=9248
,Mtr_SetHomeSVel=9281
,Mtr_SetHomeOffsetPos=9314
,Mtr_SetHomeOverTime=9347
,Mtr_SetMaxPos=9380
,Mtr_SetMinPos=9413
,Mtr_GetActPos=9446
,Mtr_GetDesPos=9479
,Temp_Mtr_GetActPos=9512
,Mtr_SavOffsetPos=9545
,Mtr_GetActSpd=9578
,Mtr_GetDesSpd=9611
,Mtr_StIngMove=9644
,Mtr_StIngHome=9677
,Mtr_StPosHome=9710
,Mtr_CalDacOut=9743
,Mtr_SetStopTd=9776
,Mtr_SetMotor_Type=9809
,Mtr_SetUSE_LIMIT_ERR=9842
,Mtr_SetMotorEcat=9875
,Mtr_ChkAmpEnable=9908
,Mtr_ChkMotorUnuse=9941
,Temp_Chk_Mach_StError=9976
,Mtr_ExeCmdStep=10040
,Mtr_ChkCmdStepReady=10073
,Mtr_BitCmdStepNotReady=10106
,Mtr_GetCmdError=10139
,Mtr_StAutoRdy=10172
,Mtr_StServoRdy=10205
,Mtr_CompExeProgRun=10238
,Mtr_CompProgRun=10271
,Mtr_ChkMoveRdyPos=10307
,Mtr_SetMoveRdyTa=10340
,Mtr_SetMoveRdySpd=10373
,Mtr_SetMoveRdyPos=10406
,Mtr_SetMoveTargetPos=10439
,Mtr_SetMoveRemainDist=10472
,Mtr_CompMovePos=10505
,Mtr_ChkPosSetPos=10538
,Mtr_ChkPosMoveRdyPos=10571
,Mtr_SetTouchprobeFunctionValue=10611
,Mtr_SaftyCheckTargetPos=10644
,Mtr_ExeManualCmd=10678
,Temp_Mtr_ExeManualCmd=10711
,Part_StAutoReady=10744
,Part_BitStNotAutoReady=10777
,Mach_ExeCmdStep=10810
,Mach_Chk1CycleCmd=10880
,Mach_ChkCmdStepReady=10950
,Mach_CmdErrorCode=11020
,Seq_ExeCmdStep=11098
,Temp_Seq_ExeCmdStep=11168
,Test_Seq_ExeCmdStep=11238
,Part_ExeCmdStep=11308
,Part_ChkCmdStepReady=11378
,Part_BitCmdStepNotReady=11448
,Part_CmdErrorCode=11518
,Part_StAmpEnable=11588
,Part_StCompHome=11658
,Part_StCompServoRdy=11728
,Part_StCompAutoRdy=11798
,Temp_Part_StAmpEnable=11868
,Temp_Part_StCompHome=11938
,Temp_Part_StCompServoRdy=12008
,Temp_Part_StCompAutoRdy=12078
,Unit_ExeCmdStep=12148
,Temp_Unit_ExeCmdStep=12218
,Unit_ReqCmd=12288
,Unit_LockCmd=12358
,Unit_StErrorStatus=12428
,Temp_Unit_StErrorStatus=12498
,Unit_CmdErrorCode=12568
,Ready_ExeCmdStep=12638
,Temp_Ready_ExeCmdStep=12708
,Part_StAutoRdy=12778
,Part_StMtrServoRdy=12848
,Part_StErrorStatus=12918
,Temp_Part_StErrorStatus=12988
,Part_ExeCmdReadyStep=13058
,Temp_Part_ExeCmdReadyStep=13128
,Part_CmdReadyError=13198
,Unit_AutoStartReadySt=13272
,Temp_Mtr_CheckReadyPos=13384
,Temp_Mtr_CheckLAlign01Pos=13417
,Temp_Mtr_CheckLAlign02Pos=13450
,Temp_Mtr_CheckLAlign03Pos=13483
,Temp_Mtr_CheckLAlign04Pos=13516
,Temp_Mtr_CheckRAlign01Pos=13549
,Temp_Mtr_CheckRAlign02Pos=13582
,Temp_Mtr_CheckRAlign03Pos=13615
,Temp_Mtr_CheckRAlign04Pos=13648
,Temp_Mtr_CheckAlign01Pos=13681
,Temp_Mtr_CheckAlign02Pos=13714
,Temp_Mtr_CheckAlign03Pos=13747
,Temp_Mtr_CheckAlign04Pos=13780
,Temp_Mtr_CheckPowerMeterPos=13813
,Temp_Mtr_CheckLoadingPos=13846
,Temp_Mtr_CheckWorkStartPos=13879
,Temp_Mtr_CheckLLoadingPos=13912
,Temp_Mtr_CheckRLoadingPos=13945
,Temp_Mtr_CheckLWorkStartPos=13978
,Temp_Mtr_CheckRWorkStartPos=14011
,MC_MoveJogP_In_Axis=14045
,MC_MoveJogP_In_MaxPosition=14078
,MC_MoveJogP_In_AccTime=14111
,MC_MoveJogP_In_Velocity=14144
,MC_MoveJogN_In_Axis=14177
,MC_MoveJogN_In_MinPosition=14210
,MC_MoveJogN_In_AccTime=14243
,MC_MoveJogN_In_Velocity=14276
,MC_MoveAbs_In_Axis=14309
,MC_MoveAbs_In_MaxPosition=14342
,MC_MoveAbs_In_MinPosition=14375
,MC_MoveAbs_In_Position=14408
,MC_MoveAbs_In_AccTime=14441
,MC_MoveAbs_In_Velocity=14474
,MC_MoveAbs_Ot_DesMovePosition=14507
,MC_MoveAbs_Ot_MovePosition=14540
,MC_MoveInc_In_Axis=14573
,MC_MoveInc_In_MaxPosition=14606
,MC_MoveInc_In_MinPosition=14639
,MC_MoveInc_In_Position=14672
,MC_MoveInc_In_AccTime=14705
,MC_MoveInc_In_Velocity=14738
,MC_MoveInc_Ot_DesMovePosition=14771
,MC_MoveInc_Ot_MovePosition=14804
,MC_MoveStop_In_DecTime=14837
,Mtr_Chk_ExeRdyErr_In_Cmd=14870
,Mtr_Chk_ExeRdyErr_Ot_Error=14903
,Mtr_Chk_ExeRdyErr_Ot_ErrorID=14936
,Mtr_Chk_ExeEndErr_In_Cmd=14969
,Mtr_Chk_ExeEndErr_Ot_Error=15002
,Mtr_Chk_ExeEndErr_Ot_ErrorID=15035
,Mtr_Cmd_StepHomeProg_In_HomeJogVel=15068
,Mtr_Cmd_StepHomeProg_In_HomeJogTa=15101
,Mtr_Cmd_StepHomeProg_In_HomeVel=15134
,Mtr_Cmd_StepHomeProg_In_HomeOffset=15167
,Mtr_Cmd_StepHomeProg_In_UseLimit=15200
,Mtr_Cmd_StepHomeProg_In_TimeOutTime=15233
,Mtr_Chk_AllAmpEna_Ot_Ena=15266
,Mtr_Chk_AllAmpEna_Ot_Temp=15299
,Mtr_Chk_AllCompHome_Ot_Comp=15332
,Mtr_Chk_AllCompHome_Ot_Temp=15365
,Mtr_Chk_AllMoving_Ot_Moving=15398
,Mtr_Chk_AllMoving_Ot_Temp=15431
,Mtr_Chk_AllErr_Ot_Err=15464
,Mtr_Chk_AllErr_Ot_Temp=15497
,MTR_Err_LimitErr_Ot_State=15530
,Mtr_Set_GateSetup_In_Word_SetGate=15563
,Mtr_Set_GateSetup_In_GateNum=15596
,Mtr_Set_GateSetup_In_ChanNum=15629
,Mtr_Set_MtWord_Setup_In_AbortAcc=15662
,Mtr_Set_MtWord_Setup_In_ProgMaxSpeed=15695
,Mtr_Set_MtWord_Setup_In_ProgMaxAcc=15728
,Mtr_Set_HomeWord_Setup_In_CaptCtrl=15761
,Mtr_Set_HomeWord_Setup_In_CaptFlag=15794
,AUTO_CHK_MtCmdEnd_Ot_Temp=15827
,AUTO_CHK_MtCmdEnd_Ot_Comp=15860
,AUTO_CHK_MtCmdEnd_Ot_Error=15893
,AUTO_CHK_CmdEnd_Ot_Temp=15926
,AUTO_CHK_CmdEnd_Ot_Comp=15959
,AUTO_CHK_CmdEnd_Ot_Error=15992
,AUTO_CHK_HostTimeBaseDone_Ot_Temp=16025
,AUTO_CHK_HostTimeBaseDone_Ot_Comp=16058};
enum csglobalQ {_csglobalQ_=-1};
enum csglobalQarray {_csglobalQarray_=-1};
enum ptrM {_ptrM_=-1
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
#define IO_Out 8192
#define IOIn 8242
#define Temp_IO_Out 8192
#define Temp_IOIn 8242
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
#define Temp_In_Main_PowerOn 8292
#define Temp_In_EMO01_Btn 8293
#define Temp_In_EMO02_Btn 8294
#define Temp_In_EMO03_Btn 8295
#define Temp_In_LeftUnit_Start_Btn 8296
#define Temp_In_LeftUnit_Vac_Btn 8297
#define Temp_In_LeftUnit_Stop_Btn 8298
#define Temp_In_LeftUnit_ReSet_Btn 8299
#define Temp_In_LeftUnit_Pressure_Sen 8300
#define Temp_In_LeftUnit_Vac_Sen 8301
#define Temp_In_RightUnit_Start_Btn 8302
#define Temp_In_RightUnit_Vac_Btn 8303
#define Temp_In_RightUnit_Stop_Btn 8304
#define Temp_In_RightUnit_ReSet_Btn 8305
#define Temp_In_RightUnit_Pressure_Sen 8306
#define Temp_In_RightUnit_Vac_Sen 8307
#define Temp_In_Stage_PowerOn 8308
#define Temp_In_Leak_Sen 8309
#define Temp_In_Door01_Sen 8310
#define Temp_In_Door02_Sen 8311
#define Temp_In_Door03_Sen 8312
#define Temp_In_Door04_Sen 8313
#define Temp_In_Door05_Sen 8314
#define Temp_In_Spare_UX024 8315
#define Temp_In_LeftUnit_Ionizer 8316
#define Temp_In_RightUnit_Ionizer 8317
#define Temp_In_BeamShutter_Close 8318
#define Temp_In_BeamShutter_Open 8319
#define Temp_In_PowerMeter_Open 8320
#define Temp_In_PowerMeter_Close 8321
#define Temp_In_LeftUnit_Area_Sen 8322
#define Temp_In_RightUnit_Area_Sen 8323
#define Temp_In_Spare_UX033 8324
#define Temp_In_Spare_UX034 8325
#define Temp_In_Spare_UX035 8326
#define Temp_In_Spare_UX036 8327
#define Temp_In_Spare_UX037 8328
#define Temp_In_Spare_UX038 8329
#define Temp_In_Spare_UX039 8330
#define Temp_In_Spare_UX040 8331
#define Temp_In_Spare_UX041 8332
#define Temp_In_Spare_UX042 8333
#define Temp_In_Spare_UX043 8334
#define Temp_In_Spare_UX044 8335
#define Temp_In_Spare_UX045 8336
#define Temp_In_Spare_UX046 8337
#define Temp_In_Spare_UX047 8338
#define Temp_In_Spare_UX048 8339
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
#define Temp_Mach_AllHomeExe 8340
#define Temp_Mach_MtrAllServoOn 8341
#define Temp_Mach_MtrAllServoOff 8342
#define Temp_Mach_PowerMeterChk 8343
#define Temp_Mach_ReadyExe 8344
#define Temp_Mach_MainDoorUnUse 8345
#define Temp_Mach_AreaSenUnUse 8346
#define Temp_Mach_SideDoorUnUse 8347
#define Temp_Mach_LED_Light_On 8348
#define Temp_Mach_BuzzerStopExe 8349
#define Temp_Mach_BuzzerUnUse 8350
#define Temp_Mach_UnitStartDelayTime 8351
#define Temp_Mach_ReserveUnUse 8352
#define Temp_Mach_AutoCompVentUnUse 8353
#define Temp_Mach_VacErrCheckUnUse 8354
#define Temp_Mach_AreaSenVentUnUse 8355
#define U2P_Mach_BitData01 5154
#define U2P_Mach_BitData02 5155
#define U2P_Mach_Status 5100
#define U2P_Mach_AllHomming 5101
#define U2P_Mach_AllHomeComp 5102
#define U2P_Mach_PowerMoterChkComp 5104
#define U2P_Mach_ReadyPosComp 5105
#define MotionEnd 8000
#define Temp_Mach_Status 8356
#define Temp_Mach_AllHomming 8357
#define Temp_Mach_AllHomeComp 8358
#define Temp_Mach_MotionTimeOut 8359
#define U2P_Lstage_BitData01 6154
#define U2P_Lstage_BitData02 6155
#define P2U_Lstage_ReadySt 6000
#define P2U_Lstage_AutoStart 6001
#define P2U_Lstage_MotionDownroadComp 6002
#define P2U_Lstage_Glessthickness 6004
#define Temp_Lstage_ReadySt 8360
#define Temp_Lstage_AutoStart 8361
#define Temp_Lstage_MotionDownroadComp 8362
#define Temp_Lstage_Glessthickness 8363
#define P2U_Lstage_ViAilgnUnUse 6009
#define P2U_Lstage_ViAilgnCts 6010
#define P2U_Lstage_ViAilgn01TrigComp 6011
#define P2U_Lstage_ViAilgn02TrigComp 6012
#define P2U_Lstage_ViAilgn03TrigComp 6013
#define P2U_Lstage_ViAilgn04TrigComp 6014
#define Temp_Lstage_ViAilgnUnUse 8364
#define Temp_Lstage_ViAilgnCts 8365
#define Temp_Lstage_ViAilgn01TrigComp 8366
#define Temp_Lstage_ViAilgn02TrigComp 8367
#define Temp_Lstage_ViAilgn03TrigComp 8368
#define Temp_Lstage_ViAilgn04TrigComp 8369
#define P2U_Lstage_VacUseCts 6016
#define Temp_Lstage_VacUseCts 8370
#define P2U_Lstage_Vac01Time 6018
#define P2U_Lstage_Vac02Time 6019
#define P2U_Lstage_Vac03Time 6020
#define P2U_Lstage_Vac04Time 6021
#define Temp_Lstage_Vac01Time 8371
#define Temp_Lstage_Vac02Time 8372
#define Temp_Lstage_Vac03Time 8373
#define Temp_Lstage_Vac04Time 8374
#define P2U_Lstage_AilgnMvStart 6023
#define P2U_Lstage_WorkPosMvStart 6024
#define P2U_Lstage_LoadingPosMvStart 6025
#define P2U_Lstage_VacStart 6026
#define P2U_Lstage_ReadyMvStart 6028
#define Temp_Lstage_AilgnMvStart 8375
#define Temp_Lstage_WorkPosMvStart 8376
#define Temp_Lstage_LoadingPosMvStart 8377
#define Temp_Lstage_ReadyMvStart 8378
#define U2P_Lstage_VacReadySt 6100
#define U2P_Lstage_AutoReadySt 6101
#define U2P_Lstage_MotionDownroadExe 6102
#define U2P_Lstage_Motioning 6103
#define U2P_Lstage_MotionComp 6104
#define U2P_Lstage_AutoRunComp 6105
#define Temp_Lstage_VacReadySt 8379
#define Temp_Lstage_AutoReadySt 8380
#define Temp_Lstage_MotionDownroadExe 8381
#define Temp_Lstage_Motioning 8382
#define Temp_Lstage_MotionComp 8383
#define Temp_Lstage_AutoRunComp 8384
#define U2P_Lstage_ViAilgnSeqComp 6109
#define U2P_Lstage_ViAilgn01TrigExe 6110
#define U2P_Lstage_ViAilgn02TrigExe 6111
#define U2P_Lstage_ViAilgn03TrigExe 6112
#define U2P_Lstage_ViAilgn04TrigExe 6113
#define Temp_Lstage_ViAilgnSeqComp 8385
#define Temp_Lstage_ViAilgn01TrigExe 8386
#define Temp_Lstage_ViAilgn02TrigExe 8387
#define Temp_Lstage_ViAilgn03TrigExe 8388
#define Temp_Lstage_ViAilgn04TrigExe 8389
#define U2P_Lstage_MachStatus 6116
#define U2P_Lstage_AilgnMvComp 6123
#define U2P_Lstage_WorkPosMvComp 6124
#define U2P_Lstage_LoadingPosMvComp 6125
#define U2P_Lstage_ReadyMvComp 6128
#define Temp_Lstage_MachStatus 8390
#define P2U_Rstage_ReadySt 7000
#define P2U_Rstage_AutoStart 7001
#define P2U_Rstage_MotionDownroadComp 7002
#define P2U_Rstage_Glessthickness 7004
#define Temp_Rstage_ReadySt 8391
#define Temp_Rstage_AutoStart 8392
#define Temp_Rstage_MotionDownroadComp 8393
#define Temp_Rstage_Glessthickness 8394
#define P2U_Rstage_ViAilgnUnUse 7009
#define P2U_Rstage_ViAilgnCts 7010
#define P2U_Rstage_ViAilgn01TrigComp 7011
#define P2U_Rstage_ViAilgn02TrigComp 7012
#define P2U_Rstage_ViAilgn03TrigComp 7013
#define P2U_Rstage_ViAilgn04TrigComp 7014
#define Temp_Rstage_ViAilgnUnUse 8395
#define Temp_Rstage_ViAilgnCts 8396
#define Temp_Rstage_ViAilgn01TrigComp 8397
#define Temp_Rstage_ViAilgn02TrigComp 8398
#define Temp_Rstage_ViAilgn03TrigComp 8399
#define Temp_Rstage_ViAilgn04TrigComp 8400
#define P2U_Rstage_VacUseCts 7016
#define Temp_Rstage_VacUseCts 8401
#define P2U_Rstage_Vac01Time 7018
#define P2U_Rstage_Vac02Time 7019
#define P2U_Rstage_Vac03Time 7020
#define P2U_Rstage_Vac04Time 7021
#define Temp_Rstage_Vac01Time 8402
#define Temp_Rstage_Vac02Time 8403
#define Temp_Rstage_Vac03Time 8404
#define Temp_Rstage_Vac04Time 8405
#define P2U_Rstage_AilgnMvStart 7023
#define P2U_Rstage_WorkPosMvStart 7024
#define P2U_Rstage_LoadingPosMvStart 7025
#define P2U_Rstage_VacStart 7026
#define P2U_Rstage_ReadyMvStart 7028
#define Temp_Rstage_AilgnMvStart 8406
#define Temp_Rstage_WorkPosMvStart 8407
#define Temp_Rstage_LoadingPosMvStart 8408
#define Temp_Rstage_ReadyMvStart 8409
#define U2P_Rstage_BitData01 7154
#define U2P_Rstage_BitData02 7155
#define U2P_Rstage_VacReadySt 7100
#define U2P_Rstage_AutoReadySt 7101
#define U2P_Rstage_MotionDownroadExe 7102
#define U2P_Rstage_Motioning 7103
#define U2P_Rstage_MotionComp 7104
#define U2P_Rstage_AutoRunComp 7105
#define Temp_Rstage_VacReadySt 8410
#define Temp_Rstage_AutoReadySt 8411
#define Temp_Rstage_MotionDownroadExe 8412
#define Temp_Rstage_Motioning 8413
#define Temp_Rstage_MotionComp 8414
#define Temp_Rstage_AutoRunComp 8415
#define U2P_Rstage_ViAilgnSeqComp 7109
#define U2P_Rstage_ViAilgn01TrigExe 7110
#define U2P_Rstage_ViAilgn02TrigExe 7111
#define U2P_Rstage_ViAilgn03TrigExe 7112
#define U2P_Rstage_ViAilgn04TrigExe 7113
#define Temp_Rstage_ViAilgnSeqComp 8416
#define Temp_Rstage_ViAilgn01TrigExe 8417
#define Temp_Rstage_ViAilgn02TrigExe 8418
#define Temp_Rstage_ViAilgn03TrigExe 8419
#define Temp_Rstage_ViAilgn04TrigExe 8420
#define U2P_Rstage_MachStatus 7116
#define U2P_Rstage_AilgnMvComp 7123
#define U2P_Rstage_WorkPosMvComp 7124
#define U2P_Rstage_LoadingPosMvComp 7125
#define U2P_Rstage_ReadyMvComp 7128
#define Temp_Rstage_MachStatus 8421
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
#define Temp_LinearX_SetMtReadyPos 8422
#define Temp_LinearX_SetMtLWorkStartPos 8423
#define Temp_LinearX_SetMtRWorkStartPos 8424
#define Temp_LinearX_SetMtLLoadingPos 8425
#define Temp_LinearX_SetMtRLoadingPos 8426
#define Temp_LinearX_SetMtLViAilgn01Pos 8427
#define Temp_LinearX_SetMtLViAilgn02Pos 8428
#define Temp_LinearX_SetMtLViAilgn03Pos 8429
#define Temp_LinearX_SetMtLViAilgn04Pos 8430
#define Temp_LinearX_SetMtRViAilgn01Pos 8431
#define Temp_LinearX_SetMtRViAilgn02Pos 8432
#define Temp_LinearX_SetMtRViAilgn03Pos 8433
#define Temp_LinearX_SetMtRViAilgn04Pos 8434
#define Temp_LinearX_SetMtPowerMeterPos 8435
#define Temp_LinearX_SetMtSpare10Pos 8436
#define Temp_LinearX_SetMtPosMvSpd 8437
#define Temp_LinearX_SetMtPosMvTA 8438
#define Temp_LinearX_SetReadyPosMvSpd 8439
#define Temp_LinearX_SetReadyPosMvTA 8440
#define Temp_LinearX_SetMtWorkStartPosMvSpd 8441
#define Temp_LinearX_SetMtWorkStartPosMvTA 8442
#define Temp_LinearX_SetAlignPosMvSpd 8443
#define Temp_LinearX_SetAlignPosMvTA 8444
#define Temp_LinearX_SetLoadingPosMvSpd 8445
#define Temp_LinearX_SetLoadingPosMvTA 8446
#define Temp_LinearX_SetPowerMeterPosMvSpd 8447
#define Temp_LinearX_SetPowerMeterPosMvTA 8448
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
#define Temp_LStageY_SetMtReadyPos 8449
#define Temp_LStageY_SetMtWorkStartPos 8450
#define Temp_LStageY_SetMtSpare03Pos 8451
#define Temp_LStageY_SetMtLoadingPos 8452
#define Temp_LStageY_SetMtSpare04Pos 8453
#define Temp_LStageY_SetMtViAilgn01Pos 8454
#define Temp_LStageY_SetMtViAilgn02Pos 8455
#define Temp_LStageY_SetMtViAilgn03Pos 8456
#define Temp_LStageY_SetMtViAilgn04Pos 8457
#define Temp_LStageY_SetMtSpare05Pos 8458
#define Temp_LStageY_SetMtSpare06Pos 8459
#define Temp_LStageY_SetMtSpare07Pos 8460
#define Temp_LStageY_SetMtSpare08Pos 8461
#define Temp_LStageY_SetMtSpare09Pos 8462
#define Temp_LStageY_SetMtSafePos 8463
#define Temp_LStageY_SetMtPosMvSpd 8464
#define Temp_LStageY_SetMtPosMvTA 8465
#define Temp_LStageY_SetReadyPosMvSpd 8466
#define Temp_LStageY_SetReadyPosMvTA 8467
#define Temp_LStageY_SetMtWorkStartPosMvSpd 8468
#define Temp_LStageY_SetMtWorkStartPosMvTA 8469
#define Temp_LStageY_SetAlignPosMvSpd 8470
#define Temp_LStageY_SetAlignPosMvTA 8471
#define Temp_LStageY_SetLoadingPosMvSpd 8472
#define Temp_LStageY_SetLoadingPosMvTA 8473
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
#define Temp_RStageY_SetMtReadyPos 8474
#define Temp_RStageY_SetMtWorkStartPos 8475
#define Temp_RStageY_SetMtSpare03Pos 8476
#define Temp_RStageY_SetMtLoadingPos 8477
#define Temp_RStageY_SetMtSpare04Pos 8478
#define Temp_RStageY_SetMtViAilgn01Pos 8479
#define Temp_RStageY_SetMtViAilgn02Pos 8480
#define Temp_RStageY_SetMtViAilgn03Pos 8481
#define Temp_RStageY_SetMtViAilgn04Pos 8482
#define Temp_RStageY_SetMtSpare05Pos 8483
#define Temp_RStageY_SetMtSpare06Pos 8484
#define Temp_RStageY_SetMtSpare07Pos 8485
#define Temp_RStageY_SetMtSpare08Pos 8486
#define Temp_RStageY_SetMtSpare09Pos 8487
#define Temp_RStageY_SetMtSafePos 8488
#define Temp_RStageY_SetMtPosMvSpd 8489
#define Temp_RStageY_SetMtPosMvTA 8490
#define Temp_RStageY_SetReadyPosMvSpd 8491
#define Temp_RStageY_SetReadyPosMvTA 8492
#define Temp_RStageY_SetMtWorkStartPosMvSpd 8493
#define Temp_RStageY_SetMtWorkStartPosMvTA 8494
#define Temp_RStageY_SetAlignPosMvSpd 8495
#define Temp_RStageY_SetAlignPosMvTA 8496
#define Temp_RStageY_SetLoadingPosMvSpd 8497
#define Temp_RStageY_SetLoadingPosMvTA 8498
#define ServoZ_SetMtReadyPos 4500
#define ServoZ_SetMtWorkStartPos 4501
#define ServoZ_SetMtSpare03Pos 4502
#define ServoZ_SetMtLoadingPos 4503
#define ServoZ_SetMtSpare04Pos 4504
#define ServoZ_SetMtViAilgn01Pos 4505
#define ServoZ_SetMtViAilgn02Pos 4506
#define ServoZ_SetMtViAilgn03Pos 4507
#define ServoZ_SetMtViAilgn04Pos 4508
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
#define Temp_ServoZ_SetMtReadyPos 8499
#define Temp_ServoZ_SetMtWorkStartPos 8500
#define Temp_ServoZ_SetMtSpare03Pos 8501
#define Temp_ServoZ_SetMtLoadingPos 8502
#define Temp_ServoZ_SetMtSpare04Pos 8503
#define Temp_ServoZ_SetMtViAilgn01Pos 8504
#define Temp_ServoZ_SetMtViAilgn02Pos 8505
#define Temp_ServoZ_SetMtViAilgn03Pos 8506
#define Temp_ServoZ_SetMtViAilgn04Pos 8507
#define Temp_ServoZ_SetMtSpare05Pos 8508
#define Temp_ServoZ_SetMtSpare06Pos 8509
#define Temp_ServoZ_SetMtSpare07Pos 8510
#define Temp_ServoZ_SetMtSpare08Pos 8511
#define Temp_ServoZ_SetMtPowerMeterPos 8512
#define Temp_ServoZ_SetMtSpare10Pos 8513
#define Temp_ServoZ_SetMtPosMvSpd 8514
#define Temp_ServoZ_SetMtPosMvTA 8515
#define Temp_ServoZ_SetReadyPosMvSpd 8516
#define Temp_ServoZ_SetReadyPosMvTA 8517
#define Temp_ServoZ_SetMtWorkStartPosMvSpd 8518
#define Temp_ServoZ_SetMtWorkStartPosMvTA 8519
#define Temp_ServoZ_SetAlignPosMvSpd 8520
#define Temp_ServoZ_SetAlignPosMvTA 8521
#define Temp_ServoZ_SetLoadingPosMvSpd 8522
#define Temp_ServoZ_SetLoadingPosMvTA 8523
#define Temp_ServoZ_SetPowerMeterPosMvSpd 8524
#define Temp_ServoZ_SetPowerMeterPosMvTA 8525
#define P2U_LstageY_MvPos 1205
#define P2U_RstageY_MvPos 1305
#define CalSlewRateForm 8526
#define Plc_SetUpdateTime 8527
#define Plc_SetExeCount 8532
#define Plc_SetUpdateCycle 8537
#define Plc_ChkUpdateCount 8542
#define Temp_Plc_ChkUpdateCount 8547
#define Mach_CalPlcCycleTime 8552
#define Mach_CalAverPlcCycleTime 8553
#define SetChkInposBand 8554
#define Mtr_ExeCmd 8555
#define Temp_Mtr_ExeCmd 8588
#define Mtr_CmdLock 8621
#define Mtr_StCompHome 8654
#define Mtr_CmdErrorCode 8687
#define Mtr_SetMachScale 8720
#define Mtr_SetScale 8753
#define Mtr_SetScaleOffset 8786
#define Mtr_CalDivFactVel 8819
#define Mtr_SetSoftLimP 8852
#define Mtr_SetSoftLimN 8885
#define Mtr_SetAbortAcc 8918
#define Mtr_SetMaxAccG 8951
#define Mtr_SetJogTa 8984
#define Mtr_SetJogVel 9017
#define Mtr_ChkJogCmd 9050
#define Mtr_SetMoveTa 9083
#define Mtr_SetMoveSpd 9116
#define Mtr_SetMovePos 9149
#define Mtr_SetPosRdy 9182
#define Mtr_SetHomeTa 9215
#define Mtr_SetHomeJVel 9248
#define Mtr_SetHomeSVel 9281
#define Mtr_SetHomeOffsetPos 9314
#define Mtr_SetHomeOverTime 9347
#define Mtr_SetMaxPos 9380
#define Mtr_SetMinPos 9413
#define Mtr_GetActPos 9446
#define Mtr_GetDesPos 9479
#define Temp_Mtr_GetActPos 9512
#define Mtr_SavOffsetPos 9545
#define Mtr_GetActSpd 9578
#define Mtr_GetDesSpd 9611
#define Mtr_StIngMove 9644
#define Mtr_StIngHome 9677
#define Mtr_StPosHome 9710
#define Mtr_CalDacOut 9743
#define Mtr_SetStopTd 9776
#define Mtr_SetMotor_Type 9809
#define Mtr_SetUSE_LIMIT_ERR 9842
#define Mtr_SetMotorEcat 9875
#define Mtr_ChkAmpEnable 9908
#define Mtr_ChkMotorUnuse 9941
#define Mach_StError 9974
#define Temp_Cts_Mach_StError 9975
#define Temp_Chk_Mach_StError 9976
#define Mach_Bit_0200_MsecToggle 10026
#define Mach_Bit_0500_MsecToggle 10027
#define Mach_Bit_1000_MsecToggle 10028
#define Mach_CmdTime 10029
#define Mach_WaitCycle 10030
#define Mach_Cmd 10031
#define Mach_CmdLock 10032
#define Temp_Mach_ChkErr 10033
#define Temp_Mach_Cmd 10034
#define Mach_CmdErrCode 10035
#define Mach_StIngMove 10036
#define Mach_StAmpEnable 10037
#define Mach_StAmpDisable 10038
#define Mach_StCompHome 10039
#define Mtr_ExeCmdStep 10040
#define Mtr_ChkCmdStepReady 10073
#define Mtr_BitCmdStepNotReady 10106
#define Mtr_GetCmdError 10139
#define Mtr_StAutoRdy 10172
#define Mtr_StServoRdy 10205
#define Mtr_CompExeProgRun 10238
#define Mtr_CompProgRun 10271
#define Mtr_CompExtraWindProgRun 10304
#define Mach_SetMoveRdyTa 10305
#define Mach_SetMoveRdySpd 10306
#define Mtr_ChkMoveRdyPos 10307
#define Mtr_SetMoveRdyTa 10340
#define Mtr_SetMoveRdySpd 10373
#define Mtr_SetMoveRdyPos 10406
#define Mtr_SetMoveTargetPos 10439
#define Mtr_SetMoveRemainDist 10472
#define Mtr_CompMovePos 10505
#define Mtr_ChkPosSetPos 10538
#define Mtr_ChkPosMoveRdyPos 10571
#define Mtr_SetBasicTa 10604
#define Mtr_SetBasicMoveSpd 10605
#define Mtr_SetBasicJogMoveSpd 10606
#define Mtr_SetBasicHomeSpd 10607
#define Mtr_GetHomeFlag 8292
#define HomeAllComplete 10608
#define LSTAGE_AreaSenPauseCmd 10609
#define RSTAGE_AreaSenPauseCmd 10610
#define Mtr_SetEcatTouchprobeFunction 8325
#define Mtr_SetEcatTouchprobeStatus 8358
#define Mtr_SetEcatErrorReset 8391
#define Mtr_SetEcatSerovoOut 8424
#define Mtr_SetTouchprobeFunctionValue 10611
#define Mtr_SaftyCheckTargetPos 10644
#define Mach_GetStatus 10677
#define Mtr_ExeManualCmd 10678
#define Temp_Mtr_ExeManualCmd 10711
#define Part_StAutoReady 10744
#define Part_BitStNotAutoReady 10777
#define Mach_ExeCmdStep 10810
#define Mach_Chk1CycleCmd 10880
#define Mach_ChkCmdStepReady 10950
#define Mach_CmdErrorCode 11020
#define Mach_CtsChkPartError 11090
#define Mach_CtsChkMtrError 11091
#define Mach_CtsChkUnitError 11092
#define Mach_CtsChkSeqError 11093
#define Mach_CtsChkRobotPosError 11094
#define Mach_ExeCmdErrorReset 11095
#define Mach_ExeCmdReset 11096
#define Mach_ExeRcpDataUpdate 11097
#define Seq_ExeCmdStep 11098
#define Temp_Seq_ExeCmdStep 11168
#define Test_Seq_ExeCmdStep 11238
#define Part_ExeCmdStep 11308
#define Part_ChkCmdStepReady 11378
#define Part_BitCmdStepNotReady 11448
#define Part_CmdErrorCode 11518
#define Part_StAmpEnable 11588
#define Part_StCompHome 11658
#define Part_StCompServoRdy 11728
#define Part_StCompAutoRdy 11798
#define Temp_Part_StAmpEnable 11868
#define Temp_Part_StCompHome 11938
#define Temp_Part_StCompServoRdy 12008
#define Temp_Part_StCompAutoRdy 12078
#define Unit_ExeCmdStep 12148
#define Temp_Unit_ExeCmdStep 12218
#define Unit_ReqCmd 12288
#define Unit_LockCmd 12358
#define Unit_StErrorStatus 12428
#define Temp_Unit_StErrorStatus 12498
#define Unit_CmdErrorCode 12568
#define Ready_ExeCmdStep 12638
#define Temp_Ready_ExeCmdStep 12708
#define Part_StAutoRdy 12778
#define Part_StMtrServoRdy 12848
#define Part_StErrorStatus 12918
#define Temp_Part_StErrorStatus 12988
#define Part_ExeCmdReadyStep 13058
#define Temp_Part_ExeCmdReadyStep 13128
#define Part_CmdReadyError 13198
#define Temp_CtsStCompHome 13268
#define Temp_ChkMotorErr 13269
#define Temp_CtsStCompReady 13270
#define Temp_ChkReadyMotorErr 13271
#define Unit_AutoStartReadySt 13272
#define Mach_MotorAllServoOn 13342
#define Mach_MotorAllServoOff 13343
#define Exe_ResetLamp_On 13344
#define Exe_ResetLamp_FlickOn 13345
#define Temp_Exe_ResetLamp_FlickOn 13346
#define Exe_LeftStartLamp_On 13347
#define Exe_LeftStartLamp_FlickOn 13348
#define Temp_Exe_LeftStartLamp_FlickOn 13349
#define Exe_RightStartLamp_On 13350
#define Exe_RightStartLamp_FlickOn 13351
#define Temp_Exe_RightStartLamp_FlickOn 13352
#define Temp_SinalTower_Buzzer 13353
#define Temp_AreaSenErrStatus 13354
#define Temp_MainDoorSenErrStatus 13355
#define Temp_SideDooerSenErrStatus 13356
#define Temp_LeftPressureSenErrStatus 13357
#define Temp_RightPressureSenErrStatus 13358
#define Temp_PressureSenErrStatus 13359
#define Temp_LeakSenErrStatus 13360
#define Temp_LstageSaftyMvErrStatus 13361
#define Temp_LstageSaftyValueErrStatus 13362
#define Temp_RstageSaftyMvErrStatus 13363
#define Temp_RstageSaftyValueErrStatus 13364
#define Safety_ErrorCheck 13365
#define AutoRun_NotStopErrBit 13366
#define Temp_SafetyStopErrNotClearStatus 13367
#define Temp_SafetyEMOErrNotClearStatus 13368
#define Temp_PressureSenUnUse 13369
#define Temp_LeakSenUnUse 13370
#define Temp_SaftyPosCheckUnUse 13371
#define test_Mode 13372
#define Half_test_Mode 13373
#define test_ModeDataUndate 13374
#define Temp_MaxAccData 13375
#define Temp_Lstage_SaftyMvCheck 13376
#define Temp_Rstage_SaftyMvCheck 13377
#define Temp_Lstage_SaftyValueCheck 13378
#define Temp_Rstage_SaftyValueCheck 13379
#define Temp_Lstage_AutoRunStatus 13380
#define Temp_Rstage_AutoRunStatus 13381
#define Temp_Lstage_AutoRdyServoZPos 13382
#define Temp_Rstage_AutoRdyServoZPos 13383
#define Temp_Mtr_CheckReadyPos 13384
#define Temp_Mtr_CheckLAlign01Pos 13417
#define Temp_Mtr_CheckLAlign02Pos 13450
#define Temp_Mtr_CheckLAlign03Pos 13483
#define Temp_Mtr_CheckLAlign04Pos 13516
#define Temp_Mtr_CheckRAlign01Pos 13549
#define Temp_Mtr_CheckRAlign02Pos 13582
#define Temp_Mtr_CheckRAlign03Pos 13615
#define Temp_Mtr_CheckRAlign04Pos 13648
#define Temp_Mtr_CheckAlign01Pos 13681
#define Temp_Mtr_CheckAlign02Pos 13714
#define Temp_Mtr_CheckAlign03Pos 13747
#define Temp_Mtr_CheckAlign04Pos 13780
#define Temp_Mtr_CheckPowerMeterPos 13813
#define Temp_Mtr_CheckLoadingPos 13846
#define Temp_Mtr_CheckWorkStartPos 13879
#define Temp_Mtr_CheckLLoadingPos 13912
#define Temp_Mtr_CheckRLoadingPos 13945
#define Temp_Mtr_CheckLWorkStartPos 13978
#define Temp_Mtr_CheckRWorkStartPos 14011
#define MotionDownloadTimeOut 14044
#define U2P_Mt01_ErrCode 3550
#define U2P_Mt02_ErrCode 3551
#define U2P_Mt03_ErrCode 3552
#define U2P_Mt05_ErrCode 3554
#define U2P_AllUnit_ErrCode 3650
#define U2P_LStage_ErrCode 3651
#define U2P_RStage_ErrCode 3652
#define U2P_Mach_ErrCode 3750
#define U2P_Part_ErrCode 3751
#define MC_MoveJogP_In_Axis 14045
#define MC_MoveJogP_In_MaxPosition 14078
#define MC_MoveJogP_In_AccTime 14111
#define MC_MoveJogP_In_Velocity 14144
#define MC_MoveJogN_In_Axis 14177
#define MC_MoveJogN_In_MinPosition 14210
#define MC_MoveJogN_In_AccTime 14243
#define MC_MoveJogN_In_Velocity 14276
#define MC_MoveAbs_In_Axis 14309
#define MC_MoveAbs_In_MaxPosition 14342
#define MC_MoveAbs_In_MinPosition 14375
#define MC_MoveAbs_In_Position 14408
#define MC_MoveAbs_In_AccTime 14441
#define MC_MoveAbs_In_Velocity 14474
#define MC_MoveAbs_Ot_DesMovePosition 14507
#define MC_MoveAbs_Ot_MovePosition 14540
#define MC_MoveInc_In_Axis 14573
#define MC_MoveInc_In_MaxPosition 14606
#define MC_MoveInc_In_MinPosition 14639
#define MC_MoveInc_In_Position 14672
#define MC_MoveInc_In_AccTime 14705
#define MC_MoveInc_In_Velocity 14738
#define MC_MoveInc_Ot_DesMovePosition 14771
#define MC_MoveInc_Ot_MovePosition 14804
#define MC_MoveStop_In_DecTime 14837
#define Mtr_Chk_ExeRdyErr_In_Cmd 14870
#define Mtr_Chk_ExeRdyErr_Ot_Error 14903
#define Mtr_Chk_ExeRdyErr_Ot_ErrorID 14936
#define Mtr_Chk_ExeEndErr_In_Cmd 14969
#define Mtr_Chk_ExeEndErr_Ot_Error 15002
#define Mtr_Chk_ExeEndErr_Ot_ErrorID 15035
#define Mtr_Cmd_StepHomeProg_In_HomeJogVel 15068
#define Mtr_Cmd_StepHomeProg_In_HomeJogTa 15101
#define Mtr_Cmd_StepHomeProg_In_HomeVel 15134
#define Mtr_Cmd_StepHomeProg_In_HomeOffset 15167
#define Mtr_Cmd_StepHomeProg_In_UseLimit 15200
#define Mtr_Cmd_StepHomeProg_In_TimeOutTime 15233
#define Mtr_Chk_AllAmpEna_Ot_Ena 15266
#define Mtr_Chk_AllAmpEna_Ot_Temp 15299
#define Mtr_Chk_AllCompHome_Ot_Comp 15332
#define Mtr_Chk_AllCompHome_Ot_Temp 15365
#define Mtr_Chk_AllMoving_Ot_Moving 15398
#define Mtr_Chk_AllMoving_Ot_Temp 15431
#define Mtr_Chk_AllErr_Ot_Err 15464
#define Mtr_Chk_AllErr_Ot_Temp 15497
#define MTR_Err_LimitErr_Ot_State 15530
#define Mtr_Set_GateSetup_In_Word_SetGate 15563
#define Mtr_Set_GateSetup_In_GateNum 15596
#define Mtr_Set_GateSetup_In_ChanNum 15629
#define Mtr_Set_MtWord_Setup_In_AbortAcc 15662
#define Mtr_Set_MtWord_Setup_In_ProgMaxSpeed 15695
#define Mtr_Set_MtWord_Setup_In_ProgMaxAcc 15728
#define Mtr_Set_HomeWord_Setup_In_CaptCtrl 15761
#define Mtr_Set_HomeWord_Setup_In_CaptFlag 15794
#define AUTO_CHK_MtCmdEnd_Ot_Temp 15827
#define AUTO_CHK_MtCmdEnd_Ot_Comp 15860
#define AUTO_CHK_MtCmdEnd_Ot_Error 15893
#define AUTO_CHK_CmdEnd_Ot_Temp 15926
#define AUTO_CHK_CmdEnd_Ot_Comp 15959
#define AUTO_CHK_CmdEnd_Ot_Error 15992
#define AUTO_CHK_HostTimeBaseDone_Ot_Temp 16025
#define AUTO_CHK_HostTimeBaseDone_Ot_Comp 16058
#define Mach_SetSubProgUpdateTime 16091
#define Mach_SetSubProgWaitCycle 16092
#define LinearX_Mtr_HomeOffset 1104
#define LStageY_Mtr_HomeOffset 1204
#define RStageY_Mtr_HomeOffset 1304
#define ServoZ_Mtr_HomeOffset 1504
#endif
#endif
#endif //_PP_PROJ_H_
