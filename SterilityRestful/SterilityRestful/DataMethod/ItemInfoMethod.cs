using SterilityRestful.CommonLibrary;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.DataMethod
{
    public class ItemInfoMethod
    {
        /// <summary>
        /// 无菌隔离器信息插入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IsolatorId"></param>
        /// <param name="ProductDay"></param>
        /// <param name="EquipPro"></param>
        /// <param name="InsDescription"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ItemIsolatorSetData(DataConnection pclsCache, string IsolatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.ItemIsolator.SetData(pclsCache.CacheConnectionObject, IsolatorId, ProductDay, EquipPro, InsDescription, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemIsolatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到无菌隔离器们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IsolatorId"></param>
        /// <param name="ProductDayS"></param>
        /// <param name="ProductDayE"></param>
        /// <param name="EquipPro"></param>
        /// <param name="InsDescription"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="GetProductDay"></param>
        /// <param name="GetEquipPro"></param>
        /// <param name="GetInsDescription"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <returns></returns>
        public List<GetIsolatorInfo> ItemIsolatorGetIsolatorsInfoByAnyProperty(DataConnection pclsCache, string IsolatorId, string ProductDayS, string ProductDayE, string EquipPro, string InsDescription, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetProductDay, int GetEquipPro, int GetInsDescription, int GetRevisionInfo)
        {
            List<GetIsolatorInfo> list = new List<GetIsolatorInfo>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = It.ItemIsolator.GetIsolatorsInfoByAnyProperty(pclsCache.CacheConnectionObject, IsolatorId, ProductDayS, ProductDayE, EquipPro, InsDescription, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetProductDay, GetEquipPro, GetInsDescription, GetRevisionInfo);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetIsolatorInfo isolatorInfo = new GetIsolatorInfo();
                    if (ret[0] != "")
                    {
                        isolatorInfo.IsolatorId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        isolatorInfo.ProductDay = Convert.ToDateTime(ret[1]);
                    }
                    if (ret[2] != "")
                    {
                        isolatorInfo.EquipPro = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        isolatorInfo.InsDescription = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        isolatorInfo.revDateTime = Convert.ToDateTime(ret[4]);
                    }
                    if (ret[5] != "")
                    {
                        isolatorInfo.TerminalIP = ret[5];
                    }
                    if (ret[6] != "")
                    {
                        isolatorInfo.TerminalName = ret[6];
                    }
                    if (ret[7] != "")
                    {
                        isolatorInfo.revUserId = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        isolatorInfo.revIdentify = ret[8];
                    }
                    list.Add(isolatorInfo);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemIsolatorGetIsolatorsInfoByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 培养箱信息插入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="ProductDay"></param>
        /// <param name="EquipPro"></param>
        /// <param name="InsDescription"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ItemIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.ItemIncubator.SetData(pclsCache.CacheConnectionObject, IncubatorId, ProductDay, EquipPro, InsDescription, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemIncubatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到培养箱们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="ProductDayS"></param>
        /// <param name="ProductDayE"></param>
        /// <param name="EquipPro"></param>
        /// <param name="InsDescription"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="GetProductDay"></param>
        /// <param name="GetEquipPro"></param>
        /// <param name="GetInsDescription"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <returns></returns>
        public List<GetIncubatorInfo> ItemIncubatorGetIncubatorsInfoByAnyProperty(DataConnection pclsCache, string IncubatorId, string ProductDayS, string ProductDayE, string EquipPro, string InsDescription, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetProductDay, int GetEquipPro, int GetInsDescription, int GetRevisionInfo)
        {
            List<GetIncubatorInfo> list = new List<GetIncubatorInfo>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = It.ItemIncubator.GetIncubatorsInfoByAnyProperty(pclsCache.CacheConnectionObject, IncubatorId, ProductDayS, ProductDayE, EquipPro, InsDescription, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetProductDay, GetEquipPro, GetInsDescription, GetRevisionInfo);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetIncubatorInfo incubatorInfo = new GetIncubatorInfo();
                    if (ret[0] != "")
                    {
                        incubatorInfo.IncubatorId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        incubatorInfo.ProductDay = Convert.ToDateTime(ret[1]);
                    }
                    if (ret[2] != "")
                    {
                        incubatorInfo.EquipPro = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        incubatorInfo.InsDescription = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        incubatorInfo.revDateTime = Convert.ToDateTime(ret[4]);
                    }
                    if (ret[5] != "")
                    {
                        incubatorInfo.TerminalIP = ret[5];
                    }
                    if (ret[6] != "")
                    {
                        incubatorInfo.TerminalName = ret[6];
                    }
                    if (ret[7] != "")
                    {
                        incubatorInfo.revUserId = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        incubatorInfo.revIdentify = ret[8];
                    }
                    list.Add(incubatorInfo);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemIncubatorGetIncubatorsInfoByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 试剂信息插入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="ReagentId"></param>
        /// <param name="ReagentSource"></param>
        /// <param name="ReagentName"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ItemReagentSetData(DataConnection pclsCache, string ReagentId, string ReagentSource, string ReagentName, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.ItemReagent.SetData(pclsCache.CacheConnectionObject, ReagentId, ReagentSource, ReagentName, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemReagentSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到试剂们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="ReagentId"></param>
        /// <param name="ReagentSource"></param>
        /// <param name="ReagentName"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="GetReagentSource"></param>
        /// <param name="GetReagentName"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <returns></returns>
        public List<GetReagentInfo> ItemReagentGetReagentsInfoByAnyProperty(DataConnection pclsCache, string ReagentId, string ReagentSource, string ReagentName, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetReagentSource, int GetReagentName, int GetRevisionInfo)
        {
            List<GetReagentInfo> list = new List<GetReagentInfo>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = It.ItemReagent.GetReagentsInfoByAnyProperty(pclsCache.CacheConnectionObject, ReagentId, ReagentSource, ReagentName, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetReagentSource, GetReagentName, GetRevisionInfo);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetReagentInfo reagentInfo = new GetReagentInfo();
                    if (ret[0] != "")
                    {
                        reagentInfo.ReagentId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        reagentInfo.ReagentSource = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        reagentInfo.ReagentName = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        reagentInfo.revDateTime = Convert.ToDateTime(ret[3]);
                    }
                    if (ret[4] != "")
                    {
                        reagentInfo.TerminalIP = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        reagentInfo.TerminalName = ret[5];
                    }
                    if (ret[6] != "")
                    {
                        reagentInfo.revUserId = ret[6];
                    }
                    if (ret[7] != "")
                    {
                        reagentInfo.revIdentify = ret[7];
                    }
                    list.Add(reagentInfo);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemReagentGetReagentsInfoByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到样品们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="ObjectNo"></param>
        /// <param name="ObjCompany"></param>
        /// <param name="ObjIncuSeq"></param>
        /// <param name="ObjectName"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SamplingPeople"></param>
        /// <param name="SamplingTimeS"></param>
        /// <param name="SamplingTimeE"></param>
        /// <param name="Warning"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="GetObjectName"></param>
        /// <param name="GetObjectType"></param>
        /// <param name="GetSamplingPeople"></param>
        /// <param name="GetSamplingTime"></param>
        /// <param name="GetWarning"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <returns></returns>
        public List<GetSampleInfo> ItemSampleGetSamplesInfoByAnyProperty(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string ObjectName, string ObjectType, string SamplingPeople, string SamplingTimeS, string SamplingTimeE, string Warning, string Status, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetObjectName, int GetObjectType, int GetSamplingPeople, int GetSamplingTime, int GetWarning, int GetStatus, int GetRevisionInfo)
        {
            List<GetSampleInfo> list = new List<GetSampleInfo>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = It.ItemSample.GetSamplesInfoByAnyProperty(pclsCache.CacheConnectionObject, ObjectNo, ObjCompany, ObjIncuSeq, ObjectName, ObjectType, SamplingPeople, SamplingTimeS, SamplingTimeE, Warning, Status, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetObjectName, GetObjectType, GetSamplingPeople, GetSamplingTime, GetWarning, GetStatus, GetRevisionInfo);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetSampleInfo sampleInfo = new GetSampleInfo();
                    if (ret[0] != "")
                    {
                        sampleInfo.ObjectNo = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        sampleInfo.ObjCompany = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        sampleInfo.ObjIncuSeq = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        sampleInfo.ObjectName = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        sampleInfo.ObjectType = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        sampleInfo.SamplingPeople = ret[5];
                    }
                    if (ret[6] != "")
                    {
                        sampleInfo.SamplingTime = Convert.ToDateTime(ret[6]);
                    }
                    if (ret[7] != "")
                    {
                        sampleInfo.Warning = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        sampleInfo.Status = ret[8];
                    }
                    if (ret[9] != "")
                    {
                        sampleInfo.revDateTime = Convert.ToDateTime(ret[9]);
                    }
                    if (ret[10] != "")
                    {
                        sampleInfo.TerminalIP = ret[10];
                    }
                    if (ret[11] != "")
                    {
                        sampleInfo.TerminalName = ret[11];
                    }
                    if (ret[12] != "")
                    {
                        sampleInfo.revUserId = ret[12];
                    }
                    if (ret[13] != "")
                    {
                        sampleInfo.revIdentify = ret[13];
                    }
                    list.Add(sampleInfo);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemSampleGetSamplesInfoByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 新建样品
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="ObjCompany"></param>
        /// <param name="ObjectName"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SamplingPeople"></param>
        /// <param name="SamplingTime"></param>
        /// <param name="Warning"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public List<string> ItemSampleCreateNewSample(DataConnection pclsCache, string ObjCompany, string ObjectName, string ObjectType, string SamplingPeople, DateTime SamplingTime, string Warning, string TerminalIP, string TerminalName, string revUserId)
        {
            List<string> Result = new List<string>();
            Result.Add("-2");
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                InterSystems.Data.CacheTypes.CacheSysList list = It.ItemSample.CreateNewSample(pclsCache.CacheConnectionObject, ObjCompany, ObjectName, ObjectType, SamplingPeople, SamplingTime, Warning, TerminalIP, TerminalName, revUserId);
                int count = list.Count;
                int i = 0;
                Result = new List<string>();
                while (i < count)
                {
                    Result.Add(list[i]);
                    i++;
                }
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemSampleCreateNewSample", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 更新样品信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="ObjectNo"></param>
        /// <param name="ObjCompany"></param>
        /// <param name="NewObjIncuSeq"></param>
        /// <param name="SamplingPeople"></param>
        /// <param name="SamplingTime"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ItemSampleUpdateSampleInfo(DataConnection pclsCache, string ObjectNo, string ObjCompany, string NewObjIncuSeq, string SamplingPeople, DateTime SamplingTime, string Status, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.ItemSample.ResetSample(pclsCache.CacheConnectionObject, ObjectNo, ObjCompany, NewObjIncuSeq, SamplingPeople, SamplingTime, Status, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemSampleUpdateSampleInfo", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 培养箱环境录入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="MeaTime"></param>
        /// <param name="Temperature1"></param>
        /// <param name="Temperature2"></param>
        /// <param name="Temperature3"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int EnvIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime MeaTime, float Temperature1, float Temperature2, float Temperature3, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.EnvIncubator.SetData(pclsCache.CacheConnectionObject, IncubatorId, MeaTime, Temperature1, Temperature2, Temperature3, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.EnvIncubatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到培养箱环境记录们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="MeaTimeS"></param>
        /// <param name="MeaTimeE"></param>
        /// <param name="Temperature1"></param>
        /// <param name="Temperature2"></param>
        /// <param name="Temperature3"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="GetTemperature1"></param>
        /// <param name="GetTemperature2"></param>
        /// <param name="GetTemperature3"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <returns></returns>
        public List<GetIncubatorEnv> EnvIncubatorGetIncubatorEnvsByAnyProperty(DataConnection pclsCache, string IncubatorId, string MeaTimeS, string MeaTimeE, string Temperature1, string Temperature2, string Temperature3, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetTemperature1, int GetTemperature2, int GetTemperature3, int GetRevisionInfo)
        {
            List<GetIncubatorEnv> list = new List<GetIncubatorEnv>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = It.EnvIncubator.GetIncubatorEnvsByAnyProperty(pclsCache.CacheConnectionObject, IncubatorId, MeaTimeS, MeaTimeE, Temperature1, Temperature2, Temperature3, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetTemperature1, GetTemperature2, GetTemperature3, GetRevisionInfo);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetIncubatorEnv incubatorEnv = new GetIncubatorEnv();
                    if (ret[0] != "")
                    {
                        incubatorEnv.IncubatorId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        incubatorEnv.MeaTime = Convert.ToDateTime(ret[1]);
                    }
                    if (ret[2] != "")
                    {
                        incubatorEnv.Temperature1 = Convert.ToSingle(ret[2]);
                    }
                    if (ret[3] != "")
                    {
                        incubatorEnv.Temperature2 = Convert.ToSingle(ret[3]);
                    }
                    if (ret[4] != "")
                    {
                        incubatorEnv.Temperature3 = Convert.ToSingle(ret[4]);
                    }
                    if (ret[5] != "")
                    {
                        incubatorEnv.revDateTime = Convert.ToDateTime(ret[5]);
                    }
                    if (ret[6] != "")
                    {
                        incubatorEnv.TerminalIP = ret[6];
                    }
                    if (ret[7] != "")
                    {
                        incubatorEnv.TerminalName = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        incubatorEnv.revUserId = ret[8];
                    }
                    if (ret[9] != "")
                    {
                        incubatorEnv.revIdentify = ret[9];
                    }
                    list.Add(incubatorEnv);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.EnvIncubatorGetIncubatorEnvsByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 读取培养箱最新环境
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IsolatorId"></param>
        /// <param name="CabinId"></param>
        /// <returns></returns>
        public List<string> EnvIncubatorGetNewIncubatorEnv(DataConnection pclsCache, string IncubatorId)
        {
            List<string> list = new List<string>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = It.EnvIncubator.GetNewIncubatorEnv(pclsCache.CacheConnectionObject, IncubatorId);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    list.Add(Result[i]);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.EnvIncubatorGetNewIncubatorEnv", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 无菌隔离器环境录入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IsolatorId"></param>
        /// <param name="CabinId"></param>
        /// <param name="MeaTime"></param>
        /// <param name="IsoCode"></param>
        /// <param name="IsoValue"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int EnvIsolatorSetData(DataConnection pclsCache, string IsolatorId, string CabinId, DateTime MeaTime, string IsoCode, string IsoValue, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.EnvIsolator.SetData(pclsCache.CacheConnectionObject, IsolatorId, CabinId, MeaTime, IsoCode, IsoValue, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.EnvIsolatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到隔离器环境记录们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IsolatorId"></param>
        /// <param name="CabinId"></param>
        /// <param name="MeaTimeS"></param>
        /// <param name="MeaTimeE"></param>
        /// <param name="IsoCode"></param>
        /// <param name="IsoValue"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="GetIsoValue"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <returns></returns>
        public List<GetIsolatorEnv> EnvIsolatorGetIsolatorEnvsByAnyProperty(DataConnection pclsCache, string IsolatorId, string CabinId, string MeaTimeS, string MeaTimeE, string IsoCode, string IsoValue, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetIsoValue, int GetRevisionInfo)
        {
            List<GetIsolatorEnv> list = new List<GetIsolatorEnv>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = It.EnvIsolator.GetIsolatorEnvsByAnyProperty(pclsCache.CacheConnectionObject, IsolatorId, CabinId, MeaTimeS, MeaTimeE, IsoCode, IsoValue, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetIsoValue, GetRevisionInfo);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetIsolatorEnv isolatorEnv = new GetIsolatorEnv();
                    if (ret[0] != "")
                    {
                        isolatorEnv.IsolatorId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        isolatorEnv.CabinId = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        isolatorEnv.MeaTime = Convert.ToDateTime(ret[2]);
                    }
                    if (ret[3] != "")
                    {
                        isolatorEnv.IsoCode = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        isolatorEnv.IsoValue = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        isolatorEnv.revDateTime = Convert.ToDateTime(ret[5]);
                    }
                    if (ret[6] != "")
                    {
                        isolatorEnv.TerminalIP = ret[6];
                    }
                    if (ret[7] != "")
                    {
                        isolatorEnv.TerminalName = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        isolatorEnv.revUserId = ret[8];
                    }
                    if (ret[9] != "")
                    {
                        isolatorEnv.revIdentify = ret[9];
                    }
                    list.Add(isolatorEnv);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.EnvIsolatorGetIsolatorEnvsByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 得到最新的隔离器环境参数
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IsolatorId"></param>
        /// <param name="CabinId"></param>
        /// <returns></returns>
        public List<string> EnvIsolatorGetNewIsolatorEnv(DataConnection pclsCache, string IsolatorId, string CabinId)
        {
            List<string> list = new List<string>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = It.EnvIsolator.GetNewIsolatorEnv(pclsCache.CacheConnectionObject, IsolatorId, CabinId);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    list.Add(Result[i]);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.EnvIsolatorGetNewIsolatorEnv", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 插入样品类型表 LY 2018-01-24
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TypeId"></param>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public int SetMstReagentType(DataConnection pclsCache, string TypeId, string TypeName)
        {
            int ret = 3;

            try
            {
                if (!pclsCache.Connect())
                {
                    return ret;
                }
                ret = (int)Cm.MstReagentType.SetData(pclsCache.CacheConnectionObject, TypeId, TypeName);
                return ret;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "Cm.MstReagentType.SetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return ret;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据主键删除MstReagentType数据 GY 2018-01-03
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TypeId"></param>
        /// <returns></returns>
        public int DeleteMstReagentType(DataConnection pclsCache, string TypeId)
        {
            int ret = 3;

            try
            {
                if (!pclsCache.Connect())
                {
                    return ret;
                }
                ret = (int)Cm.MstReagentType.DeleteByPK(pclsCache.CacheConnectionObject, TypeId);
                return ret;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "Cm.MstReagentType.DeleteByPK", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return ret;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }
    }
}
