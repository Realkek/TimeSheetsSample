using TImeSheetsSample.Models;
using TImeSheetsSample.Models.DataTransferObjects;

namespace TImeSheetsSample.Services.Interfaces;

public interface ISheetService
{
    Task<Sheet> GetItem(Guid id);
    Task<Guid> Create(SheetCreateRequest sheet);
}