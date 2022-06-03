using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3_NguyenTanThai.Startup))]
namespace lab3_NguyenTanThai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
