using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TRUJILLOISAAC_EXAMENP1.Data;
using TRUJILLOISAAC_EXAMENP1.Models;

namespace TRUJILLOISAAC_EXAMENP1.Controllers
{
    public class ITrujilloesController : Controller
    {
        private readonly TRUJILLOISAAC_EXAMENP1Context _context;

        public ITrujilloesController(TRUJILLOISAAC_EXAMENP1Context context)
        {
            _context = context;
        }

        // GET: ITrujilloes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ITrujillo.ToListAsync());
        }

        // GET: ITrujilloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTrujillo = await _context.ITrujillo
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (iTrujillo == null)
            {
                return NotFound();
            }

            return View(iTrujillo);
        }

        // GET: ITrujilloes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ITrujilloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,Name,Fecha,numfav,quierecambiar,Idceluar")] ITrujillo iTrujillo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iTrujillo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iTrujillo);
        }

        // GET: ITrujilloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTrujillo = await _context.ITrujillo.FindAsync(id);
            if (iTrujillo == null)
            {
                return NotFound();
            }
            return View(iTrujillo);
        }

        // POST: ITrujilloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,Name,Fecha,numfav,quierecambiar,Idceluar")] ITrujillo iTrujillo)
        {
            if (id != iTrujillo.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iTrujillo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ITrujilloExists(iTrujillo.IdUsuario))
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
            return View(iTrujillo);
        }

        // GET: ITrujilloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTrujillo = await _context.ITrujillo
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (iTrujillo == null)
            {
                return NotFound();
            }

            return View(iTrujillo);
        }

        // POST: ITrujilloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iTrujillo = await _context.ITrujillo.FindAsync(id);
            if (iTrujillo != null)
            {
                _context.ITrujillo.Remove(iTrujillo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ITrujilloExists(int id)
        {
            return _context.ITrujillo.Any(e => e.IdUsuario == id);
        }
    }
}
