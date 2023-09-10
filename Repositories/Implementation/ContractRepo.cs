using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data.Implementation;

public class ContractRepo : IContractRepo
{
    public Contract GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Contract> GetItems()
    {
        throw new NotImplementedException();
    }

    public void Add(Contract item)
    {
        throw new NotImplementedException();
    }
    

    public void Update()
    {
        throw new NotImplementedException();
    }
}