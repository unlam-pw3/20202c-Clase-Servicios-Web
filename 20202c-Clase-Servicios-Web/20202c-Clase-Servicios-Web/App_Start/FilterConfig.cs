﻿using System.Web;
using System.Web.Mvc;

namespace _20202c_Clase_Servicios_Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
