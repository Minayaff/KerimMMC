using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KerimMMC.DAL;
using Microsoft.AspNetCore.Mvc;

namespace KerimMMC.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           
            return View(_context.Blogs.OrderByDescending(i => i.Id).ToList());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return View("Home/Error");
            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return View("Home/Error");
            return View(blog);
        }
    }
}