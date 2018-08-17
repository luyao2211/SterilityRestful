using SterilityRestful.CommonLibrary;
using SterilityRestful.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SterilityRestful.DataModels;

namespace SterilityRestful.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*"), WebApiTracker]
    public class ResultController : ApiController
    {
        static readonly IResultRepository repository = new ResultRepository();
        DataConnection pclsCache = new DataConnection();

        /// <summary>
        /// 检测结果录入
        /// </summary>
        /// <param name="testResult"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestResultSetData")]
        public object ResTestResultSetData(TestResultInfo testResultInfo)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            int ret = repository.ResTestResultSetData(pclsCache, testResultInfo.TestId, testResultInfo.ObjectNo, testResultInfo.ObjCompany, testResultInfo.ObjIncuSeq, testResultInfo.TestType, testResultInfo.TestStand, testResultInfo.TestEquip, testResultInfo.TestEquip2, testResultInfo.Description, testResultInfo.ProcessStart, testResultInfo.ProcessEnd, testResultInfo.CollectStart, testResultInfo.CollectEnd, testResultInfo.TestTime, testResultInfo.TestResult, testResultInfo.TestPeople, testResultInfo.TestPeople2, testResultInfo.ReStatus, testResultInfo.RePeople, testResultInfo.ReTime, testResultInfo.TerminalIP, testResultInfo.TerminalName, testResultInfo.revUserId, testResultInfo.FormerStep, testResultInfo.NowStep, testResultInfo.LaterStep);
            return new ExceptionHandler().SetData(Request, ret);
        }

        [Route("Api/v1/Result/ResTestResultCreateResult")]
        public object ResTestResultCreateResult(CreateResultInfo createResultInfo)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            int ret = repository.ResTestResultCreateResult(pclsCache, createResultInfo.ObjectNo, createResultInfo.ObjCompany, createResultInfo.ObjIncuSeq, createResultInfo.Reagent1, createResultInfo.Reagent2, createResultInfo.ProcessStart, createResultInfo.TestPeople, createResultInfo.TerminalIP, createResultInfo.TerminalName, createResultInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到检测结果们的信息
        /// </summary>
        /// <param name="queryTestResultInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestResultGetResultInfosByAnyProperty")]
        public object ResTestResultGetResultInfosByAnyProperty(QueryTestResultInfo queryTestResultInfo)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.ResTestResultGetResultInfosByAnyProperty(pclsCache, queryTestResultInfo.TestId, queryTestResultInfo.ObjectNo, queryTestResultInfo.ObjCompany, queryTestResultInfo.ObjIncuSeq, queryTestResultInfo.TestType, queryTestResultInfo.TestStand, queryTestResultInfo.TestEquip, queryTestResultInfo.TestEquip2, queryTestResultInfo.Description, queryTestResultInfo.ProcessStartS, queryTestResultInfo.ProcessStartE, queryTestResultInfo.ProcessEndS, queryTestResultInfo.ProcessEndE, queryTestResultInfo.CollectStartS, queryTestResultInfo.CollectStartE, queryTestResultInfo.CollectEndS, queryTestResultInfo.CollectEndE, queryTestResultInfo.TestTimeS, queryTestResultInfo.TestTimeE, queryTestResultInfo.TestResult, queryTestResultInfo.TestPeople, queryTestResultInfo.TestPeople2, queryTestResultInfo.ReStatus, queryTestResultInfo.RePeople, queryTestResultInfo.ReTimeS, queryTestResultInfo.ReTimeE, queryTestResultInfo.ReDateTimeS, queryTestResultInfo.ReDateTimeE, queryTestResultInfo.ReTerminalIP, queryTestResultInfo.ReTerminalName, queryTestResultInfo.ReUserId, queryTestResultInfo.ReIdentify, queryTestResultInfo.FormerStep, queryTestResultInfo.NowStep, queryTestResultInfo.LaterStep, queryTestResultInfo.GetObjectNo, queryTestResultInfo.GetObjCompany, queryTestResultInfo.GetObjIncuSeq, queryTestResultInfo.GetTestType, queryTestResultInfo.GetTestStand, queryTestResultInfo.GetTestEquip, queryTestResultInfo.GetTestEquip2, queryTestResultInfo.GetDescription, queryTestResultInfo.GetProcessStart, queryTestResultInfo.GetProcessEnd, queryTestResultInfo.GetCollectStart, queryTestResultInfo.GetCollectEnd, queryTestResultInfo.GetTestTime, queryTestResultInfo.GetTestResult, queryTestResultInfo.GetTestPeople, queryTestResultInfo.GetTestPeople2, queryTestResultInfo.GetReStatus, queryTestResultInfo.GetRePeople, queryTestResultInfo.GetReTime, queryTestResultInfo.GetRevisionInfo, queryTestResultInfo.GetFormerStep, queryTestResultInfo.GetNowStep, queryTestResultInfo.GetLaterStep);
        }

        /// <summary>
        /// 样品培养记录
        /// </summary>
        /// <param name="resIncubator"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResIncubatorSetData")]
        public object ResIncubatorSetData(ResIncubator resIncubator)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            int ret = repository.ResIncubatorSetData(pclsCache, resIncubator.TestId, resIncubator.TubeNo, resIncubator.CultureId, resIncubator.BacterId, resIncubator.OtherRea, resIncubator.IncubatorId, resIncubator.Place, resIncubator.StartTime, resIncubator.EndTime, resIncubator.AnalResult, resIncubator.PutinPeople, resIncubator.PutoutPeople, resIncubator.PutoutTime);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到样品培养记录们的信息
        /// </summary>
        /// <param name="queryResIncubator"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResIncubatorGetResultTubesByAnyProperty")]
        public object ResIncubatorGetResultTubesByAnyProperty(QueryResIncubator queryResIncubator)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.ResIncubatorGetResultTubesByAnyProperty(pclsCache, queryResIncubator.TestId, queryResIncubator.TubeNo, queryResIncubator.CultureId, queryResIncubator.BacterId, queryResIncubator.OtherRea, queryResIncubator.IncubatorId, queryResIncubator.Place, queryResIncubator.StartTimeS, queryResIncubator.StartTimeE, queryResIncubator.EndTimeS, queryResIncubator.EndTimeE, queryResIncubator.AnalResult, queryResIncubator.PutinPeople, queryResIncubator.PutoutPeople, queryResIncubator.PutoutTimeS, queryResIncubator.PutoutTimeE, queryResIncubator.GetCultureId, queryResIncubator.GetBacterId, queryResIncubator.GetOtherRea, queryResIncubator.GetIncubatorId, queryResIncubator.GetPlace, queryResIncubator.GetStartTime, queryResIncubator.GetEndTime, queryResIncubator.GetAnalResult, queryResIncubator.GetPutinPeople, queryResIncubator.GetPutoutPeople, queryResIncubator.GetPutoutTime);
        }

        /// <summary>
        /// 机器视觉记录
        /// </summary>
        /// <param name="resTestPicture"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestPictureSetData")]
        public object ResTestPictureSetData(ResTestPicture resTestPicture)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            int ret = repository.ResTestPictureSetData(pclsCache, resTestPicture.TestId, resTestPicture.TubeNo, resTestPicture.PictureId, resTestPicture.CameraTime, resTestPicture.ImageAddress, resTestPicture.AnalResult);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到机器视觉检测们的信息
        /// </summary>
        /// <param name="queryResTestPicture"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestPictureGetTestPicturesByAnyProperty")]
        public object ResTestPictureGetTestPicturesByAnyProperty(QueryResTestPicture queryResTestPicture)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.ResTestPictureGetTestPicturesByAnyProperty(pclsCache, queryResTestPicture.TestId, queryResTestPicture.TubeNo, queryResTestPicture.PictureId, queryResTestPicture.CameraTimeS, queryResTestPicture.CameraTimeE, queryResTestPicture.ImageAddress, queryResTestPicture.AnalResult, queryResTestPicture.GetCameraTime, queryResTestPicture.GetImageAddress, queryResTestPicture.GetAnalResult);
        }

        /// <summary>
        /// 顶空分析记录
        /// </summary>
        /// <param name="resTopAnalysis"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTopAnalysisSetData")]
        public object ResTopAnalysisSetData(ResTopAnalysis resTopAnalysis)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            int ret = repository.ResTopAnalysisSetData(pclsCache, resTopAnalysis.TestId, resTopAnalysis.TubeNo, resTopAnalysis.PictureId, resTopAnalysis.CameraTime, resTopAnalysis.AnalResult);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到顶空分析们的信息
        /// </summary>
        /// <param name="queryResTopAnalysis"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTopAnalysisGetTopAnalysisByAnyProperty")]
        public object ResTopAnalysisGetTopAnalysisByAnyProperty(QueryResTopAnalysis queryResTopAnalysis)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.ResTopAnalysisGetTopAnalysisByAnyProperty(pclsCache, queryResTopAnalysis.TestId, queryResTopAnalysis.TubeNo, queryResTopAnalysis.PictureId, queryResTopAnalysis.CameraTimeS, queryResTopAnalysis.CameraTimeE, queryResTopAnalysis.AnalResult, queryResTopAnalysis.GetCameraTime, queryResTopAnalysis.GetAnalResult);
        }

        /// <summary>
        /// 故障信息记录
        /// </summary>
        /// <param name="breakDown"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/BreakDownSetData")]
        public object BreakDownSetData(BreakDown breakDown)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            int ret = repository.BreakDownSetData(pclsCache, breakDown.BreakId, breakDown.BreakTime, breakDown.BreakEquip, breakDown.BreakPara, breakDown.BreakValue, breakDown.BreakReason, breakDown.ResponseTime);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到故障们的信息
        /// </summary>
        /// <param name="queryBreakDown"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/BreakDownGetBreakDownsByAnyProperty")]
        public object BreakDownGetBreakDownsByAnyProperty(QueryBreakDown queryBreakDown)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.BreakDownGetBreakDownsByAnyProperty(pclsCache, queryBreakDown.BreakId, queryBreakDown.BreakTimeS, queryBreakDown.BreakTimeE, queryBreakDown.BreakEquip, queryBreakDown.BreakPara, queryBreakDown.BreakValue, queryBreakDown.BreakReason, queryBreakDown.ResponseTimeS, queryBreakDown.ResponseTimeE, queryBreakDown.GetBreakTime, queryBreakDown.GetBreakEquip, queryBreakDown.GetBreakPara, queryBreakDown.GetBreakValue, queryBreakDown.GetBreakReason, queryBreakDown.GetResponseTime);
        }
    }
}