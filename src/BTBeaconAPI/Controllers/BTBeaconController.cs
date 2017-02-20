﻿using BTBeaconAPI.Services.Interfaces;
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
		private readonly IBeaconService _beaconService;
		public BTBeaconController(IBeaconService beaconService)
		{
			_beaconService = beaconService;
		}

		[HttpGet("{guid}")]
		public IActionResult GetAsync(Guid guid)
		{
			var result = _beaconService.GetByGuid(guid);
			return Ok(result);
		}
	}
}
