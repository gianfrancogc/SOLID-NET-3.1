namespace Solid.OCP.Library.Modelos
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }

        //public bool EsIngeniero { get; set; }
        public Rol Rol { get; set; }
    }
}
