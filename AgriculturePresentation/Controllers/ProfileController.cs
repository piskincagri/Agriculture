using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.mail = values.Email;
            userEditViewModel.phone = values.PhoneNumber;
           
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.password == p.confirmPassword)
            {
                values.Email = p.mail;
                values.PhoneNumber = p.phone;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, p.password);
                var result = await _userManager.UpdateAsync(values);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();


        }
    }
}
