using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApi.Models
{
	public class ChallanStatisticsModel
	{
		public int? Id { get; set; }
		public DateTime TimeStamp { get; set; }
		public int? Day { get; set; }
		public int? Month { get; set; }
		public int? Year { get; set; }
		public int? Hour { get; set; }
		public int? Minute { get; set; }
		public string DTInterval { get; set; }
		public string JunctionName { get; set; }
		public string PoleName { get; set; }
		public string CameraName { get; set; }
		public string CameraGUID { get; set; }
		public int? ChallanTotalCount { get; set; }
		public int? ChallanApprovedCount { get; set; }
		public int? ChallanPrintedCount { get; set; }
		public int? ChallanDiscardCount { get; set; }
		public int? DifferenceInApproved { get; set; }
		public int? DifferenceInPrinted { get; set; }
		public string TimeStampStr { get; set; }
		public int? JunctionId { get; set; }
		public string Approved { get; set; }
		public string GeneratedReport { get; set; }
		public string ChallanPrinted { get; set; }
		public int? DiscardFlag { get; set; }
	}
}