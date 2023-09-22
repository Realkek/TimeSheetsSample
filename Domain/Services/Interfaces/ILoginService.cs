using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Domain.Services.Interfaces
{
    public interface ILoginService
    {
        Task<LoginResponse> Authenticate(User user);
    }
}