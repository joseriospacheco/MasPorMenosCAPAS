using Dominio.Dtos;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Interfaces
{
    public interface IProductoService
    {
        bool Registrar(CrearProductoDto dto);
        Producto Consultar(int id);
    }
}