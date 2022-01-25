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
    public class CarritoItemsController : Controller
    {
        private readonly EcommerceDbContext _context;

        private bool CarritoItemExists(Guid id)
        {
            return _context.CarritosItems.Any(e => e.Id == id);
        }
    }
}
