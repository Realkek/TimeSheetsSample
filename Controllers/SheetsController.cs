using Microsoft.AspNetCore.Mvc;
using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Services.Interfaces;

namespace TImeSheetsSample.Controllers;

[ApiController]
[Route("[controller]")]
public class SheetsController : ControllerBase
{
    private readonly ISheetService _sheetService;
    private readonly IContractService _contractService;

    public SheetsController(ISheetService sheetService, IContractService contractService)
    {
        _sheetService = sheetService;
        _contractService = contractService;
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetItem([FromQuery] Guid id)
    {
        var result = _sheetService.GetItem(id);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetItems()
    {
        var result = await _sheetService.GetItems();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SheetCreateRequest sheetCreateRequest)
    {
        var isAllowedToCreate = await _contractService.CheckContractIsActive(sheetCreateRequest.ContractId);
        if (isAllowedToCreate is false)
        {
            return BadRequest($"Contract {sheetCreateRequest.ContractId} is not active");
        }

        var createdTaskGuid = await _sheetService.Create(sheetCreateRequest);
        return Ok(createdTaskGuid);
    }
}