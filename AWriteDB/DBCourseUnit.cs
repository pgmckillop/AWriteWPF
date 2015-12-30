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
    public class DbCourseUnit
    {
        public static List<MCourseUnit> GetCourseUnits()
        {
            List<MCourseUnit> units = new List<MCourseUnit>();
            SqlConnection connection = Awdb.GetConnection();
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

        public static int GetQualUnitId(int myCourseId, string myUnitTitle)
        {
            int unitId = 0;
            string selectStatement = "SELECT * FROM CourseUnit WHERE Course_idCourse = @myCourseID and CourseUnitTitle = @myUnitTitle";

            SqlConnection connection = Awdb.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@myCourseID", myCourseId);
            selectCommand.Parameters.AddWithValue("@myUnitTitle", myUnitTitle);
            try
            {
                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    unitId = Convert.ToInt32(reader["QualUnit_idQualUnit"]);
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


        public static string GetCourseUnitId(int myCourseId, string myCourseUnitTitle)
        {
            int temp = 0;
            string unitId = string.Empty;
            SqlConnection connection = Awdb.GetConnection();
            SqlCommand command = new SqlCommand("GetCourseUnitID", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@courseID", myCourseId);
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
                unitId = outputParameter.Value.ToString();
            }
            finally
            {
                connection.Close();
            }

            return unitId;
            
        }
        
        // get limited list of courses by their Course
        public static List<MCourseUnit> GetCourseUnitsByCourse(int id)
        {
            List<MCourseUnit> units = new List<MCourseUnit>();
            SqlConnection connection = Awdb.GetConnection();
            SqlCommand command = new SqlCommand("GetCourseUnitsByCourse", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCourse", id);

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

        public static ObservableCollection<MCourseUnit> GetCourseUnitsByCourseAllInfo(int id)
        {
            ObservableCollection<MCourseUnit> units = new ObservableCollection<MCourseUnit>();
            SqlConnection connection = Awdb.GetConnection();
            SqlCommand command = new SqlCommand("GetCourseUnitsByCourseAllInfo", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCourse", id);

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
