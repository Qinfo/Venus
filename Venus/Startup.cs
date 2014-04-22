using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Venus.Startup))]
namespace Venus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
