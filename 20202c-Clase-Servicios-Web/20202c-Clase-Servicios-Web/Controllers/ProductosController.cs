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

        // GET api/values
        public IEnumerable<DAL.Producto> Get()
        {
            return prodServicio.ObtenerTodos();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
