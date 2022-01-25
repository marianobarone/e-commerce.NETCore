using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BENT1C.Grupo1.Models;
using BENT1C.Grupo1.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace BENT1C.Grupo1.Controllers
{
    public class HomeController : Controller
    {
        //PREGUNTAR SI SE PUEDE COMENTAR. PARA QUE ESTÁ EL _LOGGER?
        //private readonly ILogger<HomeController> _logger;

        private readonly EcommerceDbContext _context;

        public HomeController(EcommerceDbContext context)
        {
            _context = context;
        }

        //PREGUNTAR SI SE PUEDE COMENTAR. PARA QUE ESTÁ EL _LOGGER?
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.FindFirstValue(ClaimTypes.Role) == nameof(Rol.Administrador))
            {
                return RedirectToAction("AdminReducido");
            }

            var ecommerceDbContext = _context.Productos.Include(p => p.Categoria);

            ViewBag.Categorias = new SelectList(_context.Categorias, "Id", "Nombre");

            return View(ecommerceDbContext);
        }

        //[Authorize(Roles = nameof(Rol.Administrador))]
        //public IActionResult Admin()
        //{
        //    return View();
        //}

        [Authorize(Roles = nameof(Rol.Administrador))]
        public IActionResult AdminReducido()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
