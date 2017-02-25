using BTBeaconAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTBeaconAPI.Data.Entities;
using BTBeaconAPI.Data;
using Microsoft.EntityFrameworkCore;
using BTBeaconAPI.Services.Models;

namespace BTBeaconAPI.Services
{
	public class BeaconService : IBeaconService
	{
		private readonly BeaconContext _context;
		private readonly IBeaconConverter _converter;
		public BeaconService(BeaconContext context, IBeaconConverter converter)
		{
			_context = context;
			_converter = converter;
		}

		public async Task<Beacon> GetByGuidAsync(Guid guid)
		{
			var result = await _context.Beacons.FirstOrDefaultAsync(x => x.Guid == guid);
			return result;
		}
		public async Task<Beacon> AddAsync(BeaconDto beaconDto)
		{
			var beacon = _converter.ConvertDtoToBeacon(beaconDto);
			_context.Add(beacon);
			await _context.SaveChangesAsync();
			return beacon;
		}

	}
}
