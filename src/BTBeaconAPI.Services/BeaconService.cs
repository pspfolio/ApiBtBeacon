using BTBeaconAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTBeaconAPI.Data.Entities;
using BTBeaconAPI.Data;

namespace BTBeaconAPI.Services
{
	public class BeaconService : IBeaconService
	{
		private readonly BeaconContext _context;
		public BeaconService(BeaconContext context)
		{
			_context = context;
		}
		public Beacon GetByGuid(Guid guid)
		{
			var result = _context.Beacons.FirstOrDefault(x => x.Guid == guid);
			return result;
		}
	}
}
