﻿using BTBeaconAPI.Data.Entities;
using BTBeaconAPI.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Services.Interfaces
{
	public interface IBeaconService
	{
		Task<Beacon> GetByGuidAsync(Guid guid);

		Task<Beacon> AddAsync(BeaconDto beacon);
	}
}
