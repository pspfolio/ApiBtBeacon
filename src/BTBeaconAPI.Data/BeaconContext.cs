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

		public DbSet<Beacon> Beacon { get; set; }
		public DbSet<Message> Message { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Beacon;Trusted_Connection=True;MultipleActiveResultSets=true");
		}
	}
}
