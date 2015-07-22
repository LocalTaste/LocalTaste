using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalTaste.Mvc.Startup))]
namespace LocalTaste.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
