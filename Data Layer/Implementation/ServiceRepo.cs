using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data_Layer.Implementation;

public class ServiceRepo : IServiceRepo
{
    public async Task<Service> GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Service>> GetItems()
    {
        throw new NotImplementedException();
    }

    public async Task Add(Service item)
    {
        throw new NotImplementedException();
    }
    

    public async Task Update()
    {
        throw new NotImplementedException();
    }
}