using Owin;
using System.Web.Http;

namespace OwinFxMicroservice
{
	public class Startup
	{
		// This code configures Web API. The Startup class is specified as a type
		// parameter in the WebApp.Start method.
		public void Configuration(IAppBuilder appBuilder)
		{
			// Configure Web API for self-host. 
			var config = new HttpConfiguration();
			CreateHttpConfig(config);
			appBuilder.UseWebApi(config);
		}

		private static void CreateHttpConfig(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				 name: "DefaultApi",
				 routeTemplate: "api/{controller}/{id}",
				 defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
