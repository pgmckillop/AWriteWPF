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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AWrite
{
    /// <summary>
    /// Interaction logic for AssessmentTasks.xaml
    /// </summary>
    public partial class AssessmentTasks : Page
    {
        //ListBox dragSource = null;
        public AssessmentTasks()
        {
            InitializeComponent();
        }

        private void btnToTask1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AssessmentTask1.xaml", UriKind.Relative));
        }
    }
}
