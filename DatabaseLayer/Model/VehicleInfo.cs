using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class VehicleInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? RegistrationNo { get; set; }
        public string? OwnerName { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleClass { get; set; }
    }
}
