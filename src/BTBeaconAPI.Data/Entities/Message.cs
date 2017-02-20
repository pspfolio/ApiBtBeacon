using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Data.Entities
{
	public class Message
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }

		public int BeaconId { get; set; }
		public Beacon Beacon { get; set; }
	}
}
