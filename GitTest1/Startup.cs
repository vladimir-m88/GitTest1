using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTest1.Startup))]
namespace GitTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
