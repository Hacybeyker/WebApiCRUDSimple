using System.Data.Entity;

namespace WebApiCRUDSimple.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
    }
    internal class AlumnoDbContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
    }
}