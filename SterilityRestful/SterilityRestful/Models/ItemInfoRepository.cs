using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public class ItemInfoRepository : IItemInfoRepository
    {
        ItemInfoMethod ItemInfoMethod = new ItemInfoMethod();
        public int ItemIsolatorSetData(DataConnection pclsCache, string IsolatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemIsolatorSetData(pclsCache, IsolatorId, ProductDay, EquipPro, InsDescription, TerminalIP, TerminalName, revUserId);
        }

        public int ItemIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemIncubatorSetData(pclsCache, IncubatorId, ProductDay, EquipPro, InsDescription, TerminalIP, TerminalName, revUserId);
        }

        public int ItemReagentSetData(DataConnection pclsCache, string ReagentId, string ReagentSource, string ReagentName, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemReagentSetData(pclsCache, ReagentId, ReagentSource, ReagentName, TerminalIP, TerminalName, revUserId);
        }

        public int EnvIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime MeaTime, float Temperature1, float Temperature2, float Temperature3, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.EnvIncubatorSetData(pclsCache, IncubatorId, MeaTime, Temperature1, Temperature2, Temperature3, TerminalIP, TerminalName, revUserId);
        }

        public int EnvIsolatorSetData(DataConnection pclsCache, string IsolatorId, string CabinId, DateTime MeaTime, string IsoCode, string IsoValue, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.EnvIsolatorSetData(pclsCache, IsolatorId, CabinId, MeaTime, IsoCode, IsoValue, TerminalIP, TerminalName, revUserId);
        }

        public List<GetIsolatorInfo> ItemIsolatorGetIsolatorsInfoByAnyProperty(DataConnection pclsCache, string IsolatorId, string ProductDayS, string ProductDayE, string EquipPro, string InsDescription, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetProductDay, int GetEquipPro, int GetInsDescription, int GetRevisionInfo)
        {
            return ItemInfoMethod.ItemIsolatorGetIsolatorsInfoByAnyProperty(pclsCache, IsolatorId, ProductDayS, ProductDayE, EquipPro, InsDescription, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetProductDay, GetEquipPro, GetInsDescription, GetRevisionInfo);
        }

        public List<GetIncubatorInfo> ItemIncubatorGetIncubatorsInfoByAnyProperty(DataConnection pclsCache, string IncubatorId, string ProductDayS, string ProductDayE, string EquipPro, string InsDescription, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetProductDay, int GetEquipPro, int GetInsDescription, int GetRevisionInfo)
        {
            return ItemInfoMethod.ItemIncubatorGetIncubatorsInfoByAnyProperty(pclsCache, IncubatorId, ProductDayS, ProductDayE, EquipPro, InsDescription, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetProductDay, GetEquipPro, GetInsDescription, GetRevisionInfo);
        }

        public List<GetReagentInfo> ItemReagentGetReagentsInfoByAnyProperty(DataConnection pclsCache, string ReagentId, string ReagentSource, string ReagentName, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetReagentSource, int GetReagentName, int GetRevisionInfo)
        {
            return ItemInfoMethod.ItemReagentGetReagentsInfoByAnyProperty(pclsCache, ReagentId, ReagentSource, ReagentName, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetReagentSource, GetReagentName, GetRevisionInfo);
        }

        public List<GetSampleInfo> ItemSampleGetSamplesInfoByAnyProperty(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string ObjectName, string ObjectType, string SamplingPeople, string SamplingTimeS, string SamplingTimeE, string Warning, string Status, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetObjectName, int GetObjectType, int GetSamplingPeople, int GetSamplingTime, int GetWarning, int GetStatus, int GetRevisionInfo)
        {
            return ItemInfoMethod.ItemSampleGetSamplesInfoByAnyProperty(pclsCache, ObjectNo, ObjCompany, ObjIncuSeq, ObjectName, ObjectType, SamplingPeople, SamplingTimeS, SamplingTimeE, Warning, Status, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetObjectName, GetObjectType, GetSamplingPeople, GetSamplingTime, GetWarning, GetStatus, GetRevisionInfo);
        }

        public List<GetIncubatorEnv> EnvIncubatorGetIncubatorEnvsByAnyProperty(DataConnection pclsCache, string IncubatorId, string MeaTimeS, string MeaTimeE, string Temperature1, string Temperature2, string Temperature3, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetTemperature1, int GetTemperature2, int GetTemperature3, int GetRevisionInfo)
        {
            return ItemInfoMethod.EnvIncubatorGetIncubatorEnvsByAnyProperty(pclsCache, IncubatorId, MeaTimeS, MeaTimeE, Temperature1, Temperature2, Temperature3, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetTemperature1, GetTemperature2, GetTemperature3, GetRevisionInfo);
        }

        public List<GetIsolatorEnv> EnvIsolatorGetIsolatorEnvsByAnyProperty(DataConnection pclsCache, string IsolatorId, string CabinId, string MeaTimeS, string MeaTimeE, string IsoCode, string IsoValue, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetIsoValue, int GetRevisionInfo)
        {
            return ItemInfoMethod.EnvIsolatorGetIsolatorEnvsByAnyProperty(pclsCache, IsolatorId, CabinId, MeaTimeS, MeaTimeE, IsoCode, IsoValue, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetIsoValue, GetRevisionInfo);
        }

        public List<string> ItemSampleCreateNewSample(DataConnection pclsCache, string ObjCompany, string ObjectName, string ObjectType, string SamplingPeople, DateTime SamplingTime, string Warning, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemSampleCreateNewSample(pclsCache, ObjCompany, ObjectName, ObjectType, SamplingPeople, SamplingTime, Warning, TerminalIP, TerminalName, revUserId);
        }

        public int ItemSampleUpdateSampleInfo(DataConnection pclsCache, string ObjectNo, string ObjCompany, string NewObjIncuSeq, string SamplingPeople, DateTime SamplingTime, string Status, string TerminalIP, string TerminalName, string revUserId)
        {
            return ItemInfoMethod.ItemSampleUpdateSampleInfo(pclsCache, ObjectNo, ObjCompany, NewObjIncuSeq, SamplingPeople, SamplingTime, Status, TerminalIP, TerminalName, revUserId);
        }

        public List<string> EnvIsolatorGetNewIsolatorEnv(DataConnection pclsCache, string IsolatorId, string CabinId)
        {
            return ItemInfoMethod.EnvIsolatorGetNewIsolatorEnv(pclsCache, IsolatorId, CabinId);
        }

        public List<string> EnvIncubatorGetNewIncubatorEnv(DataConnection pclsCache, string IncubatorId)
        {
            return ItemInfoMethod.EnvIncubatorGetNewIncubatorEnv(pclsCache, IncubatorId);
        }

        public int SetMstReagentType(DataConnection pclsCache, string TypeId, string TypeName)
        {
            return ItemInfoMethod.SetMstReagentType(pclsCache, TypeId, TypeName);
        }

        public int DeleteMstReagentType(DataConnection pclsCache, string TypeId)
        {
            return ItemInfoMethod.DeleteMstReagentType(pclsCache, TypeId);
        }
    }
}
