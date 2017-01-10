using BankXml.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankXml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BackgroundWorker worker = new BackgroundWorker();
        IEnumerable<IGrouping<string, IGrouping<string, ATM>>> banks;


        public MainWindow()
        {
            InitializeComponent();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.bankComboBox.ItemsSource = banks;
            this.bankComboBox.DisplayMemberPath = "Key";
            this.loadButton.IsEnabled = true;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            banks = code.Logic.GetAllAtmGroupByBankAndCity().ToList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.loadButton.IsEnabled = false;
            worker.RunWorkerAsync();
        }
    }
}
