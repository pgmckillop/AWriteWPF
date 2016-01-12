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
            SqlConnection connection = AWriteDB.Awdb.GetConnection();
            string selectStatement = "SELECT idAcadLevel, AcadLevelName, AcadLevelShort, AcadLevelSort FROM AcademicLevel";
            SqlDataAdapter da = new SqlDataAdapter(selectStatement, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "AcademicLevel");

            CboLevels.ItemsSource = ds.Tables[0].DefaultView;
            CboLevels.DisplayMemberPath = ds.Tables[0].Columns["AcadLevelName"].ToString();
            CboLevels.SelectedValuePath = ds.Tables[0].Columns["idAcadLevel"].ToString(); // note this is a string
        }
        #endregion

        #region cboLevels dropdown close
        private void cboLevels_DropDownClosed(object sender, System.EventArgs e)
        {
            if ((int)CboLevels.SelectedValue > 0)
            {

                // debug globals
                string activeUser = App.Current.Properties["activeUser"].ToString();
                //MessageBox.Show(activeUser);

                // clear child combos
                CboCurricula.ItemsSource = null;
                CboCurricula.Items.Clear();

                CboQualifications.ItemsSource = null;
                CboQualifications.Items.Clear();

                CboPathways.ItemsSource = null;
                CboPathways.Items.Clear();

                CboCourses.ItemsSource = null;
                CboCourses.Items.Clear();



                // fill the combo cboCurricula
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection connection = AWriteDB.Awdb.GetConnection();
                try
                {
                    connection.Open();
                    command = new SqlCommand("GetCurriculumByLevel", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idAcadLevel", (int)CboLevels.SelectedValue);
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Curricula");

                    CboCurricula.ItemsSource = ds.Tables[0].DefaultView;
                    CboCurricula.DisplayMemberPath = ds.Tables[0].Columns["CurriculumName"].ToString();
                    CboCurricula.SelectedValuePath = ds.Tables[0].Columns["idCurriculum"].ToString();
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

            if ((int)CboCurricula.SelectedValue > 0)
            {

                // clear child combos
                CboQualifications.ItemsSource = null;
                CboQualifications.Items.Clear();

                CboPathways.ItemsSource = null;
                CboPathways.Items.Clear();

                CboCourses.ItemsSource = null;
                CboCourses.Items.Clear();

                // populate the qualifications combo
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection connection = AWriteDB.Awdb.GetConnection();
                try
                {
                    connection.Open();
                    command = new SqlCommand("GetQualificationByCurriculum", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idCurriculum", (int)CboCurricula.SelectedValue);
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Qualifications");

                    CboQualifications.ItemsSource = ds.Tables[0].DefaultView;
                    CboQualifications.DisplayMemberPath = ds.Tables[0].Columns["QualificationName"].ToString();
                    CboQualifications.SelectedValuePath = ds.Tables[0].Columns["idQualification"].ToString();
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
            if ((int)CboQualifications.SelectedValue > 0)
            {
                // clear child combos
                CboPathways.ItemsSource = null;
                CboPathways.Items.Clear();

                CboCourses.ItemsSource = null;
                CboCourses.Items.Clear();

                // populate the pathways combo
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection connection = AWriteDB.Awdb.GetConnection();
                try
                {
                    connection.Open();
                    command = new SqlCommand("GetPathwaysByQualification", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idQualification", (int)CboQualifications.SelectedValue);
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Pathways");

                    CboPathways.ItemsSource = ds.Tables[0].DefaultView;
                    CboPathways.DisplayMemberPath = ds.Tables[0].Columns["QualPathwayName"].ToString();
                    CboPathways.SelectedValuePath = ds.Tables[0].Columns["idQualificationPathway"].ToString();
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
            if ((int)CboPathways.SelectedValue > 0)
            {
                // clear child combo
                CboCourses.ItemsSource = null;
                CboCourses.Items.Clear();

                // populate the Cour    ses combo
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection connection = AWriteDB.Awdb.GetConnection();

                try
                {
                    connection.Open();
                    command = new SqlCommand("GetCoursesByPathway", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idPathway", (int)CboPathways.SelectedValue);
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Courses");

                    CboCourses.ItemsSource = ds.Tables[0].DefaultView;
                    CboCourses.DisplayMemberPath = ds.Tables[0].Columns["CourseName"].ToString();
                    CboCourses.SelectedValuePath = ds.Tables[0].Columns["idCourse"].ToString();
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
            App.Current.Properties["workingCourseID"] = CboCourses.SelectedValue;
        }
    }
}
