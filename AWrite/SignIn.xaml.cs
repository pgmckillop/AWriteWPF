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

namespace AWrite
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : System.Windows.Controls.Page
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            string login = TxtUsername.Text;
            string password = "7S6%5ch1";

            int validateCheck = 0;

            AWriteDB.DbSystemUser user = new AWriteDB.DbSystemUser();
            validateCheck = user.ValidateUser(login,password);

            MessageBox.Show("validation outcome = " + validateCheck.ToString());

            // Launch next page
            this.NavigationService.Navigate(new Uri("MainWindow.xaml", UriKind.Relative));

            App.Current.Properties["activeUser"] = TxtUsername.Text;


        }

        private void btnDragTest_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("DragTest.xaml", UriKind.Relative));
        }
    }
}
