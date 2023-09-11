namespace TImeSheetsSample.Services.Interfaces;

public interface IContractService
{
    Task<bool?> CheckContractIsActive(Guid id);
}