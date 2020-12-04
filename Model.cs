using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Parcial
{
    public class DB : DbContext
    {
        public DbSet<vehiculo> vehiculos { get; set; }
        public DbSet<persona> personas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=Parcial.db");

    }
    public  class vehiculo
    {
        public int vehiculoid { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public string descripcion { get; set; }

        public List<persona> personas { get; } = new List<persona>();
    }

    public class persona
    {
        public int personaid { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string lugar { get; set; }

        public vehiculo vehiculo { get; set; }

    }
}
