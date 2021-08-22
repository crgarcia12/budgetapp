using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public enum PaymentMethods
    {
        Visa,
        Amex,
        Cash,
        Twint,
        Revolut,
        Other
    }

    public class Expense
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Description { get; set; }
        public string Shop { get; set; }
        public bool Shared { get; set; }
        public bool Home { get; set; }
        public double Amount { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
    }
}
