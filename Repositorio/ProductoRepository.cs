using Dominio.Dtos;
using Dominio.Entities;
using Repositorio.Data;
using Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProductoRepository: IProductoRepository
    {
        private readonly AppDbContext _context;
        public ProductoRepository(AppDbContext context) { 
        
            _context = context;
        }

        public Producto Consultar(int id)
        {
          return  _context.Productos.Find(id);   
        }

        public bool Registrar(Producto producto)
        {
            _context.Add(producto);
            return _context.SaveChanges() > 0;
        }


    }
}
