using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using TImeSheetsSample.Domain.Services.Interfaces;
using TImeSheetsSample.Infrastructure.Extensions;
using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Models.DataTransferObjects.Authentication;
using TImeSheetsSample.Models.Entities;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace TImeSheetsSample.Domain.Services.Implementation
{
    public class LoginService: ILoginService
    {
        private readonly JwtAccessOptions _jwtAccessOptions;

        public LoginService(IOptions<JwtAccessOptions> jwtAccessOptions)
        {
            _jwtAccessOptions = jwtAccessOptions.Value;
        }
        
        public async Task<LoginResponse> Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Username),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
            };

            var accessTokenRaw = _jwtAccessOptions.GenerateToken(claims);
            var securityHandler = new JwtSecurityTokenHandler();
            var accessToken = securityHandler.WriteToken(accessTokenRaw);

            var loginResponse = new LoginResponse()
            {
                AccessToken = accessToken,
                ExpiresIn = accessTokenRaw.ValidTo.ToEpochTime()
            };

            return loginResponse;
        }
    }
}