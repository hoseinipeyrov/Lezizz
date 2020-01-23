using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lezizz.Core.Domain.Entities;
using Lezizz.Infra.Infrastructure.Persistence;
using Lezizz.Core.ApplicationService.Poses.Queries;
using Lezizz.Core.ApplicationService.Poses.Commands;

namespace Lezizz.Presentation.Web.Controllers
{
    public class PosController : ApiController
    {
        private readonly LezizzDbContext _context;

        public PosController(LezizzDbContext context)
        {
            _context = context;
        }

        // GET: Pos
        public async Task<IActionResult> Index()
        {
            var r = await Mediator.Send(new GetPosQuery());
            var poss = new List<Pos>();
            return View(poss);
        }
        public IActionResult List()
        {
            return View();
        }
        public async Task<JsonResult> PosList()
        {
            var posVm = await Mediator.Send(new GetPosQuery());
            return Json(new { data = posVm.PosList });
        }



        // GET: Pos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pos = await _context.Poses
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
        [HttpPost]
        public async Task<JsonResult> CreatePos(Pos pos)
        {
                _context.Add(pos);
                await _context.SaveChangesAsync();
                return Json(new { status = true });
            
        }

        // POST: Pos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("PosId,PersianName,EnglishName,TablesCount,SeatsCount,ServiceChargePercent,TaxChangePercent,VatChangePercent,TicketNumber,TicketNoDailyReset,InvoiceType,CreatedBy,CreatedAt,LastModifiedBy,LastModifiedAt")] Pos pos)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(pos);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(pos);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create([FromBody]CreatePosCommand command)
        {
            var r = Mediator.Send(command);
            return Json("");
        }

        // GET: Pos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pos = await _context.Poses.FindAsync(id);
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
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var pos = await _context.Poses
                .FirstOrDefaultAsync(m => m.PosId == id);
            if (pos == null)
            {
                return Json(new { status = false });
            }
            else
            {
                _context.Poses.Remove(pos);
                await _context.SaveChangesAsync();
                return Json(new { status = true });
            }

        }

        // POST: Pos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pos = await _context.Poses.FindAsync(id);
            _context.Poses.Remove(pos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PosExists(int id)
        {
            return _context.Poses.Any(e => e.PosId == id);
        }
    }
}
