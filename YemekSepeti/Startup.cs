using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YemekSepeti.Startup))]
namespace YemekSepeti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
