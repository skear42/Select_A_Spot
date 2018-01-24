using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Select_A_Spot.Startup))]
namespace Select_A_Spot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
