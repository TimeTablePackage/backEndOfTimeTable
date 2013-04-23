using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase mybd = new DataBase();
            Institute itc = new Institute("it carlow");
            itc.setBuildingList(mybd.loadBuildingList(itc));
            itc.setDeptList(mybd.loadDepartmentList(itc));

            Console.Read();

        }
    }
}
