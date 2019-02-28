using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kitchener.Startup))]
namespace kitchener
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
