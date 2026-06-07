using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.models;
using WpfApp1.repository;
using WpfApp1.viewmodels;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ITransactionRepository _repo;
        
        public MainWindow(MainWindow_ViewModel vm, ITransactionRepository repo)
        {
            InitializeComponent();
            DataContext = vm;
            _repo = repo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = new AddTransactionDialog_ViewModel(_repo);
            AddTransactionDialog dialog = new AddTransactionDialog(vm);

            dialog.ShowDialog();
        }
    }
}