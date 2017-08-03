using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rozgaarUI.Startup))]
namespace rozgaarUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
