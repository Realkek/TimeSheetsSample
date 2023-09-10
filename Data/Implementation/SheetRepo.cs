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
        /*new Sheet
        {
            Id = Guid.Parse("25ff282a-528a-8653-de71-33e1cc641e89"),
            EmployeeId = Guid.Parse("BD280568-E8B9-402E-19C1-7A2F86CB0CBE"),
            ContractId = Guid.Parse("94C3E4-87DD-4D3E-3846-AA7E14381324"),
            ServiceId = Guid.Parse("D2D84C4-E212-8019-578B-2F39884C695B"),
            Amount = 2
        },
        new Sheet
        {
            Id = Guid.Parse("bd280568-e8b9-402e-19c1-7a2f86cb0cbe"),
            EmployeeId = Guid.Parse("BD280568-E8B9-402E-19C1-7A2F86CB0CBE"),
            ContractId = Guid.Parse("94C021E4-87DD-4D3E-3846-AA7E14381324"),
            ServiceId = Guid.Parse("bd280568-e8b9-402e-19c1-7a2f86cb0cbe"),
            Amount = 15
        },*/
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
        throw new NotImplementedException();
    }
    

    public void Update()
    {
        throw new NotImplementedException();
    }
}