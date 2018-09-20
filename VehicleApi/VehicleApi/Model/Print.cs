using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Model
{
   public class Print
    {
		/// <summary>
		/// Gets or sets the alarm ApprovedBy.
		/// </summary>
		/// <value>
		/// The alarm ApprovedBy.
		/// </value>
		/// 
		

		[BsonElement("PrintBy")]
		public int? PrintBy { get; set; }

		[BsonElement("PrintName")]
		public string PrintName { get; set; }

		[BsonElement("PrintDate")]
		public DateTime? PrintDate { get; set; }
	}
}
