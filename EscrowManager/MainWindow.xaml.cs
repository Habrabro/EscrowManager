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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EscrowManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Bank bank = new Bank("VTB", 0);
            ApartmentBuyer apartmentBuyer = new ApartmentBuyer("Karpushko Anton Aleksandrovich", 5000000);
            Developer developer = new Developer("MosGorStroy", 0);
            bank.account.Added += showMessage;
            bank.account.Withdrawn += showMessage;
            apartmentBuyer.account.Added += showMessage;
            apartmentBuyer.account.Withdrawn += showMessage;
            developer.account.Added += showMessage;
            developer.account.Withdrawn += showMessage;
            Contract contract = new Contract(bank, apartmentBuyer, developer, 3000000, Currencies.rub);
            bank.ObligationsFulfilled = true;
        }

        void showMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
