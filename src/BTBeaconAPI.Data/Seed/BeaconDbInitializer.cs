using BTBeaconAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Data.Seed
{
	public class BeaconDbInitializer
	{
		private BeaconContext _context;

		List<Beacon> _initData = new List<Beacon>
		{
			new Beacon
			{
				Guid = new Guid(),
				Name = "Beacon 1",
				Description = "Beacon to show messages",
				Status = true,
				Removed = false,
				RemovedDate = null,
				Message = new Message()
				{
					Title = "Title",
					Content = "This is message",
					BeaconGuid = new Guid()
				}
			}
		};

		public BeaconDbInitializer(BeaconContext context)
		{
			_context = context;
		}

		public async Task Seed()
		{
			if(!_context.Beacons.Any())
			{
				_context.AddRange(_initData);
				await _context.SaveChangesAsync();
			}
		}
	}
}
