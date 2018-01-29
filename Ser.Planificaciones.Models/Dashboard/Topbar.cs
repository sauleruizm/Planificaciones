using System.Collections.Generic;

namespace Ser.Planificaciones.Models.Dashboard
{
    public class Topbar
    {

        public string CompanyName { get; set; }

        /// <summary>
        /// It's options for center of topbar
        /// </summary>
        public List<Link> Links { get; set; }

        /// <summary>
        /// Items for right side of top bar, exactly the user section
        /// </summary>
        public List<Link> Rights { get; set; }
    }
}
