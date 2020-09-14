using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoodsForAll.Startup))]
namespace GoodsForAll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
