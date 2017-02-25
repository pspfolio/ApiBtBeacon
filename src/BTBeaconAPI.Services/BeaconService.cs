using BTBeaconAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTBeaconAPI.Data.Entities;
using BTBeaconAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace BTBeaconAPI.Services
{
	public class BeaconService : IBeaconService
	{
		private readonly BeaconContext _context;
		public BeaconService(BeaconContext context)
		{
			_context = context;
		}
		public async Task<Beacon> GetByGuidAsync(Guid guid)
		{
			var result = await _context.Beacons.FirstOrDefaultAsync(x => x.Guid == guid);
			return result;
		}
	}
}
