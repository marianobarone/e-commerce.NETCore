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
    public class SucursalesController : Controller
    {
        private readonly EcommerceDbContext _context;

        public SucursalesController(EcommerceDbContext context)
        {
            _context = context;
        }

        // GET: Sucursales
        public IActionResult Index()
        {
            return View(_context.Sucursales
                .Include(stock => stock.StockItems).ThenInclude(producto => producto.Producto)
                .OrderBy(s => s.Nombre)                
                .ToList());
        }

        // GET: Sucursales/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sucursal = _context.Sucursales
                .Include(stock => stock.StockItems).ThenInclude(producto => producto.Producto)
                .FirstOrDefault(m => m.Id == id);

            if (sucursal == null)
            {
                return NotFound();
            }

            return View(sucursal);
        }

        // GET: Sucursales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sucursales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Direccion,Telefono,Email")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                sucursal.Id = Guid.NewGuid();
                _context.Add(sucursal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sucursal);
        }

        // GET: Sucursales/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursales.FindAsync(id);
            if (sucursal == null)
            {
                return NotFound();
            }
            return View(sucursal);
        }

        // POST: Sucursales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nombre,Direccion,Telefono,Email")] Sucursal sucursal)
        {
            if (id != sucursal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sucursal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SucursalExists(sucursal.Id))
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
            return View(sucursal);
        }


        [Authorize(Roles = nameof(Rol.Administrador))]
        [HttpGet]
        // GET: Sucursales/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sucursal == null)
            {
                return NotFound();
            }

            return View(sucursal);
        }

        // POST: Sucursales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            
            var sucursal = _context.Sucursales
                .Include(stock => stock.StockItems).ThenInclude(producto => producto.Producto)
                .FirstOrDefault(suc => suc.Id == id);

            var hayStock = false;
            var i = 0;

            while (!hayStock && i < sucursal.StockItems.Count)
            {
                
                if (sucursal.StockItems.ElementAt(i).Cantidad > 0)
                {
                    hayStock = true;
                }
                i++;
            }

            if (hayStock == false)
            {
                var stockSucursal = _context.StockItems
                    .Where(suc => suc.Sucursal.Id == id)
                    .ToList();

                foreach (var stockItem in stockSucursal)
                {
                    _context.StockItems.Remove(stockItem);
                }

                _context.Sucursales.Remove(sucursal);
                _context.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["NoSePuedeEliminar"] = hayStock;
                return View("Delete");
            }
        }

        private bool SucursalExists(Guid id)
        {
            return _context.Sucursales.Any(e => e.Id == id);
        }
    }
}
