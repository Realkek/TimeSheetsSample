using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Domain.Aggregates.InvoiceAggregate;
using TImeSheetsSample.Domain.Services.Interfaces;
using TImeSheetsSample.Models.DataTransferObjects;

namespace TImeSheetsSample.Domain.Services.Implementation
{
    public class InvoiceService: IInvoiceService
    {
        private readonly IInvoiceRepo _invoiceRepo;
        //private readonly ISheetRepo _sheetRepo;
        private readonly IInvoiceAggregateRepo _invoiceAggregateRepo;

        public InvoiceService(IInvoiceRepo invoiceRepo, ISheetRepo sheetRepo)
        {
            _invoiceRepo = invoiceRepo;
            //_sheetRepo = sheetRepo;
        }

        public async Task<Guid> Create(InvoiceRequest request)
        {
            var invoice = InvoiceAggregate.Create(request.ContractId, request.DateEnd, request.DateStart);

            var sheetsToInclude = await _invoiceAggregateRepo
                .GetSheets(request.ContractId, request.DateStart, request.DateEnd);
            
            invoice.IncludeSheets(sheetsToInclude);
            await _invoiceRepo.Add(invoice);

            return invoice.Id;
        }
        
    }
}