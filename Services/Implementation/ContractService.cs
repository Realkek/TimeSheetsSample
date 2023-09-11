using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Services.Interfaces;

namespace TImeSheetsSample.Services.Implementation;

public class ContractService : IContractService
{
    private readonly IContractRepo _contractRepo;

    public ContractService(IContractRepo contractRepo)
    {
        _contractRepo = contractRepo;
    }

    public async Task<bool?> CheckContractIsActive(Guid id)
    {
        return await _contractRepo.CheckContractIsActive(id);
    }
}