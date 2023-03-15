using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaiThiKimAnh_2080601259.Startup))]
namespace MaiThiKimAnh_2080601259
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
