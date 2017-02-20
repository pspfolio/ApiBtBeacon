using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Data.Entities
{
	public class Beacon
	{
		[Key]
		public Guid Guid { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool Status { get; set; }
		public bool Removed { get; set; }
		public DateTime? RemovedDate { get; set; }

		public Message Message { get; set; }
	}
}
