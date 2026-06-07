using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.models;


namespace WpfApp1.repository
{
    public class TransactionRepository: ITransactionRepository
    {
        private ObservableCollection<Transaction> _transactions = [];
        public TransactionRepository()
        {
            _transactions = new ObservableCollection<Transaction>();
        }

        public void SaveTransaction(Transaction t)
        {
            _transactions.Add(t);
        }

        public void DeleteTransaction(Transaction t)
        {
            _transactions.Remove(t);
        }
        public ObservableCollection<Transaction> GetAllTransactions()    
        {
            return _transactions;
        }   
    }
}
