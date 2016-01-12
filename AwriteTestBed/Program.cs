using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AWEF;
using AWriteDB;

namespace AwriteTestBed
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ids = new int[] {4,5,6};
            // -- DEBUG test only
            foreach (int i in ids)
                Console.WriteLine("Array value: " + i);

            consoleEntities context = new consoleEntities();

            // -- First clear the temp lookup id table records
            // This is a low efficiency method.
            var all = from x in context.LookupIDs select x;
            context.LookupIDs.RemoveRange(all);
            context.SaveChanges();

            // -- Now add the lookup Id range from the array
            foreach (int i in ids)
            {
                context.LookupIDs.Add(new LookupID() { LookupId1 = i });
                context.SaveChanges();
            }

            // -- now use a join to return the matching QualUnit records
            var result = from q in DbQualUnit.GetAllQualUnits()
                join x in DBLookupID.GetAllLookupIDS()
                    on q.QualUnitId equals x.LookupId
                select q;


            // -- this drill down works, if care taken to select EF
            // instance of LOTopics to allow Include() to operate through
            // the graph. 
            // -- Also watch for graph qualification of levels.
            using (context)
            {
                foreach (var topic in context.LOTopics.Include(x => x.UnitLearningOutcome.QualUnit).Where(x => x.TopicTestingMethod.idTopicTestingMethod > 2))
                    Console.WriteLine("{0} - {1} - {2}", topic.UnitLearningOutcome.QualUnit.QualUnitTitle,
                        topic.UnitLearningOutcome.LOShort,
                        topic.TopicShort);
            }
            
            //foreach (AWriteDB.MQualUnit unit in result)
            //{
            //    Console.WriteLine(unit.QualUnitNumber + ":\t" + unit.QualUnitTitle);
            //    foreach (MUnitLearningOutcome lo in unit.LearningOutcomes)
            //    {
            //        Console.WriteLine("\t" + lo.LearningOutcomeName);
            //    }
        //}
        }
    }
}
