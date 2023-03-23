using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo003.Startup))]
namespace Demo003
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
