
namespace Ser.Planificaciones.Models.Vehicle
{
    public class Motorcycle : IVehicle
    {
        #region -- Properties --

        public string Brand
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public string Year
        {
            get;
            set;
        }

        public string Chasis
        {
            get;
            set;
        }

        public Motor Motor
        {
            get;
            set;
        }

        public Transmission Transmission
        {
            get;
            set;
        }

        #endregion -- Properties --
    }
}
