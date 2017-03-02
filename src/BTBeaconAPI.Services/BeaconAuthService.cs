using BTBeaconAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTBeaconAPI.Services.Models;
using Microsoft.AspNetCore.Identity;
using BTBeaconAPI.Data.Entities;

namespace BTBeaconAPI.Services
{
	public class BeaconAuthService : IBeaconAuthService
	{
		private readonly UserManager<User> _userManager;
		public BeaconAuthService(UserManager<User> userManager)
		{
			_userManager = userManager;
		}
		public async Task<IdentityResult> RegisterAsync(RegisterViewModel model)
		{
			var user = new User
			{
				Email = model.Email,
				UserName = model.Email,
				Firstname = model.Name
			};

			var result = await _userManager.CreateAsync(user, model.Password);

			return result;
		}

	}
}
