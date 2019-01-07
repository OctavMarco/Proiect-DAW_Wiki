using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProPedia.Startup))]
namespace ProPedia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
