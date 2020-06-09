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
    public class AireAcondicionadoController : Controller
    {
        private readonly HogarDataBaseContext _context;

        public AireAcondicionadoController(HogarDataBaseContext context)
        {
            _context = context;
        }

        // GET: AireAcondicionado
        public async Task<IActionResult> Index()
        {
            return View(await _context.AA.ToListAsync());
        }

        // GET: AireAcondicionado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aireAcondicionado = await _context.AA
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aireAcondicionado == null)
            {
                return NotFound();
            }

            return View(aireAcondicionado);
        }

        // GET: AireAcondicionado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AireAcondicionado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Temperatura,Id,Nombre")] AireAcondicionado aireAcondicionado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aireAcondicionado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aireAcondicionado);
        }

        // GET: AireAcondicionado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aireAcondicionado = await _context.AA.FindAsync(id);
            if (aireAcondicionado == null)
            {
                return NotFound();
            }
            return View(aireAcondicionado);
        }

        // POST: AireAcondicionado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Temperatura,Id,Nombre")] AireAcondicionado aireAcondicionado)
        {
            if (id != aireAcondicionado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aireAcondicionado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AireAcondicionadoExists(aireAcondicionado.Id))
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
            return View(aireAcondicionado);
        }

        // GET: AireAcondicionado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aireAcondicionado = await _context.AA
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aireAcondicionado == null)
            {
                return NotFound();
            }

            return View(aireAcondicionado);
        }

        // POST: AireAcondicionado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aireAcondicionado = await _context.AA.FindAsync(id);
            _context.AA.Remove(aireAcondicionado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AireAcondicionadoExists(int id)
        {
            return _context.AA.Any(e => e.Id == id);
        }
    }
}
