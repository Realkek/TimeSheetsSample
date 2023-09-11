using TImeSheetsSample.Data;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data_Layer.Interfaces;

public interface IContractRepo : IRepoBase<Contract>
{
    Task<bool> CheckContractIsActive(Guid id);
}