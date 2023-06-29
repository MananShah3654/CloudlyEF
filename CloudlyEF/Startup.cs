using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudlyEF.Startup))]
namespace CloudlyEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
