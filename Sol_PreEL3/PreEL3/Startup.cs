using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreEL3.Startup))]
namespace PreEL3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
