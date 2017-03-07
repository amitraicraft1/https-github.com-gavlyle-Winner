using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(winner.Startup))]
namespace winner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
