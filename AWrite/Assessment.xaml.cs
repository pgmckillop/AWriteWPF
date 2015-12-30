using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace AWrite
{
    /// <summary>
    /// Interaction logic for Assessment.xaml
    /// </summary>
    public partial class Assessment : Page
    {

        //ListBox dragSource = null;
        List<AWriteDB.DbCourseUnit> selectedUnits = new List<AWriteDB.DbCourseUnit>();
        public Assessment()
        {
            InitializeComponent();
            BindAssessmentTypes();

            // Bind CourseUnits to list box
            int courseId = 0;
            courseId = Convert.ToInt32( App.Current.Properties["workingCourseID"]);
            // Check Course ID has been set
            if (courseId > 0)
            {
                BindCourseUnits(courseId);
            }
            else
            {
                MessageBox.Show("No Course ID set");
            }       
        }

        #region Control Binding code
        void BindAssessmentTypes()
        {
            // Really good algorithm for population of control
            List<AWriteDB.MAssessmentType> bindingList = AWriteDB.DbAssessmentType.GetAssessmentTypes();

            CboAssessmentType.ItemsSource = bindingList;
            CboAssessmentType.DisplayMemberPath = "AssessmentTypeName";
            CboAssessmentType.SelectedValuePath = "idAssessmentType";
        }

        void BindCourseUnits(int myId)
        {

            ObservableCollection<AWriteDB.MCourseUnit> bindingList = AWriteDB.DbCourseUnit.GetCourseUnitsByCourseAllInfo(myId);
            var oc = new List<AWriteDB.MCourseUnit>();
            foreach (var item in bindingList)
                oc.Add(item);

            LbCourseUnits.ItemsSource = oc;
            LbCourseUnits.DisplayMemberPath = "CourseUnitTitle";
            LbCourseUnits.SelectedValuePath = "idCourseUnit";
        } 
        #endregion

        private void btnGoSetUpTasks_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AssessmentTasks.xaml", UriKind.Relative));
        }
  
        private void btnAddUnit_Click(object sender, RoutedEventArgs e)
        {
            var selection = new StringBuilder();
            selection.AppendLine("You selected");
            foreach (var item in LbCourseUnits.SelectedItems)
            {
                

                Type itemType = item.GetType();
                System.Reflection.PropertyInfo propInfo = null;
                propInfo = itemType.GetProperty("CourseUnitTitle");
                int courseId = Convert.ToInt32(App.Current.Properties["workingCourseID"]);
                string propertyValue = propInfo.GetValue(item, null) as string;
                selection.AppendLine(propertyValue);
            }
            MessageBox.Show(selection.ToString());
            //MessageBox.Show();
            LbUnitsAssessed.Items.Add(selection.ToString());
        }

        private void btnRemoveUnit_Click(object sender, RoutedEventArgs e)
        {
            int unitId = 0;
            int countSelected = LbCourseUnits.SelectedItems.Count;
            int[] selectedIds = new int[countSelected];

            //foreach (var item in lbCourseUnits.SelectedItems)
            //{
            //    int i = 0;
            //    Type itemType = item.GetType();
            //    System.Reflection.PropertyInfo propInfo = null;
            //    propInfo = itemType.GetProperty("CourseUnitTitle");
            //    int courseID = Convert.ToInt32(App.Current.Properties["workingCourseID"]);
            //    string unitTitleValue = propInfo.GetValue(item, null) as string;

            //    unitID = AWriteDB.DBCourseUnit.GetUnitID(courseID, unitTitleValue);
            //    // works up to here. Cannot add items after 0 to array
            //    selectedIds[i] = unitID;
            //    i++;              
            //}

            for (int counter = countSelected -1; counter >= 0; counter--)
            {
                var item = LbCourseUnits.SelectedItems[counter];
                Type itemType = item.GetType();
                System.Reflection.PropertyInfo propInfo = null;
                propInfo = itemType.GetProperty("CourseUnitTitle");
                int courseId = Convert.ToInt32(App.Current.Properties["workingCourseID"]);
                string unitTitleValue = propInfo.GetValue(item, null) as string;

                unitId = AWriteDB.DbCourseUnit.GetUnitID(courseId, unitTitleValue);
                // works up to here. Cannot add items after 0 to array
                // debug looping seems to add right things to array

                // DEBUG UPDATE changed counter decrement to post decrement
                // now getting the ID all selecte units
                selectedIds[counter] = unitId;
            }
            for (int i = 0; i <= countSelected - 1; i++)
                MessageBox.Show(selectedIds[i].ToString());
        }

        private void lbCourseUnits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //tbkCourseUnitID.Text = lbCourseUnits.SelectedValue.ToString();
        }
    }
}
