using Microsoft.EntityFrameworkCore;
using TImeSheetsSample.Data_Layer.Ef;
using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Data_Layer.Implementation
{
    public class UserRepo: IUserRepo
    {
        private readonly TimesheetDbContext _context;

        public UserRepo(TimesheetDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByLoginAndPasswordHash(string login, byte[] passwordHash)
        {
            return 
                await _context.Users
                    .Where(x=> x.Username == login && x.PasswordHash == passwordHash)
                    .FirstOrDefaultAsync();
        }

        public async Task CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}