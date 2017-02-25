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

		public BeaconDbInitializer(BeaconContext context)
		{
			_context = context;
		}

		public async Task Seed()
		{
			if (!_context.Beacons.Any())
			{
				_context.AddRange(getInitData(Guid.NewGuid()));
				await _context.SaveChangesAsync();
			}
		}

		private ICollection<Beacon> getInitData(Guid guid)
		{
			return new List<Beacon>
				{
					new Beacon
					{
						Guid = guid,
						Name = "Beacon 1",
						Description = "Beacon to show messages",
						Status = true,
						Removed = false,
						RemovedDate = null,
						Message = new Message()
						{
							BeaconGuid = guid,
							Title = "Title",
							Content = "This is message",
						}
					}
				};
		}
	}
}
