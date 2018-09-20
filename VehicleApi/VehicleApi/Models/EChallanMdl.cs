using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Secura
{
	public class EChallanMdl
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
		public int ManualChallanCount { get; set; }
		public Decimal ManualChallanFinedAmount { get; set; }
		public Decimal ManualChallanRcvdAmount { get; set; }
		public int AutoChallanCount { get; set; }
		public Decimal AutoChallanFinedAmount { get; set; }
		public Decimal AutoChallanRcvdAmount { get; set; }
        public string TimeStampStr { get; set; }
        public string Confidence { get; set; }
        public Decimal? FineAmount { get; set; }
        public Decimal? FinePaid { get; set; }
		public int? JunctionId { get; set; }
		public string Approved { get; set; }
		public string ChallanPrinted { get; set; }
	}
}