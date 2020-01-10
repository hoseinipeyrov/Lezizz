using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lezizz.Core.Domain.Entities;
using Lezizz.Infra.Infrastructure.Persistence;

namespace Lezizz.Presentation.Web.Controllers
{
    public class PosController : Controller
    {
        private readonly LezizzDbContext _context;

        public PosController(LezizzDbContext context)
        {
            _context = context;
        }

        // GET: Pos
        public async Task<IActionResult> Index()
        {
            var poss = new List<Pos>();
            return View(poss);
        }

        // GET: Pos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pos = await _context.Pos
                .FirstOrDefaultAsync(m => m.PosId == id);
            if (pos == null)
            {
                return NotFound();
            }

            return View(pos);
        }

        // GET: Pos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PosId,PersianName,EnglishName,TablesCount,SeatsCount,ServiceChargePercent,TaxChangePercent,VatChangePercent,TicketNumber,TicketNoDailyReset,InvoiceType,CreatedBy,CreatedAt,LastModifiedBy,LastModifiedAt")] Pos pos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pos);
        }

        // GET: Pos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pos = await _context.Pos.FindAsync(id);
            if (pos == null)
            {
                return NotFound();
            }
            return View(pos);
        }

        // POST: Pos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PosId,PersianName,EnglishName,TablesCount,SeatsCount,ServiceChargePercent,TaxChangePercent,VatChangePercent,TicketNumber,TicketNoDailyReset,InvoiceType,CreatedBy,CreatedAt,LastModifiedBy,LastModifiedAt")] Pos pos)
        {
            if (id != pos.PosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PosExists(pos.PosId))
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
            return View(pos);
        }

        // GET: Pos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pos = await _context.Pos
                .FirstOrDefaultAsync(m => m.PosId == id);
            if (pos == null)
            {
                return NotFound();
            }

            return View(pos);
        }

        // POST: Pos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pos = await _context.Pos.FindAsync(id);
            _context.Pos.Remove(pos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PosExists(int id)
        {
            return _context.Pos.Any(e => e.PosId == id);
        }
    }
}
