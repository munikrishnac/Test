using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApi.Models
{
	public class TrafficListModel
	{
		//public string _id { get; set; }
		public int? Day { get; set; }
		public int? Month { get; set; }
		public int? Year { get; set; }
		public int? Hour { get; set; }
		public int? Minute { get; set; }
		public DateTime TimeStamp { get; set; }
		public string TimeStampStr { get; set; }
		public string JunctionName { get; set; }
		public string PoleName { get; set; }
		public string CameraName { get; set; }
		public string CameraGUID { get; set; }
		public Int64 TrafficCount { get; set; }
		public Int64 ViolationOverallCount { get; set; }
		public Int64 ViolationHighConfidenceCount { get; set; }
		public Int64 SuccessCount { get; set; }
		public Int64 FailureCount { get; set; }
		public Int64 VehicleNotFoundCount { get; set; }
		public Int64 InvalidRegNoCount { get; set; }
		public Int64 SevenDaysCount { get; set; }
		public Int64 MoreOfficeCount { get; set; }
		public Int64 ImgNotFoundCount { get; set; }
		public Int64 ExclusiveCount { get; set; }
		public Int64 NullCountHighConfidence { get; set; }
		public Int64 NullCountLowConfidence { get; set; }
		public int Week { get; set; }
		public string GeneratedReport { get; set; }
		public string AlarmName { get; set; }
		public string LPDImage { get; set; }
		public string MappedRLVDCamera { get; set; }
		public int? JunctionId { get; set; }
		public int? Id { get; set; }
		public string Confidence { get; set; }
		
	}
}