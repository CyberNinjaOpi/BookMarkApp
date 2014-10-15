using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMarkApp.Web.Startup))]
namespace BookMarkApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
