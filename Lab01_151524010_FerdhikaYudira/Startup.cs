using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab01_151524010_FerdhikaYudira.Startup))]
namespace Lab01_151524010_FerdhikaYudira
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
