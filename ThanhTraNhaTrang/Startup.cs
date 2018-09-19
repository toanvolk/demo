using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThanhTraNhaTrang.Startup))]
namespace ThanhTraNhaTrang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
