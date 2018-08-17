using System;

namespace SterilityRestful.DataModels
{
    public class ItemInfo
    {
    }

    public class IsolatorInfo
    {
        public string IsolatorId { get; set; }
        public DateTime ProductDay { get; set; }
        public string EquipPro { get; set; }
        public string InsDescription { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class GetIsolatorInfo
    {
        public string IsolatorId { get; set; }
        public DateTime ProductDay { get; set; }
        public string EquipPro { get; set; }
        public string InsDescription { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
    }

    public class QueryIsolatorInfo
    {
        public string IsolatorId { get; set; }
        public string ProductDayS { get; set; }
        public string ProductDayE { get; set; }
        public string EquipPro { get; set; }
        public string InsDescription { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public int GetProductDay { get; set; }
        public int GetEquipPro { get; set; }
        public int GetInsDescription { get; set; }
        public int GetRevisionInfo { get; set; }
    }

    public class IncubatorInfo
    {
        public string IncubatorId { get; set; }
        public DateTime ProductDay { get; set; }
        public string EquipPro { get; set; }
        public string InsDescription { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class GetIncubatorInfo
    {
        public string IncubatorId { get; set; }
        public DateTime ProductDay { get; set; }
        public string EquipPro { get; set; }
        public string InsDescription { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
    }

    public class QueryIncubatorInfo
    {
        public string IncubatorId { get; set; }
        public string ProductDayS { get; set; }
        public string ProductDayE { get; set; }
        public string EquipPro { get; set; }
        public string InsDescription { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public int GetProductDay { get; set; }
        public int GetEquipPro { get; set; }
        public int GetInsDescription { get; set; }
        public int GetRevisionInfo { get; set; }
    }

    public class ReagentInfo
    {
        public string ReagentId { get; set; }
        public string ReagentSource { get; set; }
        public string ReagentName { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class GetReagentInfo
    {
        public string ReagentId { get; set; }
        public string ReagentSource { get; set; }
        public string ReagentName { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
    }

    public class QueryReagentInfo
    {
        public string ReagentId { get; set; }
        public string ReagentSource { get; set; }
        public string ReagentName { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public int GetReagentSource { get; set; }
        public int GetReagentName { get; set; }
        public int GetRevisionInfo { get; set; }
    }

    public class GetSampleInfo
    {
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string ObjIncuSeq { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string SamplingPeople { get; set; }
        public DateTime SamplingTime { get; set; }
        public string Warning { get; set; }
        public string Status { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
    }

    public class QuerySampleInfo
    {
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string ObjIncuSeq { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string SamplingPeople { get; set; }
        public string SamplingTimeS { get; set; }
        public string SamplingTimeE { get; set; }
        public string Warning { get; set; }
        public string Status { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public int GetObjectName { get; set; }
        public int GetObjectType { get; set; }
        public int GetSamplingPeople { get; set; }
        public int GetSamplingTime { get; set; }
        public int GetWarning { get; set; }
        public int GetStatus { get; set; }
        public int GetRevisionInfo { get; set; }
    }

    public class CreateSampleInfo
    {
        public string ObjCompany { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string SamplingPeople { get; set; }
        public DateTime SamplingTime { get; set; }
        public string Warning { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class UpdateSampleInfo
    {
        public string ObjectNo { get; set; }
        public string ObjCompany { get; set; }
        public string NewObjIncuSeq { get; set; }
        public string SamplingPeople { get; set; }
        public DateTime SamplingTime { get; set; }
        public string Status { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class IncubatorEnv
    {
        public string IncubatorId { get; set; }
        public DateTime MeaTime { get; set; }
        public float Temperature1 { get; set; }
        public float Temperature2{ get; set; }
        public float Temperature3 { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class GetIncubatorEnv
    {
        public string IncubatorId { get; set; }
        public DateTime MeaTime { get; set; }
        public float Temperature1 { get; set; }
        public float Temperature2 { get; set; }
        public float Temperature3 { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
    }

    public class QueryIncubatorEnv
    {
        public string IncubatorId { get; set; }
        public string MeaTimeS { get; set; }
        public string MeaTimeE { get; set; }
        public string Temperature1 { get; set; }
        public string Temperature2 { get; set; }
        public string Temperature3 { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public int GetTemperature1 { get; set; }
        public int GetTemperature2 { get; set; }
        public int GetTemperature3 { get; set; }
        public int GetRevisionInfo { get; set; }
    }

    public class IsolatorEnv
    {
        public string IsolatorId { get; set; }
        public string CabinId { get; set; }
        public DateTime MeaTime { get; set; }
        public string IsoCode { get; set; }
        public string IsoValue { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class GetIsolatorEnv
    {
        public string IsolatorId { get; set; }
        public string CabinId { get; set; }
        public DateTime MeaTime { get; set; }
        public string IsoCode { get; set; }
        public string IsoValue { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
    }

    public class QueryIsolatorEnv
    {
        public string IsolatorId { get; set; }
        public string CabinId { get; set; }
        public string MeaTimeS { get; set; }
        public string MeaTimeE { get; set; }
        public string IsoCode { get; set; }
        public string IsoValue { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public int GetIsoValue { get; set; }
        public int GetRevisionInfo { get; set; }
    }

    public class MstReagentTypeDelete
    {
        public string TypeId { get; set; }
    }
}
