using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secura
{
   public class UndoApprove
	{
		/// <summary>
		/// Gets or sets the alarm ApprovedBy.
		/// </summary>
		/// <value>
		/// The alarm ApprovedBy.
		/// </value>
		/// 

		[BsonElement("UndoApproveBy")]
		public int? UndoApproveBy { get; set; }

		[BsonElement("UndoApproveName")]
		public string UndoApproveName { get; set; }

		[BsonElement("UndoApproveDate")]
		public DateTime? UndoApproveDate { get; set; }

		[BsonElement("ApproveNo")]
		public string ApproveNo { get; set; }
	}
}
