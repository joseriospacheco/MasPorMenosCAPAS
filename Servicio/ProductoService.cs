using Dominio.Dtos;
using Dominio.Entities;
using Repositorio;
using Repositorio.Interfaces;
using Servicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ProductoService: IProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {
            _repository = repository;
        }

        public Producto Consultar(int id)
        {
  
            return _repository.Consultar(id);
        }

        public bool Registrar(CrearProductoDto dto) {

            Producto producto = new Producto();

            producto.Descripcion = dto.Descripcion;
            producto.Categoria = dto.Categoria;
            producto.Marca = dto.Marca;

            producto.Estado = "Registrado";
            producto.FechaRegistro = DateTime.Now;
            producto.Codigo = producto.Categoria.Substring(0, 1) + new Random().NextInt64(1, 10000);

            // Viola el principio de ID
            //ProductoRepository _repository = new ProductoRepository();
            _repository.Registrar(producto);

            return true;
        }
    }
}
