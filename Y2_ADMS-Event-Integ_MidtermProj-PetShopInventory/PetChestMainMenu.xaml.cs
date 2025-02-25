﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Net.NetworkInformation;
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

        SoundSystem sound = new SoundSystem();

        public PetChestMainMenu()
        {
            InitializeComponent();
        }

        public PetChestMainMenu(string userName, PetChestConnDataContext connection, string messageString)
        {
            InitializeComponent();

            _currentUser = userName;
            _dbConn = connection;

            EmployeePrivilegeHandler();

            //StatusMessageHandler("Welcome to the system " + userName + "!");
            //StatusMessageHandler(messageString);
            RetrieveDefaultTable();
            StatusMessageHandler(messageString);
        }

        private void EmployeePrivilegeHandler()
        {
            var selectResults = (from s in _dbConn.Employees
                                where s.Employee_ID == _currentUser
                                select s.EmployeeRole_ID).FirstOrDefault();

            if (selectResults != "R1")
            {
                btnEmployees.Visibility = Visibility.Collapsed;
                btnLogs.Visibility = Visibility.Collapsed;
            }
        }

        private void StatusMessageHandler(string message)
        {
            lbStatusMessage.Content = message;
        }

        private void RetrieveTable(string button)
        {
            sound.Initialize("Terraria-UI-Sound.mp3", 5);

            IQueryable<object> table = null;

            switch (button)
            {
                case "btnPets":
                    dgMainTable.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
                    table = from tb in _dbConn.petDisplays
                            select (object)tb;
                    StatusMessageHandler("Now viewing the Pets Table.");
                    btnAdd.IsEnabled = true;
                    break;
                case "btnProducts":
                    dgMainTable.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
                    table = from tb in _dbConn.productDisplays
                            select tb;
                    StatusMessageHandler("Now viewing the Products Table.");
                    btnAdd.IsEnabled = true;
                    break;
                case "btnMedSum":
                    dgMainTable.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
                    table = from tb in _dbConn.medicalDisplays
                            select tb;
                    StatusMessageHandler("Now viewing the Medical Summary Table.");
                    btnAdd.IsEnabled = true;
                    break;
                case "btnEmployees":
                    dgMainTable.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Auto);
                    table = from tb in _dbConn.employeeDisplays
                            select (object)tb;
                    StatusMessageHandler("Now viewing the Employees Table."); 
                    btnAdd.IsEnabled = false;
                    break;
                case "btnLogs":
                    dgMainTable.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
                    table = from tb in _dbConn.Logs
                            select tb;
                    StatusMessageHandler("Now viewing the Logs Table.");
                    btnAdd.IsEnabled = false;
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
            tbSearchBar.Text = string.Empty;
            RetrieveTable(button);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            sound.Initialize("Terraria-UI-Sound.mp3", 5);

            MessageBoxResult mbr = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if(mbr == MessageBoxResult.Yes)
            {
                btnEmployees.Visibility = Visibility.Visible;
                btnLogs.Visibility = Visibility.Visible;

                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            sound.Initialize("Terraria-UI-Sound.mp3", 5);

            AddUpdateWindow auw = new AddUpdateWindow(_currentTable, _dbConn);
            auw.Owner = this;
            auw.ShowDialog();

            string message = auw.StatusMessagePasser + _currentTable + " table.";
            StatusMessageHandler(message);
            RetrieveTable(auw.TableRefresher);
        }

        private void dgMainTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sound.Initialize("Terraria-UI-Sound.mp3", 5);

            if (dgMainTable.SelectedItem != null)
            {
                if (_currentTable == "Pets")
                {
                    petDisplay selectedPet = dgMainTable.SelectedItem as petDisplay;
                    if (selectedPet != null)
                    {
                        AddUpdateWindow auw = new AddUpdateWindow(selectedPet, _currentTable, _dbConn);
                        auw.Owner = this;
                        auw.ShowDialog();
                        string message = auw.StatusMessagePasser + "Pets Table";
                        StatusMessageHandler(message);
                        RetrieveTable(auw.TableRefresher);
                    }
                }
                else if (_currentTable == "Products")
                {
                    productDisplay selectedProduct = dgMainTable.SelectedItem as productDisplay;
                    if (selectedProduct != null)
                    {
                        AddUpdateWindow auw = new AddUpdateWindow(selectedProduct, _currentTable, _dbConn);
                        auw.Owner = this;
                        auw.ShowDialog();
                        string message = auw.StatusMessagePasser + "Products Table";
                        StatusMessageHandler(message);
                        RetrieveTable(auw.TableRefresher);
                    }
                }
                else if (_currentTable == "MedSum")
                {
                    medicalDisplay selectedMedSum = dgMainTable.SelectedItem as medicalDisplay;
                    if (selectedMedSum != null)
                    {
                        AddUpdateWindow auw = new AddUpdateWindow(selectedMedSum, _currentTable, _dbConn);
                        auw.Owner = this;
                        auw.ShowDialog();
                        string message = auw.StatusMessagePasser + "Medical Summary Table";
                        StatusMessageHandler(message);
                        RetrieveTable(auw.TableRefresher);
                    }
                }
            }
        }
            
        private void tbSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchQuery = tbSearchBar.Text.ToLower();

            // Filter the data based on the search query
            IEnumerable<object> filteredData = SearchTableColumns(searchQuery);

            ObservableCollection<object> dataCollection = new ObservableCollection<object>();

            foreach (var item in filteredData)
            {
                dataCollection.Add(item);
            }

            dgMainTable.ItemsSource = dataCollection;

            if (dgMainTable.Items.Count == 0)
                StatusMessageHandler("No entries found for " + searchQuery + "...");
            else
                StatusMessageHandler("Searching...");
        }

        private IEnumerable<object> SearchTableColumns(string searchQuery)
        {
            IEnumerable<object> filteredData = null;
            int searchQueryInt;
            DateTime searchDateTime;
            bool isNumeric = int.TryParse(searchQuery, out searchQueryInt);
            bool isDateTime = DateTime.TryParse(searchQuery, out searchDateTime);

            switch (_currentTable)
            {
                case "Pets":
                    filteredData = from item in _dbConn.petDisplays
                                   where item.Pet_Name.ToLower().Contains(searchQuery) ||
                                         item.Pet_Breed.ToLower().Contains(searchQuery) ||
                                         (isNumeric && item.Pet_Age.ToString().Contains(searchQuery)) ||
                                         item.Pet_Sex.ToLower().Contains(searchQuery) ||
                                         (isNumeric && item.Pet_Price.ToString().Contains(searchQuery)) ||
                                         item.Pet_Status.ToLower().Contains(searchQuery)
                                   select item;
                    break;
                case "Products":
                    filteredData = from item in _dbConn.productDisplays
                                   where item.Product_Name.ToLower().Contains(searchQuery) ||
                                         item.Pet_Type.ToLower().Contains(searchQuery) ||
                                         item.Product_Type.ToLower().Contains(searchQuery) ||
                                         (isNumeric && item.Product_Stock.ToString().Contains(searchQuery)) ||
                                         (isNumeric && item.Product_Price.ToString().Contains(searchQuery))
                                   select item;
                    break;
                case "MedSum":
                    filteredData = from item in _dbConn.medicalDisplays
                                   where item.Pet_Name.ToLower().Contains(searchQuery) ||
                                         item.Physical_Exam.ToLower().Contains(searchQuery) ||
                                         item.Fecal_Test.ToLower().Contains(searchQuery) ||
                                         item.Blood_Test.ToLower().Contains(searchQuery) ||
                                         item.Parasite_Exam.ToLower().Contains(searchQuery) ||
                                         (isNumeric && item.Last_Checkup.ToString().Contains(searchQuery))
                                   select item;
                    break;
                case "Employees":
                    filteredData = from item in _dbConn.employeeDisplays
                                   where item.Employee_ID.ToLower().Contains(searchQuery) ||
                                         item.Employee_Name.ToLower().Contains(searchQuery) ||
                                         item.Employee_Email.ToLower().Contains(searchQuery) ||
                                         //item.Employee_Password.ToLower().Contains(searchQuery) ||
                                         item.Employee_Role.ToLower().Contains(searchQuery) ||
                                         item.Employee_Status.ToLower().Contains(searchQuery)
                                   select item;
                    break;
                case "Logs":
                    filteredData = from item in _dbConn.Logs
                                   where (isNumeric && item.Log_ID.ToString().Contains(searchQuery)) ||
                                         item.Login_ID.ToLower().Contains(searchQuery) ||
                                         (isNumeric && item.Login_Date.ToString().Contains(searchQuery))
                                   select item;
                    break;
            }

            return filteredData;
        }
    }
}
