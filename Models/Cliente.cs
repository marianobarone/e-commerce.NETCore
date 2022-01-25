using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BENT1C.Grupo1.Models
{
    // TODO: Agregar MaxLength a TODAS las propiedades de tipo string
    public class Cliente : Usuario
    {
        public override Rol Rol => Rol.Cliente;

        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [RegularExpression(@"[0-9]{2}\.[0-9]{3}\.[0-9]{3}", ErrorMessage = "El dni debe tener un formato NN.NNN.NNN")]
        public string Dni { get; set; }

        public List<Compra> Compras { get; set; }
        public List<Carrito> Carritos { get; set; }
    }
}
