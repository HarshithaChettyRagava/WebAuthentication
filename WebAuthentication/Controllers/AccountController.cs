using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using WebAuthentication.Models;

namespace WebAuthentication.Controllers
{
    public class AccountController : Controller
    {
        //A very simplistic user store. This would normally be a database or similar.
        public List<ApplicationUser> Users => new List<ApplicationUser>() {
            new ApplicationUser { UserName = "Harshitha", Password = "Harshitha@1" },
            new ApplicationUser{ UserName = "Zaiba", Password = "Zaiba@2" },
            new ApplicationUser{ UserName = "Vamshi", Password = "Vamshi@3" },
        };

        public IActionResult Login(string returnUrl = null)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(ApplicationUser user, string returnUrl = null)
        {
            const string badUserNameOrPasswordMessage = "Username or password is incorrect.";

            if (user == null)
            {
                return BadRequest(badUserNameOrPasswordMessage);
            }

            var lookupUser = Users.FirstOrDefault(u => u.UserName == user.UserName);

            if (lookupUser?.Password != user.Password)
            {
                return BadRequest(badUserNameOrPasswordMessage);
            }

            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(ClaimTypes.Name, lookupUser.UserName));

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

            if (returnUrl == null)
            {
                returnUrl = TempData["returnUrl"]?.ToString();
            }

            if (returnUrl != null)
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}