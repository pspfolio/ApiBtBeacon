using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Controllers
{
	[Route("api/beacon")]
	public class BTBeaconController : Controller
	{
		[HttpGet("")]
		public IActionResult GetAsync()
		{
			return Ok(new { Name = "BT", Message = "Jou!" });
		}
	}
}
