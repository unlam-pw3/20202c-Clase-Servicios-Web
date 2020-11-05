using _20202c_Clase_Servicios_Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult EjemploConsumiendoDesdeBackend()
        {
            List<ProductoDTO> productos = GetProductos();
            return View(productos);
        }

        public ActionResult EjemploConsumiendoDesdeJavascript()
        {
            return View();
        }

        private List<ProductoDTO> GetProductos()
        {
            var url = $"https://localhost:44380/api/productosdto";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return new List<ProductoDTO>();
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        var result = JsonConvert.DeserializeObject<List<ProductoDTO>>(responseBody);
                        return result;
                    }
                }
            }
        }
    }

}
