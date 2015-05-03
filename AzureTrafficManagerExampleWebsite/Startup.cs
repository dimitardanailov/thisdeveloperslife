using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureTrafficManagerExampleWebsite.Startup))]
namespace AzureTrafficManagerExampleWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
