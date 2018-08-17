using System;

namespace SterilityRestful.DataModels
{
    public class Operation
    {
    }

    public class OperationInfo
    {
        public string EquipmentId { get; set; }
        public DateTime OperationTime { get; set; }
        public string OperationCode { get; set; }
        public string OperationValue { get; set; }
        public string OperationResult { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class GetOperationInfo
    {
        public string EquipmentId { get; set; }
        public DateTime OperationTime { get; set; }
        public string OperationCode { get; set; }
        public string OperationValue { get; set; }
        public string OperationResult { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
    }

    public class QueryOperationInfo
    {
        public string EquipmentId { get; set; }
        public string OperationTimeS { get; set; }
        public string OperationTimeE { get; set; }
        public string OperationCode { get; set; }
        public string OperationValue { get; set; }
        public string OperationResult { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public int GetOperationCode { get; set; }
        public int GetOperationValue { get; set; }
        public int GetOperationResult { get; set; }
        public int GetRevisionInfo { get; set; }
    }

    public class MstOperationInfo
    {
        public string OperationId { get; set; }
        public string OperationName { get; set; }
        public string OutputCode { get; set; }
    }

    public class GetMstOperationInfo
    {
        public string OperationId { get; set; }
        public string OperationName { get; set; }
        public string OutputCode { get; set; }
        public int GetOperationName { get; set; }
        public int GetOutputCode { get; set; }
    }

    public class MstOperationOrder
    {
        //OrderId, SampleType, OperationId, OperationValue, OpDescription, PreviousStep, LaterStep
        public string OrderId { get; set; }
        public string SampleType { get; set; }
        public string OperationId { get; set; }
        public string OperationValue { get; set; }
        public string OpDescription { get; set; }
        public string PreviousStep { get; set; }
        public string LaterStep { get; set; }
    }
    public class GetOrdersBySampleType
    {
        // OrderId,OperationId,OperationValue,OpDescription
        public string OrderId { get; set; }
        public string OperationId { get; set; }
        public string OperationValue { get; set; }
        public string OpDescription { get; set; }
    }
    public class SampleTypeInput
    {
        public string SampleType { get; set; }
    }

    public class MstOperationDelete
    {
        public string OperationId { get; set; }
    }

    public class MstOperationOrderDelete
    {
        public string OrderId { get; set; }
    }

    public class MstOperationOrderDeleteSampleType
    {
        public string SampleType { get; set; }
    }
}
