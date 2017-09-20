using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalIISWebSite.Startup))]
namespace LocalIISWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
