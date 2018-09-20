using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApi.Models
{
	public class TrafficDrillMain
	{
		public CameraDrillMapReduce _id { get; set; }
		public TrafficDrillMapReduce value { get; set; }
	}
	public class TrafficDrillMapReduce
	{
		public string CamGUID { get; set; }
		public int? Day { get; set; }
		public int? Month { get; set; }
		public int? Year { get; set; }
		public int? Hour { get; set; }
		public int? Minute { get; set; }
		public string TimeStampStr { get; set; }
		public Int64 TrafficCount { get; set; }
		public Int64 ViolationCount { get; set; }
	}

	public class CameraDrillMapReduce
	{
		public string CamGUID { get; set; }
	}
}