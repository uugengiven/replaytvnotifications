using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReplayTVNotifications.Startup))]
namespace ReplayTVNotifications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
