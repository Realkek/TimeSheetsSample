using TImeSheetsSample.Data_Layer.Interfaces;
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

    public async Task<IEnumerable<Sheet>> GetItems()
    {
        return await _sheetRepo.GetItems();
    }

    public async Task<Guid> Create(SheetRequest sheetRequest)
    {
        var sheet = new Sheet()
        {
            Id = Guid.NewGuid(),
            Date = sheetRequest.Date,
            UserId = sheetRequest.UserId,
            EmployeeId = sheetRequest.EmployeeId,
            ContractId = sheetRequest.ContractId,
            ServiceId = sheetRequest.ServiceId,
            Amount = sheetRequest.Amount,
        };
        await _sheetRepo.Add(sheet);
        return sheet.Id;
    }

    public  void Update(Guid id, SheetRequest sheetRequest)
    {
        var sheet = new Sheet()
        {
            Id = id,
            Date = sheetRequest.Date,
            UserId = sheetRequest.UserId,
            EmployeeId = sheetRequest.EmployeeId,
            ContractId = sheetRequest.ContractId,
            ServiceId = sheetRequest.ServiceId,
            Amount = sheetRequest.Amount,
        };
         _sheetRepo.Update(sheet);
    }
}