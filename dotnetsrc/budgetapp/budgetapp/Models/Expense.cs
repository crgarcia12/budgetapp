using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class Expense
    {
        public string User { get; set; }
        public string Description { get; set; }
        public string Shop { get; set; }
        public bool Shared { get; set; }
        public bool Home { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}
