using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cibertec.MVC.Startup))]
namespace Cibertec.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
