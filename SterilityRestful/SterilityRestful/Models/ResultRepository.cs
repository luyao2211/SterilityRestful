using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public class ResultRepository : IResultRepository
    {
        ResultMethod ResultMethod = new ResultMethod();
        public int ResTestResultSetData(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string TestEquip2, string Description, DateTime ProcessStart, DateTime ProcessEnd, DateTime CollectStart, DateTime CollectEnd, DateTime TestTime, string TestResult, string TestPeople, string TestPeople2, int ReStatus, string RePeople, string ReTime, string TerminalIP, string TerminalName, string revUserId, string FormerStep, string NowStep, string LaterStep)
        {
            return ResultMethod.ResTestResultSetData(pclsCache, TestId, ObjectNo, ObjCompany, ObjIncuSeq, TestType, TestStand, TestEquip, TestEquip2, Description, ProcessStart, ProcessEnd, CollectStart, CollectEnd, TestTime, TestResult, TestPeople, TestPeople2, ReStatus, RePeople, ReTime, TerminalIP, TerminalName, revUserId, FormerStep, NowStep, LaterStep);
        }

        public int ResTestResultCreateResult(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string Reagent1, string Reagent2, DateTime ProcessStart, string TestPeople, string TerminalIP, string TerminalName, string revUserId)
        {
            return ResultMethod.ResTestResultCreateResult(pclsCache, ObjectNo, ObjCompany, ObjIncuSeq, Reagent1, Reagent2, ProcessStart, TestPeople, TerminalIP, TerminalName, revUserId);
        }

        public int ResIncubatorSetData(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string Place, string StartTime, string EndTime, string AnalResult, string PutinPeople, string PutoutPeople, DateTime PutoutTime)
        {
            return ResultMethod.ResIncubatorSetData(pclsCache, TestId, TubeNo, CultureId, BacterId, OtherRea, IncubatorId, Place, StartTime, EndTime, AnalResult, PutinPeople, PutoutPeople, PutoutTime);
        }

        public int ResTestPictureSetData(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, DateTime CameraTime, string ImageAddress, string AnalResult)
        {
            return ResultMethod.ResTestPictureSetData(pclsCache, TestId, TubeNo, PictureId, CameraTime, ImageAddress, AnalResult);
        }

        public int ResTopAnalysisSetData(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, DateTime CameraTime, string AnalResult)
        {
            return ResultMethod.ResTopAnalysisSetData(pclsCache, TestId, TubeNo, PictureId, CameraTime, AnalResult);
        }
        
        public int BreakDownSetData(DataConnection pclsCache, string BreakId, DateTime BreakTime, string BreakEquip, string BreakPara, string BreakValue, string BreakReason, DateTime ResponseTime)
        {
            return ResultMethod.BreakDownSetData(pclsCache, BreakId, BreakTime, BreakEquip, BreakPara, BreakValue, BreakReason, ResponseTime);
        }

        public List<GetTestResultInfo> ResTestResultGetResultInfosByAnyProperty(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string TestEquip2, string Description, string ProcessStartS, string ProcessStartE, string ProcessEndS, string ProcessEndE, string CollectStartS, string CollectStartE, string CollectEndS, string CollectEndE, string TestTimeS, string TestTimeE, string TestResult, string TestPeople, string TestPeople2, string ReStatus, string RePeople, string ReTimeS, string ReTimeE, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, string FormerStep, string NowStep, string LaterStep, int GetObjectNo, int GetObjCompany, int GetObjIncuSeq, int GetTestType, int GetTestStand, int GetTestEquip, int GetTestEquip2, int GetDescription, int GetProcessStart, int GetProcessEnd, int GetCollectStart, int GetCollectEnd, int GetTestTime, int GetTestResult, int GetTestPeople, int GetTestPeople2, int GetReStatus, int GetRePeople, int GetReTime, int GetRevisionInfo, int GetFormerStep, int GetNowStep, int GetLaterStep)
        {
            return ResultMethod.ResTestResultGetResultInfosByAnyProperty(pclsCache, TestId, ObjectNo, ObjCompany, ObjIncuSeq, TestType, TestStand, TestEquip, TestEquip2, Description, ProcessStartS, ProcessStartE, ProcessEndS, ProcessEndE, CollectStartS, CollectStartE, CollectEndS, CollectEndE, TestTimeS, TestTimeE, TestResult, TestPeople, TestPeople2, ReStatus, RePeople, ReTimeS, ReTimeE, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, FormerStep, NowStep, LaterStep, GetObjectNo, GetObjCompany, GetObjIncuSeq, GetTestType, GetTestStand, GetTestEquip, GetTestEquip2, GetDescription, GetProcessStart, GetProcessEnd, GetCollectStart, GetCollectEnd, GetTestTime, GetTestResult, GetTestPeople, GetTestPeople2, GetReStatus, GetRePeople, GetReTime, GetRevisionInfo, GetFormerStep, GetNowStep, GetLaterStep);
        }

        public List<ResIncubator> ResIncubatorGetResultTubesByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string Place, string StartTimeS, string StartTimeE, string EndTimeS, string EndTimeE, string AnalResult, string PutinPeople, string PutoutPeople, string PutoutTimeS, string PutoutTimeE, int GetCultureId, int GetBacterId, int GetOtherRea, int GetIncubatorId, int GetPlace, int GetStartTime, int GetEndTime, int GetAnalResult, int GetPutinPeople, int GetPutoutPeople, int GetPutoutTime)
        {
            return ResultMethod.ResIncubatorGetResultTubesByAnyProperty(pclsCache, TestId, TubeNo, CultureId, BacterId, OtherRea, IncubatorId, Place, StartTimeS, StartTimeE, EndTimeS, EndTimeE, AnalResult, PutinPeople, PutoutPeople, PutoutTimeS, PutoutTimeE, GetCultureId, GetBacterId, GetOtherRea, GetIncubatorId, GetPlace, GetStartTime, GetEndTime, GetAnalResult, GetPutinPeople, GetPutoutPeople, GetPutoutTime);
        }

        public List<ResTestPicture> ResTestPictureGetTestPicturesByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, string CameraTimeS, string CameraTimeE, string ImageAddress, string AnalResult, int GetCameraTime, int GetImageAddress, int GetAnalResult)
        {
            return ResultMethod.ResTestPictureGetTestPicturesByAnyProperty(pclsCache, TestId, TubeNo, PictureId, CameraTimeS, CameraTimeE, ImageAddress, AnalResult, GetCameraTime, GetImageAddress, GetAnalResult);
        }

        public List<ResTopAnalysis> ResTopAnalysisGetTopAnalysisByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, string CameraTimeS, string CameraTimeE, string AnalResult, int GetCameraTime, int GetAnalResult)
        {
            return ResultMethod.ResTopAnalysisGetTopAnalysisByAnyProperty(pclsCache, TestId, TubeNo, PictureId, CameraTimeS, CameraTimeE, AnalResult, GetCameraTime, GetAnalResult);
        }

        public List<BreakDown> BreakDownGetBreakDownsByAnyProperty(DataConnection pclsCache, string BreakId, string BreakTimeS, string BreakTimeE, string BreakEquip, string BreakPara, string BreakValue, string BreakReason, string ResponseTimeS, string ResponseTimeE, int GetBreakTime, int GetBreakEquip, int GetBreakPara, int GetBreakValue, int GetBreakReason, int GetResponseTime)
        {
            return ResultMethod.BreakDownGetBreakDownsByAnyProperty(pclsCache, BreakId, BreakTimeS, BreakTimeE, BreakEquip, BreakPara, BreakValue, BreakReason, ResponseTimeS, ResponseTimeE, GetBreakTime, GetBreakEquip, GetBreakPara, GetBreakValue, GetBreakReason, GetResponseTime);
        }
    }
}
