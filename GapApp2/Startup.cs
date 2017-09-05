using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GapApp2.Startup))]
namespace GapApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
