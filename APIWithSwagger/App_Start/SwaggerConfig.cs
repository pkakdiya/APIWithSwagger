using System.Web.Http;
using WebActivatorEx;
using APIWithSwagger;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace APIWithSwagger
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "APIWithSwagger");
                        c.IncludeXmlComments(string.Format(@"{0}\bin\APIWithSwagger.XML", System.AppDomain.CurrentDomain.BaseDirectory));
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}
