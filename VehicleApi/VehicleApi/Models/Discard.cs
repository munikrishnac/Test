using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secura
{
   public class Discard
	{
		/// <summary>
		/// Gets or sets the alarm ApprovedBy.
		/// </summary>
		/// <value>
		/// The alarm ApprovedBy.
		/// </value>
		/// 
	
		[BsonElement("DiscardBy")]
		public int? DiscardBy { get; set; }

		[BsonElement("DiscardName")]
		public string DiscardName { get; set; }

		[BsonElement("DiscardDate")]
		public DateTime? DiscardDate { get; set; }
	}
}
