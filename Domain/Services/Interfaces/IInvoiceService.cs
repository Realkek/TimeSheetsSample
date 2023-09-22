using TImeSheetsSample.Models.DataTransferObjects;

namespace TImeSheetsSample.Domain.Services.Interfaces
{
    public interface IInvoiceService
    {
        Task<Guid> Create(InvoiceRequest request);
    }
}