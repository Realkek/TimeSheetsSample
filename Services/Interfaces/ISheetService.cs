using TImeSheetsSample.Models;
using TImeSheetsSample.Models.DataTransferObjects;

namespace TImeSheetsSample.Services.Interfaces;

public interface ISheetService
{
    Sheet GetItem(Guid id);
    Guid Create(SheetCreateRequest sheet);
}