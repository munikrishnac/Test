using Secura.Core;

namespace Secura
{
    public class PoleMaster : BaseEntity
    {
        public string Name { get; set; }
        public int JunctionID { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsDelete { get; set; }
        public string CameraName { get; set; }
		public string JunctionName { get; set; }
	}
}