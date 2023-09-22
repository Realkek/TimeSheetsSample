using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Domain.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary> Возвращает пользователя по логину и паролю </summary>
        Task<User> GetUser(LoginRequest request);

        /// <summary> Создает нового пользователя </summary>
        Task<Guid> CreateUser(CreateUserRequest request);
    }
}