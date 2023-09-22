using TImeSheetsSample.Models;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Data_Layer.Interfaces;

public interface IUserRepo 
{
    Task<User> GetByLoginAndPasswordHash(string login, byte[] passwordHash);
    Task CreateUser(User user);
}