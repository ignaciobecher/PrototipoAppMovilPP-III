using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototipoAppMovil.Modelos;
using PrototipoAppMovil.Utilidades;
using Microsoft.EntityFrameworkCore;

namespace PrototipoAppMovil.DataAccess
{
    public class AppDbContext:DbContext
    {
        public DbSet<Menus> Menues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDb = $"Filename={ConexionDB.DevolverRuta("app.db")}";
            optionsBuilder.UseSqlite(conexionDb);
        }
    }
}

