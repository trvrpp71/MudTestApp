using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MudTestApp.Models.DataLayer;

namespace MudTestApp.Controllers
{
    public class MainController : Controller
    {
        private readonly MudTestDbContext _context;

        public MainController(MudTestDbContext context)
        {
            _context = context;
        }

        // GET: Main
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblMains.ToListAsync());
        }

        // GET: Main/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMain = await _context.TblMains
                .FirstOrDefaultAsync(m => m.Mt == id);
            if (tblMain == null)
            {
                return NotFound();
            }

            return View(tblMain);
        }

        // GET: Main/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Main/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mt,Customer,Contact,LabTech,MudType,MudSystemName,ReceivedDate,ExposureTime,DateIn,TimeIn,DateOut,TimeOut,LegacyMt,SpecialInstructions,Rma,SsmaTimeStamp")] TblMain tblMain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblMain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblMain);
        }

        // GET: Main/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMain = await _context.TblMains.FindAsync(id);
            if (tblMain == null)
            {
                return NotFound();
            }
            return View(tblMain);
        }

        // POST: Main/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Mt,Customer,Contact,LabTech,MudType,MudSystemName,ReceivedDate,ExposureTime,DateIn,TimeIn,DateOut,TimeOut,LegacyMt,SpecialInstructions,Rma,SsmaTimeStamp")] TblMain tblMain)
        {
            if (id != tblMain.Mt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblMain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblMainExists(tblMain.Mt))
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
            return View(tblMain);
        }

        // GET: Main/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMain = await _context.TblMains
                .FirstOrDefaultAsync(m => m.Mt == id);
            if (tblMain == null)
            {
                return NotFound();
            }

            return View(tblMain);
        }

        // POST: Main/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblMain = await _context.TblMains.FindAsync(id);
            _context.TblMains.Remove(tblMain);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblMainExists(int id)
        {
            return _context.TblMains.Any(e => e.Mt == id);
        }
    }
}
