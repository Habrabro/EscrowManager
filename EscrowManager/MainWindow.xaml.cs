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

            Bank bank = new Bank("Sberbank", 0);
            ApartmentBuyer buyer = new ApartmentBuyer("Sergey", 3000000);
            buyer.account.Added += showMessage;
            buyer.account.Withdrawn += showMessage;
            buyer.account.Put(200000, Currencies.rub, Currencies.dol);
        }

        void showMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
