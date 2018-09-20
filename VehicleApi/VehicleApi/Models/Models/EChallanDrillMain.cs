using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApi.Models
{
	public class EChallanDrillMain
	{
		public CameraEChallanDrillMapReduce _id { get; set; }
		public EChallanDrillMapReduce value { get; set; }
	}
	public class EChallanDrillMapReduce
	{
		public string CameraGUID { get; set; }
		public int? Day { get; set; }
		public int? Month { get; set; }
		public int? Year { get; set; }
		public int? Hour { get; set; }
		public int? Minute { get; set; }
		public string TimeStampStr { get; set; }
		public int ManualChallanCount { get; set; }
		public Decimal ManualChallanFinedAmount { get; set; }
		public Decimal ManualChallanRcvdAmount { get; set; }
		public int AutoChallanCount { get; set; }
		public Decimal AutoChallanFinedAmount { get; set; }
		public Decimal AutoChallanRcvdAmount { get; set; }
	}

	public class CameraEChallanDrillMapReduce
	{
		public string CameraGUID { get; set; }
	}

}