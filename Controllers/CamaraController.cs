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
    public class CamaraController : Controller
    {
        private readonly HogarDataBaseContext _context;

        public CamaraController(HogarDataBaseContext context)
        {
            _context = context;
        }

        // GET: Camara
        public async Task<IActionResult> Index()
        {
            return View(await _context.Camaras.ToListAsync());
        }

        // GET: Camara/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camara = await _context.Camaras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camara == null)
            {
                return NotFound();
            }

            return View(camara);
        }

        // GET: Camara/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Camara/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Grabar,Id,Nombre,Estado")] Camara camara)
        {
            if (ModelState.IsValid)
            {
                _context.Add(camara);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(camara);
        }

        // GET: Camara/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camara = await _context.Camaras.FindAsync(id);
            if (camara == null)
            {
                return NotFound();
            }
            return View(camara);
        }

        // POST: Camara/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Grabar,Id,Nombre,Estado")] Camara camara)
        {
            if (id != camara.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camara);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CamaraExists(camara.Id))
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
            return View(camara);
        }

        // GET: Camara/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camara = await _context.Camaras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (camara == null)
            {
                return NotFound();
            }

            return View(camara);
        }

        // POST: Camara/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var camara = await _context.Camaras.FindAsync(id);
            _context.Camaras.Remove(camara);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CamaraExists(int id)
        {
            return _context.Camaras.Any(e => e.Id == id);
        }
    }
}
