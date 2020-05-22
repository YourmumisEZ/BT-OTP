namespace BT_OTP_BL.Interfaces
{
    public interface IOTPManager
    {
        string GenerateCode(string userId);
    }
}