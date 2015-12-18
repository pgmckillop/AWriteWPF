using System.Windows;
using System.Data.SqlClient;
using System.Data;
using System;

namespace AWrite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Controls.Page
    {
        public MainWindow()
        {
            InitializeComponent();
            BindAcademicLevels();
        }

        #region Drill down combo routines
        #region Academic Levels Combo Populate
        public void BindAcademicLevels()
        {
            SqlConnection connection = AWriteDB.AWDB.GetConnection();
            string selectStatement = "SELECT idAcadLevel, AcadLevelName, AcadLevelShort, AcadLevelSort FROM AcademicLevel";
            SqlDataAdapter da = new SqlDataAdapter(selectStatement, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "AcademicLevel");

            cboLevels.ItemsSource = ds.Tables[0].DefaultView;
            cboLevels.DisplayMemberPath = ds.Tables[0].Columns["AcadLevelName"].ToString();
            cboLevels.SelectedValuePath = ds.Tables[0].Columns["idAcadLevel"].ToString(); // note this is a string
        }
        #endregion

        #region cboLevels dropdown close
        private void cboLevels_DropDownClosed(object sender, System.EventArgs e)
        {
            if ((int)cboLevels.SelectedValue > 0)
            {

                // debug globals
                string activeUser = App.Current.Properties["activeUser"].ToString();
                //MessageBox.Show(activeUser);

                // clear child combos
                cboCurricula.ItemsSource = null;
                cboCurricula.Items.Clear();

                cboQualifications.ItemsSource = null;
                cboQualifications.Items.Clear();

                cboPathways.ItemsSource = null;
                cboPathways.Items.Clear();

                cboCourses.ItemsSource = null;
                cboCourses.Items.Clear();



                // fill the combo cboCurricula
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection connection = AWriteDB.AWDB.GetConnection();
                try
                {
                    connection.Open();
                    command = new SqlCommand("GetCurriculumByLevel", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idAcadLevel", (int)cboLevels.SelectedValue);
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Curricula");

                    cboCurricula.ItemsSource = ds.Tables[0].DefaultView;
                    cboCurricula.DisplayMemberPath = ds.Tables[0].Columns["CurriculumName"].ToString();
                    cboCurricula.SelectedValuePath = ds.Tables[0].Columns["idCurriculum"].ToString();
                }
                finally
                {
                    connection.Close();
                }
            }


        }
        #endregion

        #region cboCurricula dropdown close
        private void cboCurricula_DropDownClosed(object sender, System.EventArgs e)
        {

            if ((int)cboCurricula.SelectedValue > 0)
            {

                // clear child combos
                cboQualifications.ItemsSource = null;
                cboQualifications.Items.Clear();

                cboPathways.ItemsSource = null;
                cboPathways.Items.Clear();

                cboCourses.ItemsSource = null;
                cboCourses.Items.Clear();

                // populate the qualifications combo
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection connection = AWriteDB.AWDB.GetConnection();
                try
                {
                    connection.Open();
                    command = new SqlCommand("GetQualificationByCurriculum", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idCurriculum", (int)cboCurricula.SelectedValue);
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Qualifications");

                    cboQualifications.ItemsSource = ds.Tables[0].DefaultView;
                    cboQualifications.DisplayMemberPath = ds.Tables[0].Columns["QualificationName"].ToString();
                    cboQualifications.SelectedValuePath = ds.Tables[0].Columns["idQualification"].ToString();
                }
                finally
                {
                    // Houaw
                    connection.Close();
                }
            }
            else
            {
                // input error inform Error tell 
                MessageBox.Show("Your must select a curriculum");
            }
        }
        #endregion

        #region cboQualifications dropdown close
        private void cboQualifications_DropDownClosed(object sender, System.EventArgs e)
        {
            if ((int)cboQualifications.SelectedValue > 0)
            {
                // clear child combos
                cboPathways.ItemsSource = null;
                cboPathways.Items.Clear();

                cboCourses.ItemsSource = null;
                cboCourses.Items.Clear();

                // populate the pathways combo
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection connection = AWriteDB.AWDB.GetConnection();
                try
                {
                    connection.Open();
                    command = new SqlCommand("GetPathwaysByQualification", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idQualification", (int)cboQualifications.SelectedValue);
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Pathways");

                    cboPathways.ItemsSource = ds.Tables[0].DefaultView;
                    cboPathways.DisplayMemberPath = ds.Tables[0].Columns["QualPathwayName"].ToString();
                    cboPathways.SelectedValuePath = ds.Tables[0].Columns["idQualificationPathway"].ToString();
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion

        #region cboPathways dropdown close
        private void cboPathways_DropDownClosed(object sender, System.EventArgs e)
        {
            if ((int)cboPathways.SelectedValue > 0)
            {
                // clear child combo
                cboCourses.ItemsSource = null;
                cboCourses.Items.Clear();

                // populate the Cour    ses combo
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection connection = AWriteDB.AWDB.GetConnection();

                try
                {
                    connection.Open();
                    command = new SqlCommand("GetCoursesByPathway", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idPathway", (int)cboPathways.SelectedValue);
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Courses");

                    cboCourses.ItemsSource = ds.Tables[0].DefaultView;
                    cboCourses.DisplayMemberPath = ds.Tables[0].Columns["CourseName"].ToString();
                    cboCourses.SelectedValuePath = ds.Tables[0].Columns["idCourse"].ToString();
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion

        #endregion

        private void btnEditAssignment_Click(object sender, RoutedEventArgs e)
        {
            // placeholder function in v1
        }

        private void btnNewAssignment_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Assessment.xaml", UriKind.Relative));
        }

        private void cboCourses_DropDownClosed(object sender, EventArgs e)
        {
            // DEBUG **** Is value stored
            // NOT getting integer
            App.Current.Properties["workingCourseID"] = cboCourses.SelectedValue;
        }
    }
}
