using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBaker.Web.Controllers
{
	[Authorize]
	public class AccountController : Controller
	{
		private UserManager<AppUser> _userManager;
		private SignInManager<AppUser> _signInManager;


		[AllowAnonymous]
		public IActionResult Register()
		{
			return View();
		}

		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> RegisterAsync()
		{
			var result = await _userManager.CreateAsync(new AppUser());
			_signInManager.SignInAsync(new AppUser(), false);
			return RedirectToAction("Index", "Home");
		}

		[AllowAnonymous]
		public IActionResult Login()
		{
			return View();
		}
	}
}
