using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobWork.Startup))]
namespace JobWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
