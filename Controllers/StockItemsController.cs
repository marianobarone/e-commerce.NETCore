using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BENT1C.Grupo1.Database;
using BENT1C.Grupo1.Models;
using Microsoft.AspNetCore.Authorization;

namespace BENT1C.Grupo1.Controllers
{
    [Authorize(Roles = nameof(Rol.Administrador))]
    public class StockItemsController : Controller
    {
        private readonly EcommerceDbContext _context;

        public StockItemsController(EcommerceDbContext context)
        {
            _context = context;
        }

        // GET: StockItems/Create
        public IActionResult Create()
        {
            ViewData["ProductoId"] = new SelectList(_context.Productos, "Id", "Nombre");
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Nombre");
            return View();
        }

        // POST: StockItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cantidad,SucursalId,ProductoId")] StockItem stockItem)
        {

            var sucursal = _context.Sucursales
                .Include(sucursal => sucursal.StockItems)
                .FirstOrDefault(sucursal => sucursal.Id == stockItem.SucursalId);

            var stockItemExistente = sucursal.StockItems.FirstOrDefault(stItem => stItem.ProductoId == stockItem.ProductoId);

            if (stockItemExistente != null)
            {
                stockItemExistente.Cantidad += stockItem.Cantidad;

                _context.Update(stockItemExistente);
                _context.SaveChanges();
                return RedirectToAction("Index", "Sucursales");
            }

            if (ModelState.IsValid)
            {

                stockItem.Id = Guid.NewGuid();
                _context.Add(stockItem);
                await _context.SaveChangesAsync();
                
                return RedirectToAction("Index", "Sucursales");
            }

            ViewData["ProductoId"] = new SelectList(_context.Productos, "Id", "Nombre", stockItem.ProductoId);
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Nombre", stockItem.SucursalId);

            return View(stockItem);
        }

        // POST: StockItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Cantidad,SucursalId,ProductoId")] StockItem stockItem)
        {
            if (id != stockItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockItemExists(stockItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }                
            }
            return RedirectToAction("Index", "Sucursales");
        }

        private bool StockItemExists(Guid id)
        {
            return _context.StockItems.Any(e => e.Id == id);
        }
    }
}
