
namespace VehicleApi.Data
{
    using AppApi.Model;
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using VehicleApi.AlertVehicles;
    using VehicleApi.Interfaces;
    using VehicleApi.Model;

    public class VehicleRepository : IVehicleRepository
    {

        private readonly VehicleApiContext _context = null;

        public VehicleRepository(IOptions<Settings> settings)
        {
            _context = new VehicleApiContext(settings);
        }

        public async Task<IList<AlertVehicles>> Get(DateTime? fromDate = null, DateTime? toDate = null, string cameraName = null, string sourceLocation = null, string licensePlateNumber = null)
        {
            FilterDefinition<AlertVehicles> filter = Builders<AlertVehicles>.Filter.Ne(c => c.CamName, null); ;
            if (cameraName != null)
            {
                filter = filter & Builders<AlertVehicles>.Filter.Eq(c => c.CamName, cameraName);
            }
            if (sourceLocation != null)
            {
                filter = filter & Builders<AlertVehicles>.Filter.Eq(c => c.SourceLocation, sourceLocation);
            }
            if (licensePlateNumber != null)
            {
                filter = filter & Builders<AlertVehicles>.Filter.Eq(c => c.LicensePlateNumber, licensePlateNumber);
            }           
            if (fromDate != null && toDate != null)
            {                
                filter = filter & Builders<AlertVehicles>.Filter.Gte(c => c.TimeStamp, fromDate) & Builders<AlertVehicles>.Filter.Lte(x => x.TimeStamp, toDate);
            }
           
            return await _context.AlertVehicle.Find(filter).ToListAsync();         
        }
        
    }
}
