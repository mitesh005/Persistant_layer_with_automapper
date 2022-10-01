using AutoMapper;
using DatabaseLayer.Model;
using VehicleRegistration.Models;

namespace VehicleRegistration.Helper
{//this is helper class for automapping.
    public class AutoMappingProfile:Profile
    {
        public AutoMappingProfile()
        {
            CreateMap <VehicleInfo, ViewVehicle>().ReverseMap();
        }
    }
}
