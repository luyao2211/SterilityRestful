using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using SterilityRestful.SignalR;

[assembly: OwinStartup(typeof(SterilityRestful.Startup))]

namespace SterilityRestful
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/monitor",
                map =>
                {
                    map.UseCors(CorsOptions.AllowAll);
                    map.RunSignalR<RequestMonitor>();
                }
            );
        }
    }
}
