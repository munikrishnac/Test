using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApi.Models
{
	public class TrafficListMain
	{
		public CameraMapReduce _id { get; set; }
		public TrafficListMapReduce value { get; set; }
	}

	public class TrafficListMapReduce
	{
		public string CamGUID { get; set; }
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

	}

	public class CameraMapReduce
	{
		public string CamGUID { get; set; }
	}


}