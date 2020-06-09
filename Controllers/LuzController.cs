using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HogarIoT;
using HogarIoT.Context;

namespace HogarIoT.Controllers
{
    public class LuzController : Controller
    {
        private readonly HogarDataBaseContext _context;

        public LuzController(HogarDataBaseContext context)
        {
            _context = context;
        }

        // GET: Luz
        public async Task<IActionResult> Index()
        {
            return View(await _context.Luces.ToListAsync());
        }

        // GET: Luz/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luz = await _context.Luces
                .FirstOrDefaultAsync(m => m.Id == id);
            if (luz == null)
            {
                return NotFound();
            }

            return View(luz);
        }

        // GET: Luz/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Luz/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Intensidad,Id,Nombre")] Luz luz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(luz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(luz);
        }

        // GET: Luz/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luz = await _context.Luces.FindAsync(id);
            if (luz == null)
            {
                return NotFound();
            }
            return View(luz);
        }

        // POST: Luz/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Intensidad,Id,Nombre")] Luz luz)
        {
            if (id != luz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(luz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LuzExists(luz.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(luz);
        }

        // GET: Luz/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var luz = await _context.Luces
                .FirstOrDefaultAsync(m => m.Id == id);
            if (luz == null)
            {
                return NotFound();
            }

            return View(luz);
        }

        // POST: Luz/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var luz = await _context.Luces.FindAsync(id);
            _context.Luces.Remove(luz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LuzExists(int id)
        {
            return _context.Luces.Any(e => e.Id == id);
        }
    }
}
