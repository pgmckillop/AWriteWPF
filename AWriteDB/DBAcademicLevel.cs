using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class DBAcademicLevel
    {
        public static List<MAcademicLevel> GetAcademicLevels()
        {
            List<MAcademicLevel> myList = new List<MAcademicLevel>();
            SqlConnection connection = AWDB.GetConnection();
            string selectStatement = "SELECT idAcadLevel, AcadLevelName, AcadLevelShort, AcadLevelSort FROM AcademicLevel";
            SqlCommand command = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MAcademicLevel level = new MAcademicLevel((int)reader["idAcadLevel"], (string)reader["AcadLevelName"], (string)reader["AcadLevelShort"], (int)reader["AcadLevelSort"]);
                    myList.Add(level);
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }
            return myList;
        }
    }
}
