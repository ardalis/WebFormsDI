using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsDI.Startup))]
namespace WebFormsDI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
