using Microsoft.EntityFrameworkCore;
using ProyectoFinal_23CV.Context;
using ProyectoFinal_23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23CV.Services
{
    public class VentaServices
    {
      
        public void AddVenta(Venta request)
        {

            try
            {
                if (request != null)
                {
                    using (var _context = new ApplicationDbContext())
                    {
                        _context.Ventas.Add(request);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al agregar la venta: " + ex.Message);
            }
        }

        public List<Venta> GetVentas()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    List<Venta> ventas = _context.Ventas.Include(v => v.DetallesVenta).ToList();
                    return ventas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener la lista de ventas: " + ex.Message);
            }
        }

        public void UpdateVenta(int ventaId, Venta venta)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Venta existingVenta = _context.Ventas.Include(v => v.DetallesVenta).FirstOrDefault(v => v.PkVenta == ventaId);

                    if (existingVenta != null)
                    {
                        existingVenta.Total = venta.Total;
                        
                        existingVenta.FechaVenta = venta.FechaVenta;
                        existingVenta.Vendedor = venta.Vendedor;

                        // Actualizar detalles de venta
                        if (venta.DetallesVenta != null)
                        {
                             foreach (var detalle in venta.DetallesVenta)
                            {
                                if (detalle.PkDetalleVenta == 0)
                                {
                                    _context.DetallesVenta.Add(detalle);
                                }
                                else
                                {
                                    DetalleVenta existingDetalle = existingVenta.DetallesVenta.FirstOrDefault(d => d.PkDetalleVenta == detalle.PkDetalleVenta);
                                    if (existingDetalle != null)
                                    {
                                        existingDetalle.Cantidad = detalle.Cantidad;
                                    
                                    }
                                }
                            }
                        }

                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al actualizar la venta: " + ex.Message);
            }
        }

        public void DeleteVenta(int ventaId)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Venta venta = _context.Ventas.Find(ventaId);

                    if (venta != null)
                    {
                        _context.Ventas.Remove(venta);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al eliminar la venta: " + ex.Message);
            }
        }
       
    }

}
