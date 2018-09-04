using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Donaraee.Backend.Startup))]
namespace Donaraee.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
