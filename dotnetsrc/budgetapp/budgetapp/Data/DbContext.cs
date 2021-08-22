using System;
using System.Collections.Generic;
using budgetapp.Models;
using Microsoft.EntityFrameworkCore;

namespace budgetapp.Data
{
    public class DbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public DbContext()
        {
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
