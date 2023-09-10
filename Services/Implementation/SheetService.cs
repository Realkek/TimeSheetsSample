using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;
using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Services.Interfaces;

namespace TImeSheetsSample.Services.Implementation;
/// <summary>
/// Сервис оперирования рабочими табелями
/// </summary>
public class SheetService : ISheetService
{
    private readonly ISheetRepo _sheetRepo;

    public SheetService(ISheetRepo sheetRepo)
    {
        _sheetRepo = sheetRepo;
    }

    public async Task<Sheet> GetItem(Guid id)
    {
       return await _sheetRepo.GetItem(id);
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