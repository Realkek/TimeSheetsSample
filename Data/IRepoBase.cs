﻿namespace TImeSheetsSample.Data;

public interface IRepoBase<T>
{
    T GetItem(Guid id);
    IEnumerable<T> GetItems();
    void Add();
    void Update();
}