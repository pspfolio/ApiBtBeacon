using BTBeaconAPI.Data.Entities;
using BTBeaconAPI.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Services.Interfaces
{
	public interface IBeaconConverter
	{
		Beacon ConvertDtoToBeacon(BeaconDto beaconDto);
	}
}
