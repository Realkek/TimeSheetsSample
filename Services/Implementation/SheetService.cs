using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;
using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Services.Interfaces;

namespace TImeSheetsSample.Services.Implementation;

public class SheetService : ISheetService
{
    private readonly ISheetRepo _sheetRepo;

    public SheetService(ISheetRepo sheetRepo)
    {
        _sheetRepo = sheetRepo;
    }

    public Sheet GetItem(Guid id)
    {
       return _sheetRepo.GetItem(id);
    }
    
    public Guid Create(SheetCreateRequest sheetRequest)
    {
        var sheet = new Sheet()
        {
            Id = Guid.NewGuid(),
            Amount = sheetRequest.Amount,
            ContractId = sheetRequest.ContractId,
            Date = sheetRequest.Date,
            EmployeeId = sheetRequest.EmployeeId,
            ServiceId = sheetRequest.ServiceId
            
        };
        _sheetRepo.Add(sheet);
        return sheet.Id;
    }
}