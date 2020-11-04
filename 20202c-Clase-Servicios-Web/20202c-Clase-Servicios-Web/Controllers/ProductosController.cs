using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _20202c_Clase_Servicios_Web.Controllers
{
    public class ProductosController : ApiController
    {
        ProductoServicio prodServicio;

        public ProductosController()
        {
            Entities contexto = new Entities();
            prodServicio = new ProductoServicio(contexto);
        }

        public IEnumerable<DAL.Producto> Get()
        {
            return prodServicio.ObtenerTodos();
        }

        public DAL.Producto Get(int id)
        {
            return prodServicio.ObtenerPorId(id);
        }

        public void Post([FromBody] DAL.Producto prod)
        {
            prodServicio.Alta(prod);
        }

        public void Put([FromBody] DAL.Producto prod)
        {
            prodServicio.Modificar(prod);
        }

        public void Delete(int id)
        {
            prodServicio.Eliminar(id);
        }
    }
}
