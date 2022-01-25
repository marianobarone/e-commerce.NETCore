using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BENT1C.Grupo1.Database;
using BENT1C.Grupo1.Models;
using BENT1C.Grupo1.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace BENT1C.Grupo1.Controllers
{
    [Authorize(Roles = nameof(Rol.Administrador))]
    public class EmpleadosController : Controller
    {
        private readonly EcommerceDbContext _context;

        public EmpleadosController(EcommerceDbContext context)
        {
            _context = context;
        }

        // GET: Empleados
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empleados.ToListAsync());
        }

        // GET: Empleados/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // GET: Empleados/Create

        //   [Authorize(Roles = nameof(Rol.Administrador))]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[Authorize(Roles = nameof(Rol.Administrador))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nombre,Apellido,Email,Telefono,Direccion")] Empleado empleado, string password)
        {
            try
            {
                password.ValidarPassword();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(nameof(Empleado.Password), ex.Message);
            }

            if (_context.Empleados.Any(emple => emple.Email == empleado.Email) || _context.Clientes.Any(clientes => clientes.Email == empleado.Email))
            {
                ModelState.AddModelError(nameof(Empleado.Email), "El mail ya se encuentra utilizado");
            }

            if (ModelState.IsValid)
            {
                empleado.Id = Guid.NewGuid();
                empleado.Password = password.Encriptar();
                empleado.FechaAlta = DateTime.Now;
                _context.Add(empleado);
                _context.SaveChanges();
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(empleado);
        }

        // GET: Empleados/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = _context.Empleados.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
        }

        // POST: Empleados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,Nombre,Apellido,Email,Telefono,Direccion")] Empleado empleado, string password)
        {

            if (!string.IsNullOrWhiteSpace(password))
            {
                try
                {
                    password.ValidarPassword();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(nameof(Empleado.Password), ex.Message);
                }
            }

            if (id != empleado.Id)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                var empleadoDatabase = _context.Empleados.Find(id);

                empleadoDatabase.Nombre = empleado.Nombre;
                empleadoDatabase.Apellido = empleado.Apellido;
                empleadoDatabase.Telefono = empleado.Telefono;
                empleadoDatabase.Direccion = empleado.Direccion;

                if (!string.IsNullOrWhiteSpace(password))
                {
                    empleadoDatabase.Password = password.Encriptar();
                }


                    _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(empleado);
        }


        // GET: Empleados/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // POST: Empleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpleadoExists(Guid id)
        {
            return _context.Empleados.Any(e => e.Id == id);
        }

        [HttpGet]

        public IActionResult VerListadoCompras()
        {
            
            var listaCompras = _context.Compras
                .Where(compra => compra.FechaCompra.Month == DateTime.Now.Month)
                .Include(compra => compra.Carrito).ThenInclude(items => items.CarritoItems).ThenInclude(producto => producto.Producto)
                .Include(compra => compra.Cliente)
                .OrderByDescending(compra => (double)compra.Total);

            return View(listaCompras);                      
        }
    }
}
