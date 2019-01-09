using System;

namespace TaxCalculatorApp.API.Models
{
    public class TaxCalculation
    {
        public int Id { get; set; } 
        public double AnnualIncome { get; set; }
        public string PostalCode { get; set; }
        public double TaxCalculated { get; set; }
        public DateTime DateCalculated { get; set; }
    }
}