using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkoutMVC.Startup))]
namespace WorkoutMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
