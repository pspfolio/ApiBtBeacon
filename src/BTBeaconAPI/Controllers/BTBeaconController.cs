using BTBeaconAPI.Services.Interfaces;
using BTBeaconAPI.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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

		[HttpGet("{guid}", Name = "BeaconGet")]
		public async Task<IActionResult> GetAsync(Guid guid) {
			try {
				var result = await _beaconService.GetByGuidAsync(guid);

				if (result == null) return NotFound($"Beacon {guid} was not found");

				return Ok(result);
			} catch
			{

			}

			return BadRequest();
		}

		[HttpPost("add")]
		public async Task<IActionResult> AddAsync([FromBody]BeaconDto beacon) {
			try
			{
				var newBeacon = await _beaconService.AddAsync(beacon);
				string newUri = Url.Link("BeaconGet", new { guid = newBeacon.Guid });
				return Created(newUri, newBeacon);

			} catch(Exception e)
			{

			}
			return BadRequest();

		}
		
		
	}
}
