using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalAssignment_Part1.Startup))]
namespace FinalAssignment_Part1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
