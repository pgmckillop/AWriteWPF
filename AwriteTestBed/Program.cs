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
            var ids = new int[4, 7, 9];
            
            consoleEntities context = new consoleEntities();

            var result = (from u in context.QualUnits
                select u);

            foreach (QualUnit unit in result)
            {
                Console.WriteLine(unit.CGUnitNumber + ": " + unit.QualUnitTitle);
            }
            
            
            
            //var result = from qualUnit in context.AsQueryable<MQualUnit>()
            //             where idList.A
            //foreach (QualUnit unit in result)
            //{
            //    Console.WriteLine(unit.QualUnitTitle);
            //}


            //var context = new AWEF.awriteEntities();
            //// get records
            //var result = context.QualUnits;

            //foreach (QualUnit qualUnit in result)
            //{
            //    Console.WriteLine(qualUnit.QualUnitTitle);
            //}
        }
    }
}
