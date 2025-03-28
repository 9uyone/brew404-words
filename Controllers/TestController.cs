using Microsoft.AspNetCore.Mvc;

namespace brew404_words_webapi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TestController : ControllerBase
	{
		[HttpGet]
		public IActionResult Index()
		{
			return Ok("hello");
		}
	}
}
