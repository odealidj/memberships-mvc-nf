using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(memberships_mvc_nf.Startup))]
namespace memberships_mvc_nf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
