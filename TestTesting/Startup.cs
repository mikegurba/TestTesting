using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTesting.Startup))]
namespace TestTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
