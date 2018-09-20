
namespace VehicleApi.Data
{
    using Api.Model;
    using AppApi.Model;
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using VehicleApi.AlertVehicles;
    using VehicleApi.Interfaces;
    using VehicleApi.Model;
    using GetDetails;
    using VehicleApi.Models.Models;
    using VehicleApi.Models;

    public class eChallanRepository : Iechallan
    {

        private readonly VehicleApiContext _context = null;

        public eChallanRepository(IOptions<Settings> settings)
        {
            _context = new VehicleApiContext(settings);
        }

        //public async Task<IList<AlertVehicles>> Get(DateTime? fromDate = null, DateTime? toDate = null, string cameraName = null, string sourceLocation = null, string licensePlateNumber = null)
        //{
        //    FilterDefinition<AlertVehicles> filter = Builders<AlertVehicles>.Filter.Ne(c => c.CamName, null); ;
        //    if (cameraName != null)
        //    {
        //        filter = filter & Builders<AlertVehicles>.Filter.Eq(c => c.CamName, cameraName);
        //    }
        //    if (sourceLocation != null)
        //    {
        //        filter = filter & Builders<AlertVehicles>.Filter.Eq(c => c.SourceLocation, sourceLocation);
        //    }
        //    if (licensePlateNumber != null)
        //    {
        //        filter = filter & Builders<AlertVehicles>.Filter.Eq(c => c.LicensePlateNumber, licensePlateNumber);
        //    }           
        //    if (fromDate != null && toDate != null)
        //    {                
        //        filter = filter & Builders<AlertVehicles>.Filter.Gte(c => c.TimeStamp, fromDate) & Builders<AlertVehicles>.Filter.Lte(x => x.TimeStamp, toDate);
        //    }

        //    return await _context.AlertVehicle.Find(filter).ToListAsync();         
        //}
        private List<TrafficListMain> MapReduceAlarm(DateTime? fromDate, DateTime? toDate)
        {
            //emit(1, { LPDImage: alarm.LPDImage,MappedRLVDCamera: alarm.MappedRLVDCamera,Confidence: alarm.Confidence,GeneratedReport: alarm.GeneratedReport,DayMonthYearInt: alarm.DayMonthYearInt });
            string map = @"
			function() {
                      var key = {CamGUID:this.CamGUID};
                      var value = {
                                    TrafficCount: 1,
                                    ViolationOverallCount : (this.LPDImage != null && this.MappedRLVDCamera != null ? 1 : 0),
                                    ViolationHighConfidenceCount : ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport != null) ? 1 : 0),
									SuccessCount: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == 'Y') ? 1 : 0),
                                    FailureCount: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == 'F') ? 1 : 0),
                                    VehicleNotFoundCount: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == 'V') ? 1 : 0),
                                    InvalidRegNoCount: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == 'I') ? 1 : 0),
                                    SevenDaysCount: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == 'L') ? 1 : 0),
                                    MoreOfficeCount: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == 'M') ? 1 : 0),
                                    ImgNotFoundCount: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == 'G') ? 1 : 0),
                                    ExclusiveCount: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == 'E') ? 1 : 0),
                                    NullCountHighConfidence: ((this.Confidence == '1.0' && this.LPDImage != null && this.MappedRLVDCamera != null && this.GeneratedReport == null) ? 1 : 0)

								   };

                      emit( key, value );
                  };";
            //var result = { ViolationOverallCount:0, ViolationHighConfidenceCount: 0,SuccessCount: 0,FailureCount: 0,VehicleNotFoundCount: 0, InvalidRegNoCount: 0, SevenDaysCount: 0,MoreOfficeCount: 0, ImgNotFoundCount: 0,ExclusiveCount: 0,NullCountHighConfidence: 0,NullCountLowConfidence: 0};
            string reduce = @"        
			function(key, values) {

                        var reducedObject = {
                                              TrafficCount:0,
                                              ViolationOverallCount:0,
                                              ViolationHighConfidenceCount:0,
                                              SuccessCount:0,
                                              FailureCount:0,
                                              VehicleNotFoundCount:0,
                                              InvalidRegNoCount:0,
                                              SevenDaysCount:0,
                                              MoreOfficeCount:0,
                                              ImgNotFoundCount:0,
                                              ExclusiveCount:0,
                                              NullCountHighConfidence:0
                                            };

                        values.forEach( function(value) {
										reducedObject.TrafficCount += value.TrafficCount ;
                                   		reducedObject.ViolationOverallCount += value.ViolationOverallCount;
                                   		reducedObject.ViolationHighConfidenceCount+=value.ViolationHighConfidenceCount;
                                   		reducedObject.SuccessCount+=value.SuccessCount;
                                   		reducedObject.FailureCount+=value.FailureCount;
                                   		reducedObject.VehicleNotFoundCount+=value.VehicleNotFoundCount;
                                   		reducedObject.InvalidRegNoCount+=value.InvalidRegNoCount;
                                   		reducedObject.SevenDaysCount+=value.SevenDaysCount;
                                   		reducedObject.MoreOfficeCount+=value.MoreOfficeCount;
                                   		reducedObject.ImgNotFoundCount+=value.ImgNotFoundCount;
                                   		reducedObject.ExclusiveCount+=value.ExclusiveCount;
                                   		reducedObject.NullCountHighConfidence+=value.NullCountHighConfidence;
                                    }
                          );
                          return reducedObject;
                     }";

            var options = new MapReduceOptions<Alarm, TrafficListMain>
            {
                OutputOptions = MapReduceOutputOptions.Inline,
                Filter = "{ DayMonthYearHrMin: {'$gte': " + String.Format("{0:yyyyMMddHHmm}", fromDate) + ", '$lte': " + String.Format("{0:yyyyMMddHHmm}", toDate) + "}, DuplicateAlarm : NumberInt(1), AlarmName:{$regex: \".*LICENSE_PLATE.*\"} }"
                //Filter= "{ DayMonthYearInt: {'$gte': 20180813, '$lte':20180813}, DuplicateAlarm : NumberInt(1), AlarmName:{$regex: \".*LICENSE_PLATE.*\"} }"
                //Filter = "{ DayMonthYearInt:20180813,DuplicateAlarm : NumberInt(1), Hour: { \"$gte\":9, \"$lt\":10}, LPDImage: { \"$ne\": null}, AlarmName: {$regex: \".*LICENSE_PLATE.*\"}"
            };

            var alarmCollection = _context.AlarmCollection;

            var results = alarmCollection.MapReduce(map, reduce, options).ToList<TrafficListMain>();

            return results;
        }
        public async Task<IList<Alarm>> Get(DateTime? fromDate, DateTime? toDate, List<string> cameraName, List<string> sourceLocation, string licensePlateNumber)
        {
            var retResults = MapReduceAlarm(fromDate, toDate);
            CombineClass combineClass = new CombineClass();
            combineClass= GetDetails.Alarm();
            List<string> lstJunctionId = new List<string>();

            //if (sourceLocation.Count > 0)
            //    lstJunctionId = from o in sourceLocation where sourceLocation == o.lstJunctionId select o;
            //lstJunctionId = sourceLocation.Contains(p=>p).Select(Int32.Parse).ToList();

            //string[] arrSourceLocation = (from a in lstJunctionMaster
            //                              where lstJunctionId.Contains(a.JunctionID)
            //                              select a.SourceLocation).ToArray<string>();

            //string[] arrPoleIds = { };

            //string[] arrCameraGuids = { };

            //if (poleIds.Length > 0)
            //    arrPoleIds = poleIds.Split(',');

            //if (cameraGuids.Length > 0)
            //    arrCameraGuids = cameraGuids.Split(',');

            //var glstTraffic = (from a in retResults
            //                   join polecameraMapping in lstPoleCameraMapping on a._id.CamGUID equals polecameraMapping.CameraGUID
            //                   join polemaster in lstPolemaster on polecameraMapping.PoleCameraMappingID equals polemaster.Id
            //                   join junctionmaster in lstJunctionMaster on polemaster.JunctionID equals junctionmaster.JunctionID
            //                   where (arrSourceLocation.Length > 0 ? arrSourceLocation.Contains(junctionmaster.SourceLocation) : true)
            //                   && (arrPoleIds.Length > 0 ? arrPoleIds.Contains(polemaster.Id.ToString()) : true)
            //                   && (arrCameraGuids.Length > 0 ? arrCameraGuids.Contains(polecameraMapping.CameraGUID) : true)
            //                   select new TrafficListModel
            //                   {
            //                       JunctionId = junctionmaster.JunctionID,
            //                       JunctionName = junctionmaster.JunctionName,
            //                       Id = polemaster.Id,
            //                       PoleName = polemaster.Name,
            //                       CameraName = polecameraMapping.CameraName,
            //                       TrafficCount = a.value.TrafficCount,
            //                       ViolationOverallCount = a.value.ViolationOverallCount,
            //                       ViolationHighConfidenceCount = a.value.ViolationHighConfidenceCount,
            //                       SuccessCount = a.value.SuccessCount,
            //                       FailureCount = a.value.FailureCount,
            //                       VehicleNotFoundCount = a.value.VehicleNotFoundCount,
            //                       InvalidRegNoCount = a.value.InvalidRegNoCount,
            //                       SevenDaysCount = a.value.SevenDaysCount,
            //                       MoreOfficeCount = a.value.MoreOfficeCount,
            //                       ImgNotFoundCount = a.value.ImgNotFoundCount,
            //                       ExclusiveCount = a.value.ExclusiveCount,
            //                       NullCountHighConfidence = a.value.NullCountHighConfidence
            //                   });

            //return glstTraffic;
            return null;
        }
    }
}
