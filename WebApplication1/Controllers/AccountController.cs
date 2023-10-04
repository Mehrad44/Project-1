using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private static List<Person> personLists = new List<Person>
		{
			new Person
			{
				Id = 0,
				Name = "test",
				Age = 0,
				Email = "test",
				Phone = "0000000",

			} 
		};
		[HttpPost]
		public async Task<ActionResult<List<Person>>> AddInfo(Person person)
		{
			personLists.Add(person);
			return Ok($"OK The List is {personLists}");	
			


		}
	}
}
