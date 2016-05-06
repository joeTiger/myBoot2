using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myBoot2.Startup))]
namespace myBoot2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
