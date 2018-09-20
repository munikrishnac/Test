using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Secura
{
    public class ViolationType
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public string Description { get; set; }
        public string SystemName { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public DateTime? DateOfModification { get; set; }
        public bool? IsDelete { get; set; }
        public Decimal ViolationAmount { get; set; }
        public Decimal CompoundingFee { get; set; }
        public string ApplicableSection { get; set; }
		public string ColorCode { get; set; }
		public int? NoOfDueDays { get; set; }
	}
}