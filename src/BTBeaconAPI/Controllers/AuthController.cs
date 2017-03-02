using BTBeaconAPI.Services.Interfaces;
using BTBeaconAPI.Services.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Controllers
{
	[Route("api/auth")]
	public class AuthController : Controller
	{
		private readonly IBeaconAuthService _authService;
		public AuthController(IBeaconAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("register")]
		[AllowAnonymous]
		public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
		{
			try
			{
				if(ModelState.IsValid)
				{
					var result = await _authService.RegisterAsync(model);
					return Ok();
				}
			}
			catch (Exception)
			{

				throw;
			}

			return BadRequest("Register failed");
		}
	}
}
