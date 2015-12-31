using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using AWEF;

namespace AWriteDB
{
    public class DbQualUnit
    {
        public static List<MQualUnit> UnitRange(int[] myUnits)
        {
            // create a list of units based on the IDs of the Qual Units
            awriteEntities context = new awriteEntities();

            List<MQualUnit> result = new List<MQualUnit>();
            return result;
        }

        public static List<MQualUnit> GetAllQualUnits()
        {
            List<MQualUnit> units = new List<MQualUnit>();
            SqlConnection connection = Awdb.GetConnection();
            SqlCommand command = new SqlCommand("GetAllQualUnits",connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MQualUnit unit = new MQualUnit((int)reader["idQualUnit"],
                        (int)reader["Qualification_idQualification"],
                        (string)reader["QualUnitTitle"],
                        (int)reader["CGUnitNumber"],
                        (string)reader["QualUnitUAN"],
                        (int)reader["QualUnitGLH"]
                        );
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
