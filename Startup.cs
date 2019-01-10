using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHub_BC5.Startup))]
namespace GigHub_BC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
