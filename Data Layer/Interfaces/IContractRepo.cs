using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Data_Layer.Interfaces;

public interface IContractRepo : IRepoBase<Contract>
{
    Task<bool> CheckContractIsActive(Guid id);
}