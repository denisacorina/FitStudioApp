using FitStudio_App.Models;

namespace FitStudio_App.Services.Interface
{
    public interface IGenerateToken
    {
        public string GenerateAccessToken(User user);
        public RefreshToken GenerateRefreshToken();
      
   
    }
}
