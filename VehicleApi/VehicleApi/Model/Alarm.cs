
namespace Api.Model
{
	using MongoDB.Bson.Serialization.Attributes;
	using System;
	using System.Collections.Generic;

	public class Alarm : ParentEntity
	{
		/// <summary>
		/// Gets or sets the alarm identifier.
		/// </summary>
		/// <value>
		/// The alarm identifier.
		/// </value>
		[BsonElement("AlarmID")]
		public int AlarmID { get; set; }

		/// <summary>
		/// Gets or sets the name of the alarm.
		/// </summary>
		/// <value>
		/// The name of the alarm.
		/// </value>
		[BsonElement("AlarmName")]
		public string AlarmName { get; set; }

		/// <summary>
		/// Gets or sets the time stamp.
		/// </summary>
		/// <value>
		/// The time stamp.
		/// </value>
		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("TimeStamp")]
		public DateTime TimeStamp { get; set; }

		/// <summary>
		/// Gets or sets the type of the object.
		/// </summary>
		/// <value>
		/// The type of the object.
		/// </value>
		[BsonElement("ObjectType")]
		public string ObjectType { get; set; }

		/// <summary>
		/// Gets or sets the agent rectangle.
		/// </summary>
		/// <value>
		/// The agent rectangle.
		/// </value>
		[BsonElement("AgentRectangle")]
		public string AgentRectangle { get; set; }

		/// <summary>
		/// Gets or sets the agent path.
		/// </summary>
		/// <value>
		/// The agent path.
		/// </value>
		[BsonElement("AgentPath")]
		public string AgentPath { get; set; }

		/// <summary>
		/// Gets or sets the bounding box.
		/// </summary>
		/// <value>
		/// The bounding box.
		/// </value>
		[BsonElement("BoundingBox")]
		public string BoundingBox { get; set; }

		/// <summary>
		/// Gets or sets the image file.
		/// </summary>
		/// <value>
		/// The image file.
		/// </value>
		[BsonElement("ImageFile")]
		public string ImageFile
		{
			get;

			set;

		}

		/// <summary>
		/// Gets or sets the video file.
		/// </summary>
		/// <value>
		/// The video file.
		/// </value>
		[BsonElement("VideoFile")]
		public string VideoFile { get; set; }

		/// <summary>
		/// Gets or sets the alarm description.
		/// </summary>
		/// <value>
		/// The alarm description.
		/// </value>
		[BsonElement("AlarmDescription")]
		public string AlarmDescription { get; set; }

		/// <summary>
		/// Gets or sets the type of the analytics.
		/// </summary>
		/// <value>
		/// The type of the analytics.
		/// </value>
		[BsonElement("AnalyticsType")]
		public string AnalyticsType { get; set; }

		/// <summary>
		/// Gets or sets the alarm source vas.
		/// </summary>
		/// <value>
		/// The alarm source vas.
		/// </value>
		[BsonElement("AlarmSourceVAS")]
		public string AlarmSourceVAS { get; set; }

		/// <summary>
		/// Gets or sets the cam unique identifier.
		/// </summary>
		/// <value>
		/// The cam unique identifier.
		/// </value>
		[BsonElement("CamGUID")]
		public string CamGUID { get; set; }

		/// <summary>
		/// Gets or sets the name of the cam.
		/// </summary>
		/// <value>
		/// The name of the cam.
		/// </value>
		[BsonElement("CamName")]
		public string CamName { get; set; }

		/// <summary>
		/// Gets or sets the width of the channel.
		/// </summary>
		/// <value>
		/// The width of the channel.
		/// </value>
		[BsonElement("ChannelWidth")]
		public int? ChannelWidth { get; set; }

		/// <summary>
		/// Gets or sets the height of the channel.
		/// </summary>
		/// <value>
		/// The height of the channel.
		/// </value>
		[BsonElement("ChannelHeight")]
		public int? ChannelHeight { get; set; }

		/// <summary>
		/// Gets or sets the color of the object.
		/// </summary>
		/// <value>
		/// The color of the object.
		/// </value>
		[BsonElement("ObjectColor")]
		public string ObjectColor { get; set; }

		/// <summary>
		/// Gets or sets the size of the object.
		/// </summary>
		/// <value>
		/// The size of the object.
		/// </value>
		[BsonElement("ObjectSize")]
		public string ObjectSize { get; set; }

		/// <summary>
		/// Gets or sets the pc in count.
		/// </summary>
		/// <value>
		/// The pc in count.
		/// </value>
		[BsonElement("PCInCount")]
		public int? PCInCount { get; set; }

		/// <summary>
		/// Gets or sets the pc out count.
		/// </summary>
		/// <value>
		/// The pc out count.
		/// </value>
		[BsonElement("PCOutCount")]
		public int? PCOutCount { get; set; }

		/// <summary>
		/// Gets or sets the cumulative pc in.
		/// </summary>
		/// <value>
		/// The cumulative pc in.
		/// </value>
		[BsonElement("CumulativePCIn")]
		public int? CumulativePCIn { get; set; }

		/// <summary>
		/// Gets or sets the cumulative pc out.
		/// </summary>
		/// <value>
		/// The cumulative pc out.
		/// </value>
		[BsonElement("CumulativePCOut")]
		public int? CumulativePCOut { get; set; }

		/// <summary>
		/// Gets or sets the index of the region.
		/// </summary>
		/// <value>
		/// The index of the region.
		/// </value>
		[BsonElement("RegionIndex")]
		public int? RegionIndex { get; set; }

		/// <summary>
		/// Gets or sets the face image.
		/// </summary>
		/// <value>
		/// The face image.
		/// </value>
		[BsonElement("FaceImage")]
		public string FaceImage { get; set; }

		/// <summary>
		/// Gets or sets the LPD image.
		/// </summary>
		/// <value>
		/// The LPD image.
		/// </value>
		[BsonElement("LPDImage")]
		public string LPDImage { get; set; }

		/// <summary>
		/// Gets or sets the name of the region.
		/// </summary>
		/// <value>
		/// The name of the region.
		/// </value>
		[BsonElement("RegionName")]
		public string RegionName { get; set; }

		/// <summary>
		/// Gets or sets the region priority.
		/// </summary>
		/// <value>
		/// The region priority.
		/// </value>
		[BsonElement("RegionPriority")]
		public string RegionPriority { get; set; }

		/// <summary>
		/// Gets or sets the alarm source vas public.
		/// </summary>
		/// <value>
		/// The alarm source vas public.
		/// </value>
		[BsonElement("AlarmSourceVASPublic")]
		public string AlarmSourceVASPublic { get; set; }

		/// <summary>
		/// Gets or sets the acknowledgement status.
		/// </summary>
		/// <value>
		/// The acknowledgement status.
		/// </value>
		[BsonElement("AcknowledgementStatus")]
		public int AcknowledgementStatus { get; set; }

		/// <summary>
		/// Gets or sets the closed status.
		/// </summary>
		/// <value>
		/// The closed status.
		/// </value>
		[BsonElement("ClosedStatus")]
		public int ClosedStatus { get; set; }

		/// <summary>
		/// Gets or sets the confidence.
		/// </summary>
		/// <value>
		/// The confidence.
		/// </value>
		[BsonElement("Confidence")]
		public string Confidence { get; set; }

		/// <summary>
		/// Gets or sets the license plate number.
		/// </summary>
		/// <value>
		/// The license plate number.
		/// </value>
		[BsonElement("LicensePlateNumber")]
		public string LicensePlateNumber { get; set; }

		/// <summary>
		/// Gets or sets the source location.
		/// </summary>
		/// <value>
		/// The source location.
		/// </value>
		[BsonElement("SourceLocation")]
		public string SourceLocation { get; set; }

		/// <summary>
		/// Gets or sets the mapped RLVD camera.
		/// </summary>
		/// <value>
		/// The mapped RLVD camera.
		/// </value>
		[BsonElement("MappedRLVDCamera")]
		public string MappedRLVDCamera { get; set; }

		/// <summary>
		/// Gets or sets the secura process.
		/// </summary>
		/// <value>
		/// The secura process.
		/// </value>
		[BsonElement("SecuraProcess")]
		public int? SecuraProcess { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>
		/// The unique identifier.
		/// </value>
		[BsonElement("guid")]
		public string guid { get; set; }

		/// <summary>
		/// Gets or sets the secura process crop.
		/// </summary>
		/// <value>
		/// The secura process crop.
		/// </value>
		[BsonElement("SecuraProcess_crop")]
		public int? SecuraProcess_crop { get; set; }

		/// <summary>
		/// Gets or sets the ms precision ts.
		/// </summary>
		/// <value>
		/// The ms precision ts.
		/// </value>
		[BsonElement("MsPrecisionTS")]
		public long? MsPrecisionTS { get; set; }

		/// <summary>
		/// Gets or sets the challan no.
		/// </summary>
		/// <value>
		/// The challan no.
		/// </value>
		[BsonElement("ChallanNo")]
		public string ChallanNo { get; set; }

		/// <summary>
		/// Gets or sets the generated report.
		/// </summary>
		/// <value>
		/// The generated report.
		/// </value>
		[BsonElement("GeneratedReport")]
		public string GeneratedReport { get; set; }

		/// <summary>
		/// Gets or sets the printed report.
		/// </summary>
		/// <value>
		/// The printed report.
		/// </value>
		[BsonElement("PrintedReport")]
		public string PrintedReport { get; set; }

		/// <summary>
		/// Gets or sets the discard flag.
		/// </summary>
		/// <value>
		/// The discard flag.
		/// </value>
		[BsonElement("DiscardFlag")]
		public int? DiscardFlag { get; set; }

		/// <summary>
		/// Gets or sets the duplicate alarm.
		/// </summary>
		/// <value>
		/// The duplicate alarm.
		/// </value>
		[BsonElement("DuplicateAlarm")]
		public int? DuplicateAlarm { get; set; }

		/// <summary>
		/// Gets or sets the pushed.
		/// </summary>
		/// <value>
		/// The pushed.
		/// </value>
		[BsonElement("pushed")]
		public bool? pushed { get; set; }

		/// <summary>
		/// Gets or sets the updated flag.
		/// </summary>
		/// <value>
		/// The updated flag.
		/// </value>
		[BsonElement("UpdatedFlag")]
		public int? UpdatedFlag { get; set; }

		/// <summary>
		/// Gets or sets the speed.
		/// </summary>
		/// <value>
		/// The speed.
		/// </value>
		[BsonElement("Speed")]
		public double? Speed { get; set; }

		/// <summary>
		/// Gets or sets the challan date.
		/// </summary>
		/// <value>
		/// The challan date.
		/// </value>
		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("ChallanDate")]
		public DateTime? ChallanDate { get; set; }

		/// <summary>
		/// Gets or sets the date of violation.
		/// </summary>
		/// <value>
		/// The date of violation.
		/// </value>
		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("DateOfViolation")]
		public DateTime? DateOfViolation { get; set; }

		/// <summary>
		/// Gets or sets the challan image1.
		/// </summary>
		/// <value>
		/// The challan image1.
		/// </value>
		[BsonElement("ChallanImage1")]
		public string ChallanImage1 { get; set; }

		/// <summary>
		/// Gets or sets the challan image2.
		/// </summary>
		/// <value>
		/// The challan image2.
		/// </value>
		[BsonElement("ChallanImage2")]
		public string ChallanImage2 { get; set; }

		/// <summary>
		/// Gets or sets the challan image3.
		/// </summary>
		/// <value>
		/// The challan image3.
		/// </value>
		[BsonElement("ChallanImage3")]
		public string ChallanImage3 { get; set; }

		/// <summary>
		/// Gets or sets the challan image4.
		/// </summary>
		/// <value>
		/// The challan image4.
		/// </value>
		[BsonElement("ChallanImage4")]
		public string ChallanImage4 { get; set; }

		/// <summary>
		/// Gets or sets the challan update mongo.
		/// </summary>
		/// <value>
		/// The challan update mongo.
		/// </value>
		[BsonElement("ChallanUpdateMongo")]
		public bool? ChallanUpdateMongo { get; set; }

		/// <summary>
		/// Gets or sets the challan identifier.
		/// </summary>
		/// <value>
		/// The challan identifier.
		/// </value>
		[BsonElement("ChallanId")]
		public int? ChallanId { get; set; }

		/// <summary>
		/// Gets or sets the RLVD discard.
		/// </summary>
		/// <value>
		/// The RLVD discard.
		/// </value>
		[BsonElement("RLVDDiscard")]
		public int? RLVDDiscard { get; set; }

		/// <summary>
		/// Gets or sets the Approved.
		/// </summary>
		[BsonElement("Approved")]
		public string Approved { get; set; }

		[BsonElement("ApprovedBy")]
		public int? ApprovedBy { get; set; }

		[BsonElement("Year")]
		public int? Year { get; set; }

		[BsonElement("Day")]
		public int? Day { get; set; }

		[BsonElement("Month")]
		public int? Month { get; set; }

		[BsonElement("DayMonthYear")]
		public string DayMonthYear { get; set; }

		[BsonElement("Hour")]
		public int? Hour { get; set; }

		[BsonElement("Hourstr")]
		public string Hourstr { get; set; }

		[BsonElement("Minute")]
		public int? Minute { get; set; }

		[BsonElement("DayMonthYearInt")]
		public int? DayMonthYearInt { get; set; }

		[BsonElement("DayMonthYearHrMin")]
		public long? DayMonthYearHrMin { get; set; }

		[BsonElement("ManualChallan")]
		public string ManualChallan { get; set; }

		[BsonElement("ViolationType")]
		public int? ViolationType { get; set; }

		[BsonElement("ViolationTypeName")]
		public string ViolationTypeName { get; set; }

		[BsonElement("PaymentDate")]
		public DateTime PaymentDate { get; set; }

		[BsonElement("FinePaid")]
		public decimal? FinePaid { get; set; }

		[BsonElement("ReceiptNo")]
		public string ReceiptNo { get; set; }

		[BsonElement("Status")]
		public string Status
		{
			get; set;

		}

		[BsonElement("ApproveNo")]
		public string ApproveNo
		{
			get; set;
		}
		[BsonElement("ApproveByName")]
		public string ApproveByName
		{
			get; set;
		}
		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[BsonElement("ApproveDate")]
		public DateTime ApproveDate { get; set; }


		[BsonElement("ChallanPrinted")]
		public string ChallanPrinted { get; set; }

		[BsonElement("Print")]
		public IList<Print> Print { get; set; }

		[BsonElement("Approve")]
		public IList<Approve> Approve { get; set; }

		[BsonElement("UndoApprove")]
		public IList<UndoApprove> UndoApprove { get; set; }

		[BsonElement("Discard")]
		public IList<Discard> Discard { get; set; }

		[BsonElement("ViolatorName")]
		public string ViolatorName { get; set; }

		[BsonElement("ViolatorAddress1")]
		public string ViolatorAddress1 { get; set; }

		[BsonElement("ViolatorAddress2")]
		public string ViolatorAddress2 { get; set; }

		[BsonElement("VehicleType")]
		public string VehicleType { get; set; }

		[BsonElement("VehicleMake")]
		public string VehicleMake { get; set; }

		[BsonElement("VehicleModel")]
		public string VehicleModel { get; set; }

		[BsonElement("DriverName")]
		public string DriverName { get; set; }

		[BsonElement("LicenseNo")]
		public string LicenseNo { get; set; }

	}
}

