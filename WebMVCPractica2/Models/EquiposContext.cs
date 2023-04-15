using Microsoft.EntityFrameworkCore;
using MVCPractica01.Models;
using wedApi_join.Model;

namespace WebMVCPractica2.Models
{
    public class equiposContext :DbContext
    {
        public equiposContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
        public DbSet<equipos> equipos { get; set; }

    }
}
