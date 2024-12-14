using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNet4Template.Startup))]
namespace DotNet4Template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
