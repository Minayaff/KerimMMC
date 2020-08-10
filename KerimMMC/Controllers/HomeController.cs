using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KerimMMC.Models;
using KerimMMC.DAL;

namespace KerimMMC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Blogs.OrderByDescending(i => i.Id).Take(3).ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
             Contact contact = new Contact();
            return View(contact);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }

            if (!contact.Email.Contains('@'))
            {
                return View(contact);
            }
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Services()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Team()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
