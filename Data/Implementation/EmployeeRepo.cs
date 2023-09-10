using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data.Implementation;

public class EmployeeRepo : IEmployeeRepo
{
    public Employee GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetItems()
    {
        throw new NotImplementedException();
    }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}