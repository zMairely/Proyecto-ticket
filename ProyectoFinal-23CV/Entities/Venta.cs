using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23CV.Entities
{
    public class Venta
    {
        [Key]
        public int PkVenta { get; set; }
        public double Total { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Subtotal { get; set; }

        public int Cantidad { get; set; }
        public double Iva { get; set; }
        [NotMapped] // Indica que esta propiedad no está mapeada a una columna en la base de datos
        public string NombreProducto { get; set; }
        [NotMapped] // Esta propiedad no se mapeará a la base de datos.
        public double PrecioProducto { get; set; }
        [NotMapped]
        public double SubtotalCalculado => PrecioProducto * Cantidad;

        // Propiedad calculada - IVA
        [NotMapped]
        public double IvaCalculado => SubtotalCalculado * 0.16;

        // Propiedad calculada - Total
        [NotMapped]
        public double TotalCalculado => SubtotalCalculado + IvaCalculado;

        public List<DetalleVenta> DetallesVenta { get; set; }

        [ForeignKey("Vendedor")]
        public int? FkVendedor { get; set; }
        public Usuario Vendedor { get; set; }

        [ForeignKey("Producto")]
        public int? FkProducto { get; set; }
        public Producto Producto { get; set; }



    }
}

