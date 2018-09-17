using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nikunj_final_lab1.Startup))]
namespace Nikunj_final_lab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
