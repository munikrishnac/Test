using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Model
{
   public class Approve
    {
		/// <summary>
		/// Gets or sets the alarm ApprovedBy.
		/// </summary>
		/// <value>
		/// The alarm ApprovedBy.
		/// </value>
		/// 
		[BsonElement("ApprovedNo")]
		public string ApprovedNo { get; set; }

		[BsonElement("ApprovedBy")]
		public int? ApprovedBy { get; set; }

		[BsonElement("ApprovedName")]
		public string ApprovedName { get; set; }

		[BsonElement("ApprovedDate")]
		public DateTime? ApprovedDate { get; set; }
	}
}
