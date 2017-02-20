using BTBeaconAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Services.Interfaces
{
	public interface IBeaconService
	{
		Beacon GetByGuid(Guid guid);
	}
}
