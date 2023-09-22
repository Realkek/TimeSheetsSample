using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Domain.Services.Interfaces;

public interface ISheetService
{
    Task<Sheet> GetItem(Guid id);
    Task<IEnumerable<Sheet>> GetItems();
    Task<Guid> Create(SheetRequest sheet);
    Task Update(Guid id, SheetRequest sheetRequest);
}