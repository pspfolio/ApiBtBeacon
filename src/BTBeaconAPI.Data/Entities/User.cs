using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BTBeaconAPI.Data.Entities
{
	public class User : IdentityUser
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }

	

	}
}
