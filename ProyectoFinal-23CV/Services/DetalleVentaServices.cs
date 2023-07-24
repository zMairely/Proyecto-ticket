using ProyectoFinal_23CV.Context;
using ProyectoFinal_23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23CV.Services
{
    public class DetalleVentaServices
    {
        public void AddDetalleVenta(DetalleVenta detalleVenta)
        {
            try
            {
                if (detalleVenta != null)
                {
                    using (var _context = new ApplicationDbContext())
                    {
                        _context.DetallesVenta.Add(detalleVenta);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al agregar el detalle de venta: " + ex.Message);
            }
        }

        public List<DetalleVenta> GetDetallesVentaByVentaId(int ventaId)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    List<DetalleVenta> detallesVenta = _context.DetallesVenta
                        .Where(d => d.FkVenta == ventaId)
                        .ToList();
                    return detallesVenta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener los detalles de venta: " + ex.Message);
            }
        }

        public void UpdateDetalleVenta(DetalleVenta detalleVenta)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    DetalleVenta existingDetalleVenta = _context.DetallesVenta.Find(detalleVenta.PkDetalleVenta);

                    if (existingDetalleVenta != null)
                    {
                        existingDetalleVenta.Cantidad = detalleVenta.Cantidad;
                       
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al actualizar el detalle de venta: " + ex.Message);
            }
        }

        public void DeleteDetalleVenta(int detalleVentaId)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    DetalleVenta detalleVenta = _context.DetallesVenta.Find(detalleVentaId);

                    if (detalleVenta != null)
                    {
                        _context.DetallesVenta.Remove(detalleVenta);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al eliminar el detalle de venta: " + ex.Message);
            }
        }
    }

}
