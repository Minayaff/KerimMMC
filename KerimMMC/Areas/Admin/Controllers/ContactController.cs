using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KerimMMC.DAL;
using KerimMMC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KerimMMC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Contacts.OrderByDescending(i => i.Id).ToList());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Contact contact = await _context.Contacts.FindAsync(id);
            if (contact == null) return NotFound();
            return View(contact);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Contact contact = await _context.Contacts.FindAsync(id);
            if (contact == null) return NotFound();
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Mesaj silindi.";
            return RedirectToAction(nameof(Index));
        }
    }
}