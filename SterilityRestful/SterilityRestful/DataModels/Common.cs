
using System;
namespace SterilityRestful.DataModels
{
    public class Common
    {
    }

    public class Result
    {
        public string result { get; set; }
    }

    public class ServerTime
    {
        public DateTime time { get; set; }
    }

    public class TypeAndName
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
}