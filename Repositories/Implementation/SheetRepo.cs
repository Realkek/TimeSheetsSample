using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data.Implementation;

public class SheetRepo : ISheetRepo
{
    private static List<Sheet> _sheets { get; set; } = new List<Sheet>()
    {
        new Sheet
        {
            Id = Guid.Parse("23111234-2223-4321-1234-892345721901"),
            EmployeeId = Guid.Parse("bd280568e8b9402e19c17a2f86cb0cbe"),
            ContractId = Guid.Parse("94c021e487dd4d3e3846aa7e14381324"),
            ServiceId = Guid.Parse("d2d83dc4e2128019568b2f39884c695b"),
            Amount = 25
        },
    };

    public Sheet GetItem(Guid id)
    {
        return _sheets.FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<Sheet> GetItems()
    {
        throw new NotImplementedException();
    }

    public void Add(Sheet item)
    {
        _sheets.Add(item);
    }
    
    public void Update()
    {
        throw new NotImplementedException();
    }
}