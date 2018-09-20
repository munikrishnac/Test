using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppApi.Model
{
	public class UpdateAlarm
	{

		/// <summary>
		/// Gets or sets the cam unique identifier.
		/// </summary>
		/// <value>
		/// The cam unique identifier.
		/// </value>
		[BsonElement("CAMGU")]
		public string CamGUID { get; set; }

		/// <summary>
		/// Gets or sets the name of the cam.
		/// </summary>
		/// <value>
		/// The name of the cam.
		/// </value>
		[BsonElement("CAMNA")]
		public string CamName { get; set; }

        /// <summary>
        /// Gets or sets the time stamp.
        /// </summary>
        /// <value>
        /// The time stamp.
        /// </value>
        [BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("TIMES")]
		public DateTime TimeStamp { get; set; }

		/// <summary>
		/// Gets or sets the ms precision ts.
		/// </summary>
		/// <value>
		/// The ms precision ts.
		/// </value>
		[BsonElement("MSPRT")]
		public double MsPrecisionTS { get; set; }



		/// <summary>
		/// Gets or sets the Statu.
		/// </summary>
		/// <value>
		/// The time stamp.
		/// </value>
		[BsonElement("STATUS")]
		public string Status { get; set; }
	}
}
