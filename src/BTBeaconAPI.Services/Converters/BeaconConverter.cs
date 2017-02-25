using BTBeaconAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTBeaconAPI.Data.Entities;
using BTBeaconAPI.Services.Models;

namespace BTBeaconAPI.Services.Converters
{
	public class BeaconConverter : IBeaconConverter
	{
		public Beacon ConvertDtoToBeacon(BeaconDto beaconDto)
		{
			var beacon = new Beacon
			{
				Guid = Guid.NewGuid(),
				Name = beaconDto.Name,
				Description = beaconDto.Description,
				Status = true
			};

			return beacon;
		}
	}
}
