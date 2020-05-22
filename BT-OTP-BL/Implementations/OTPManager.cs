using BT_OTP_BL.Interfaces;
using OtpNet;
using System;
using System.Text;

namespace BT_OTP_BL.Implementations
{
    public class OTPManager : IOTPManager
    {
        public string GenerateCode(string userId)
        {
            Totp timeBased_OTP = new Totp(Encoding.ASCII.GetBytes(userId), step: 30);
            return timeBased_OTP.ComputeTotp(DateTime.UtcNow);
        }
    }
}
