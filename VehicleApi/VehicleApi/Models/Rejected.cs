using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Secura
{
	public class Rejected
	{
		[BsonElement("Status")]
		public string Status { get; set; }

		[BsonElement("RejectedName")]
		public string RejectedName { get; set; }

		[BsonElement("RejectedBy")]
		public int? RejectedBy { get; set; }

		[BsonElement("RejectedReason")]
		public string RejectedReason { get; set; }

		[BsonElement("RejectedDate")]
		public DateTime? RejectedDate { get; set; }

		[BsonElement("ApproveNo")]
		public string ApproveNo { get; set; }
	}
}