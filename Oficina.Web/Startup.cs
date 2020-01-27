using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OficinaDLL.Web.Startup))]
namespace OficinaDLL.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
