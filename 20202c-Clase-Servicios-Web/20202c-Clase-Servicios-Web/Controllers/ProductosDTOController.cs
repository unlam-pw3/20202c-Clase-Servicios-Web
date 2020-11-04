using _20202c_Clase_Servicios_Web.Models;
using AutoMapper;
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
    public class ProductosDTOController : ApiController
    {
        ProductoServicio prodServicio;
        MapperConfiguration mapConfig;
        IMapper iMapper;
        public ProductosDTOController()
        {
            Entities contexto = new Entities();
            prodServicio = new ProductoServicio(contexto);

            mapConfig = new MapperConfiguration(cfg => {
                cfg.CreateMap<DAL.Producto, ProductoDTO>();
                cfg.CreateMap<ProductoDTO, DAL.Producto>();
            });

            iMapper = mapConfig.CreateMapper();

        }

        public IEnumerable<ProductoDTO> Get()
        {
            List<Producto> productos = prodServicio.ObtenerTodos();
            List<ProductoDTO> productosDTO = new List<ProductoDTO>();
            foreach (var prod in productos)
            {
                ProductoDTO dto = new ProductoDTO()
                {
                    IdMarca = prod.IdMarca,
                    IdProducto = prod.IdProducto,
                    Nombre = prod.Nombre,
                    Precio = prod.Precio
                };

                productosDTO.Add(dto);
            }
            return productosDTO;
        }

        // GET api/<controller>/5
        public ProductoDTO Get(int id)
        {
            DAL.Producto prod = prodServicio.ObtenerPorId(id);
            ProductoDTO prodDTO = iMapper.Map<DAL.Producto, ProductoDTO>(prod);

            return prodDTO;
        }

        // POST api/<controller>
        public void Post([FromBody] ProductoDTO prodDTO)
        {
            Producto prod = new Producto();
            prod.IdMarca = prodDTO.IdMarca;
            prod.Nombre = prodDTO.Nombre;
            prod.Precio = prodDTO.Precio;

            prodServicio.Alta(prod);
        }

        // PUT api/<controller>/5
        public void Put([FromBody] ProductoDTO prodDTO)
        {
            Producto prod = iMapper.Map<ProductoDTO, DAL.Producto>(prodDTO);
            prodServicio.Modificar(prod);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}