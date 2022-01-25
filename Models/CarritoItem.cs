using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BENT1C.Grupo1.Models
{
    public class CarritoItem
    {
        [Key]
        public Guid Id { get; set; }
        public decimal ValorUnitario { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El {0} debe ser mayor a {1}")]
        public int Cantidad { get; set; }

        public decimal SubTotal { get; set; }

        [ForeignKey(nameof(Categoria))]
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [ForeignKey(nameof(Carrito))]
        public Guid CarritoId { get; set; }
        public Carrito Carrito { get; set; }

        [ForeignKey(nameof(Producto))]
        public Guid ProductId { get; set; }
        public Producto Producto { get; set; }
    }
}