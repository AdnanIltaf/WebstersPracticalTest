using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebstersPracticalTest.Startup))]
namespace WebstersPracticalTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
