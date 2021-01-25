using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ornekMVC2021.Startup))]
namespace ornekMVC2021
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
