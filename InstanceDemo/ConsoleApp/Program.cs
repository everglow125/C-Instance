using ConsoleApp.Chart1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSort.ExcuteSearch();
            var xx = TestSort.ReturnDimensionsAsTuple(1);
            Console.ReadKey();
        }
    }
}
