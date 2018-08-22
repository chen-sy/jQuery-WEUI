using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQuery_WEUI.Startup))]
namespace jQuery_WEUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
