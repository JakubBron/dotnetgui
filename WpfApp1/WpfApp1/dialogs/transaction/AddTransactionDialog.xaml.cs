using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.enums;
using WpfApp1.viewmodels;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddTransactionDialog : Window
    {
        //public AddTransactionDialog_ViewModel ViewModel => (AddTransactionDialog_ViewModel)DataContext;

        public AddTransactionDialog(AddTransactionDialog_ViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            var vm = (AddTransactionDialog_ViewModel)DataContext;       // binds to ViewModel
            OperationResults result = vm.ProcessReceivedData();                                   // data passed to ViewModel via WPF binding
            if (result == OperationResults.SUCCESS)
            {
                DialogResult = true;
            }
        }
    }
}
