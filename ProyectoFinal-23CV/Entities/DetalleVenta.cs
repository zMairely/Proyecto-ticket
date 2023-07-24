using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23CV.Entities
{
    public class DetalleVenta
    {
        [Key]
        public int PkDetalleVenta { get; set; }

        public int Cantidad { get; set; }
        [ForeignKey ("Ventas")]
        public int FkVenta { get; set; }
        public Venta Venta { get; set; }

        [ForeignKey("Productos")]
        public int FkProducto { get; set; }
        public Producto Producto { get; set; }
    }
}
