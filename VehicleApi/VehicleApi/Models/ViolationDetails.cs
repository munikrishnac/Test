using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Secura
{
	public class ViolationDetails
	{
		public string _id { get; set; }

		[BsonElement("ViolationTypeId")]
		public int ViolationTypeId { get; set; }

		[BsonElement("ViolationDescription")]
		public string ViolationDescription { get; set; }

		[BsonElement("ApplicableSection")]
		public string ApplicableSection { get; set; }

		[BsonElement("FineAmount")]
		public Double FineAmount { get; set; }

		/// <summary>
		/// FineType - F - Fine Amount, C- Compounding Amount
		/// </summary>
		[BsonElement("FineType")]
		public string FineType { get; set; }

		[BsonElement("PrevChallan")]
		public string PrevChallan { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("CreatedDate")]
		public DateTime CreatedDate { get; set; }
	}
}