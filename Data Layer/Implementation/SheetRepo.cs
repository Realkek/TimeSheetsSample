using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data_Layer.Implementation;

public class SheetRepo : ISheetRepo
{
    private const string SheetNotFound = "Sheet not found";
    private readonly TimeSheetDbContext _context;

    public SheetRepo(TimeSheetDbContext context)
    {
        _context = context;
    }

    public async Task<Sheet> GetItem(Guid id)
    {
        return await _context.Sheets.FindAsync(id) ?? throw new InvalidOperationException(SheetNotFound);
    }

    public async Task<IEnumerable<Sheet>> GetItems()
    {
        throw new NotImplementedException();
    }

    public async Task Add(Sheet item)
    {
        await _context.Sheets.AddAsync(item);
        await _context.SaveChangesAsync();
    }

    public async Task Update()
    {
        throw new NotImplementedException();
    }
}