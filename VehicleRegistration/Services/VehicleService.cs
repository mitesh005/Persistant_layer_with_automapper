

using DatabaseLayer;
using DatabaseLayer.Model;
using VehicleRegistration.Models;


namespace VehicleRegistration.Services
{/// <summary>
/// Service class is used to connect with repository service by creating object and implementing Iservice interface.
/// </summary>
    public class VehicleService:IVehicleService
    {
        public readonly VehicleRepo  _vehicleRepository ;
        public VehicleService()
        {
            _vehicleRepository = new VehicleRepo();
        }

        public bool DeleteInfo(int id)
        {
            bool status = _vehicleRepository.DeleteInfo(id);
            return status;
        }

        public bool EditInfo(object information)
        {
            bool status = _vehicleRepository.EditInfo(information);
            return status;
        }

        public object FindById(int id)
        {
           return _vehicleRepository.FindById(id);
        }

        //public VehicleService(VehicleRepo vehicleRepository)
        //{
        //    _vehicleRepository = vehicleRepository;
        //}

        //{
        //    _vehicleRepository = vehicleRepository;

        //}

        public List<VehicleInfo> GetAllVehicle()
        {
            return _vehicleRepository.GetAllVehicle();
        }


        public bool RegisterVehicle(VehicleInfo vehicleInfo)
        {
            bool status=_vehicleRepository.RegisterVehicle(vehicleInfo);
            return status;
        }
    }
}
