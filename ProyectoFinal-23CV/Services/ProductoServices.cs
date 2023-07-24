using ProyectoFinal_23CV.Context;
using ProyectoFinal_23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23CV.Services
{
    public class ProductoServices
    {
        public void AddProducto(Producto request)
        {
            try
            {
                if (request != null)
                {
                    using (var _context = new ApplicationDbContext())
                    {
                        Producto res = new Producto();
                        res.NombreProducto = request.NombreProducto;
                        res.PrecioProducto = request.PrecioProducto;
                        _context.Productos.Add(res);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al agregar el producto: " + ex.Message);
            }
        }

        public List<Producto> GetProductos()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    List<Producto> productos = new List<Producto>();
                    productos = _context.Productos.ToList();
                    return productos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener la lista de productos: " + ex.Message);
            }
        }

        public void UpdateProducto(int productId, Producto producto)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Producto existingProducto = _context.Productos.FirstOrDefault(p => p.PkProducto == productId);

                    if (existingProducto != null)
                    {
                        existingProducto.NombreProducto = producto.NombreProducto;
                        existingProducto.PrecioProducto = producto.PrecioProducto;
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al actualizar el producto: " + ex.Message);
            }
        }

        public void DeleteProducto(int productId)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Producto producto = _context.Productos.Find(productId);

                    if (producto != null)
                    {
                        _context.Productos.Remove(producto);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al eliminar el producto: " + ex.Message);
            }
        }
    }

}
