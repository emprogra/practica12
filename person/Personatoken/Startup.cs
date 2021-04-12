using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Personatoken.Startup))]
namespace Personatoken
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
