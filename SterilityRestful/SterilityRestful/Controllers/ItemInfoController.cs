using SterilityRestful.CommonLibrary;
using SterilityRestful.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SterilityRestful.DataModels;
using System;

namespace SterilityRestful.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*"), WebApiTracker]
    public class ItemInfoController : ApiController
    {
        static readonly IItemInfoRepository repository = new ItemInfoRepository();
        DataConnection pclsCache = new DataConnection();

        /// <summary>
        /// 无菌隔离器信息插入
        /// </summary>
        /// <param name="isolatorInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemIsolatorSetData")]
        public object ItemIsolatorSetData(IsolatorInfo isolatorInfo)
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
            int ret = repository.ItemIsolatorSetData(pclsCache, isolatorInfo.IsolatorId, isolatorInfo.ProductDay, isolatorInfo.EquipPro, isolatorInfo.InsDescription, isolatorInfo.TerminalIP, isolatorInfo.TerminalName, isolatorInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到无菌隔离器们的信息
        /// </summary>
        /// <param name="queryIsolatorInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemIsolatorGetIsolatorsInfoByAnyProperty")]
        public object ItemIsolatorGetIsolatorsInfoByAnyProperty(QueryIsolatorInfo queryIsolatorInfo)
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
            return repository.ItemIsolatorGetIsolatorsInfoByAnyProperty(pclsCache, queryIsolatorInfo.IsolatorId, queryIsolatorInfo.ProductDayS, queryIsolatorInfo.ProductDayE, queryIsolatorInfo.EquipPro, queryIsolatorInfo.InsDescription, queryIsolatorInfo.ReDateTimeS, queryIsolatorInfo.ReDateTimeE, queryIsolatorInfo.ReTerminalIP, queryIsolatorInfo.ReTerminalName, queryIsolatorInfo.ReUserId, queryIsolatorInfo.ReIdentify, queryIsolatorInfo.GetProductDay, queryIsolatorInfo.GetEquipPro, queryIsolatorInfo.GetInsDescription, queryIsolatorInfo.GetRevisionInfo);
        }

        /// <summary>
        /// 培养箱信息插入
        /// </summary>
        /// <param name="incubatorInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemIncubatorSetData")]
        public object ItemIncubatorSetData(IncubatorInfo incubatorInfo)
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
            int ret = repository.ItemIncubatorSetData(pclsCache, incubatorInfo.IncubatorId, incubatorInfo.ProductDay, incubatorInfo.EquipPro, incubatorInfo.InsDescription, incubatorInfo.TerminalIP, incubatorInfo.TerminalName, incubatorInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到培养箱们的信息
        /// </summary>
        /// <param name="queryIncubatorInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemIncubatorGetIncubatorsInfoByAnyProperty")]
        public object ItemIncubatorGetIncubatorsInfoByAnyProperty(QueryIncubatorInfo queryIncubatorInfo)
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
            return repository.ItemIncubatorGetIncubatorsInfoByAnyProperty(pclsCache, queryIncubatorInfo.IncubatorId, queryIncubatorInfo.ProductDayS, queryIncubatorInfo.ProductDayE, queryIncubatorInfo.EquipPro, queryIncubatorInfo.InsDescription, queryIncubatorInfo.ReDateTimeS, queryIncubatorInfo.ReDateTimeE, queryIncubatorInfo.ReTerminalIP, queryIncubatorInfo.ReTerminalName, queryIncubatorInfo.ReUserId, queryIncubatorInfo.ReIdentify, queryIncubatorInfo.GetProductDay, queryIncubatorInfo.GetEquipPro, queryIncubatorInfo.GetInsDescription, queryIncubatorInfo.GetRevisionInfo);
        }

        /// <summary>
        /// 试剂信息插入
        /// </summary>
        /// <param name="reagentInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemReagentSetData")]
        public object ItemReagentSetData(ReagentInfo reagentInfo)
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
            int ret = repository.ItemReagentSetData(pclsCache, reagentInfo.ReagentId, reagentInfo.ReagentSource, reagentInfo.ReagentName, reagentInfo.TerminalIP, reagentInfo.TerminalName, reagentInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到试剂们的信息
        /// </summary>
        /// <param name="queryReagentInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemReagentGetReagentsInfoByAnyProperty")]
        public object ItemReagentGetReagentsInfoByAnyProperty(QueryReagentInfo queryReagentInfo)
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
            return repository.ItemReagentGetReagentsInfoByAnyProperty(pclsCache, queryReagentInfo.ReagentId, queryReagentInfo.ReagentSource, queryReagentInfo.ReagentName, queryReagentInfo.ReDateTimeS, queryReagentInfo.ReDateTimeE, queryReagentInfo.ReTerminalIP, queryReagentInfo.ReTerminalName, queryReagentInfo.ReUserId, queryReagentInfo.ReIdentify, queryReagentInfo.GetReagentSource, queryReagentInfo.GetReagentName, queryReagentInfo.GetRevisionInfo);
        }

        /// <summary>
        /// 根据任何筛选条件得到样品们的信息
        /// </summary>
        /// <param name="querySampleInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemSampleGetSamplesInfoByAnyProperty")]
        public object ItemSampleGetSamplesInfoByAnyProperty(QuerySampleInfo querySampleInfo)
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
            return repository.ItemSampleGetSamplesInfoByAnyProperty(pclsCache, querySampleInfo.ObjectNo, querySampleInfo.ObjCompany, querySampleInfo.ObjIncuSeq, querySampleInfo.ObjectName, querySampleInfo.ObjectType, querySampleInfo.SamplingPeople, querySampleInfo.SamplingTimeS, querySampleInfo.SamplingTimeE, querySampleInfo.Warning, querySampleInfo.Status, querySampleInfo.ReDateTimeS, querySampleInfo.ReDateTimeE, querySampleInfo.ReTerminalIP, querySampleInfo.ReTerminalName, querySampleInfo.ReUserId, querySampleInfo.ReIdentify, querySampleInfo.GetObjectName, querySampleInfo.GetObjectType, querySampleInfo.GetSamplingPeople, querySampleInfo.GetSamplingTime, querySampleInfo.GetWarning, querySampleInfo.GetStatus, querySampleInfo.GetRevisionInfo);
        }

        /// <summary>
        /// 新建样品
        /// </summary>
        /// <param name="createSampleInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemSampleCreateNewSample")]
        public object ItemSampleCreateNewSample(CreateSampleInfo createSampleInfo)
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
            List<string> Result = repository.ItemSampleCreateNewSample(pclsCache, createSampleInfo.ObjCompany, createSampleInfo.ObjectName, createSampleInfo.ObjectType, createSampleInfo.SamplingPeople, createSampleInfo.SamplingTime, createSampleInfo.Warning, createSampleInfo.TerminalIP, createSampleInfo.TerminalName, createSampleInfo.revUserId);
            Result[0] = new ExceptionHandler().UpdateData(Request, Convert.ToInt32(Result[0]));
            return Result;
        }

        /// <summary>
        /// 样品信息更新
        /// </summary>
        /// <param name="updateSampleInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemSampleUpdateSampleInfo")]
        public string ItemSampleUpdateSampleInfo(UpdateSampleInfo updateSampleInfo)
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
            int ret = repository.ItemSampleUpdateSampleInfo(pclsCache, updateSampleInfo.ObjectNo, updateSampleInfo.ObjCompany, updateSampleInfo.NewObjIncuSeq, updateSampleInfo.SamplingPeople, updateSampleInfo.SamplingTime, updateSampleInfo.Status, updateSampleInfo.TerminalIP, updateSampleInfo.TerminalName, updateSampleInfo.revUserId);
            return new ExceptionHandler().UpdateData(Request, ret);
        }

        /// <summary>
        /// 培养箱环境录入
        /// </summary>
        /// <param name="incubatorEnv"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/EnvIncubatorSetData")]
        public object EnvIncubatorSetData(IncubatorEnv incubatorEnv)
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
            int ret = repository.EnvIncubatorSetData(pclsCache, incubatorEnv.IncubatorId, incubatorEnv.MeaTime, incubatorEnv.Temperature1, incubatorEnv.Temperature2, incubatorEnv.Temperature3, incubatorEnv.TerminalIP, incubatorEnv.TerminalName, incubatorEnv.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到培养箱环境记录们的信息
        /// </summary>
        /// <param name="queryIncubatorEnv"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/EnvIncubatorGetIncubatorEnvsByAnyProperty")]
        public object EnvIncubatorGetIncubatorEnvsByAnyProperty(QueryIncubatorEnv queryIncubatorEnv)
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
            return repository.EnvIncubatorGetIncubatorEnvsByAnyProperty(pclsCache, queryIncubatorEnv.IncubatorId, queryIncubatorEnv.MeaTimeS, queryIncubatorEnv.MeaTimeE, queryIncubatorEnv.Temperature1, queryIncubatorEnv.Temperature2, queryIncubatorEnv.Temperature3, queryIncubatorEnv.ReDateTimeS, queryIncubatorEnv.ReDateTimeE, queryIncubatorEnv.ReTerminalIP, queryIncubatorEnv.ReTerminalName, queryIncubatorEnv.ReUserId, queryIncubatorEnv.ReIdentify, queryIncubatorEnv.GetTemperature1, queryIncubatorEnv.GetTemperature2, queryIncubatorEnv.GetTemperature3, queryIncubatorEnv.GetRevisionInfo);
        }

        /// <summary>
        /// 无菌隔离器环境录入
        /// </summary>
        /// <param name="isolatorEnv"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/EnvIsolatorSetData")]
        public object EnvIsolatorSetData(IsolatorEnv isolatorEnv)
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
            int ret = repository.EnvIsolatorSetData(pclsCache, isolatorEnv.IsolatorId, isolatorEnv.CabinId, isolatorEnv.MeaTime, isolatorEnv.IsoCode, isolatorEnv.IsoValue, isolatorEnv.TerminalIP, isolatorEnv.TerminalName, isolatorEnv.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到隔离器环境记录们的信息
        /// </summary>
        /// <param name="queryIsolatorEnv"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/EnvIsolatorGetIsolatorEnvsByAnyProperty")]
        public object EnvIsolatorGetIsolatorEnvsByAnyProperty(QueryIsolatorEnv queryIsolatorEnv)
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
            return repository.EnvIsolatorGetIsolatorEnvsByAnyProperty(pclsCache, queryIsolatorEnv.IsolatorId, queryIsolatorEnv.CabinId, queryIsolatorEnv.MeaTimeS, queryIsolatorEnv.MeaTimeE, queryIsolatorEnv.IsoCode, queryIsolatorEnv.IsoValue, queryIsolatorEnv.ReDateTimeS, queryIsolatorEnv.ReDateTimeE, queryIsolatorEnv.ReTerminalIP, queryIsolatorEnv.ReTerminalName, queryIsolatorEnv.ReUserId, queryIsolatorEnv.ReIdentify, queryIsolatorEnv.GetIsoValue, queryIsolatorEnv.GetRevisionInfo);
        }

        /// <summary>
        /// 得到最新的隔离器环境参数
        /// </summary>
        /// <param name="IsolatorId"></param>
        /// <param name="CabinId"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/EnvIsolatorGetNewIsolatorEnv")]
        [HttpGet]
        public object EnvIsolatorGetNewIsolatorEnv(string IsolatorId, string CabinId)
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
            return repository.EnvIsolatorGetNewIsolatorEnv(pclsCache, IsolatorId, CabinId);
        }

        [Route("Api/v1/ItemInfo/EnvIncubatorGetNewIncubatorEnv")]
        [HttpGet]
        public object EnvIncubatorGetNewIncubatorEnv(string IncubatorId)
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
            return repository.EnvIncubatorGetNewIncubatorEnv(pclsCache, IncubatorId);
        }

        [Route("Api/v1/ItemInfo/MstReagentTypeSetData")]
        public object MstReagentTypeSetData(TypeAndName TypeAndName)
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
            int ret = repository.SetMstReagentType(pclsCache, TypeAndName.Type, TypeAndName.Name);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据主键删除MstReagentType数据 GY 2018-01-03
        /// </summary>
        /// <param name="MstReagentTypeDelete"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/MstReagentTypeDeleteByPK")]
        public object MstReagentTypeDeleteByPK(MstReagentTypeDelete MstReagentTypeDelete)
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
            int ret = repository.DeleteMstReagentType(pclsCache, MstReagentTypeDelete.TypeId);
            return new ExceptionHandler().DeleteData(Request, ret);
        }
    }
}