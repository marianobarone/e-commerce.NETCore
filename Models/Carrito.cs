using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BENT1C.Grupo1.Models
{
    public class Carrito
    {
        [Key]
        public Guid Id { get; set; }
        public bool Activo { get; set; }

        public List<CarritoItem> CarritoItems { get; set; }
        
        public decimal Subtotal { get; set; }

        [ForeignKey(nameof(Cliente))]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        // Relación 1 a 1 con FK en la Compra.
        public Compra Compra { get; set; }
    }
}
