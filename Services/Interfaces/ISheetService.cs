﻿using TImeSheetsSample.Models;
using TImeSheetsSample.Models.DataTransferObjects;

namespace TImeSheetsSample.Services.Interfaces;

public interface ISheetService
{
    Task<Sheet> GetItem(Guid id);
    Task<IEnumerable<Sheet>> GetItems();
    Task<Guid> Create(SheetRequest sheet);
    void  Update(Guid id, SheetRequest sheetRequest);
}