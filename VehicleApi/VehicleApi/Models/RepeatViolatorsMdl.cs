using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Secura
{
    public class RepeatViolatorsMdl
    {
        public int? Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string DTInterval { get; set; }
        public int? Day { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Minute { get; set; }
        public int? Hour { get; set; }
        public string JunctionName { get; set; }
        public string PoleName { get; set; }
        public string CameraName { get; set; }
        public string CameraGUID { get; set; }
        public string LPNumber { get; set; }
        public string ViolatorName { get; set; }
        public int NoOfViolation { get; set; }
        public string SourceLocation { get; set; }
        public string TimeStampStr { get; set; }
		public int? JunctionId { get; set; }
		public DateTime? DateOfViolation { get; set; }
	}
}