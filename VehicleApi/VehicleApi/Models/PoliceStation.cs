using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Secura
{
    public class PoliceStation
    {
        public int? Id { get; set; }
        public string StationName { get; set; }
        public int? Code { get; set; }
        public string SystemName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Pincode { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public DateTime? DateOfModification { get; set; }
        public bool? IsDelete { get; set; }
        public string CameraName { get; set; }
        public string CameraGUID { get; set; }
    }
}