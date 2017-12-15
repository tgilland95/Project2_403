using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project2_403.Startup))]
namespace Project2_403
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
