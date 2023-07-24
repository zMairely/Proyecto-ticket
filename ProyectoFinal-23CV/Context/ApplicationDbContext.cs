using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProyectoFinal_23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23CV.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server =localhost; database= mai; user= root; password=");
          


        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Producto> Productos { get; set; }
       
        public DbSet<Venta> Ventas { get; set; }
        public DbSet <DetalleVenta> DetallesVenta { get; set; }


        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //    var rol = new Rol{ Nombre = "SuperAdmin"};
        //    var rol2 = new Rol { Nombre = "Admin" };
        //    var rol3 = new Rol { Nombre = "Usuario" };

        //    builder.Entity<Rol>().HasData(rol, rol2,rol3);
        //   base.OnModelCreating(builder);

        //}

    }
}
