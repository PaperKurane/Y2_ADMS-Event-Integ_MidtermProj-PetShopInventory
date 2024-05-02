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

namespace Y2_ADMS_Event_Integ_MidtermProj_PetShopInventory
{
    /// <summary>
    /// Interaction logic for PetChestMainMenu.xaml
    /// </summary>
    public partial class PetChestMainMenu : Window
    {
        PetChestConnDataContext _dbConn = null;
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
        }

        private void sdbr_btn_click(object sender, RoutedEventArgs e)
        {
            string button = ((Button)sender).Name.ToString();
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

            dgMainTable.ItemsSource = table.ToList();
        }

        private void LoadTable(string tableName)
        {
            try
            {
                var table = from employee in _dbConn.Employees
                                select employee;

                dgMainTable.ItemsSource = table.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
