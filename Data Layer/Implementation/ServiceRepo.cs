using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Models;
using TImeSheetsSample.Models.Entities;

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

    public Task Update(Service item)
    {
        throw new NotImplementedException();
    }
}