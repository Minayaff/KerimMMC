using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KerimMMC.DAL;
using KerimMMC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace KerimMMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _myroot;

        public AccountController(AppDbContext dbContext,
                                 UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager,
                                 RoleManager<IdentityRole> roleManager,
                                 IHostingEnvironment myroot)
        {
            _db = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _myroot = myroot;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);
            IdentityUser user = await _userManager.FindByEmailAsync(loginViewModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("Email", "Email or Password is invalid");
                return View(loginViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                  await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, true, true);
            if (!signInResult.Succeeded)
            {

                ModelState.AddModelError("Email", "Email or password is invalid");
                return View(loginViewModel);
            }
            return RedirectToAction("Index", "Account");
        }

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        public async Task SeedRoles()
        {
            if (!await _roleManager.RoleExistsAsync(roleName: "Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "Admin"));
            }
        }
        public async Task SeedAdmin()
        {
            if (_userManager.FindByEmailAsync("admin@gmail.com").Result == null)
            {
                IdentityUser admin = new IdentityUser()
                {
                    UserName = "admin",
                    Email = "admin@gmail.com",
                };
                IdentityResult result = await _userManager.CreateAsync(admin, "admin123A!@");
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(admin, "Admin").Wait();
                    await _db.SaveChangesAsync();

                    await _signInManager.SignInAsync(admin, true);

                }

            }
        }
    }
}