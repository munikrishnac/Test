using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Secura
{
	public class Challan
	{
		public string _id { get; set; }

		[BsonElement("ChallanId")]
		public int? ChallanId { get; set; }

		[BsonElement("ChallanNo")]
		public string ChallanNo { get; set; }

		[BsonElement("ViolatorName")]
		public string ViolatorName { get; set; }

		[BsonElement("ViolatorAddress1")]
		public string ViolatorAddress1 { get; set; }

		[BsonElement("ViolatorAddress2")]
		public string ViolatorAddress2 { get; set; }

		[BsonElement("VehicleType")]
		public string VehicleType { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("ChallanDate")]
		public DateTime? ChallanDate { get; set; }

		[BsonElement("DueDate")]
		public string DueDate { get; set; }

		[BsonElement("VehicleRegNo")]
		public string VehicleRegNo { get; set; }

		[BsonElement("VehicleMake")]
		public string VehicleMake { get; set; }

		[BsonElement("VehicleModel")]
		public string VehicleModel { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("DateOfViolation")]
		public DateTime DateOfViolation { get; set; }

		[BsonElement("PreviousViolation")]
		public string PreviousViolation { get; set; }

		[BsonElement("PlaceOfViolation")]
		public string PlaceOfViolation { get; set; }

		[BsonElement("TrafficPS")]
		public string TrafficPS { get; set; }

		[BsonElement("SNo")]
		public int? SNo { get; set; }

		[BsonElement("OffenceDescription")]
		public string OffenceDescription { get; set; }

		[BsonElement("ApplicableSection")]
		public string ApplicableSection { get; set; }

		[BsonElement("FineAmount")]
		public decimal? FineAmount { get; set; }

		[BsonElement("PrevChallan")]
		public string PrevChallan { get; set; }

		[BsonElement("TotalCompoundingChallan")]
		public decimal? TotalCompoundingChallan { get; set; }

		[BsonElement("TotalChallan")]
		public string TotalChallan { get; set; }

		[BsonElement("DriverName")]
		public string DriverName { get; set; }

		[BsonElement("LicenseNo")]
		public string LicenseNo { get; set; }

		[BsonElement("ChallanImage1")]
		public string ChallanImage1 { get; set; }

		[BsonElement("ChallanImage2")]
		public string ChallanImage2 { get; set; }

		[BsonElement("ChallanImage3")]
		public string ChallanImage3 { get; set; }

		[BsonElement("ChallanImage4")]
		public string ChallanImage4 { get; set; }

		[BsonElement("AlarmId")]
		public string AlarmId { get; set; }

		[BsonElement("pushed")]
		public bool? pushed { get; set; }

		[BsonElement("Confidence")]
		public string Confidence { get; set; }

		[BsonElement("ChallanType")]
		public string ChallanType { get; set; }

		[BsonElement("ChallanPrinted")]
		public string ChallanPrinted { get; set; }

		[BsonElement("PaidAmount")]
		public decimal? PaidAmount { get; set; }

		[BsonElement("PaidStatus")]
		public string PaidStatus { get; set; }

		[BsonElement("GeneratedType")]
		public bool? GeneratedType { get; set; }

		[BsonElement("RLVDdiscard")]
		public int? RLVDdiscard { get; set; }

		[BsonElement("Regenerate")]
		public bool? Regenerate { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("CreatedDateTime")]
		public DateTime? CreatedDateTime { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("UpdatedDateTime")]
		public DateTime? UpdatedDateTime { get; set; }

		[BsonElement("ViolationId")]
		public int? ViolationId { get; set; }

		[BsonElement("CameraGUID")]
		public string CameraGUID { get; set; }

		[BsonElement("VehicleColor")]
		public string VehicleColor { get; set; }

		[BsonElement("TrafficPSId")]
		public int? TrafficPSId { get; set; }

		[BsonElement("TrafficPSId1")]
		public int? TrafficPSId1 { get; set; }

		[BsonElement("TrafficPS1")]
		public string TrafficPS1 { get; set; }

		[BsonElement("DiscardFlag")]
		public int? DiscardFlag { get; set; }

		[BsonElement("AlarmSourceVASPublic")]
		public string AlarmSourceVASPublic { get; set; }

		[BsonElement("GeneratedReport")]
		public string GeneratedReport { get; set; }

		[BsonElement("JunctionId")]
		public int? JunctionId { get; set; }

		[BsonElement("JunctionName")]
		public string JunctionName { get; set; }

		[BsonElement("SourceLocation")]
		public string SourceLocation { get; set; }

		[BsonElement("Approved")]
		public string Approved { get; set; }

		[BsonElement("ApprovedBy")]
		public int? ApprovedBy { get; set; }

		/// <summary>
		/// Gets or sets the Year.
		/// </summary>
		/// <value>
		/// The Year.
		/// </value>
		[BsonElement("Year")]
		public int? Year { get; set; }

		/// <summary>
		/// Gets or sets the Day.
		/// </summary>
		/// <value>
		/// The Day.
		/// </value>
		[BsonElement("Day")]
		public int? Day { get; set; }

		/// <summary>
		/// Gets or sets the Month.
		/// </summary>
		/// <value>
		/// The Month.
		/// </value>
		[BsonElement("Month")]
		public int? Month { get; set; }

		/// <summary>
		/// Gets or sets the DayMonthYear.
		/// </summary>
		/// <value>
		/// The DayMonthYear.
		/// </value>
		[BsonElement("DayMonthYear")]
		public string DayMonthYear { get; set; }

		/// <summary>
		/// Gets or sets the Hour.
		/// </summary>
		/// <value>
		/// The Hour.
		/// </value>
		[BsonElement("Hour")]
		public int? Hour { get; set; }

		/// <summary>
		/// Gets or sets the Hourstr.
		/// </summary>
		/// <value>
		/// The Hourstr.
		/// </value>
		[BsonElement("Hourstr")]
		public string Hourstr { get; set; }

		/// <summary>
		/// Gets or sets the Minute.
		/// </summary>
		/// <value>
		/// The Minute.
		/// </value>
		[BsonElement("Minute")]
		public int? Minute { get; set; }


		/// <summary>
		/// Gets or sets the DayMonthYearInt.
		/// </summary>
		/// <value>
		/// The DayMonthYearInt.
		/// </value>
		[BsonElement("DayMonthYearInt")]
		public int? DayMonthYearInt { get; set; }

		/// <summary>
		/// Gets or sets the DayMonthYearHrMin.
		/// </summary>
		/// <value>
		/// The DayMonthYearHrMin.
		/// </value>
		[BsonElement("DayMonthYearHrMin")]
		public long? DayMonthYearHrMin { get; set; }

		[BsonElement("ManualChallan")]
		public string ManualChallan { get; set; }

		[BsonElement("ViolationType")]
		public int? ViolationType { get; set; }

		[BsonElement("ViolationTypeName")]
		public string ViolationTypeName { get; set; }


		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("PaymentDate")]
		public DateTime? PaymentDate { get; set; }

		[BsonElement("FinePaid")]
		public decimal? FinePaid { get; set; }

		[BsonElement("ReceiptNo")]
		public string ReceiptNo { get; set; }

		[BsonElement("Status")]
		public string Status { get; set; }

		[BsonElement("ApproveNo")]
		public string ApproveNo { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("ApproveDate")]
		public DateTime ApproveDate { get; set; }

		[BsonElement("ApproveByName")]
		public string ApproveByName { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("PrintedDateTime")]
		public DateTime? PrintedDateTime { get; set; }

		[BsonElement("Print")]
		public List<Print> Print { get; set; }

		[BsonElement("Approve")]
		public List<Approve> Approve { get; set; }

		[BsonElement("UndoApprove")]
		public List<UndoApprove> UndoApprove { get; set; }

		[BsonElement("Discard")]
		public List<Discard> Discard { get; set; }

		[BsonElement("Rejected")]
		public List<Rejected> Rejected { get; set; }

		[BsonElement("Amend")]
		public IList<Amend> Amend { get; set; }

		[BsonElement("ViolationDetails")]
		public IList<ViolationDetails> ViolationDetails { get; set; }

		[BsonElement("ViolationDetailsHistory")]
		public IList<ViolationDetailsHistory> ViolationDetailsHistory { get; set; }
	}
}