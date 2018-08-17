using SterilityRestful.CommonLibrary;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public interface IOperationRepository
    {
        int OpEquipmentSetData(DataConnection pclsCache, string EquipmentId, DateTime OperationTime, string OperationCode, string OperationValue, string OperationResult, string TerminalIP, string TerminalName, string revUserId);

        List<GetOperationInfo> OpEquipmentGetEquipmentOpsByAnyProperty(DataConnection pclsCache, string EquipmentId, string OperationTimeS, string OperationTimeE, string OperationCode, string OperationValue, string OperationResult, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetOperationCode, int GetOperationValue, int GetOperationResult, int GetRevisionInfo);

        int MstOperationSetData(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode);

        List<MstOperationInfo> GetOperationInfoByAnyProperty(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode, int GetOperationName, int GetOutputCode);

        int MstOperationOrderSetData(DataConnection pclsCache, string OrderId, string SampleType, string OperationId, string OperationValue, string OpDescription, string PreviousStep, string LaterStep);

        List<GetOrdersBySampleType> GetOrdersBySampleType(DataConnection pclsCache, string SampleType);

        List<string> GetNextStep(DataConnection pclsCache, string OrderId);

        List<string> GetAllSampleTypes(DataConnection pclsCache);

        int DeleteMstOperation(DataConnection pclsCache, string OperationId);

        int DeleteMstOperationOrder(DataConnection pclsCache, string OrderId);

        int DeleteMstOperationOrderBySampleType(DataConnection pclsCache, string SampleType);

    }
}
