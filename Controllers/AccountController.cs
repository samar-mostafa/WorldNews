using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WorldNews.ViewModels;

namespace WorldNews.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManger;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManger = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { Email = model.Email, UserName = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManger.SignInAsync(user, true);
                    return RedirectToAction("Categories", "Home");
                }

            }

            return View(model);
        }

        [HttpGet]
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
               var result= await signInManger.PasswordSignInAsync(model.Email, model.Password, model.RememberMer, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Categories", "Home");
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
           await signInManger.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
