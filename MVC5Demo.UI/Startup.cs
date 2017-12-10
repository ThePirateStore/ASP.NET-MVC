using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Demo.UI.Startup))]
namespace MVC5Demo.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
