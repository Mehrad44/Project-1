using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		private static List<Person> personLists = new List<Person>
		{
			new Person
			{
				Id = 1,
				Name = "Mehrad",
				Age = 10,
				Email = "mehradkhavary@gmail.com",
				Phone = "0999999999999",
				
			},
			new Person
			{
				Id = 2,
				Name = "Nima",
				Age =20,
				Email = "nima@gmail.com",
				Phone = "09111111111111111111",
			},
			new Person
			{
				Id = 3,
				Name = "Mohsen",
				Age =30,	
				Email = "mohsen@gmail.com",
				Phone = "09222222222",
			}
		};
		[HttpGet("{email}")]
	
		public async Task<IActionResult> GetPersonEmail(string email)
		{
			var emials = personLists.Find(x => x.Email == email);
			if(emials == null)
			{
				return NotFound("SOrry but this emial isnit exist");
			}

			return Ok(emials);
			
		}
	}
}
