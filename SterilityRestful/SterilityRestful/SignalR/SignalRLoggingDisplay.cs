using Microsoft.AspNet.SignalR;
using SterilityRestful.MessageHandlers;
using System.Text;

namespace SterilityRestful.SignalR
{
    public class SignalRLoggingDisplay : ILoggingDisplay
    {
        /// <summary>
        /// PersistentConnection上下文
        /// </summary>
        private static IPersistentConnectionContext connectionContext = GlobalHost.ConnectionManager.GetConnectionContext<RequestMonitor>();

        public void Display(ApiLoggingInfo loggingInfo)
        {
            var message = new StringBuilder();
            //message.AppendFormat("StartTime:{0},Method:{1},Url:{2},ReponseStatus:{3},TotalTime:{4}"
            //   , loggingInfo.StartTime, loggingInfo.HttpMethod, loggingInfo.UriAccessed, loggingInfo.ResponseStatusCode, loggingInfo.TotalTime);
            //message.AppendLine();
            //message.AppendFormat("Headers:{0},Body:{1}", string.Join(",", loggingInfo.Headers), loggingInfo.BodyContent);
            message.AppendFormat("{0}", loggingInfo.BodyContent);
            connectionContext.Connection.Broadcast(message.ToString());
        }
    }
}
