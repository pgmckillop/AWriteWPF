using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class DbSystemUser
    {
        #region Validate user
        public int ValidateUser(string myLogin, string myPassword)
        {

            SqlConnection connection = Awdb.GetConnection();
            SqlCommand command = new SqlCommand("GetSystemUserByLogin", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("systemUserLoginName", myLogin);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    // create user data id, login and password
                    MSystemUser myUser = new MSystemUser((int)reader["idSystemUser"], (string)reader["SystemUserLoginName"], (string)reader["SystemUserInitialPassword"]);

                    if (myUser.SystemUserInitialPassword != null || myUser.SystemUserInitialPassword != "")
                    {
                        // check credentials
                        if (myUser.SystemUserInitialPassword.ToString() == myPassword)
                        {
                            // password matched
                            return Convert.ToInt32(myUser.SystemUserId);
                        }
                        else
                        {
                            // password does not match
                            return -1;
                        }
                    }
                    else
                    {
                        // null or empty string
                        return -2;
                    }
                }
                else
                {
                    // user not found
                    return -3;
                }
            }
            finally
            {
                // housekeeping
                connection.Close();
            }

        }
        #endregion

        #region Login exists
        public int LoginExists(string myLogin)
        {
            SqlConnection connection = Awdb.GetConnection();
            SqlCommand command = new SqlCommand("GetSystemUserByLogin", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("systemUserLoginName", myLogin);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    MSystemUser myUser = new MSystemUser((int)reader["idSystemUser"], (string)reader["SystemUserLoginName"], (string)reader["SystemUserInitialPassword"]);
                    return myUser.SystemUserId;
                }
                else
                {
                    return -1;
                }
            }
            finally
            {
                connection.Close();
            }
        } 
        #endregion
    }
}
