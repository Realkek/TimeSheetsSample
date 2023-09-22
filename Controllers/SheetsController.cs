using Microsoft.AspNetCore.Mvc;
using TImeSheetsSample.Domain.Services.Interfaces;
using TImeSheetsSample.Models.DataTransferObjects;

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

    /// <summary>
    /// Создаёт запись табеля
    /// </summary>
    /// <param name="sheetRequest"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SheetRequest sheetRequest)
    {
        var isAllowedToCreate = await _contractService.CheckContractIsActive(sheetRequest.ContractId);
        if (isAllowedToCreate is false)
        {
            return BadRequest($"Contract {sheetRequest.ContractId} is not active or not found");
        }

        var createdTaskGuid = await _sheetService.Create(sheetRequest);
        return Ok(createdTaskGuid);
    }
    /// <summary>
    /// Обновляет запись табеля
    /// </summary>
    /// <param name="id"></param>
    /// <param name="sheetRequest"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] SheetRequest sheetRequest)
    {
        var isAllowedToCreate = await _contractService.CheckContractIsActive(sheetRequest.ContractId);
        if (isAllowedToCreate is false)
        {
            return BadRequest($"Contract {sheetRequest.ContractId} is not active or not found");
        }

        _sheetService.Update(id, sheetRequest);
        return Ok();
    }
}