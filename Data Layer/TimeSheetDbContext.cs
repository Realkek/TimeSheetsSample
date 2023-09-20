﻿using Microsoft.EntityFrameworkCore;
using TImeSheetsSample.Models;

namespace TImeSheetsSample.Data_Layer;

public class TimeSheetDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Sheet> Sheets { get; set; }
    public DbSet<User> Users { get; set; } 

    public TimeSheetDbContext(DbContextOptions<TimeSheetDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>().ToTable("Client");
        modelBuilder.Entity<Contract>().ToTable("Contract");
        modelBuilder.Entity<Employee>().ToTable("Employee");
        modelBuilder.Entity<Service>().ToTable("Service");
        modelBuilder.Entity<Sheet>().ToTable("Sheet");
        modelBuilder.Entity<User>().ToTable("User");

        modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Contract).WithMany(contract => contract.Sheets)
            .HasForeignKey("ContractId");

        modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Service).WithMany(service => service.Sheets)
            .HasForeignKey("ServiceId");

        modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Employee).WithMany(employee => employee.Sheets)
            .HasForeignKey("EmployeeId");
    }
}