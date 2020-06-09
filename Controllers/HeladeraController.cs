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
    public class HeladeraController : Controller
    {
        private readonly HogarDataBaseContext _context;

        public HeladeraController(HogarDataBaseContext context)
        {
            _context = context;
        }

        // GET: Heladera
        public async Task<IActionResult> Index()
        {
            return View(await _context.Heladeras.ToListAsync());
        }

        // GET: Heladera/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heladera = await _context.Heladeras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (heladera == null)
            {
                return NotFound();
            }

            return View(heladera);
        }

        // GET: Heladera/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Heladera/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TempHeladera,TempFreezer,Id,Nombre")] Heladera heladera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(heladera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(heladera);
        }

        // GET: Heladera/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heladera = await _context.Heladeras.FindAsync(id);
            if (heladera == null)
            {
                return NotFound();
            }
            return View(heladera);
        }

        // POST: Heladera/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TempHeladera,TempFreezer,Id,Nombre")] Heladera heladera)
        {
            if (id != heladera.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(heladera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeladeraExists(heladera.Id))
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
            return View(heladera);
        }

        // GET: Heladera/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heladera = await _context.Heladeras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (heladera == null)
            {
                return NotFound();
            }

            return View(heladera);
        }

        // POST: Heladera/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var heladera = await _context.Heladeras.FindAsync(id);
            _context.Heladeras.Remove(heladera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeladeraExists(int id)
        {
            return _context.Heladeras.Any(e => e.Id == id);
        }
    }
}
