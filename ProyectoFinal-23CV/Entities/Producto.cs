using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23CV.Entities
{
    public class Producto
    {
        [Key]
        public int PkProducto { get; set; }
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }
    }
}
