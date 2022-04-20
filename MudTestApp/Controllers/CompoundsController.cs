using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MudTestApp.Models.DataLayer;
using MudTestApp.Models;

namespace MudTestApp.Controllers
{
    public class CompoundsController : Controller
    {
        private readonly MudTestDbContext _context;

        public CompoundsController(MudTestDbContext context)
        {
            _context = context;
        }

        // GET: Compounds
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblCompounds.ToListAsync());
        }

        // GET: Compounds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCompound = await _context.TblCompounds
                .FirstOrDefaultAsync(m => m.CompoundId == id);
            if (tblCompound == null)
            {
                return NotFound();
            }

            return View(tblCompound);
        }

        // GET: Compounds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Compounds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompoundId,Compound,Hardness,_25Mod,_50Mod,_100Mod,Tensile,Elongation,Development,SsmaTimeStamp")] TblCompound tblCompound)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblCompound);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblCompound);
        }

        // GET: Compounds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCompound = await _context.TblCompounds.FindAsync(id);
            if (tblCompound == null)
            {
                return NotFound();
            }
            return View(tblCompound);
        }

        // POST: Compounds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompoundId,Compound,Hardness,_25Mod,_50Mod,_100Mod,Tensile,Elongation,Development,SsmaTimeStamp")] TblCompound tblCompound)
        {
            if (id != tblCompound.CompoundId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblCompound);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblCompoundExists(tblCompound.CompoundId))
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
            return View(tblCompound);
        }

        // GET: Compounds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCompound = await _context.TblCompounds
                .FirstOrDefaultAsync(m => m.CompoundId == id);
            if (tblCompound == null)
            {
                return NotFound();
            }

            return View(tblCompound);
        }

        // POST: Compounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblCompound = await _context.TblCompounds.FindAsync(id);
            _context.TblCompounds.Remove(tblCompound);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblCompoundExists(int id)
        {
            return _context.TblCompounds.Any(e => e.CompoundId == id);
        }
    }
}
