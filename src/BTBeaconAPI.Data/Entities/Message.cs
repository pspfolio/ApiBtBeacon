using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Data.Entities
{
	public class Message
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }

		[ForeignKey("Beacon")]
		public Guid BeaconGuid { get; set; }
		public Beacon Beacon { get; set; }
	}
}
