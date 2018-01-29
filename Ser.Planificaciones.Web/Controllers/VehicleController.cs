using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ser.Planificaciones.Web.Controllers
{
    public class VehicleController : BaseController
    {
        //
        // GET: /Vehicle/
        public ActionResult Index()
        {
            return View(base.DashboardIndex());
        }
	}
}