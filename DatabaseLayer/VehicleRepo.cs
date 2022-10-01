using DatabaseLayer.Context;
using DatabaseLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{/// <summary>
/// This class is used to connect with dbcontext and perform operations realated to database.
/// </summary>
    public class VehicleRepo
    {
        private readonly VehicleDbContext _vehicleDbCtx;
        public VehicleRepo()
        {
            _vehicleDbCtx = new VehicleDbContext();

        }
        public bool RegisterVehicle(VehicleInfo vehicleInfo)
        {
            _vehicleDbCtx.VehicleRegistrationTbl.Add(vehicleInfo);
            _vehicleDbCtx.SaveChanges();
            return true;
        }
        public List<VehicleInfo> GetAllVehicle()
        {
            return _vehicleDbCtx.VehicleRegistrationTbl.ToList();
        }
        public VehicleInfo FindById(int id)
        {
            return _vehicleDbCtx.VehicleRegistrationTbl.Where(x => x.Id == id).FirstOrDefault();
        }
        public bool DeleteInfo(int id)
        {
            var VehicleObj= FindById(id);
            _vehicleDbCtx.VehicleRegistrationTbl.Remove(VehicleObj);
            _vehicleDbCtx.SaveChanges();
            return true;
        }

        public bool EditInfo(object information)
        {
            _vehicleDbCtx.Entry<VehicleInfo>((VehicleInfo)information).State = EntityState.Modified;
            _vehicleDbCtx.SaveChanges();
            return true;
        }
    }
}
