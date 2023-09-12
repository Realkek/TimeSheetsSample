using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data_Layer.Implementation;

public class EmployeeRepo : IEmployeeRepo
{
    public async Task<Employee> GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Employee>> GetItems()
    {
        throw new NotImplementedException();
    }

    public async Task Add(Employee item)
    {
        throw new NotImplementedException();
    }

    public Task Update(Employee item)
    {
        throw new NotImplementedException();
    }
}