using Secura.Core;

namespace Secura
{
    public class PoleCameraMapping : BaseEntity
    {
        public int PoleCameraMappingID { get; set; }
        public string CameraGUID { get; set; }
        public string CameraName { get; set; }
		public string CameraDescription { get; set; }
		public string Name { get; set; }  //PoleName
		public string JunctionName { get; set; }
	}
}