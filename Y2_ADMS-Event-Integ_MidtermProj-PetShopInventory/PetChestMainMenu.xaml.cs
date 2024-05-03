using System;
using System.Collections.Generic;
using System.Data.Linq;
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

namespace Y2_ADMS_Event_Integ_MidtermProj_PetShopInventory
{
    /// <summary>
    /// Interaction logic for PetChestMainMenu.xaml
    /// </summary>
    public partial class PetChestMainMenu : Window
    {
        PetChestConnDataContext _dbConn = null;
        string _defaultTable = "btnPets";
        string _currentTable = "";

        string _currentUser = "";

        public PetChestMainMenu()
        {
            InitializeComponent();
        }

        public PetChestMainMenu(string userName, PetChestConnDataContext connection)
        {
            InitializeComponent();

            _currentUser = userName;
            _dbConn = connection;

            lbStatusMessage.Content = "Welcome to the system " + userName + "!";
            RetrieveDefaultTable();
        }

        private void RetrieveTable(string button)
        {
            IQueryable<object> table = null;

            switch (button)
            {
                case "btnPets":
                    table = from tb in _dbConn.Pets
                            select (object)tb;
                    break;
                case "btnProducts":
                    table = from tb in _dbConn.Products
                            select tb;
                    break;
                case "btnMedSum":
                    table = from tb in _dbConn.Medical_Summaries
                            select tb;
                    break;
                case "btnEmployees":
                    table = from tb in _dbConn.Employees
                            select (object)tb;
                    break;
                case "btnLogs":
                    table = from tb in _dbConn.Logs
                            select tb;
                    break;
            }

            string[] tableName = button.Split(new string[] { "btn" }, StringSplitOptions.None);
            _currentTable = tableName[1];
            dgMainTable.ItemsSource = table.ToList();
        }

        private void RetrieveDefaultTable()
        {
            RetrieveTable(_defaultTable);
        }

        private void sdbr_btn_click(object sender, RoutedEventArgs e)
        {
            string button = ((Button)sender).Name.ToString();
            RetrieveTable(button);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if(mbr == MessageBoxResult.Yes)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddUpdateWindow auw = new AddUpdateWindow(_currentTable);
            auw.Owner = this;
            auw.ShowDialog();
        }
    }
}
