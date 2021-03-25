using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.Controllers
{
	[Route("api/{controller}/{action}")]
	[ApiController]
	public class HomeController : ControllerBase
	{
		[HttpGet]
		[Authorize]
		public IActionResult Index()
		{
			var username = HttpContext.User.Identity.Name;

			return Ok($"Olá você foi autenticado, seu nome de usuário é: {username}");
		}
	}
}
