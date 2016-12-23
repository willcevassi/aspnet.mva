using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp.mvc5.basico.web.Startup))]
namespace asp.mvc5.basico.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
