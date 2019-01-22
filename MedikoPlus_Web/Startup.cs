using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedikoPlus_Web.Startup))]
namespace MedikoPlus_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
