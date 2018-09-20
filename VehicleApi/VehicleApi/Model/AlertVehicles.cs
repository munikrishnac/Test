using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.Model;
using VehicleApi.AlertVehicles;
using Secura.Core;

namespace VehicleApi.AlertVehicles
{
	public class AlertVehicles : BaseEntityMongo
    {
        //[BsonElement("Push")]
        //public int Push { get; set; }
        /// <summary>
        /// Gets or sets the name of the alarm.
        /// </summary>
        /// <value>
        /// The name of the alarm.
        /// </value>
        [BsonElement("AlarmName")]
		public string AlarmName { get; set; }

		/// <summary>
		/// Gets or sets the time stamp.
		/// </summary>
		/// <value>
		/// The time stamp.
		/// </value>
		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("TimeStamp")]
		public DateTime TimeStamp { get; set; }

	

		/// <summary>
		/// Gets or sets the image file.
		/// </summary>
		/// <value>
		/// The image file.
		/// </value>
		[BsonElement("ImageFile")]
		public string ImageFile
		{
			get;

			set;

		}

		

		/// <summary>
		/// Gets or sets the cam unique identifier.
		/// </summary>
		/// <value>
		/// The cam unique identifier.
		/// </value>
		[BsonElement("CamGUID")]
		public string CamGUID { get; set; }

		/// <summary>
		/// Gets or sets the name of the cam.
		/// </summary>
		/// <value>
		/// The name of the cam.
		/// </value>
		[BsonElement("CamName")]
		public string CamName { get; set; }

		

		/// <summary>
		/// Gets or sets the LPD image.
		/// </summary>
		/// <value>
		/// The LPD image.
		/// </value>
		[BsonElement("LPDImage")]
		public string LPDImage { get; set; }

		

		/// <summary>
		/// Gets or sets the confidence.
		/// </summary>
		/// <value>
		/// The confidence.
		/// </value>
		[BsonElement("Confidence")]
		public string Confidence { get; set; }

		/// <summary>
		/// Gets or sets the license plate number.
		/// </summary>
		/// <value>
		/// The license plate number.
		/// </value>
		[BsonElement("LicensePlateNumber")]
		public string LicensePlateNumber { get; set; }

		/// <summary>
		/// Gets or sets the source location.
		/// </summary>
		/// <value>
		/// The source location.
		/// </value>
		[BsonElement("SourceLocation")]
		public string SourceLocation { get; set; }

		/// <summary>
		/// Gets or sets the Vehicleid.
		/// </summary>
		/// <value>
		/// VehicleCategoryId.
		/// </value>
		[BsonElement("VehicleCategoryId")]
		public int VehicleCategoryId { get; set; }

		/// <summary>
		/// Gets or sets the Vehicle Type.
		/// </summary>
		/// <value>
		/// VehicleVehicle Type.
		/// </value>
		[BsonElement("VehicleCategory")]
		public string VehicleCategory { get; set; }

        /// VehicleVehicle Type.
        /// </value>
        [BsonElement("Push")]
        public bool Push { get; set; } = false;

        /// <summary>
        /// Gets or sets the Vehicle Type.
        /// </summary>
        /// <value>
        /// VehicleVehicle Type.
        /// </value>

        [BsonElement("QPush")]
        public bool Qcognify { get; set; } = false;
    }
}
