using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleApi.Attributes;
using VehicleApi.Interfaces;

namespace VehicleApi.Controllers
{
    [Produces("application/json")]
    //[Route("api/EchallanDetails")]
    [BasicAuthorize("http://securaworld.com/")]
    [Route("api/[controller]")]
    public class EchallanDetailsController : Controller
    {
        private readonly Iechallan _iechallan;

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoController"/> class.
        /// </summary>
        /// <param name="mongoRepository">The mongo repository.</param>

        public EchallanDetailsController(Iechallan iechallan)
        {

            _iechallan = iechallan;
        }

        [HttpPost]
       
        public async Task<IList<Alarm>> Get(DateTime? fromDate = null, DateTime? toDate = null, List<string> cameraName = null, List<string> sourceLocation = null, string licensePlateNumber = null)
        {
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("veryVerySecretKey"));
            //string authHeader = context.Request.Headers["Authorization"];
            try
            {
                var details = await _iechallan.Get(fromDate, toDate, cameraName, sourceLocation, licensePlateNumber);
                return details;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}