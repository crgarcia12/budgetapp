using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BudgetApp.Model;

namespace BudgetApp.Data
{
    public class BudgetAppContext : DbContext
    {
        public BudgetAppContext (DbContextOptions<BudgetAppContext> options)
            : base(options)
        {
        }

        public DbSet<BudgetApp.Model.Expense> Expense { get; set; }
    }
}
