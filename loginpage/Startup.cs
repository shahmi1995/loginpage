using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(loginpage.Startup))]
namespace loginpage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
