using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GCP_ConsumerApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace GCP_ConsumerApplication.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<string> Get()
		{
			ConsumerDetails[] consumerDetails = new ConsumerDetails[2];
			consumerDetails[0] = new ConsumerDetails { firstName = "Williams", lastName = "Smith", dateOfBirth = "01-Jan-1980" };
			consumerDetails[1] = new ConsumerDetails { firstName = "Steve", lastName = "Jobs", dateOfBirth = "22-Dec-1970" };

			string response = JsonConvert.SerializeObject(consumerDetails, Formatting.None);

			return response;
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "Welcome to ADS Info Systems, A new venture of advance technologies in digital world";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
