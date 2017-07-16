using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomatedTellerMachineASPMVC.Startup))]
namespace AutomatedTellerMachineASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
