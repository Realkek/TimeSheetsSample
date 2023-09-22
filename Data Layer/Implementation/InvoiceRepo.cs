﻿using TImeSheetsSample.Data_Layer.Ef;
using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Data_Layer.Implementation
{
    public class InvoiceRepo: IInvoiceRepo
    {
        private readonly TimesheetDbContext _context;

        public InvoiceRepo(TimesheetDbContext context)
        {
            _context = context;
        }
        
        public Task<Invoice> GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Invoice>> GetItems()
        {
            throw new NotImplementedException();
        }

        public async Task Add(Invoice item)
        {
            

            await _context.Invoices.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public Task Update(Invoice item)
        {
            throw new NotImplementedException();
        }
    }
}