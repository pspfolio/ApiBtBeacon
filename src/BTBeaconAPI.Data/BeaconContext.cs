using BTBeaconAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Data
{
	public class BeaconContext : DbContext
	{

		public BeaconContext(DbContextOptions<BeaconContext> options)
			:base(options)
		{ }

		public DbSet<Beacon> Beacons { get; set; }
		public DbSet<Message> Messages { get; set; }

	}
}
