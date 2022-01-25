using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BENT1C.Grupo1.Models
{
    // Esta entidad representa el stock de cada producto en cada Sucursal.
    // Por eso es una relación muchos a muchos entre Producto y Sucursal.
    public class StockItem
    {
        [Key]
        public Guid Id { get; set; }

        public int Cantidad { get; set; }

        [ForeignKey(nameof(Sucursal))]
        public Guid SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }

        [ForeignKey(nameof(Producto))]
        public Guid ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
