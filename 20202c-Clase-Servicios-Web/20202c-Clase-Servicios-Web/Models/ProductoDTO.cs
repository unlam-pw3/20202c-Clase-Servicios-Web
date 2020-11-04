using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20202c_Clase_Servicios_Web.Models
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> IdMarca { get; set; }
    }
}