using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(HSTestV2Api.Startup))]
namespace HSTestV2Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //HttpConfiguration config = new HttpConfiguration();

            //WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);
            //app.UseWebApi(config);

            ConfigureOAuth(app);
        }
    }
}