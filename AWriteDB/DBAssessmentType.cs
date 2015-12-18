using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class DBAssessmentType
    {
        public static List<MAssessmentType> GetAssessmentTypes()
        {
            List<MAssessmentType> mylist = new List<MAssessmentType>();
            SqlConnection connection = AWDB.GetConnection();
            string selectStatement = "SELECT idAssessmentType, AssessmentTypeName FROM AssessmentType";
            SqlCommand command = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MAssessmentType assessmentType = new MAssessmentType((int)reader["idAssessmentType"], (string)reader["AssessmentTypeName"].ToString());
                    mylist.Add(assessmentType);
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }
            return mylist;
        }
    }
}
