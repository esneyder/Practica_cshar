using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica.Startup))]
namespace Practica
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
