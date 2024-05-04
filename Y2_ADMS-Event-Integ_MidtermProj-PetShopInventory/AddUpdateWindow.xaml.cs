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

            switch (tableName)
            {
                case "Pets":
                    Pets();
                    break;
                case "Products":
                    Products(); 
                    break;
                case "MedSum":
                    Medical_Summary(); 
                    break;
                case "Employees":
                    Employees();
                    break;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DisableAUWInterface();
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TableDecider()
        {

        }

        private void Pets()
        {
            PetsTable.Visibility = Visibility.Visible;

            cbPetsPetType.Items.Add("Dog");
            cbPetsPetType.Items.Add("Cat");

            cbPetsPetSex.Items.Add("Male");
            cbPetsPetSex.Items.Add("Female");

            cbPetsPetStatus.Items.Add("Available");
            cbPetsPetStatus.Items.Add("Reserved");
            cbPetsPetStatus.Items.Add("Sold");
        }

        private void Products()
        {
            ProductsTable.Visibility = Visibility.Visible;

            cbProductsPetType.Items.Add("Dog");
            cbProductsPetType.Items.Add("Cat");

            cbProductsProductType.Items.Add("Food");
            cbProductsProductType.Items.Add("Toys");
            cbProductsProductType.Items.Add("Grooming");
            cbProductsProductType.Items.Add("Accessories");
        }

        private void Medical_Summary()
        {
            MedSumTable.Visibility = Visibility.Visible;

            cbMedSumPhysical.Items.Add("Positive");
            cbMedSumPhysical.Items.Add("Negative");
            
            cbMedSumFecal.Items.Add("Positive");
            cbMedSumFecal.Items.Add("Negative");

            cbMedSumBlood.Items.Add("Positive");
            cbMedSumBlood.Items.Add("Negative");

            cbMedSumParasite.Items.Add("Positive");
            cbMedSumParasite.Items.Add("Negative");

        }

        private void btnMedSumDate_Click(object sender, RoutedEventArgs e)
        {
            if (clndrDate.Visibility == Visibility.Collapsed)
                clndrDate.Visibility = Visibility.Visible;
            else
                clndrDate.Visibility = Visibility.Collapsed;
        }

        private void clndrDate_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = clndrDate.SelectedDate.GetValueOrDefault();

            btnMedSumDate.Content = selectedDate.ToShortDateString();

            clndrDate.Visibility = Visibility.Collapsed;
        }

        private void Employees()
        {
            EmployeesTable.Visibility = Visibility.Visible;

            cbEmployeesEmployeeRole.Items.Add("Manager");
            cbEmployeesEmployeeRole.Items.Add("Staff");

            cbEmployeesEmployeeStatus.Items.Add("Active");
            cbEmployeesEmployeeStatus.Items.Add("On Leave");
            cbEmployeesEmployeeStatus.Items.Add("Terminated");
        }

        private void DisableAUWInterface()
        {
            PetsTable.Visibility = Visibility.Collapsed;
            ProductsTable.Visibility = Visibility.Collapsed;
            MedSumTable.Visibility = Visibility.Collapsed;
            EmployeesTable.Visibility = Visibility.Collapsed;
        }
    }
}
