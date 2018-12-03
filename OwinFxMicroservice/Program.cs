using Microsoft.Owin.Hosting;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace OwinFxMicroservice
{
	class Program
	{
		static void Main(string[] args)
		{
			string baseAddress = "http://localhost:9000/";

			// Start OWIN host 
			using (WebApp.Start<Startup>(url: baseAddress))
			{
				// Create HttpCient and make a request to api/values 
				var client = new HttpClient();

				#region GET
				Console.WriteLine("///////////////////////// GET HAS BEEN SENT ///////////////////////////////////////");
				var response = client.GetAsync(new Uri(baseAddress + "api/values")).Result;
				Console.WriteLine(response);
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);
				#endregion

				Console.WriteLine("Press any key to continue with the POST message or call Postman for more tests..");
				Console.ReadLine();

				#region POST
				Console.WriteLine("///////////////////////// POST HAS BEEN SENT ///////////////////////////////////");
				var stringContent = new StringContent(JsonConvert.SerializeObject("New World"), Encoding.UTF8, "application/json");
				response = client.PostAsync(new Uri(baseAddress + "api/values"), stringContent).Result;
				Console.WriteLine(response);
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);
				#endregion

				Console.WriteLine("Press any key to exit or call Postman for more tests.");
				Console.ReadLine();
			}
		}
	}
}
