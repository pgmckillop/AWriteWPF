using System;
using System.Collections.Generic;
using System.Linq;
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
            //var ids = new int[4, 7, 9];
            int[] ids = new int[] {4,7,9};
            foreach (int i in ids)
            {
                Console.WriteLine("Array value: " + i);
            }
            
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

            var result = (from u in context.QualUnits
                select u);

            foreach (QualUnit unit in result)
            {
                Console.WriteLine(unit.CGUnitNumber + ": " + unit.QualUnitTitle);
            }
        }
    }
}
