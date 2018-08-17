using System;

namespace SterilityRestful.DataModels
{
    public class ResultInfo
    {
    }

    public class TestResultInfo
    {
        public string TestId { get; set; }
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string ObjIncuSeq { get; set; }
        public string TestType { get; set; }
        public string TestStand { get; set; }
        public string TestEquip { get; set; }
        public string TestEquip2 { get; set; }
        public string Description { get; set; }
        public DateTime ProcessStart { get; set; }
        public DateTime ProcessEnd { get; set; }
        public DateTime CollectStart { get; set; }
        public DateTime CollectEnd { get; set; }
        public DateTime TestTime { get; set; }
        public string TestResult { get; set; }
        public string TestPeople { get; set; }
        public string TestPeople2 { get; set; }
        public int ReStatus { get; set; }
        public string RePeople { get; set; }
        public string ReTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string FormerStep { get; set; }
        public string NowStep { get; set; }
        public string LaterStep { get; set; }
    }

    public class CreateResultInfo
    {
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string ObjIncuSeq { get; set; }
        public string Reagent1 { get; set; }
        public string Reagent2 { get; set; }
        public DateTime ProcessStart { get; set;}
        public string TestPeople { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class GetTestResultInfo
    {
        public string TestId { get; set; }
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string ObjIncuSeq { get; set; }
        public string TestType { get; set; }
        public string TestStand { get; set; }
        public string TestEquip { get; set; }
        public string TestEquip2 { get; set; }
        public string Description { get; set; }
        public DateTime ProcessStart { get; set; }
        public DateTime ProcessEnd { get; set; }
        public DateTime CollectStart { get; set; }
        public DateTime CollectEnd { get; set; }
        public DateTime TestTime { get; set; }
        public string TestResult { get; set; }
        public string TestPeople { get; set; }
        public string TestPeople2 { get; set; }
        public int ReStatus { get; set; }
        public string RePeople { get; set; }
        public string ReTime { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
        public string FormerStep { get; set; }
        public string NowStep { get; set; }
        public string LaterStep { get; set; }
        public string ObjectName { get; set; }
        public int JinDu { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class QueryTestResultInfo
    {
        public string TestId { get; set; }
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string ObjIncuSeq { get; set; }
        public string TestType { get; set; }
        public string TestStand { get; set; }
        public string TestEquip { get; set; }
        public string TestEquip2 { get; set; }
        public string Description { get; set; }
        public string ProcessStartS { get; set; }
        public string ProcessStartE { get; set; }
        public string ProcessEndS { get; set; }
        public string ProcessEndE { get; set; }
        public string CollectStartS { get; set; }
        public string CollectStartE { get; set; }
        public string CollectEndS { get; set; }
        public string CollectEndE { get; set; }
        public string TestTimeS { get; set; }
        public string TestTimeE { get; set; }
        public string TestResult { get; set; }
        public string TestPeople { get; set; }
        public string TestPeople2 { get; set; }
        public string ReStatus { get; set; }
        public string RePeople { get; set; }
        public string ReTimeS { get; set; }
        public string ReTimeE { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public string FormerStep { get; set; }
        public string NowStep { get; set; }
        public string LaterStep { get; set; }
        public int GetObjectNo { get; set; }
        public int GetObjCompany { get; set; }
        public int GetObjIncuSeq { get; set; }
        public int GetTestType { get; set; }
        public int GetTestStand { get; set; }
        public int GetTestEquip { get; set; }
        public int GetTestEquip2 { get; set; }
        public int GetDescription { get; set; }
        public int GetProcessStart { get; set; }
        public int GetProcessEnd { get; set; }
        public int GetCollectStart { get; set; }
        public int GetCollectEnd { get; set; }
        public int GetTestTime { get; set; }
        public int GetTestResult { get; set; }
        public int GetTestPeople { get; set; }
        public int GetTestPeople2 { get; set; }
        public int GetReStatus { get; set; }
        public int GetRePeople { get; set; }
        public int GetReTime { get; set; }
        public int GetRevisionInfo { get; set; }
        public int GetFormerStep { get; set; }
        public int GetNowStep { get; set; }
        public int GetLaterStep { get; set; }
    }

    public class ResIncubator
    {
        public string TestId { get; set; }
        public string TubeNo { get; set; }
        public string CultureId { get; set; }
        public string BacterId { get; set; }
        public string OtherRea { get; set; }
        public string IncubatorId { get; set; }
        public string Place { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string AnalResult { get; set; }
        public string PutinPeople { get; set; }
        public string PutoutPeople { get; set; }
        public DateTime PutoutTime { get; set; }
    }

    public class QueryResIncubator
    {
        public string TestId { get; set; }
        public string TubeNo { get; set; }
        public string CultureId { get; set; }
        public string BacterId { get; set; }
        public string OtherRea { get; set; }
        public string IncubatorId { get; set; }
        public string Place { get; set; }
        public string StartTimeS { get; set; }
        public string StartTimeE { get; set; }
        public string EndTimeS { get; set; }
        public string EndTimeE { get; set; }
        public string AnalResult { get; set; }
        public string PutinPeople { get; set; }
        public string PutoutPeople { get; set; }
        public string PutoutTimeS { get; set; }
        public string PutoutTimeE { get; set; }
        public int GetCultureId { get; set; }
        public int GetBacterId { get; set; }
        public int GetOtherRea { get; set; }
        public int GetIncubatorId { get; set; }
        public int GetPlace { get; set; }
        public int GetStartTime { get; set; }
        public int GetEndTime { get; set; }
        public int GetAnalResult { get; set; }
        public int GetPutinPeople { get; set; }
        public int GetPutoutPeople { get; set; }
        public int GetPutoutTime { get; set; }
    }

    public class ResTestPicture
    {
        public string TestId { get; set; }
        public string TubeNo { get; set; }
        public string PictureId { get; set; }
        public DateTime CameraTime { get; set; }
        public string ImageAddress { get; set; }
        public string AnalResult { get; set; }
    }

    public class QueryResTestPicture
    {
        public string TestId { get; set; }
        public string TubeNo { get; set; }
        public string PictureId { get; set; }
        public string CameraTimeS { get; set; }
        public string CameraTimeE { get; set; }
        public string ImageAddress { get; set; }
        public string AnalResult { get; set; }
        public int GetCameraTime { get; set; }
        public int GetImageAddress { get; set; }
        public int GetAnalResult { get; set; }
    }

    public class ResTopAnalysis
    {
        public string TestId { get; set; }
        public string TubeNo { get; set; }
        public string PictureId { get; set; }
        public DateTime CameraTime { get; set; }
        public string AnalResult { get; set; }
    }

    public class QueryResTopAnalysis
    {
        public string TestId { get; set; }
        public string TubeNo { get; set; }
        public string PictureId { get; set; }
        public string CameraTimeS { get; set; }
        public string CameraTimeE { get; set; }
        public string AnalResult { get; set; }
        public int GetCameraTime { get; set; }
        public int GetAnalResult { get; set; }
    }

    public class BreakDown
    {
        public string BreakId { get; set; }
        public DateTime BreakTime { get; set; }
        public string BreakEquip { get; set; }
        public string BreakPara { get; set; }
        public string BreakValue { get; set; }
        public string BreakReason { get; set; }
        public DateTime ResponseTime { get; set; }
    }

    public class QueryBreakDown
    {
        public string BreakId { get; set; }
        public string BreakTimeS { get; set; }
        public string BreakTimeE { get; set; }
        public string BreakEquip { get; set; }
        public string BreakPara { get; set; }
        public string BreakValue { get; set; }
        public string BreakReason { get; set; }
        public string ResponseTimeS { get; set; }
        public string ResponseTimeE { get; set; }
        public int GetBreakTime { get; set; }
        public int GetBreakEquip { get; set; }
        public int GetBreakPara { get; set; }
        public int GetBreakValue { get; set; }
        public int GetBreakReason { get; set; }
        public int GetResponseTime { get; set; }
    }
}
