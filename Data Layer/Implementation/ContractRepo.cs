using TImeSheetsSample.Data_Layer.Ef;
using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Models;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Data_Layer.Implementation;

public class ContractRepo : IContractRepo
{
    private readonly TimesheetDbContext _timesheetDbContext;

    public ContractRepo(TimesheetDbContext timesheetDbContext)
    {
        _timesheetDbContext = timesheetDbContext;
    }

    public Task<Contract> GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Contract>> GetItems()
    {
        throw new NotImplementedException();
    }

    public Task Add(Contract item)
    {
        throw new NotImplementedException();
    }

    public async Task Update(Contract item)
    {
         _timesheetDbContext.Contracts.Update(item);
         await _timesheetDbContext.SaveChangesAsync();
    }
    
    public async Task<bool> CheckContractIsActive(Guid id)
    {
        var contract = await _timesheetDbContext.Contracts.FindAsync(id);
        var now = DateTime.Now;
        var isActive = now <= contract?.DateEnd && now >= contract?.DateStart;
        return isActive;
    }
}