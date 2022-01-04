using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseDemo.Startup))]
namespace CourseDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
