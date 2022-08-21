﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using School.Models.DbModels;
using School.Models.ViewModels.Account;

namespace School.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string returnUrl)
        {
            AppUser user = null;
            user = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (user is null)
                user = await _userManager.FindByNameAsync(loginViewModel.Email);
            if (user is null)
                return View();
                
            var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, false);

            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Log In Attempt");
            }

            return View(loginViewModel);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public async Task<IActionResult> Register(RegisterViweModel registerViweModel)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = registerViweModel.UserName,
                    Email = registerViweModel.Email,
                    FirstName = registerViweModel.FirstName,
                    LastName = registerViweModel.LastName
                };
                var result =  _userManager.CreateAsync(user, registerViweModel.Password);
                if (result.Result.Succeeded)
                {
                    
                    return RedirectToAction("Index", "Admin");
                }
                foreach (var er in result.Result.Errors)
                {
                    ModelState.AddModelError(string.Empty, er.Description);
                }
            }
            return View(registerViweModel);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> EmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already use");
            }
        }
    }
}
