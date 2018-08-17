using SterilityRestful.CommonLibrary;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;
using InterSystems.Data.CacheClient;

namespace SterilityRestful.DataMethod
{
    public class OperationMethod
    {
        /// <summary>
        /// 无菌隔离器、培养箱操作记录
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="EquipmentId"></param>
        /// <param name="OperationNo"></param>
        /// <param name="OperationTime"></param>
        /// <param name="OperationCode"></param>
        /// <param name="OperationValue"></param>
        /// <param name="OperationResult"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int OpEquipmentSetData(DataConnection pclsCache, string EquipmentId, DateTime OperationTime, string OperationCode, string OperationValue, string OperationResult, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Op.OpEquipment.SetData(pclsCache.CacheConnectionObject, EquipmentId, OperationTime, OperationCode, OperationValue, OperationResult, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.OpEquipmentSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到仪器操作记录们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="EquipmentId"></param>
        /// <param name="OperationNo"></param>
        /// <param name="OperationTimeS"></param>
        /// <param name="OperationTimeE"></param>
        /// <param name="OperationCode"></param>
        /// <param name="OperationValue"></param>
        /// <param name="OperationResult"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="GetOperationTime"></param>
        /// <param name="GetOperationCode"></param>
        /// <param name="GetOperationValue"></param>
        /// <param name="GetOperationResult"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <returns></returns>
        public List<GetOperationInfo> OpEquipmentGetEquipmentOpsByAnyProperty(DataConnection pclsCache, string EquipmentId, string OperationTimeS, string OperationTimeE, string OperationCode, string OperationValue, string OperationResult, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetOperationCode, int GetOperationValue, int GetOperationResult, int GetRevisionInfo)
        {
            List<GetOperationInfo> list = new List<GetOperationInfo>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Op.OpEquipment.GetEquipmentOpsByAnyProperty(pclsCache.CacheConnectionObject, EquipmentId, OperationTimeS, OperationTimeE, OperationCode, OperationValue, OperationResult, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetOperationCode, GetOperationValue, GetOperationResult, GetRevisionInfo);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetOperationInfo operationInfo = new GetOperationInfo();
                    if (ret[0] != "")
                    {
                        operationInfo.EquipmentId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        operationInfo.OperationTime = Convert.ToDateTime(ret[1]);
                    }
                    if (ret[2] != "")
                    {
                        operationInfo.OperationCode = ret[2];
                    }
                    if (ret[3] != "")
                    {
                        operationInfo.OperationValue = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        operationInfo.OperationResult = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        operationInfo.revDateTime = Convert.ToDateTime(ret[5]);
                    }
                    if (ret[6] != "")
                    {
                        operationInfo.TerminalIP = ret[6];
                    }
                    if (ret[7] != "")
                    {
                        operationInfo.TerminalName = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        operationInfo.revUserId = ret[8];
                    }
                    if (ret[9] != "")
                    {
                        operationInfo.revIdentify = ret[9];
                    }
                    list.Add(operationInfo);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.OpEquipmentGetEquipmentOpsByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 基本操作录入 GY 2017-11-23
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="OperationId"></param>
        /// <param name="OperationName"></param>
        /// <param name="OutputCode"></param>
        /// <returns></returns>
        public int MstOperationSetData(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstOperation.SetData(pclsCache.CacheConnectionObject, OperationId, OperationName, OutputCode));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.MstOperationSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 基本操作条件查询 GY 2017-11-23
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="OperationId"></param>
        /// <param name="OperationName"></param>
        /// <param name="OutputCode"></param>
        /// <param name="GetOperationName"></param>
        /// <param name="GetOutputCode"></param>
        /// <returns></returns>
        public List<MstOperationInfo> GetOperationInfoByAnyProperty(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode, int GetOperationName, int GetOutputCode)
        {
            List<MstOperationInfo> list = new List<MstOperationInfo>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Cm.MstOperation.GetOperationInfoByAnyProperty(pclsCache.CacheConnectionObject, OperationId, OperationName, OutputCode, GetOperationName, GetOutputCode);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    MstOperationInfo opInfo = new MstOperationInfo();
                    if (ret[0] != "")
                    {
                        opInfo.OperationId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        opInfo.OperationName = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        opInfo.OutputCode = ret[2];
                    }
                    
                    list.Add(opInfo);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.MstUserGetUsersInfoByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// MstOperationOrder数据录入 GY 2017-11-29
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="OrderId"></param>
        /// <param name="SampleType"></param>
        /// <param name="OperationId"></param>
        /// <param name="OperationValue"></param>
        /// <param name="OpDescription"></param>
        /// <param name="PreviousStep"></param>
        /// <param name="LaterStep"></param>
        /// <returns></returns>
        public int MstOperationOrderSetData(DataConnection pclsCache, string OrderId, string SampleType, string OperationId, string OperationValue, string OpDescription, string PreviousStep, string LaterStep)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstOperationOrder.SetData(pclsCache.CacheConnectionObject, OrderId, SampleType, OperationId, OperationValue, OpDescription, PreviousStep, LaterStep));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.MstOperationOrderSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 按供试品类型得到无菌检测流程规划 GY 2017-11-28
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="SampleType"></param>
        /// <returns></returns>
        public List<GetOrdersBySampleType> GetOrdersBySampleType(DataConnection pclsCache, string SampleType)
        {
            List<GetOrdersBySampleType> list = new List<GetOrdersBySampleType>();
            CacheCommand cmd = null;
            CacheDataReader cdr = null;

            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }

                cmd = Cm.MstOperationOrder.GetOdersBySample(pclsCache.CacheConnectionObject);
                cmd.Parameters.Add("SampleType", CacheDbType.NVarChar).Value = SampleType;

                cdr = cmd.ExecuteReader();

                while (cdr.Read())
                {
                    GetOrdersBySampleType item = new GetOrdersBySampleType();
                    item.OrderId = cdr["OrderId"].ToString();
                    item.OperationId = cdr["OperationId"].ToString();
                    item.OperationValue = cdr["OperationValue"].ToString();
                    item.OpDescription = cdr["OpDescription"].ToString();

                    list.Add(item);
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.GetOrdersBySampleType", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 得到流程的下一步
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public List<string> GetNextStep(DataConnection pclsCache, string OrderId)
        {
            List<string> list = new List<string>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Cm.MstOperationOrder.GetNextStep(pclsCache.CacheConnectionObject, OrderId);
                int count = Result.Count;
                int i = 0;
                while (i < count)
                {
                    list.Add(Result[i]);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.GetNextStep", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 输出所有供试品类型 GY 2017-12-04
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <returns></returns>
        public List<string> GetAllSampleTypes(DataConnection pclsCache)
        {
            List<string> sampleTypes = new List<string>();
            CacheCommand cmd = null;
            CacheDataReader cdr = null;

            try
            {
                if (!pclsCache.Connect())
                {
                    return sampleTypes;
                }

                cmd = Cm.MstOperationOrder.GetAllSampletype(pclsCache.CacheConnectionObject);

                cdr = cmd.ExecuteReader();

                while (cdr.Read())
                {
                    string item = string.Empty;
                    item = cdr["SampleType"].ToString();

                    sampleTypes.Add(item);
                }
                return sampleTypes;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.GetAllSampleTypes", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return sampleTypes;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据主键删除MstOperation数据 GY 2018-01-03
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="OperationId"></param>
        /// <returns></returns>
        /// 返回值：0 失败；1 成功；2 数据不存在
        public int DeleteMstOperation(DataConnection pclsCache, string OperationId)
        {
            int ret = 3;
            
            try
            {
                if (!pclsCache.Connect())
                {
                    return ret;
                }
                ret = (int)Cm.MstOperation.DeleteByPK(pclsCache.CacheConnectionObject, OperationId);
                return ret;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "Cm.MstOperation.DeleteByPK", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return ret;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据主键删除MstOperationOrder数据 GY 2018-01-03
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        /// 返回值：0 失败；1 成功；2 数据不存在
        public int DeleteMstOperationOrder(DataConnection pclsCache, string OrderId)
        {
            int ret = 3;

            try
            {
                if (!pclsCache.Connect())
                {
                    return ret;
                }
                ret = (int)Cm.MstOperationOrder.DeleteByPK(pclsCache.CacheConnectionObject, OrderId);
                return ret;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "Cm.MstOperationOrder.DeleteByPK", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return ret;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据样品类型删除MstOperationOrder数据 LY 2018-01-24
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="SampleType"></param>
        /// <returns></returns>
        public int DeleteMstOperationOrderBySampleType(DataConnection pclsCache, string SampleType)
        {
            int ret = 3;

            try
            {
                if (!pclsCache.Connect())
                {
                    return ret;
                }
                ret = (int)Cm.MstOperationOrder.DeleteBySampleType(pclsCache.CacheConnectionObject, SampleType);
                return ret;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "Cm.MstOperationOrder.DeleteBySampleType", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return ret;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

    }
}
