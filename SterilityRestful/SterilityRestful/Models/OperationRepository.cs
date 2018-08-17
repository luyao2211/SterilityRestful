using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public class OperationRepository : IOperationRepository
    {
        OperationMethod OperationMethod = new OperationMethod();
        public int OpEquipmentSetData(DataConnection pclsCache, string EquipmentId, DateTime OperationTime, string OperationCode, string OperationValue, string OperationResult, string TerminalIP, string TerminalName, string revUserId)
        {
            return OperationMethod.OpEquipmentSetData(pclsCache, EquipmentId, OperationTime, OperationCode, OperationValue, OperationResult, TerminalIP, TerminalName, revUserId);
        }

        public List<GetOperationInfo> OpEquipmentGetEquipmentOpsByAnyProperty(DataConnection pclsCache, string EquipmentId, string OperationTimeS, string OperationTimeE, string OperationCode, string OperationValue, string OperationResult, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetOperationCode, int GetOperationValue, int GetOperationResult, int GetRevisionInfo)
        {
            return OperationMethod.OpEquipmentGetEquipmentOpsByAnyProperty(pclsCache, EquipmentId, OperationTimeS, OperationTimeE, OperationCode, OperationValue, OperationResult, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetOperationCode, GetOperationValue, GetOperationResult, GetRevisionInfo);
        }

        public int MstOperationSetData(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode)
        {
            return OperationMethod.MstOperationSetData(pclsCache, OperationId, OperationName, OutputCode);
        }

        public List<MstOperationInfo> GetOperationInfoByAnyProperty(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode, int GetOperationName, int GetOutputCode)
        {
            return OperationMethod.GetOperationInfoByAnyProperty(pclsCache, OperationId, OperationName, OutputCode, GetOperationName, GetOutputCode);
        }

        public int MstOperationOrderSetData(DataConnection pclsCache, string OrderId, string SampleType, string OperationId, string OperationValue, string OpDescription, string PreviousStep, string LaterStep)
        {
            return OperationMethod.MstOperationOrderSetData(pclsCache, OrderId, SampleType, OperationId, OperationValue, OpDescription, PreviousStep, LaterStep);
        }

        public List<GetOrdersBySampleType> GetOrdersBySampleType(DataConnection pclsCache, string SampleType)
        {
            return OperationMethod.GetOrdersBySampleType(pclsCache, SampleType);
        }

        public List<string> GetNextStep(DataConnection pclsCache, string OrderId)
        {
            return OperationMethod.GetNextStep(pclsCache, OrderId);
        }

        public List<string> GetAllSampleTypes(DataConnection pclsCache)
        {
            return OperationMethod.GetAllSampleTypes(pclsCache);
        }

        public int DeleteMstOperation(DataConnection pclsCache, string OperationId)
        {
            return OperationMethod.DeleteMstOperation(pclsCache, OperationId);
        }

        public int DeleteMstOperationOrder(DataConnection pclsCache, string OrderId)
        {
            return OperationMethod.DeleteMstOperationOrder(pclsCache, OrderId);
        }

        public int DeleteMstOperationOrderBySampleType(DataConnection pclsCache, string SampleType)
        {
            return OperationMethod.DeleteMstOperationOrderBySampleType(pclsCache, SampleType);
        }
    }
}
