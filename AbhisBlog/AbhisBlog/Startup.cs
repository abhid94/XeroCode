using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbhisBlog.Startup))]
namespace AbhisBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
