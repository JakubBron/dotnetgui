using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.models;

namespace WpfApp1.repository
{
    public interface ITransactionRepository
    {
        void SaveTransaction(Transaction t);
        void DeleteTransaction(Transaction t);

        ObservableCollection<Transaction> GetAllTransactions();
    }
}
