using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(w04a.Startup))]
namespace w04a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
