using Ser.Planificaciones.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ser.Planificaciones.Web.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Represent the first action for show the dashboard page
        /// </summary>
        /// <returns></returns>
        public DashboardViewModel DashboardModel
        {
            get
            {
                return new DashboardViewModel
                {
                    Title = "Dashboard",
                    Navbars = new Navbar
                    {
                        TopBar = new Topbar
                        {
                            CompanyName = "Maintenance",
                            Rights = new List<Link> { 
                            new Link { Class= "dropdown-icon fa fa-power-off", Href= "#", Id= "signInOut", Text=" Log in" }
                            }
                        },
                        Content = new List<Link> { //left menu
                            new Link { Active= true, Class="px-nav-icon ion-home", Text="Dashboard", Href= Url.Action("Index", "Dashboard") },
                            new Link { Active= true, Class="px-nav-icon ion-star", Text="Motorcycle", Href= Url.Action("Index","Vehicle") }
                        }
                    }
                };
            }

        }

        public virtual ActionResult Index()
        {
            ViewBag.DashboardViewModel = DashboardModel;
            return View();
        }
    }
}