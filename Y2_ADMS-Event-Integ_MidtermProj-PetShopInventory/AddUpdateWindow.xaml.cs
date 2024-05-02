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
    /// Interaction logic for AddUpdateWindow.xaml
    /// </summary>
    public partial class AddUpdateWindow : Window
    {
        public AddUpdateWindow()
        {
            InitializeComponent();
        }

        public AddUpdateWindow(string tableName)
        {
            InitializeComponent();

            lbWindowTitle.Content = "Adding a New Entry to the " + tableName + " table...";
        }
    }
}
