using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab14Set.Startup))]
namespace Lab14Set
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
