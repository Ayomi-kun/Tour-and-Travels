using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tour_and_Travels.Startup))]
namespace Tour_and_Travels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
