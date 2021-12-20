using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Section2_IPG521.Startup))]
namespace Section2_IPG521
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
