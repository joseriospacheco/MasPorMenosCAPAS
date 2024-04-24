using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dominio;
using Dominio.Entities;
using Dominio.Dtos;
using Repositorio.Data;
using Servicio;
using Servicio.Interfaces;
namespace MasPorMenos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;
        public ProductosController(IProductoService productoService)
        {
           _productoService = productoService;
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> Consultar(int id)
        {
            return Ok(_productoService.Consultar(id));
        }

        [HttpPost]
        public ActionResult Crear([FromBody] CrearProductoDto crearProductoDto)
        {


            if (!String.IsNullOrEmpty(crearProductoDto.Categoria) 
                || !String.IsNullOrEmpty(crearProductoDto.Marca) 
                || !String.IsNullOrEmpty(crearProductoDto.Descripcion)) {


                // Esto no se debe hacer    

                _productoService.Registrar(crearProductoDto);
                /*
                
                ProductoCreadoDto productoCreadoDto = new ProductoCreadoDto();
            productoCreadoDto.Id = producto.Id;
            productoCreadoDto.FechaCreacion=producto.FechaRegistro;
            productoCreadoDto.Descripcion = producto.Descripcion;
            productoCreadoDto.Marca = producto.Marca;
            productoCreadoDto.Estado = producto.Estado;
            productoCreadoDto.Categoria = producto.Categoria;
            productoCreadoDto.Codigo = producto.Codigo;

                */

                return Ok("Producto creado");


            }
            else {

                return BadRequest("Error en los datos de entrada");
            }

 
        }

    }
}
