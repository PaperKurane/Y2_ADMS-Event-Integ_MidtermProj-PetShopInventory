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

            _dbConn = new PetChestConnDataContext(Properties.Settings.Default.PetChestConnectionString);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string messageString = "";

            if (tbUsername.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                IQueryable<Employee> selectResults = from s in _dbConn.Employees
                                                     where s.Employee_ID == tbUsername.Text
                                                     select s;

                if (selectResults.Count() == 1)
                {
                    foreach (Employee s in selectResults)
                    {
                        if (s.Employee_Password == tbPassword.Text)
                        {
                            if (s.Last_Login == null)
                                messageString += $" Welcome {s.Employee_Name}!";
                            else
                                messageString += $" Welcome back {s.Employee_Name}! Havent seen you since {s.Last_Login}";

                            s.Last_Login = DateTime.Now;

                            Log logInsertion = new Log();
                            logInsertion.Login_ID = s.Employee_ID;
                            logInsertion.Login_Date = (DateTime)s.Last_Login;

                            _dbConn.Logs.InsertOnSubmit(logInsertion);
                            flag = true;
                            break;
                        }
                    }
                    _dbConn.SubmitChanges();
                }
            }

            if (flag)
            {
                PetChestMainMenu w = new PetChestMainMenu(tbUsername.Text, _dbConn, messageString);
                w.Show();
                this.Close();
            }
        }
    }
}
