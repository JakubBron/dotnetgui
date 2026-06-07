using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.enums;
using WpfApp1.models;
using WpfApp1.repository;

namespace WpfApp1.viewmodels
{
    public partial class MainWindow_ViewModel: ObservableObject
    {
        private readonly ITransactionRepository _repository;
        public ObservableCollection<Transaction> Transactions { get; }

        public MainWindow_ViewModel(ITransactionRepository repository)
        {
            _repository = repository; 
            Transactions = _repository.GetAllTransactions();
    }
    }
}
