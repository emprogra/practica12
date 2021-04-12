using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(token.Startup))]
namespace token
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
