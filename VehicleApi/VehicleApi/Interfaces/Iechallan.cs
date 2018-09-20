using Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleApi.Interfaces
{
    public interface Iechallan
    {
        Task<IList<Alarm>> Get(DateTime? fromDate = null, DateTime? toDate = null, List<string> cameraName = null, List<string> sourceLocation = null, string licensePlateNumber = null);
    }
}
