﻿using System.Web.Mvc;

namespace MaquetaAsapX1.Areas.ASAP
{
    public class ASAPAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ASAP";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ASAP_default",
                "ASAP/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}