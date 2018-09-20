using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Secura
{
    
    public class JunctionMaster
    {
        public int ID { get; set; }
        public int JunctionID { get; set; }
        public string JunctionName { get; set; }
        public string JunctionLocation { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CameraImageLocation { get; set; }
        public string SourceLocation { get; set; }
        public int? AreaId { get; set; }
        public string JunctionIP { get; set; }
        public string AreaCode { get; set; }
    }
}