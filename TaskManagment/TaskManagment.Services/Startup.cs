using Microsoft.Owin;
using Owin;
using TaskManagment.Services;

[assembly: OwinStartup(typeof (Startup))]

namespace TaskManagment.Services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}