using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jenkinsTest.Startup))]
namespace jenkinsTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
