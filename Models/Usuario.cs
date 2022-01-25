using System;
using System.ComponentModel.DataAnnotations;

namespace BENT1C.Grupo1.Models
{
    // Usuario está perfecto que sea abstracta ya que jamás tendrán un usuario que no tenga Rol.
    // Los usuarios deben ser de tipo Cliente/Empleado/etc, pero jamás serán de tipo Usuario genérico.
    // A consecuencia de que el usuario es abstracto y no pueden existir objetos de tipo usuario, jamás se 
    // representaría como una tabla y es por eso que no lo debemos agregar en el DbContext.
    public abstract class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [MinLength(2, ErrorMessage = "{0} debe tener un mínimo de {1} caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo {0} sólo admite caracteres alfabéticos")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo {0} sólo admite caracteres alfabéticos")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [EmailAddress(ErrorMessage = "El campo {0} debe ser un email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [RegularExpression(@"[0-9/-]*", ErrorMessage = "El campo {0} sólo admite números y guiones")]
        public string Telefono { get; set; }

        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        public string Direccion { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaAlta { get; set; }

        [ScaffoldColumn(false)] // [ScaffoldColumn(false)] lo agregamos para que no se utilice el campo Password en el scaffold
        public byte[] Password { get; set; } // La password la usaremos como byte[] para almacenarla encriptada

        public abstract Rol Rol { get; }
    }
}
