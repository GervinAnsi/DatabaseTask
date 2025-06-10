using System;
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


    }
}