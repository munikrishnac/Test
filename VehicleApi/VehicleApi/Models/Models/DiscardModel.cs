
using Api.Model;
using System;
using System.Collections.Generic;

namespace VehicleApi.Models
{
	public class DiscardModel
	{
		public DateTime TimeStamp { get; set; }
		public int? Day { get; set; }
		public int? Month { get; set; }
		public int? Year { get; set; }
		public int? Hour { get; set; }
		public int? Minute { get; set; }
		public string DTInterval { get; set; }
		public string VehicleNo { get; set; }
		public string ViolatorName { get; set; }
		public int? JunctionId { get; set; }
		public string JunctionName { get; set; }
		public int? Id { get; set; }
		public string PoleName { get; set; }
		public string CameraGUID { get; set; }
		public string CameraName { get; set; }
		public DateTime GeneratedOn { get; set; }
		public DateTime DiscardOn { get; set; }
		public int? DiscardFlag { get; set; }
		public List<Discard> Discard { get; set; }
		public string TimeStampStr { get; set; }
	}
}