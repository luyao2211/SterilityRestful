using SterilityRestful.CommonLibrary;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.DataMethod
{
    public class ResultMethod
    {
        /// <summary>
        /// 检测结果录入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="ObjectNo"></param>
        /// <param name="ObjCompany"></param>
        /// <param name="ObjIncuSeq"></param>
        /// <param name="TestType"></param>
        /// <param name="TestStand"></param>
        /// <param name="TestEquip"></param>
        /// <param name="TestEquip2"></param>
        /// <param name="Description"></param>
        /// <param name="ProcessStart"></param>
        /// <param name="ProcessEnd"></param>
        /// <param name="CollectStart"></param>
        /// <param name="CollectEnd"></param>
        /// <param name="TestTime"></param>
        /// <param name="TestResult"></param>
        /// <param name="TestPeople"></param>
        /// <param name="TestPeople2"></param>
        /// <param name="ReStatus"></param>
        /// <param name="RePeople"></param>
        /// <param name="ReTime"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <param name="FormerStep"></param>
        /// <param name="NowStep"></param>
        /// <param name="LaterStep"></param>
        /// <returns></returns>
        public int ResTestResultSetData(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string TestEquip2, string Description, DateTime ProcessStart, DateTime ProcessEnd, DateTime CollectStart, DateTime CollectEnd, DateTime TestTime, string TestResult, string TestPeople, string TestPeople2, int ReStatus, string RePeople, string ReTime, string TerminalIP, string TerminalName, string revUserId, string FormerStep, string NowStep, string LaterStep)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                DateTime? processEnd = ProcessEnd;
                DateTime? collectStart = CollectStart;
                DateTime? collectEnd = CollectEnd;
                DateTime? testTime = TestTime;
                if (ProcessEnd == new DateTime())
                {
                    processEnd = null;
                }
                if (CollectStart == new DateTime())
                {
                    collectStart = null;
                }
                if (CollectEnd == new DateTime())
                {
                    collectEnd = null;
                }
                if (TestTime == new DateTime())
                {
                    testTime = null;
                }
                Result = Convert.ToInt32(Rs.ResTestResult.SetData(pclsCache.CacheConnectionObject, TestId, ObjectNo, ObjCompany, ObjIncuSeq, TestType, TestStand, TestEquip, TestEquip2, Description, ProcessStart, processEnd, collectStart, collectEnd, testTime, TestResult, TestPeople, TestPeople2, ReStatus, RePeople, ReTime, TerminalIP, TerminalName, revUserId, FormerStep, NowStep, LaterStep));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResTestResultSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 检测结果创建
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="ObjectNo"></param>
        /// <param name="ObjCompany"></param>
        /// <param name="ObjIncuSeq"></param>
        /// <param name="Reagent1"></param>
        /// <param name="Reagent2"></param>
        /// <param name="ProcessStart"></param>
        /// <param name="TestPeople"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ResTestResultCreateResult(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string Reagent1, string Reagent2, DateTime ProcessStart, string TestPeople, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Rs.ResTestResult.CreateResult(pclsCache.CacheConnectionObject, ObjectNo, ObjCompany, ObjIncuSeq, Reagent1, Reagent2, ProcessStart, TestPeople, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResTestResultCreateResult", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到检测结果们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="ObjectNo"></param>
        /// <param name="ObjCompany"></param>
        /// <param name="ObjIncuSeq"></param>
        /// <param name="TestType"></param>
        /// <param name="TestStand"></param>
        /// <param name="TestEquip"></param>
        /// <param name="TestEquip2"></param>
        /// <param name="Description"></param>
        /// <param name="ProcessStartS"></param>
        /// <param name="ProcessStartE"></param>
        /// <param name="ProcessEndS"></param>
        /// <param name="ProcessEndE"></param>
        /// <param name="CollectStartS"></param>
        /// <param name="CollectStartE"></param>
        /// <param name="CollectEndS"></param>
        /// <param name="CollectEndE"></param>
        /// <param name="TestTimeS"></param>
        /// <param name="TestTimeE"></param>
        /// <param name="TestResult"></param>
        /// <param name="TestPeople"></param>
        /// <param name="TestPeople2"></param>
        /// <param name="ReStatus"></param>
        /// <param name="RePeople"></param>
        /// <param name="ReTimeS"></param>
        /// <param name="ReTimeE"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="FormerStep"></param>
        /// <param name="NowStep"></param>
        /// <param name="LaterStep"></param>
        /// <param name="GetObjectNo"></param>
        /// <param name="GetObjCompany"></param>
        /// <param name="GetObjIncuSeq"></param>
        /// <param name="GetTestType"></param>
        /// <param name="GetTestStand"></param>
        /// <param name="GetTestEquip"></param>
        /// <param name="GetTestEquip2"></param>
        /// <param name="GetDescription"></param>
        /// <param name="GetProcessStart"></param>
        /// <param name="GetProcessEnd"></param>
        /// <param name="GetCollectStart"></param>
        /// <param name="GetCollectEnd"></param>
        /// <param name="GetTestTime"></param>
        /// <param name="GetTestResult"></param>
        /// <param name="GetTestPeople"></param>
        /// <param name="GetTestPeople2"></param>
        /// <param name="GetReStatus"></param>
        /// <param name="GetRePeople"></param>
        /// <param name="GetReTime"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <param name="GetFormerStep"></param>
        /// <param name="GetNowStep"></param>
        /// <param name="GetLaterStep"></param>
        /// <returns></returns>
        public List<GetTestResultInfo> ResTestResultGetResultInfosByAnyProperty(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string TestEquip2, string Description, string ProcessStartS, string ProcessStartE, string ProcessEndS, string ProcessEndE, string CollectStartS, string CollectStartE, string CollectEndS, string CollectEndE, string TestTimeS, string TestTimeE, string TestResult, string TestPeople, string TestPeople2, string ReStatus, string RePeople, string ReTimeS, string ReTimeE, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, string FormerStep, string NowStep, string LaterStep, int GetObjectNo, int GetObjCompany, int GetObjIncuSeq, int GetTestType, int GetTestStand, int GetTestEquip, int GetTestEquip2, int GetDescription, int GetProcessStart, int GetProcessEnd, int GetCollectStart, int GetCollectEnd, int GetTestTime, int GetTestResult, int GetTestPeople, int GetTestPeople2, int GetReStatus, int GetRePeople, int GetReTime, int GetRevisionInfo, int GetFormerStep, int GetNowStep, int GetLaterStep)
        {
            List<GetTestResultInfo> list = new List<GetTestResultInfo>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Rs.ResTestResult.GetResultInfosByAnyProperty(pclsCache.CacheConnectionObject, TestId, ObjectNo, ObjCompany, ObjIncuSeq, TestType, TestStand, TestEquip, TestEquip2, Description, ProcessStartS, ProcessStartE, ProcessEndS, ProcessEndE, CollectStartS, CollectStartE, CollectEndS, CollectEndE, TestTimeS, TestTimeE, TestResult, TestPeople, TestPeople2, ReStatus, RePeople, ReTimeS, ReTimeE, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, FormerStep, NowStep, LaterStep, GetObjectNo, GetObjCompany, GetObjIncuSeq, GetTestType, GetTestStand, GetTestEquip, GetTestEquip2, GetDescription, GetProcessStart, GetProcessEnd, GetCollectStart, GetCollectEnd, GetTestTime, GetTestResult, GetTestPeople, GetTestPeople2, GetReStatus, GetRePeople, GetReTime, GetRevisionInfo, GetFormerStep, GetNowStep, GetLaterStep);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetTestResultInfo testResultInfo = new GetTestResultInfo();
                    if (ret[0] != "")
                    {
                        testResultInfo.TestId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        testResultInfo.ObjectNo = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        testResultInfo.ObjCompany = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        testResultInfo.ObjIncuSeq = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        testResultInfo.TestType = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        testResultInfo.TestStand = ret[5];
                    }
                    if (ret[6] != "")
                    {
                        testResultInfo.TestEquip = ret[6];
                    }
                    if (ret[7] != "")
                    {
                        testResultInfo.TestEquip2 = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        testResultInfo.Description = ret[8];
                    }
                    if (ret[9] != "")
                    {
                        testResultInfo.ProcessStart = Convert.ToDateTime(ret[9]);
                    }
                    if (ret[10] != "")
                    {
                        testResultInfo.ProcessEnd = Convert.ToDateTime(ret[10]);
                    }
                    if (ret[11] != "")
                    {
                        testResultInfo.CollectStart = Convert.ToDateTime(ret[11]);
                    }
                    if (ret[12] != "")
                    {
                        testResultInfo.CollectEnd = Convert.ToDateTime(ret[12]);
                    }
                    if (ret[13] != "")
                    {
                        testResultInfo.TestTime = Convert.ToDateTime(ret[13]);
                    }
                    if (ret[14] != "")
                    {
                        testResultInfo.TestResult = ret[14];
                    }
                    if (ret[15] != "")
                    {
                        testResultInfo.TestPeople = ret[15];
                    }
                    if (ret[16] != "")
                    {
                        testResultInfo.TestPeople2 = ret[16];
                    }
                    if (ret[17] != "")
                    {
                        testResultInfo.ReStatus = Convert.ToInt32(ret[17]);
                    }
                    if (ret[18] != "")
                    {
                        testResultInfo.RePeople = ret[18];
                    }
                    if (ret[19] != "")
                    {
                        testResultInfo.ReTime = ret[19];
                    }
                    if (ret[20] != "")
                    {
                        testResultInfo.revDateTime = Convert.ToDateTime(ret[20]);
                    }
                    if (ret[21] != "")
                    {
                        testResultInfo.TerminalIP = ret[21];
                    }
                    if (ret[22] != "")
                    {
                        testResultInfo.TerminalName = ret[22];
                    }
                    if (ret[23] != "")
                    {
                        testResultInfo.revUserId = ret[23];
                    }
                    if (ret[24] != "")
                    {
                        testResultInfo.revIdentify = ret[24];
                    }
                    if (ret[25] != "")
                    {
                        testResultInfo.FormerStep = ret[25];
                    }
                    if (ret[26] != "")
                    {
                        testResultInfo.NowStep = ret[26];
                    }
                    if (ret[27] != "")
                    {
                        testResultInfo.LaterStep = ret[27];
                    }
                    if (ret[28] != "")
                    {
                        testResultInfo.ObjectName = ret[28];
                    }
                    if (ret[29] != "" && ret[30] != "0")
                    {
                        testResultInfo.JinDu = Convert.ToInt32(ret[29]) * 100 / Convert.ToInt32(ret[30]);
                    }
                    if (ret[31] != "" &&ret[31] != "0000-00-00 00:00:00")
                    {
                        testResultInfo.EndTime = Convert.ToDateTime(ret[31]);
                    }
                    list.Add(testResultInfo);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResTestResultGetResultInfosByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 样品培养记录
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="TubeNo"></param>
        /// <param name="CultureId"></param>
        /// <param name="BacterId"></param>
        /// <param name="OtherRea"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="Place"></param>
        /// <param name="StartTime"></param>
        /// <param name="EndTime"></param>
        /// <param name="AnalResult"></param>
        /// <param name="PutinPeople"></param>
        /// <param name="PutoutPeople"></param>
        /// <param name="PutoutTime"></param>
        /// <returns></returns>
        public int ResIncubatorSetData(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string Place, string StartTime, string EndTime, string AnalResult, string PutinPeople, string PutoutPeople, DateTime PutoutTime)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                DateTime? putoutTime = PutoutTime;
                if (PutoutTime == new DateTime())
                {
                    putoutTime = null;
                }
                Result = Convert.ToInt32(Rs.ResIncubator.SetData(pclsCache.CacheConnectionObject, TestId, TubeNo, CultureId, BacterId, OtherRea, IncubatorId, Place, StartTime, EndTime, AnalResult, PutinPeople, PutoutPeople, putoutTime));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResIncubatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到样品培养记录们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="TubeNo"></param>
        /// <param name="CultureId"></param>
        /// <param name="BacterId"></param>
        /// <param name="OtherRea"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="Place"></param>
        /// <param name="StartTimeS"></param>
        /// <param name="StartTimeE"></param>
        /// <param name="EndTimeS"></param>
        /// <param name="EndTimeE"></param>
        /// <param name="AnalResult"></param>
        /// <param name="PutinPeople"></param>
        /// <param name="PutoutPeople"></param>
        /// <param name="PutoutTimeS"></param>
        /// <param name="PutoutTimeE"></param>
        /// <param name="GetCultureId"></param>
        /// <param name="GetBacterId"></param>
        /// <param name="GetOtherRea"></param>
        /// <param name="GetIncubatorId"></param>
        /// <param name="GetPlace"></param>
        /// <param name="GetStartTime"></param>
        /// <param name="GetEndTime"></param>
        /// <param name="GetAnalResult"></param>
        /// <param name="GetPutinPeople"></param>
        /// <param name="GetPutoutPeople"></param>
        /// <param name="GetPutoutTime"></param>
        /// <returns></returns>
        public List<ResIncubator> ResIncubatorGetResultTubesByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string Place, string StartTimeS, string StartTimeE, string EndTimeS, string EndTimeE, string AnalResult, string PutinPeople, string PutoutPeople, string PutoutTimeS, string PutoutTimeE, int GetCultureId, int GetBacterId, int GetOtherRea, int GetIncubatorId, int GetPlace, int GetStartTime, int GetEndTime, int GetAnalResult, int GetPutinPeople, int GetPutoutPeople, int GetPutoutTime)
        {
            List<ResIncubator> list = new List<ResIncubator>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Rs.ResIncubator.GetResultTubesByAnyProperty(pclsCache.CacheConnectionObject, TestId, TubeNo, CultureId, BacterId, OtherRea, IncubatorId, Place, StartTimeS, StartTimeE, EndTimeS, EndTimeE, AnalResult, PutinPeople, PutoutPeople, PutoutTimeS, PutoutTimeE, GetCultureId, GetBacterId, GetOtherRea, GetIncubatorId, GetPlace, GetStartTime, GetEndTime, GetAnalResult, GetPutinPeople, GetPutoutPeople, GetPutoutTime);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    ResIncubator resIncubator = new ResIncubator();
                    if (ret[0] != "")
                    {
                        resIncubator.TestId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        resIncubator.TubeNo = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        resIncubator.CultureId = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        resIncubator.BacterId = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        resIncubator.OtherRea = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        resIncubator.IncubatorId = ret[5];
                    }
                    if (ret[6] != "")
                    {
                        resIncubator.Place = ret[6];
                    }
                    if (ret[7] != "")
                    {
                        resIncubator.StartTime = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        resIncubator.EndTime = ret[8];
                    }
                    if (ret[9] != "")
                    {
                        resIncubator.AnalResult = ret[9];
                    }
                    if (ret[10] != "")
                    {
                        resIncubator.PutinPeople = ret[10];
                    }
                    if (ret[11] != "")
                    {
                        resIncubator.PutoutPeople = ret[11];
                    }
                    if (ret[12] != "")
                    {
                        resIncubator.PutoutTime = Convert.ToDateTime(ret[12]);
                    }
                    list.Add(resIncubator);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResIncubatorGetResultTubesByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 机器视觉记录
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="TubeNo"></param>
        /// <param name="PictureId"></param>
        /// <param name="CameraTime"></param>
        /// <param name="ImageAddress"></param>
        /// <param name="AnalResult"></param>
        /// <returns></returns>
        public int ResTestPictureSetData(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, DateTime CameraTime, string ImageAddress, string AnalResult)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Rs.ResTestPicture.SetData(pclsCache.CacheConnectionObject, TestId, TubeNo, PictureId, CameraTime, ImageAddress, AnalResult));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResTestPictureSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到机器视觉检测们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="TubeNo"></param>
        /// <param name="PictureId"></param>
        /// <param name="CameraTimeS"></param>
        /// <param name="CameraTimeE"></param>
        /// <param name="ImageAddress"></param>
        /// <param name="AnalResult"></param>
        /// <param name="GetCameraTime"></param>
        /// <param name="GetImageAddress"></param>
        /// <param name="GetAnalResult"></param>
        /// <returns></returns>
        public List<ResTestPicture> ResTestPictureGetTestPicturesByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, string CameraTimeS, string CameraTimeE, string ImageAddress, string AnalResult, int GetCameraTime, int GetImageAddress, int GetAnalResult)
        {
            List<ResTestPicture> list = new List<ResTestPicture>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Rs.ResTestPicture.GetTestPicturesByAnyProperty(pclsCache.CacheConnectionObject, TestId, TubeNo, PictureId, CameraTimeS, CameraTimeE, ImageAddress, AnalResult, GetCameraTime, GetImageAddress, GetAnalResult);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    ResTestPicture resTestPicture = new ResTestPicture();
                    if (ret[0] != "")
                    {
                        resTestPicture.TestId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        resTestPicture.TubeNo = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        resTestPicture.PictureId = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        resTestPicture.CameraTime = Convert.ToDateTime(ret[3]);
                    }
                    if (ret[4] != "")
                    {
                        resTestPicture.ImageAddress = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        resTestPicture.AnalResult = ret[5];
                    }
                    list.Add(resTestPicture);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResTestPictureGetTestPicturesByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 顶空分析记录
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="TubeNo"></param>
        /// <param name="PictureId"></param>
        /// <param name="CameraTime"></param>
        /// <param name="AnalResult"></param>
        /// <returns></returns>
        public int ResTopAnalysisSetData(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, DateTime CameraTime, string AnalResult)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Rs.ResTopAnalysis.SetData(pclsCache.CacheConnectionObject, TestId, TubeNo, PictureId, CameraTime, AnalResult));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResTopAnalysisSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到顶空分析们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="TubeNo"></param>
        /// <param name="PictureId"></param>
        /// <param name="CameraTimeS"></param>
        /// <param name="CameraTimeE"></param>
        /// <param name="AnalResult"></param>
        /// <param name="GetCameraTime"></param>
        /// <param name="GetAnalResult"></param>
        /// <returns></returns>
        public List<ResTopAnalysis> ResTopAnalysisGetTopAnalysisByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, string CameraTimeS, string CameraTimeE, string AnalResult, int GetCameraTime, int GetAnalResult)
        {
            List<ResTopAnalysis> list = new List<ResTopAnalysis>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Rs.ResTopAnalysis.GetTopAnalysisByAnyProperty(pclsCache.CacheConnectionObject, TestId, TubeNo, PictureId, CameraTimeS, CameraTimeE, AnalResult, GetCameraTime, GetAnalResult);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    ResTopAnalysis resTopAnalysis = new ResTopAnalysis();
                    if (ret[0] != "")
                    {
                        resTopAnalysis.TestId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        resTopAnalysis.TubeNo = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        resTopAnalysis.PictureId = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        resTopAnalysis.CameraTime = Convert.ToDateTime(ret[3]);
                    }
                    if (ret[4] != "")
                    {
                        resTopAnalysis.AnalResult = ret[4];
                    }
                    list.Add(resTopAnalysis);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResTopAnalysisGetTopAnalysisByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 故障信息记录
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="BreakId"></param>
        /// <param name="BreakTime"></param>
        /// <param name="BreakEquip"></param>
        /// <param name="BreakPara"></param>
        /// <param name="BreakValue"></param>
        /// <param name="BreakReason"></param>
        /// <param name="ResponseTime"></param>
        /// <returns></returns>
        public int BreakDownSetData(DataConnection pclsCache, string BreakId, DateTime BreakTime, string BreakEquip, string BreakPara, string BreakValue, string BreakReason, DateTime ResponseTime)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                DateTime? responseTime = ResponseTime;
                if (responseTime == new DateTime())
                {
                    responseTime = null;
                }
                Result = Convert.ToInt32(Rs.BreakDown.SetData(pclsCache.CacheConnectionObject, BreakId, BreakTime, BreakEquip, BreakPara, BreakValue, BreakReason, responseTime));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.BreakDownSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }
        
        /// <summary>
        /// 根据任何筛选条件得到故障们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="BreakId"></param>
        /// <param name="BreakTimeS"></param>
        /// <param name="BreakTimeE"></param>
        /// <param name="BreakEquip"></param>
        /// <param name="BreakPara"></param>
        /// <param name="BreakValue"></param>
        /// <param name="BreakReason"></param>
        /// <param name="ResponseTimeS"></param>
        /// <param name="ResponseTimeE"></param>
        /// <param name="GetBreakTime"></param>
        /// <param name="GetBreakEquip"></param>
        /// <param name="GetBreakPara"></param>
        /// <param name="GetBreakValue"></param>
        /// <param name="GetBreakReason"></param>
        /// <param name="GetResponseTime"></param>
        /// <returns></returns>
        public List<BreakDown> BreakDownGetBreakDownsByAnyProperty(DataConnection pclsCache, string BreakId, string BreakTimeS, string BreakTimeE, string BreakEquip, string BreakPara, string BreakValue, string BreakReason, string ResponseTimeS, string ResponseTimeE, int GetBreakTime, int GetBreakEquip, int GetBreakPara, int GetBreakValue, int GetBreakReason, int GetResponseTime)
        {
            List<BreakDown> list = new List<BreakDown>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Rs.BreakDown.GetBreakDownsByAnyProperty(pclsCache.CacheConnectionObject, BreakId, BreakTimeS, BreakTimeE, BreakEquip, BreakPara, BreakValue, BreakReason, ResponseTimeS, ResponseTimeE, GetBreakTime, GetBreakEquip, GetBreakPara, GetBreakValue, GetBreakReason, GetResponseTime);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    BreakDown breakDown = new BreakDown();
                    if (ret[0] != "")
                    {
                        breakDown.BreakId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        breakDown.BreakTime = Convert.ToDateTime(ret[1]);
                    }
                    if (ret[2] != "")
                    {
                        breakDown.BreakEquip = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        breakDown.BreakPara = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        breakDown.BreakValue = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        breakDown.BreakReason = ret[5];
                    }
                    if (ret[6] != "")
                    {
                        breakDown.ResponseTime = Convert.ToDateTime(ret[6]);
                    }
                    list.Add(breakDown);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.BreakDownGetBreakDownsByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }
    }
}
