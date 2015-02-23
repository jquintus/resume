using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeMvc.Startup))]
namespace ResumeMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
