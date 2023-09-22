using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Domain.Services.Interfaces;

namespace TImeSheetsSample.Domain.Services.Implementation;

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