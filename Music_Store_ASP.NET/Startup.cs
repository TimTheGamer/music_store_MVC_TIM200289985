using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Music_Store_ASP.NET.Startup))]
namespace Music_Store_ASP.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
