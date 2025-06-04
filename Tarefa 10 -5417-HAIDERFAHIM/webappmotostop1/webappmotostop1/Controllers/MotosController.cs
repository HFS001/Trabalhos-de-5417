using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webappmotostop1.Data;
using webappmotostop1.Models;

namespace webappmotostop1.Controllers
{
    public class MotosController : Controller
    {
        private readonly WEBASPITSContext _context;

        public MotosController(WEBASPITSContext context)
        {
            _context = context;
        }

        // GET: Motos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Motos.ToListAsync());
        }

        // GET: Motos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moto = await _context.Motos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moto == null)
            {
                return NotFound();
            }

            return View(moto);
        }

        // GET: Motos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Model,Year,Condition,LicensePlateNumber,Price")] Moto moto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moto);
        }

        // GET: Motos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moto = await _context.Motos.FindAsync(id);
            if (moto == null)
            {
                return NotFound();
            }
            return View(moto);
        }

        // POST: Motos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Model,Year,Condition,LicensePlateNumber,Price")] Moto moto)
        {
            if (id != moto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotoExists(moto.Id))
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
            return View(moto);
        }

        // GET: Motos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moto = await _context.Motos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moto == null)
            {
                return NotFound();
            }

            return View(moto);
        }

        // POST: Motos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moto = await _context.Motos.FindAsync(id);
            if (moto != null)
            {
                _context.Motos.Remove(moto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotoExists(int id)
        {
            return _context.Motos.Any(e => e.Id == id);
        }
    }
}
