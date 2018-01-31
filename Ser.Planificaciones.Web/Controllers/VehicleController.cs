using System.Web.Mvc;

namespace Ser.Planificaciones.Web.Controllers
{
    public class VehicleController : BaseController
    {
        //
        // GET: /Vehicle/
        public override ActionResult Index()
        {
            base.Index();
            return View();
        }
	}
}