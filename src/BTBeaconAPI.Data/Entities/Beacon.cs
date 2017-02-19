using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Data.Entities
{
	public class Beacon
	{
		public int Id { get; set; }
		public Guid Guid { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool Status { get; set; }
		public bool Removed { get; set; }
		public DateTime RemovedDate { get; set; }

		public int MessageId { get; set; }
		public Message Message { get; set; }
	}
}
