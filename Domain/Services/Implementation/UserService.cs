using System.Security.Cryptography;
using System.Text;
using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Domain.Services.Interfaces;
using TImeSheetsSample.Infrastructure.Extensions;
using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Domain.Services.Implementation
{
    public class UserService: IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<User> GetUser(LoginRequest request)
        {
            var passwordHash = GetPasswordHash(request.Password);
            var user = await _userRepo.GetByLoginAndPasswordHash(request.Login, passwordHash);

            return user;
        }

        public async Task<Guid> CreateUser(CreateUserRequest request)
        {
            request.EnsureNotNull(nameof(request));
            
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = request.Username,
                PasswordHash = GetPasswordHash(request.Password),
                Role = request.Role
            };

            await _userRepo.CreateUser(user);

            return user.Id;
        }

        private static byte[] GetPasswordHash(string password)
        {
            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                return sha1.ComputeHash(Encoding.Unicode.GetBytes(password));
            }
        }
    }
}