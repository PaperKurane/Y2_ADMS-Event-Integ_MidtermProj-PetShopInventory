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
        IQueryable<Employee> selectionNow = null;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
