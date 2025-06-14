﻿using System;
using DatabaseTask.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext()
        {
        }

        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
                : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<AnonymousFeedback> AnonymousFeedbacks { get; set; }

        public DbSet<Child> Children { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<EmployeeAccess> EmployeeAccess { get; set; }

        public DbSet<Equipment> Equipment { get; set; }

        public DbSet<HealthCheck> HealthChecks { get; set; }

        public DbSet<JobTitle> JobTitles { get; set; }

        public DbSet<Loan> Loans { get; set; }

        public DbSet<SickLeave> SickLeaves { get; set; }

        public DbSet<Vacation> Vacations { get; set; }




    }
}