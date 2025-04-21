using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kullanıcı_Bilgileri__Formu.Startup))]
namespace Kullanıcı_Bilgileri__Formu
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
