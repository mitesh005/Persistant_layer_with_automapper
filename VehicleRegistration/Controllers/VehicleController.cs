
using AutoMapper;
using DatabaseLayer.Model;
using Microsoft.AspNetCore.Mvc;
using VehicleRegistration.Models;
using VehicleRegistration.Services;

namespace VehicleRegistration.Controllers
/// <summary>
/// This controller class contains two dpendencies and controller methods.
/// </summary>
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;
        public VehicleController(IVehicleService vehicleService,IMapper mapper)
        {

            _vehicleService = vehicleService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult RegisterVehicle()
        {
           
            return View();
        }

        [HttpPost]
        
        public ActionResult RegisterVehicle(ViewVehicle _viewVehicle)
        {
         
            VehicleInfo _vehicleInfo = new VehicleInfo();
           _mapper.Map(_viewVehicle,_vehicleInfo);
          
         
            bool status = _vehicleService.RegisterVehicle(_vehicleInfo);

            return View();
        }

        [Route("")]
        public ActionResult GetAllVehicle()
        {
            List<VehicleInfo> vehicleInfos = _vehicleService.GetAllVehicle();
         

            return View(vehicleInfos);
        }

        [HttpGet]
        public ActionResult DeleteInfo(int id)
        {
           var information= _vehicleService.FindById(id);
            return View(information);
        }
        [HttpPost]
        public ActionResult DeleteInfo(int id,string RegisterationNo)
        {
           bool status= _vehicleService.DeleteInfo(id);
            return View();
        }
        [HttpGet]
        public ActionResult EditInfo(int id)
        {

            var information = _vehicleService.FindById(id);
            return View(information);
        }
        [HttpPost]
        public ActionResult EditInfo(int id, ViewVehicle viewvehicle)
        {

            var information = _vehicleService.FindById(id);
            _mapper.Map(viewvehicle, information);
            bool status=_vehicleService.EditInfo(information);
            return View();

        }
    }
}
