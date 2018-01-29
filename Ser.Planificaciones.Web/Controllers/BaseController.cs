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
        public override DashboardViewModel DashboardIndex()
        {
            return  new DashboardViewModel
            {
                Title = "Dashboard",
                Navbars = new Navbar
                {
                    TopBar = new Topbar
                    {
                        CompanyName = "Maintenance",
                        Rights = new List<Link> { 
                            new Link { 
                                Class= "dropdown-icon fa fa-power-off",
                                Href= "#",
                                Id= "signInOut", 
                                Text=" Log in" 
                            }
                        }
                    },
                    Content = new List<Link> { }
                }
            };

        }
    }
}