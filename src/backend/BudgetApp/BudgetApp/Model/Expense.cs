using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Model
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Shop { get; set; }
        public int Amount { get; set; }
        public string Detail { get; set; }
    }
}
