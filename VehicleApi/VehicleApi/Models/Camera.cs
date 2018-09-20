using Secura.Core;

namespace Secura
{
    public class Camera : BaseEntity
    {
        public string CameraGUID { get; set; }
        public string CameraName { get; set; }
        public string SourceVMS { get; set; }
        public int? ChannelWidth { get; set; }
        public int? ChannelHeight { get; set; }
        public string AnalyticsConfig { get; set; }
        public string CameraURL { get; set; }
        public bool? pushed { get; set; }
		public string CameraDescription { get; set; }
		public string Name { get; set; }  //PoleName
		public string JunctionName { get; set; }
	}
}