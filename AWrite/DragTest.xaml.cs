using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
    /// Interaction logic for DragTest.xaml
    /// </summary>
    public partial class DragTest : Page
    {
        ListBox dragSource = null;
        public DragTest()
        {
            InitializeComponent();
            
        }


        private AWriteDB.LTSC.CourseUnit awriteDataContext = new AWriteDB.LTSC.CourseUnit();
        private DataGridTextColumn textColumn = null;
        private string dataGridDataSource = string.Empty;

        private void lbSource_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            if (data != null)
            {
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            }
        }

        private void lbTarget_Drop(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            object data = e.Data.GetData(typeof(string));
            parent.Items.Add(data);
        }

        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data==DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }
                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }
            return null;
        }

        

        

        private void btnFillGrid_Click(object sender, RoutedEventArgs e)
        {
            List<AWriteDB.MCourseUnit> units = AWriteDB.DBCourseUnit.GetCourseUnits();
            testGrid.Columns.Clear();
            testGrid.ItemsSource = units;

            DataGridTextColumn idColumn = new DataGridTextColumn();
            idColumn.Header = "ID";
            idColumn.Binding = new Binding("idCourseUnit");
            testGrid.Columns.Add(idColumn);
        
        }
    }
}
