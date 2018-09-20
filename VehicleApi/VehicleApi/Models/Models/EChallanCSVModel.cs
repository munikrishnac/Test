
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApi.Models
{
	public class EChallanCSVModel
	{
		public string Location { get; set; }
		public string VehicleRegNo { get; set; }
		public string VehicleType { get; set; }
		public string ViolatorName { get; set; }
		public string ViolatorAddress1 { get; set; }
		public string VehicleMake { get; set; }
		public string VehicleModel { get; set; }
		public string TrafficPS { get; set; }
		public string ChallanDate { get; set; }
		public string DueDate { get; set; }
		public string StatusDate { get; set; }
		public decimal? FineAmount { get; set; }
		public string DateOfViolation { get; set; }
		public string TotalChallans { get; set; }
		public string Description { get; set; }
		public string ApplicableSection { get; set; }
		public string ChallanNo { get; set; }
		public string ApproveNo { get; set; }
		public string UserName { get; set; }
		//public Approve Approve { get; set; }
		//public UndoApprove UndoApprove { get; set; }
		//public Print Print { get; set; }
		//public Rejected Rejected { get; set; }
		//public Amend Amend { get; set; }
		//public Discard Discard { get; set; }
		public string Status { get; set; }
	}
}