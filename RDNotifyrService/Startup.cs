using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RDNotifyrService.Startup))]

namespace RDNotifyrService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}