using BTBeaconAPI.Services.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBeaconAPI.Services.Interfaces
{
	public interface IBeaconAuthService
	{
		Task<IdentityResult> RegisterAsync(RegisterViewModel model);
	}
}
