using DatabaseLayer.Model;
using VehicleRegistration.Models;

namespace VehicleRegistration.Services
{
    public interface IVehicleService
    {
        bool RegisterVehicle(VehicleInfo vehicleInfo);
        List<VehicleInfo> GetAllVehicle();
        object FindById(int id);
        bool DeleteInfo(int id);
        bool EditInfo(object information);

        //VehicleInfo FindById(int id);
    }
}
