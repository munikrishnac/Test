namespace VehicleApi.Data
{
    using Api.Model;
    using AppApi.Model;
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;
    using MongoDB.Driver.Linq;
    using VehicleApi.Model;

    /// <summary>
    /// NoteContext.
    /// </summary>
    public class VehicleApiContext
    {
        /// <summary>
        /// The database
        /// </summary>
        private readonly IMongoDatabase _database = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleApiContext"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public VehicleApiContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        /// <summary>
        /// Gets the alarms.
        /// </summary>
        /// <value>
        /// The alarms.
        /// </value>
        public IMongoCollection<AlertVehicles.AlertVehicles> AlertVehicle
        {
            get
            {
                return _database.GetCollection<AlertVehicles.AlertVehicles>("AlertVehicles");
            }
        }
        
        public IMongoCollection<Alarm> AlarmCollection
        {
            get
            {
                return _database.GetCollection<Alarm>("Alarm");
            }
        }
        
        public IMongoQueryable<Alarm> AlarmsQuery
        {
            get
            {
                return _database.GetCollection<Alarm>("Alarm").AsQueryable<Alarm>();
            }
        }
    }
}
