using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC模板.Startup))]
namespace MVC模板
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
