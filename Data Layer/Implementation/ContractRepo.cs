using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data_Layer.Implementation;

public class ContractRepo : IContractRepo
{
    private readonly TimeSheetDbContext _timeSheetDbContext;

    public ContractRepo(TimeSheetDbContext timeSheetDbContext)
    {
        _timeSheetDbContext = timeSheetDbContext;
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
         _timeSheetDbContext.Contracts.Update(item);
         await _timeSheetDbContext.SaveChangesAsync();
    }
    
    public async Task<bool> CheckContractIsActive(Guid id)
    {
        var contract = await _timeSheetDbContext.Contracts.FindAsync(id);
        var now = DateTime.Now;
        var isActive = now <= contract?.DateEnd && now >= contract?.DateStart;
        return isActive;
    }
}