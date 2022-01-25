namespace BENT1C.Grupo1.Models
{
    public class Empleado : Usuario
    {
        public override Rol Rol => Rol.Administrador;

    }
}
