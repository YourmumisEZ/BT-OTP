using BT_OTP_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BT_OTP_Server.Controllers
{
    [Route("api/otp")]
    [ApiController]
    public class OTPController : ControllerBase
    {
        private readonly IOTPManager otpManager;

        public OTPController(IOTPManager otpManager)
        {
            this.otpManager = otpManager;
        }

        [HttpGet]
        public ActionResult<string> Get(string userId)
        {
           return otpManager.GenerateCode(userId);
        }
    }
}