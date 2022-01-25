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
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BENT1C.Grupo1.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {
        private readonly EcommerceDbContext _context;

        public ClientesController(EcommerceDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        [Authorize(Roles = nameof(Rol.Administrador))]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: Clientes/Details/5
        [Authorize]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (User.FindFirstValue(ClaimTypes.Role) == nameof(Rol.Cliente) && Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) != id)
            {
                return RedirectToAction("NoAutorizado", "Accesos");
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            //For dropdown select
            ViewBag.Categorias = new SelectList(_context.Categorias, "Id", "Nombre");

            return View(cliente);
        }

        // GET: Clientes/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Dni,Id,Nombre,Apellido,Email,Telefono,Direccion")] Cliente cliente, string password)
        {

            try
            {
                password.ValidarPassword();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(nameof(Cliente.Password), ex.Message);
            }

            if (_context.Empleados.Any(empleado => empleado.Email == cliente.Email) || _context.Clientes.Any(clientes => clientes.Email == cliente.Email))
            {
                ModelState.AddModelError(nameof(Cliente.Email), "El mail ya se encuentra utilizado");
            }

            if (ModelState.IsValid)
            {
                cliente.Id = Guid.NewGuid();
                var carrito = new Carrito
                {
                    Id = Guid.NewGuid(),
                    Activo = true,
                    ClienteId = cliente.Id
                };
                cliente.Password = password.Encriptar();
                cliente.FechaAlta = DateTime.Now;
                cliente.Carritos = new List<Carrito>
                {
                    carrito
                };
                _context.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        [Authorize(Roles = nameof(Rol.Administrador))]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = nameof(Rol.Administrador))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Dni,Id,Nombre,Apellido,Email,Telefono,Direccion,FechaAlta")] Cliente cliente, string password)
        {
            if (!string.IsNullOrWhiteSpace(password))
            {
                try
                {
                    password.ValidarPassword();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(nameof(Cliente.Password), ex.Message);
                }
            }


            if (id != cliente.Id)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                var clienteDatabase = _context.Clientes.Find(id);

                clienteDatabase.Nombre = cliente.Nombre;
                clienteDatabase.Apellido = cliente.Apellido;
                clienteDatabase.Telefono = cliente.Telefono;
                clienteDatabase.Direccion = cliente.Direccion;

                if (!string.IsNullOrWhiteSpace(password))
                {
                    clienteDatabase.Password = password.Encriptar();
                }


                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Categorias = new SelectList(_context.Categorias, "Id", "Nombre");

            return View(cliente);
        }


        // GET: Clientes/Edit/5
        [Authorize(Roles = nameof(Rol.Cliente))]
        public async Task<IActionResult> EditReducido(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) != id)
            {
                return RedirectToAction("NoAutorizado", "Accesos");
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            ViewBag.Categorias = new SelectList(_context.Categorias, "Id", "Nombre");

            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = nameof(Rol.Cliente))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditReducido(Guid id, [Bind("Telefono,Direccion")] Cliente cliente)
        {

            if (Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) != id)
            {
                return RedirectToAction("NoAutorizado", "Accesos");
            }            
            
            if (ModelState["Telefono"].ValidationState == ModelValidationState.Valid && ModelState["Direccion"].ValidationState == ModelValidationState.Valid)
            {
                var clienteDatabase = _context.Clientes.Find(id);
                clienteDatabase.Telefono = cliente.Telefono;
                clienteDatabase.Direccion = cliente.Direccion;
                _context.SaveChanges();

                return RedirectToAction("Details", new { id = id } );
            }

            return View(cliente);
        }

        // GET: Clientes/Delete/5
        [Authorize(Roles = nameof(Rol.Administrador))]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [Authorize(Roles = nameof(Rol.Administrador))]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(Guid id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }

        [Authorize(Roles = nameof(Rol.Cliente))]
        public async Task<IActionResult> HistorialCompras(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) != id)
            {
                return RedirectToAction("NoAutorizado", "Accesos");
            }

            var cliente = await _context.Clientes
                .Include(clientes => clientes.Compras).ThenInclude(compras => compras.Carrito)
                .Include(clientes => clientes.Carritos).ThenInclude(carritos => carritos.CarritoItems).ThenInclude(items => items.Producto)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            ViewBag.Categorias = new SelectList(_context.Categorias, "Id", "Nombre");

            return View(cliente);
        }
    }
}

