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
    public class CarritosController : Controller
    {
        private readonly EcommerceDbContext _context;

        public CarritosController(EcommerceDbContext context)
        {
            _context = context;
        }


        [Authorize(Roles = nameof(Rol.Cliente))]
        [HttpGet]
        public IActionResult MiCarrito()
        {
            var clienteId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var carrito = _context.Carritos
                .Include(carrito => carrito.CarritoItems).ThenInclude(carritoItem => carritoItem.Producto)
                .FirstOrDefault(carrito => carrito.ClienteId == clienteId && carrito.Activo);

            ViewBag.Sucursales = new SelectList(_context.Sucursales, "Id", "Nombre");

            return View(carrito);
        }

        [Authorize(Roles = nameof(Rol.Cliente))]
        [HttpGet]
        public IActionResult CarritoConSucursalesDisponibles()
        {
            var clienteId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var carrito = _context.Carritos
                .Include(carrito => carrito.CarritoItems).ThenInclude(carritoItem => carritoItem.Producto)
                .FirstOrDefault(carrito => carrito.ClienteId == clienteId && carrito.Activo);


            ViewBag.Sucursales = new SelectList(buscarSucursalesDisponibles(carrito), "Id", "Nombre");
            ViewData["NoDisponible"] = "true";

            return View("MiCarrito", carrito);
        }

        private List<Sucursal> buscarSucursalesDisponibles(Carrito carrito)
        {
            var sucursalesDiponibles = new List<Sucursal>();

            foreach (Sucursal suc in _context.Sucursales.Include(s => s.StockItems).ThenInclude(p => p.Producto))
            {
                var hayStock = true;

                foreach (CarritoItem item in carrito.CarritoItems)
                {
                    var itemSucursal = suc.StockItems.Find(p => p.Producto == item.Producto);

                    if (itemSucursal == null || item.Producto != itemSucursal.Producto || item.Cantidad > itemSucursal.Cantidad)
                    {
                        hayStock = false;
                    }
                }                
                if (hayStock)
                {
                    sucursalesDiponibles.Add(suc);
                }
            }

            return sucursalesDiponibles;
        }

        [Authorize(Roles = nameof(Rol.Cliente))]
        [HttpPost]
        public IActionResult AgregarProducto(Guid productoId, int cantidad)
        {
            var clienteId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var carrito = _context.Carritos
                .FirstOrDefault(carrito => carrito.ClienteId == clienteId && carrito.Activo);

            var carritoItemExistente = _context.CarritosItems.FirstOrDefault(carritoItemExistente => carritoItemExistente.CarritoId == carrito.Id && carritoItemExistente.ProductId == productoId);

            if (carritoItemExistente != null)
            {
                if ((carritoItemExistente.Cantidad + cantidad) > 0)
                {
                    carrito.Subtotal -= carritoItemExistente.SubTotal;
                    carritoItemExistente.Cantidad += cantidad;

                    carritoItemExistente.SubTotal = carritoItemExistente.Cantidad * carritoItemExistente.ValorUnitario;
                    carrito.Subtotal += carritoItemExistente.SubTotal;
                }
            }
            else
            {
                var producto = _context.Productos.Find(productoId);

                var carritoItem = new CarritoItem()
                {
                    Id = Guid.NewGuid(),
                    SubTotal = producto.PrecioVigente * cantidad,
                    CarritoId = carrito.Id,
                    ProductId = producto.Id,
                    ValorUnitario = producto.PrecioVigente,
                    Cantidad = cantidad,
                    CategoriaId = producto.CategoriaId
                };

                _context.CarritosItems.Add(carritoItem);

                carrito.Subtotal += carritoItem.SubTotal;
            }

            _context.SaveChanges();

            return RedirectToAction(nameof(MiCarrito));

        }


        [Authorize(Roles = nameof(Rol.Cliente))]
        [HttpPost]
        public IActionResult VaciarCarrito(Guid carritoId)
        {
            var carrito = _context.Carritos
                .FirstOrDefault(carrito => carrito.Id == carritoId);

            var carritoItemExistente = _context.CarritosItems.FirstOrDefault(carritoItemExistente => carritoItemExistente.CarritoId == carrito.Id);
         
            while (carritoItemExistente != null)
            {
                _context.CarritosItems.Remove(carritoItemExistente);                
                _context.SaveChanges();
                carritoItemExistente = _context.CarritosItems.FirstOrDefault(carritoItemExistente => carritoItemExistente.CarritoId == carrito.Id);
            }
            carrito.Subtotal = 0;
            _context.SaveChanges();

            return RedirectToAction(nameof(MiCarrito));
        }


        [Authorize(Roles = nameof(Rol.Cliente))]
        [HttpPost]
        public IActionResult EliminarProducto(Guid carritoItemId)
        {

            var clienteId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var carrito = _context.Carritos
                //.Include(carrito => carrito.CarritoItems).ThenInclude(carritoItem => carritoItem.Producto)
                .FirstOrDefault(carrito => carrito.ClienteId == clienteId && carrito.Activo);

            var item = _context.CarritosItems.Find(carritoItemId);

            if (item != null)
            {
                carrito.Subtotal -= item.SubTotal;
                _context.CarritosItems.Remove(item);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(MiCarrito));
        }

        private bool CarritoExists(Guid id)
        {
            return _context.Carritos.Any(e => e.Id == id);
        }
    }
}
