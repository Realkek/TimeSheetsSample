using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data.Implementation;

public class ClientRepo : IClientRepo
{
    public async Task<Client> GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Client>> GetItems()
    {
        throw new NotImplementedException();
    }

    public async Task Add(Client item)
    {
        throw new NotImplementedException();
    }
    

    public async Task Update()
    {
        throw new NotImplementedException();
    }
}