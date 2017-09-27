using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(foodFinder.Startup))]
namespace foodFinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
