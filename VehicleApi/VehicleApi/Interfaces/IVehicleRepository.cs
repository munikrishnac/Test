
namespace VehicleApi.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VehicleApi.AlertVehicles;

    /// <summary>
    /// IMongoRepository.
    /// </summary>
    public interface IVehicleRepository
    {
        /// <summary>
        /// Adds the alarm.
        /// </summary>
        /// <param name="alarm">The alarm.</param>
        /// <returns></returns>
        Task<IList<AlertVehicles>> Get(DateTime? fromDate = null, DateTime? toDate = null, string cameraName = null, string sourceLocation = null, string licensePlateNumber = null);

    }
}
