using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Ser.Planificaciones.Models.Dashboard;

namespace Ser.Planificaciones.Web.Controllers
{
    /// <summary>
    /// Manager all functionability of main page [dashboard]
    /// </summary>
	public class DashboardController : BaseController
	{
        public override ActionResult Index()
        {
            base.Index();
            return View();
        }
	}
}
