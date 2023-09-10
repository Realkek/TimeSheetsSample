using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data.Implementation;

public class ContractRepo : IContractRepo
{
    public async Task<Contract> GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Contract>> GetItems()
    {
        throw new NotImplementedException();
    }

    public async Task Add(Contract item)
    {
        throw new NotImplementedException();
    }
    

    public async Task Update()
    {
        throw new NotImplementedException();
    }
}