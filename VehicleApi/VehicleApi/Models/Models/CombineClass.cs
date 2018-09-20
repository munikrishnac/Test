using Secura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleApi.Models.Models
{
   
    public class CombineClass
    {   public IEnumerable<JunctionMaster> junctionMaster { get; set; }
        public IEnumerable<PoleMaster> poleMaster { get; set; }
        public IEnumerable<Camera> camera { get; set; }
        public IEnumerable<PoleCameraMapping> poleCameraMapping { get; set; }
    }
}
