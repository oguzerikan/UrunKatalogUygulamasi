using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(Abc.MvcWebUI.App_Start.Startup1))]

namespace Abc.MvcWebUI.App_Start
{
    // Startup, genel ayarların yapıldığı bir config dosyasıdır.
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login") // Kullanıcı, sınırladığımız bir action metoduna gitmek istediğinde kullanıcının varsayılan olarak gönderileceği yer "Account Controller" altındaki "Login action metodu"dur.
            });
        }
    }
}
