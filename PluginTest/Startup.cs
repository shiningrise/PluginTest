using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PluginTest.Startup))]
namespace PluginTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
