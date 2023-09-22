using Microsoft.AspNetCore.Mvc;
using TImeSheetsSample.Domain.Services.Interfaces;
using TImeSheetsSample.Models.DataTransferObjects;

namespace TImeSheetsSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoicesController: ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IContractService _contractService;
        
        public InvoicesController(IInvoiceService invoiceService, IContractService contractService)
        {
            _invoiceService = invoiceService;
            _contractService = contractService;
        }
        
        /// <summary> Создает клиентский счет </summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] InvoiceRequest invoiceRequest)
        {
            var isAllowedToCreate = await _contractService.CheckContractIsActive(invoiceRequest.ContractId);

            if (isAllowedToCreate !=null && !(bool)isAllowedToCreate)
            {
                return BadRequest($"Contract {invoiceRequest.ContractId} is not active or not found.");
            }
            
            var id = await _invoiceService.Create(invoiceRequest);
            return Ok(id);
        }
    }
}