using System;

namespace ExclusionVehicles
{
    public class ExclusionVehicle
    {
        public int Id { get; set; }
        public string VehicleNo { get; set; }
        public int VehicleCategoryId { get; set; }
        public DateTime DateofCreation { get; set; }
        public DateTime DateofModification { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        
    }
}

