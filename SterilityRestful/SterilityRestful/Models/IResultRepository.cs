using SterilityRestful.CommonLibrary;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public interface IResultRepository
    {
        int ResTestResultSetData(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string TestEquip2, string Description, DateTime ProcessStart, DateTime ProcessEnd, DateTime CollectStart, DateTime CollectEnd, DateTime TestTime, string TestResult, string TestPeople, string TestPeople2, int ReStatus, string RePeople, string ReTime, string TerminalIP, string TerminalName, string revUserId, string FormerStep, string NowStep, string LaterStep);

        int ResTestResultCreateResult(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string Reagent1, string Reagent2, DateTime ProcessStart, string TestPeople, string TerminalIP, string TerminalName, string revUserId);

        int ResIncubatorSetData(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string Place, string StartTime, string EndTime, string AnalResult, string PutinPeople, string PutoutPeople, DateTime PutoutTime);

        int ResTestPictureSetData(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, DateTime CameraTime, string ImageAddress, string AnalResult);

        int ResTopAnalysisSetData(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, DateTime CameraTime, string AnalResult);

        int BreakDownSetData(DataConnection pclsCache, string BreakId, DateTime BreakTime, string BreakEquip, string BreakPara, string BreakValue, string BreakReason, DateTime ResponseTime);

        List<GetTestResultInfo> ResTestResultGetResultInfosByAnyProperty(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string TestEquip2, string Description, string ProcessStarts, string ProcessStartE, string ProcessEndS, string ProcessEndE, string CollectStartS, string CollectStartE, string CollectEndS, string CollectEndE, string TestTimeS, string TestTimeE, string TestResult, string TestPeople, string TestPeople2, string ReStatus, string RePeople, string ReTimeS, string ReTimeE, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, string FormerStep, string NowStep, string LaterStep, int GetObjectNo, int GetObjCompany, int GetObjIncuSeq, int GetTestType, int GetTestStand, int GetTestEquip, int GetTestEquip2, int GetDescription, int GetProcessStart, int GetProcessEnd, int GetCollectStart, int GetCollectEnd, int GetTestTime, int GetTestResult, int GetTestPeople, int GetTestPeople2, int GetReStatus, int GetRePeople, int GetReTime, int GetRevisionInfo, int GetFormerStep, int GetNowStep, int GetLaterStep);

        List<ResIncubator> ResIncubatorGetResultTubesByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string Place, string StartTimeS, string StartTimeE, string EndTimeS, string EndTimeE, string AnalResult, string PutinPeople, string PutoutPeople, string PutoutTimeS, string PutoutTimeE, int GetCultureId, int GetBacterId, int GetOtherRea, int GetIncubatorId, int GetPlace, int GetStartTime, int GetEndTime, int GetAnalResult, int GetPutinPeople, int GetPutoutPeople, int GetPutoutTime);

        List<ResTestPicture> ResTestPictureGetTestPicturesByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, string CameraTimeS, string CameraTimeE, string ImageAddress, string AnalResult, int GetCameraTime, int GetImageAddress, int GetAnalResult);

        List<ResTopAnalysis> ResTopAnalysisGetTopAnalysisByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, string CameraTimeS, string CameraTimeE, string AnalResult, int GetCameraTime, int GetAnalResult);

        List<BreakDown> BreakDownGetBreakDownsByAnyProperty(DataConnection pclsCache, string BreakId, string BreakTimeS, string BreakTimeE, string BreakEquip, string BreakPara, string BreakValue, string BreakReason, string ResponseTimeS, string ResponseTimeE, int GetBreakTime, int GetBreakEquip, int GetBreakPara, int GetBreakValue, int GetBreakReason, int GetResponseTime);
    }
}
