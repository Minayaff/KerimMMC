using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KerimMMC.DAL;
using KerimMMC.Extension;
using KerimMMC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace KerimMMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _env;
        public BlogController(AppDbContext  context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Blogs.OrderByDescending(i => i.Id).ToList());
        }

        public async Task<IActionResult> Details( int? id)
        {
            if (id==null)  return NotFound();
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpGet]
        public IActionResult Create()
        {

            Blog blog = new Blog();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (blog.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can't be null");
                return View(blog);
            }

            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Photo type is not valid...");
                return View(blog);
            }

            blog.Image = await blog.Photo.SaveAsync(_env.WebRootPath);

            blog.CreatedDate = DateTime.Now;

            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blogone = await _context.Blogs.FindAsync(id);
            if (blogone == null) return NotFound();
            _context.Blogs.Remove(blogone);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Blog silindi.";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        //Edit(Blog) (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( Blog blog, int id)
        {

            var blogBefore = await _context.Blogs.FindAsync(id);

            if (blog.Photo != null)
            {
                if (!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Photo type is not valid!");
                    return View(blog);
                }

                blogBefore.Image = await blog.Photo.SaveAsync(_env.WebRootPath);

            }

            blogBefore.HeadText = blog.HeadText;
            blogBefore.Text = blog.Text;
            blogBefore.CreatedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


    }
}