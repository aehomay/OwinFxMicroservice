using System;
using System.Collections.Generic;
using System.Web.Http;

namespace OwinFxMicroservice
{
	/// <summary>
	/// The Costume Web Api Controller
	/// </summary>
	public class ValuesController : ApiController
	{
		/// <summary>
		/// GET api/values 
		/// </summary>
		/// <returns>IEnu</returns>
		public IEnumerable<string> Get() => new string[] { "Hello", "World", "...!" };

		// GET api/values/3
		public string Get(int id) => (id == 1) ? "Hello" : (id == 2) ? "World" : (id == 3) ? "...!" : "No world found... ;-)";

		// POST api/values 
		public void Post([FromBody]string value) => Console.WriteLine($"The received value is {value}");

		// PUT api/values/5 
		public void Put(int id, [FromBody]string value)
		{
			//TODO: Write your Put logic here..
		}

		// DELETE api/values/5 
		public void Delete(int id)
		{
			//TODO: Write your Delete logic here..
		}
	}
}
