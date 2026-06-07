using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.enums;

namespace WpfApp1.models
{
    public class Transaction
    {
        // important but not from business pov
        public Guid Id { get; }
        public DateTime CreationDatetime { get; }

        // important from business pov
        public decimal Amount { get; set; }
        public Currency TransactionCurrency { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Comment { get; set; }

        public Transaction(decimal amount, Currency transactionCurrency, DateTime transactionDate, string comment = "")
        {
            Id = Guid.NewGuid();    // change for more user-friendly
            CreationDatetime = DateTime.Now;
            Amount = amount;
            TransactionCurrency = transactionCurrency;
            TransactionDate = transactionDate;
            Comment = comment;
        }

        public Transaction(decimal amount, string comment) : this(amount, Currency.PLN, DateTime.UtcNow, comment) {}

        public override string ToString()
        {
            return $"Id: {Id}, CreationDatetime: {CreationDatetime.ToString()}, Amount: {Amount}, Currency: {TransactionCurrency}, TransactionDate: {TransactionDate}, Comment: {Comment}";
        }
        public ValidationResult Validate()
        {
            var result = new ValidationResult();

            if (Amount == 0)
                result.AddError("Amount must be other than zero.");

            if (TransactionDate == null)
                result.AddError("Transaction date cannot be in the future.");

            if(TransactionCurrency == null)
                result.AddError("Currency must be specified.");

            return result;
        }

    }
}
