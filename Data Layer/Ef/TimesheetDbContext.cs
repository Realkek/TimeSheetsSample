using Microsoft.EntityFrameworkCore;
using TImeSheetsSample.Data_Layer.Ef.Configurations;
using TImeSheetsSample.Domain.ValueObjects;
using TImeSheetsSample.Models.Entities;

namespace TImeSheetsSample.Data_Layer.Ef
{
    public class TimesheetDbContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Sheet> Sheets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public TimesheetDbContext(DbContextOptions<TimesheetDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new SheetConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Entity<Invoice>()
                .OwnsOne(i => i.Sum)
                .Property(m => m.Amount)
                .HasColumnName("SumAmount");
        }
    }
}