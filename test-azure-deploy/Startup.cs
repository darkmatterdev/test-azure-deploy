using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_azure_deploy.Startup))]
namespace test_azure_deploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
