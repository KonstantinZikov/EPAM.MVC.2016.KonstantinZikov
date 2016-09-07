using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarWars.Startup))]
namespace StarWars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
