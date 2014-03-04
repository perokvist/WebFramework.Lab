using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace Jayway.WebLab
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var controllers = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.Name.EndsWith("Controller"));

            app
                .Use((ctx, next) => ctx.Request.Uri.ToString().Contains("localhost") ? next() : Task.Run(() => ctx.Response.Write("Not Authorized")))
                .Use((ctx, next) =>
                {
                    var routePart = ctx.Request.Uri.Segments.Last().Trim('/');
                    if (string.IsNullOrWhiteSpace(routePart))
                        routePart = "Home";

                    var controllerType = controllers.FirstOrDefault(x => x.Name.ToLower().StartsWith(routePart.ToLower()));
                    return controllerType != null ? ((dynamic)Activator.CreateInstance(controllerType)).Run((dynamic)ctx) : next();
                })
                .Run(context => context.Response.WriteAsync("No route found"));
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }

        public class TestController
        {
            public Task Run(IOwinContext context)
            {
                return context.Response.WriteAsync("Boom!");
            }
        }

        public class HomeController
        {
            public Task Run(IOwinContext context)
            {
                return context.Response.WriteAsync("Home");
            }   
        }
    }
}
