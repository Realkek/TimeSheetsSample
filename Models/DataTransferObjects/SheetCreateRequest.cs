﻿namespace TImeSheetsSample.Models.DataTransferObjects;

public class SheetCreateRequest
{
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public Guid EmployeeId { get; set; }
    public Guid ContractId { get; set; }
    public Guid ServiceId { get; set; }
    public int Amount { get; set; }
}