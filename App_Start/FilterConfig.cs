﻿using System.Web;
using System.Web.Mvc;

namespace NguyenVanChien_5951071006
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
