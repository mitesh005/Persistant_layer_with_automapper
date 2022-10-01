using DatabaseLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Context
{
   public class VehicleDbContext:DbContext
    {
        public VehicleDbContext()
        {
                
        }
        public VehicleDbContext (DbContextOptions<VehicleDbContext> Context) : base(Context)
        {

        }
        public DbSet<VehicleInfo> VehicleRegistrationTbl { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=NEOLAP000003389;Database=VehicleInfoRegistrationDb;trusted_Connection=True;");
            }
        }
    }
}
