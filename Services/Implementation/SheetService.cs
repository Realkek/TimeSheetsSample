using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Models;
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

    public void Create(Sheet sheet)
    {
        _sheetRepo.Add(sheet);
    }
}