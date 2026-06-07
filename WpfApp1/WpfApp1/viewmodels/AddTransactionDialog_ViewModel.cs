using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.enums;
using CommunityToolkit.Mvvm.ComponentModel;
using WpfApp1.models;
using WpfApp1.repository;

namespace WpfApp1.viewmodels
{
    public partial class AddTransactionDialog_ViewModel: ObservableObject
    {
        // data obtained
        public Currency SelectedCurrency { get; set; } = Currency.DEFAULT;
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime SelectedDate { get; set; } = DateTime.Today;
        public TransactionPaymentMethod SelectedTransactionPaymentMethod { get; set; } = TransactionPaymentMethod.DEFAULT;

        // data to bind
        public ImmutableList<Currency> Currencies { get; } = Currency.All;
        public ImmutableList<TransactionPaymentMethod> TransactionPaymentMethods { get; } = TransactionPaymentMethod.All;

        // repository
        private readonly ITransactionRepository _repository;

        // Add constructor for Dependency Injection
        public AddTransactionDialog_ViewModel(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public OperationResults ProcessReceivedData()
        {
            Transaction transactionCandidate = new Transaction(Amount, SelectedCurrency, SelectedDate, Description, SelectedTransactionPaymentMethod);
            ValidationResult vr = transactionCandidate.Validate();
            if (vr.IsValid())
            {
                MessageBox.Show(string.Join(Environment.NewLine, vr.Errors), enums.MessageBoxTitles.VALIDATIONRESULT_TITLE);
                return OperationResults.ERROR;
            }
            _repository.SaveTransaction(transactionCandidate);
            return OperationResults.SUCCESS;
        }
    }
}
