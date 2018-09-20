using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using VehicleApi.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace VehicleApi.Controllers
{
    
    [Produces("application/json")]
    [Route("api/[controller]")]
   // [AuthorizeAttribute(Policy = JwtBearerDefaults.AuthenticationScheme, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AlertApiController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoController"/> class.
        /// </summary>
        /// <param name="mongoRepository">The mongo repository.</param>
       
        public AlertApiController(IVehicleRepository vehicleRepository)
        {
 
            _vehicleRepository = vehicleRepository;
        }

        [HttpPost]

        [Authorize]
        public async Task<IList<VehicleApi.AlertVehicles.AlertVehicles>> Get(DateTime? fromDate = null, DateTime? toDate = null, string cameraName = null,string sourceLocation = null, string licensePlateNumber = null)
        {
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("veryVerySecretKey"));
            //string authHeader = context.Request.Headers["Authorization"];
            try { 
           var details= await _vehicleRepository.Get(fromDate, toDate, cameraName, sourceLocation, licensePlateNumber);
           return details;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
