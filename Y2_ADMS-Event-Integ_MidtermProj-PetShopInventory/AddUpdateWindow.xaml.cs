using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        PetChestConnDataContext _dbConn = null;
        public int _uspNum = 0;
        public string _calendarDate = "";
        public int _rowID = 0;
        private List<string> _rowDetails = new List<string>();

        SoundSystem sound = new SoundSystem();

        public string StatusMessagePasser { get; set; }

        public AddUpdateWindow(object selectedItem, string tableName, PetChestConnDataContext connection)
        {
            InitializeComponent();

            btnConfirm.Content = "Update";

            if (selectedItem != null)
            {
                PropertyInfo[] properties = selectedItem.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    _rowDetails.Add(property.GetValue(selectedItem)?.ToString());
                }
            }

            _dbConn = connection;

            lbWindowTitle.Content = "Updating an Entry in the " + tableName + " table...";

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

        public AddUpdateWindow(string tableName, PetChestConnDataContext connection)
        {
            InitializeComponent();

            btnConfirm.Content = "Add";

            _dbConn = connection;

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
            sound.Initialize("Terraria-UI-Sound.mp3", 5);

            DisableAUWInterface();
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            sound.Initialize("Terraria-UI-Sound.mp3", 5);

            if (btnConfirm.Content.ToString() == "Add")
            {
                switch (_uspNum)
                {
                    case 1:
                        string selectedPetType1 = cbPetsPetType.SelectedItem.ToString();
                        string selectedPetStatus = cbPetsPetStatus.SelectedItem.ToString();
                        _dbConn.addPet(tbPetsPetName.Text, dataToKey(selectedPetType1), tbPetsPetBreed.Text, int.Parse(tbPetsPetAge.Text),
                            cbPetsPetSex.SelectedItem.ToString(), int.Parse(tbPetsPetPrice.Text), dataToKey(selectedPetStatus));
                        break;
                    case 2:
                        string selectedPetType2 = cbProductsPetType.SelectedItem.ToString();
                        string selectedProductType = cbProductsProductType.SelectedItem.ToString();
                        _dbConn.addProduct(tbProductsProductName.Text, dataToKey(selectedPetType2), dataToKey(selectedProductType), 
                            int.Parse(tbProductsStock.Text), int.Parse(tbProductsPrice.Text));
                        break;
                    case 3:
                        _dbConn.addMedSum(int.Parse(tbMedSumPetID.Text), cbMedSumPhysical.SelectedItem.ToString(), cbMedSumFecal.SelectedItem.ToString(),
                            cbMedSumBlood.SelectedItem.ToString(), cbMedSumParasite.SelectedItem.ToString(), _calendarDate);
                        break;
                }
                StatusMessagePasser = "Sucessfully added an entry in the ";
            }
            else
            {
                switch (_uspNum)
                {
                    case 1:
                        string selectedPetType1 = cbPetsPetType.SelectedItem.ToString();
                        string selectedPetStatus = cbPetsPetStatus.SelectedItem.ToString();
                        _dbConn.updatePets(_rowID, tbPetsPetName.Text, dataToKey(selectedPetType1), tbPetsPetBreed.Text, int.Parse(tbPetsPetAge.Text),
                            cbPetsPetSex.SelectedItem.ToString(), int.Parse(tbPetsPetPrice.Text), dataToKey(selectedPetStatus));
                        break;
                    case 2:
                        string selectedPetType2 = cbProductsPetType.SelectedItem.ToString();
                        string selectedProductType = cbProductsProductType.SelectedItem.ToString();
                        _dbConn.updateProducts(_rowID, tbProductsProductName.Text, dataToKey(selectedPetType2), dataToKey(selectedProductType),
                            int.Parse(tbProductsStock.Text), int.Parse(tbProductsPrice.Text));
                        break;
                    case 3:
                        _dbConn.updateMedSum(_rowID, cbMedSumPhysical.SelectedItem.ToString(), cbMedSumFecal.SelectedItem.ToString(),
                            cbMedSumBlood.SelectedItem.ToString(), cbMedSumParasite.SelectedItem.ToString(), _calendarDate);
                        break;
                }
                StatusMessagePasser = "Sucessfully updated an entry in the ";
            }
            DisableAUWInterface();
            this.Close();
        }

        private void TableDecider()
        {

        }

        private void Pets()
        {
            _uspNum = 1;
            PetsTable.Visibility = Visibility.Visible;

            cbPetsPetType.Items.Add("Dog");
            cbPetsPetType.Items.Add("Cat");

            cbPetsPetSex.Items.Add("Male");
            cbPetsPetSex.Items.Add("Female");

            cbPetsPetStatus.Items.Add("Available");
            cbPetsPetStatus.Items.Add("Reserved");
            cbPetsPetStatus.Items.Add("Sold");

            if (btnConfirm.Content.ToString() == "Update")
            {
                _rowID = int.Parse(_rowDetails[0]);
                tbPetsPetName.Text = _rowDetails[1];
                cbPetsPetType.SelectedItem = _rowDetails[2];
                tbPetsPetBreed.Text = _rowDetails[3];
                tbPetsPetAge.Text = _rowDetails[4];
                cbPetsPetSex.SelectedItem = _rowDetails[5];
                tbPetsPetPrice.Text = _rowDetails[6];
                cbPetsPetStatus.SelectedItem = _rowDetails[7];
            }
        }

        private void Products()
        {
            _uspNum = 2;
            ProductsTable.Visibility = Visibility.Visible;

            cbProductsPetType.Items.Add("Dog");
            cbProductsPetType.Items.Add("Cat");

            cbProductsProductType.Items.Add("Food");
            cbProductsProductType.Items.Add("Toys");
            cbProductsProductType.Items.Add("Grooming");
            cbProductsProductType.Items.Add("Accessories");

            if (btnConfirm.Content.ToString() == "Update")
            {
                _rowID = int.Parse(_rowDetails[0]);
                tbProductsProductName.Text = _rowDetails[1];
                cbProductsPetType.SelectedItem = _rowDetails[2];
                cbProductsProductType.SelectedItem = _rowDetails[3];
                tbProductsStock.Text = _rowDetails[4];
                tbProductsPrice.Text = _rowDetails[5];
            }
        }

        private void Medical_Summary()
        {
            //equate petID to pet name :>
            _uspNum = 3;
            MedSumTable.Visibility = Visibility.Visible;

            cbMedSumPhysical.Items.Add("Positive");
            cbMedSumPhysical.Items.Add("Negative");
            
            cbMedSumFecal.Items.Add("Positive");
            cbMedSumFecal.Items.Add("Negative");

            cbMedSumBlood.Items.Add("Positive");
            cbMedSumBlood.Items.Add("Negative");

            cbMedSumParasite.Items.Add("Positive");
            cbMedSumParasite.Items.Add("Negative");

            if (btnConfirm.Content.ToString() == "Update")
            {
                _rowID = int.Parse(_rowDetails[0]);
                tbMedSumPetID.Text = _rowDetails[1];
                cbMedSumPhysical.SelectedItem = _rowDetails[2];
                cbMedSumFecal.SelectedItem = _rowDetails[3];
                cbMedSumBlood.SelectedItem = _rowDetails[4];
                cbMedSumParasite.SelectedItem = _rowDetails[5];
                btnMedSumDate.Content = _rowDetails[6];
            }
        }

        private void btnMedSumDate_Click(object sender, RoutedEventArgs e)
        {
            sound.Initialize("Terraria-UI-Sound.mp3", 5);

            if (clndrDate.Visibility == Visibility.Collapsed)
                clndrDate.Visibility = Visibility.Visible;
            else
                clndrDate.Visibility = Visibility.Collapsed;
        }

        private void clndrDate_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            sound.Initialize("Terraria-UI-Sound.mp3", 5);

            DateTime selectedDate = clndrDate.SelectedDate.GetValueOrDefault();

            _calendarDate = selectedDate.ToShortDateString();
            btnMedSumDate.Content = _calendarDate;

            clndrDate.Visibility = Visibility.Collapsed;
        }

        private void Employees()
        {
            _uspNum = 4;
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

        private string dataToKey(string dataValue)
        {
            Dictionary<string, string> dataToKeyMap = new Dictionary<string, string>
            {
                { "Dog", "PT1" },
                { "Cat", "PT2" },
                { "Available", "PS1" },
                { "Reserved", "PS2" },
                { "Sold", "PS3" },
                { "Food", "T1" },
                { "Toys", "T2" },
                { "Grooming", "T3" },
                { "Accessories", "T4" },
                { "Manager", "R1" },
                { "Staff", "R2" }
            };
            dataToKeyMap.TryGetValue(dataValue, out string databaseKey);
            return databaseKey;
        }
    }
}
