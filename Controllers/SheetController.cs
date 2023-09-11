using Microsoft.AspNetCore.Mvc;
using TImeSheetsSample.Models;
using TImeSheetsSample.Models.DataTransferObjects;
using TImeSheetsSample.Services.Interfaces;

namespace TImeSheetsSample.Controllers;

[ApiController]
[Route("[controller]")]
public class SheetController : ControllerBase
{
    private readonly ISheetService _sheetService;

    public SheetController(ISheetService sheetService)
    {
        _sheetService = sheetService;
    }

    [HttpGet]
    public IActionResult Get(Guid id)
    {
        var result = _sheetService.GetItem(id);
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create([FromBody] SheetCreateRequest sheetCreateRequest)
    {
        var createdTaskGuid = _sheetService.Create(sheetCreateRequest);
        return Ok(createdTaskGuid.Id);  
    }
}