
namespace Ser.Planificaciones.Models.Vehicle
{
    public interface IVehicle
    {
        string Brand { get; set; }

        string Model { get; set; }

        string Year { get; set; }

        string Chasis { get; set; }

        Motor Motor { get; set; }

        Transmission Transmission { get; set; }

    }
}
