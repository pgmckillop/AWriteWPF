using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    class DBAssessment
    {
        //CRUD Operations

        // Create
        public int CreateNewAssesment(MAssessment assessment)
        {
            MAssessment myAssessment = new MAssessment();
            SqlConnection connection = AWDB.GetConnection();


            // Successful create return new assessment ID
            return 1;
        }

        // Read all

        public List<MAssessment> GetAllAssessments()
        {
            List<MAssessment> assessments = new List<MAssessment>();

            return assessments;
        }
        
        // Read by ID


        // Update by ID


        // Delete ID

    }
}
