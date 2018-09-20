using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Secura
{
	public class Amend
	{

		/// <summary>
		/// Gets or sets the alarm ApprovedBy.
		/// </summary>
		/// <value>
		/// The alarm ApprovedBy.
		/// </value>

		[BsonElement("Status")]
		public string Status { get; set; }

		[BsonElement("AmendName")]
		public string AmendName { get; set; }

		[BsonElement("AmendBy")]
		public int? AmendBy { get; set; }

		[BsonElement("AmendReason")]
		public string AmendReason { get; set; }

		[BsonElement("AmendDate")]
		public DateTime? AmendDate { get; set; }

		[BsonElement("ApproveNo")]
		public string ApproveNo { get; set; }
	}
}
