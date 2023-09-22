using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Domain.Aggregates.SheetAggregate;
using TImeSheetsSample.Domain.Services.Interfaces;
using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Domain.Services.Implementation;

/// <summary>
/// Сервис оперирования рабочими табелями
/// </summary>
public class SheetService : ISheetService
{
    private readonly ISheetRepo _sheetRepo;
    private readonly ISheetAggregateRepo _sheetAggregateRepo;

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
        var sheet = SheetAggregate.CreateFromSheetRequest(sheetRequest);

        await _sheetRepo.Add(sheet);
        return sheet.Id;
    }

    public async Task Approve(Guid sheetId)
    {
        var sheet = await _sheetAggregateRepo.GetItem(sheetId);
        sheet.ApproveSheet();
        await _sheetAggregateRepo.Update(sheet);
    }

    public async Task Update(Guid id, SheetRequest sheetRequest)
    {
        var sheet = SheetAggregate.CreateFromSheetRequest(sheetRequest);
        await _sheetRepo.Update(sheet);
    }
}