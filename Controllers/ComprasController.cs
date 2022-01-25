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
using System.Security.Claims;

namespace BENT1C.Grupo1.Controllers
{
    public class ComprasController : Controller
    {
        private readonly EcommerceDbContext _context;

        public ComprasController(EcommerceDbContext context)
        {
            _context = context;
        }

        private bool sucursalesConStock(Guid carritoId, Guid sucursalId)
        {
            var carrito = _context.Carritos
                .Include(carrito => carrito.CarritoItems)
                .FirstOrDefault(carrito => carrito.Id == carritoId);

            var sucursal = _context.Sucursales
                .Include(sucursal => sucursal.StockItems)
                .FirstOrDefault(sucursal => sucursal.Id == sucursalId);

            var hayStock = true;


            if (sucursal != null)
            {
                foreach (CarritoItem item in carrito.CarritoItems)
                {
                    hayStock = hayStock && sucursal.StockItems.Any(stockItem => stockItem.ProductoId == item.ProductId && stockItem.Cantidad >= item.Cantidad);

                    if (hayStock)
                    {
                        sucursal.StockItems.Find(stock => stock.ProductoId == item.ProductId).Cantidad -= item.Cantidad;

                    }
                }

                if (hayStock)
                {
                    _context.SaveChanges();
                }
            }
            else
            {
                hayStock = false;
            }

            return hayStock;

        }


        [Authorize(Roles = nameof(Rol.Cliente))]
        [HttpPost]
        public IActionResult Comprar(Guid carritoId, Guid sucursalId)
        {
            var clienteId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var carrito = _context.Carritos
                .Include(carrito => carrito.CarritoItems).ThenInclude(carritoItems => carritoItems.Producto)
                .FirstOrDefault(carrito => carrito.Id == carritoId);

            var cliente = _context.Clientes
                .FirstOrDefault(cliente => cliente.Id == clienteId);

            var sucursal = _context.Sucursales
                .FirstOrDefault(sucursal => sucursal.Id == sucursalId);

            if (sucursalesConStock(carritoId, sucursalId))
            {
                carrito.Activo = false;

                var compra = new Compra
                {
                    Id = Guid.NewGuid(),
                    ClienteId = cliente.Id,
                    CarritoId = carrito.Id,
                    Total = carrito.Subtotal,
                    FechaCompra = DateTime.Now
                };

                var carritoNuevo = new Carrito
                {
                    Activo = true,
                    ClienteId = cliente.Id,
                    Subtotal = 0
                };

                _context.Add(compra);
                _context.Add(carritoNuevo);
                _context.SaveChanges();

                ViewBag.Sucursal = sucursal;

                return RedirectToAction("Resumen", new { compraId = compra.Id, sucursalId = sucursal.Id });
            }

            return RedirectToAction("CarritoConSucursalesDisponibles", "Carritos");

        }

        public IActionResult Resumen(Guid compraId, Guid sucursalId)
        {

            var compra = _context.Compras
                .Include(compra => compra.Carrito).ThenInclude(carrito => carrito.CarritoItems).ThenInclude(carritoItem => carritoItem.Producto)
                .First(compra => compra.Id == compraId);

            ViewBag.Sucursal = _context.Sucursales.First(sucursal => sucursal.Id == sucursalId);

            return View(compra);
        }

        private bool CompraExists(Guid id)
        {
            return _context.Compras.Any(e => e.Id == id);
        }
    }
}
