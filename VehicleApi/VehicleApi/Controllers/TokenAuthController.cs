//using System;
//using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
//using System.Linq;
//using System.Security.Claims;
//using System.Security.Cryptography;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.IdentityModel.Tokens;
//using Newtonsoft.Json;
//using VehicleApi.Model;

//namespace VehicleApi.Controllers
//{
  
//    public class TokenController : Controller
//    {
//        [AllowAnonymous]
//        [Route("api/token")]
//        [HttpPost]
//        public async Task<IActionResult> Token(User model)
//        {

//            if (!ModelState.IsValid) return BadRequest("Token failed to generate");

//            var user = (model.Password == "lkm@123" && model.UserName == "secura");

//            if (!user) return Unauthorized();

//            //Add Claims
//            var claims = new[]
//            {
//                new Claim(JwtRegisteredClaimNames.UniqueName, "data"),
//                new Claim(JwtRegisteredClaimNames.Sub, "data"),
//                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
//            };

//            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("rlyaKithdrYVl6Z80ODU350md")); //Secret
//            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

//            var token = new JwtSecurityToken("me",
//                "you",
//                claims,
//                expires: DateTime.Now.AddMinutes(30),
//                signingCredentials: creds);

//            return Ok(new JsonWebToken()
//            {
//                access_token = new JwtSecurityTokenHandler().WriteToken(token),
//                expires_in = 600000,
//                token_type = "bearer"
//            });
//        }
//    }
//}