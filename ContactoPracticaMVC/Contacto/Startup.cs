using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contacto.Startup))]
namespace Contacto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
