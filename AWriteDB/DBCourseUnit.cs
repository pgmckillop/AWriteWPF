using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class DBCourseUnit
    {
        public static List<MCourseUnit> GetCourseUnits()
        {
            List<MCourseUnit> units = new List<MCourseUnit>();
            SqlConnection connection = AWDB.GetConnection();
            SqlCommand command = new SqlCommand("GetAllCourseUnits", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MCourseUnit unit = new MCourseUnit((int)reader["idCourseUnit"], (int)reader["idUnitStatus"], (int)reader["Course_idCourse"], (int)reader["QualUnit_idQualUnit"], (string)reader["CourseUnitTitle"]);
                    units.Add(unit);
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }
            return units;
        }

        //public static int GetCourseUnitID(int courseID, string courseUnitTitle)
        //{
        //SqlConnection connection = AWDB.GetConnection();
        //SqlCommand command = new SqlCommand("GetCourseUnitID", connection);
        //command.CommandType = System.Data.CommandType.StoredProcedure;
        //command.Parameters.AddWithValue("@courseID",courseID);
        //command.Parameters.AddWithValue("@courseUnitTitle", courseUnitTitle);
        //}

        public static int GetUnitID(int myCourseID, string myUnitTitle)
        {
            int unitId = 0;
            string selectStatement = "SELECT * FROM CourseUnit WHERE Course_idCourse = @myCourseID and CourseUnitTitle = @myUnitTitle";

            SqlConnection connection = AWDB.GetConnection();
            //This statement works in SSMS
            //SELECT idCourseUnit FROM [dbo].[CourseUnit]
            //WHERE CourseUnitTitle = '301 Project Management' and Course_idCourse = 1
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@myCourseID", myCourseID);
            selectCommand.Parameters.AddWithValue("@myUnitTitle", myUnitTitle);
            try
            {
                connection.Open();
                // Error here

                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    unitId = Convert.ToInt32(reader["idCourseUnit"]);
                }
                else
                {
                    unitId = -2;
                }
                reader.Close();
                
            }
            finally
            {
                connection.Close();
            }
        
            return unitId;
        }


        public static string GetCourseUnitID(int myCourseID, string myCourseUnitTitle)
        {
            int temp = 0;
            string unitID = string.Empty;
            SqlConnection connection = AWDB.GetConnection();
            SqlCommand command = new SqlCommand("GetCourseUnitID", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@courseID", myCourseID);
            command.Parameters.AddWithValue("@courseUnitTitle", myCourseUnitTitle);
            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@courseUnitID";
            outputParameter.SqlDbType = SqlDbType.Int;
            outputParameter.Direction = ParameterDirection.Output;
            command.Parameters.Add(outputParameter);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                unitID = outputParameter.Value.ToString();
            }
            finally
            {
                connection.Close();
            }

            return unitID;
            
        }
        
        // get limited list of courses by their Course
        public static List<MCourseUnit> GetCourseUnitsByCourse(int ID)
        {
            List<MCourseUnit> units = new List<MCourseUnit>();
            SqlConnection connection = AWDB.GetConnection();
            SqlCommand command = new SqlCommand("GetCourseUnitsByCourse", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCourse", ID);

            try  
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MCourseUnit unit = new MCourseUnit((int)reader["idCourseUnit"], 
                        (string)reader["CourseUnitTitle"]);
                    units.Add(unit);
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return units;
        }

        public static ObservableCollection<MCourseUnit> GetCourseUnitsByCourseAllInfo(int ID)
        {
            ObservableCollection<MCourseUnit> units = new ObservableCollection<MCourseUnit>();
            SqlConnection connection = AWDB.GetConnection();
            SqlCommand command = new SqlCommand("GetCourseUnitsByCourseAllInfo", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCourse", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MCourseUnit unit = 
                        new MCourseUnit((int)reader["idCourseUnit"],
                        (int)reader["UnitStatus_idUnitStatus"],
                        (int)reader["Course_idCourse"],
                        (int)reader["QualUnit_idQualUnit"],
                        (string)reader["CourseUnitTitle"]);
                    units.Add(unit);
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return units;
        }

    }
}
