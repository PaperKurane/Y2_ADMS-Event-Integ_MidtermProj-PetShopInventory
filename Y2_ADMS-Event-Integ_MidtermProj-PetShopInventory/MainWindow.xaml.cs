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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Y2_ADMS_Event_Integ_MidtermProj_PetShopInventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PetChestConnDataContext _dbConn = null;
        bool flag = false;


        public MainWindow()
        {
            InitializeComponent();

            _dbConn = new PetChestConnDataContext(Properties.Settings.Default.PetCenterConnectionString);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbUsername.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                IQueryable<Employee> selectResults = from s in _dbConn.Employees
                                                     where s.Employee_ID == tbUsername.Text
                                                     select s;

                if (selectResults.Count() == 1)
                {
                    //MessageBox.Show("Username exists");

                    foreach (Employee s in selectResults)
                    {
                        if (s.Employee_Password == tbPassword.Text)
                        {
                            //if (s. == null)
                            //    messageString += $" Welcome {s.LoginName}!";
                            //else
                            //    messageString += $" Welcome back {s.LoginName}! Havent seen you since {s.LoginDate}";

                            //s.LoginDate = DateTime.Now;

                            Employee employ = new Employee();
                            //employ.LoginID = s.LoginID;
                            //employ.LogDate = (DateTime)s.LoginDate;

                            //_dbConn.tblLogs.InsertOnSubmit(tlog);
                            flag = true;
                            break;
                        }
                    }
                    //_dbConn.SubmitChanges();
                }
            }

            if (flag)
            {
                PetChestMainMenu w = new PetChestMainMenu(tbUsername.Text, _dbConn);
                w.Show();
                this.Close();
            }
        }
    }
}
