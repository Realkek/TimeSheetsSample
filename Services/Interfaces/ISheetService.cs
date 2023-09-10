using TImeSheetsSample.Models;

namespace TImeSheetsSample.Services.Interfaces;

public interface ISheetService
{
    Sheet GetItem(Guid id);
    void Create(Sheet sheet);
}