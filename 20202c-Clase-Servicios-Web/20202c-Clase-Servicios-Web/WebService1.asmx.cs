using _20202c_Clase_Servicios_Web.Models;
using AutoMapper;
using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _20202c_Clase_Servicios_Web
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    //[System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        ProductoServicio prodServicio;
        MapperConfiguration mapConfig;
        IMapper iMapper;

        public WebService1()
        {
            Entities contexto = new Entities();
            prodServicio = new ProductoServicio(contexto);


            mapConfig = new MapperConfiguration(cfg => {
                cfg.CreateMap<DAL.Producto, ProductoDTO>();
                cfg.CreateMap<ProductoDTO, DAL.Producto>();
            });

            iMapper = mapConfig.CreateMapper();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public ProductoDTO ObtenerPorId(int id)
        {
            DAL.Producto prod = prodServicio.ObtenerPorId(id);
            ProductoDTO prodDTO = iMapper.Map<DAL.Producto, ProductoDTO>(prod);

            return prodDTO;
        }
    }
}
