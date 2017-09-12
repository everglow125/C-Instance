using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Logic.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void SquareTest()
        {
            List<Square> listOfSquares = new List<Square>()
            {
                new Square(1,3),
                new Square(4,3),
                new Square(2,1),
                new Square(6,1)
            };
            StringBuilder sb = new StringBuilder();
            foreach (var item in listOfSquares)
            {
                sb.AppendLine(item.ToString());
            }
            IComparer<Square> heightCompare = new CompareHeight();
            listOfSquares.Sort(heightCompare);
            foreach (var item in listOfSquares)
            {
                sb.AppendLine(item.ToString());
            }
            listOfSquares.Sort();
            foreach (var item in listOfSquares)
            {
                sb.AppendLine(item.ToString());
            }
            var sortedListOfSquares = new SortedList<int, Square>()
            {
                {0,new Square(1,3)},
                {2,new Square(3,3)},
                {1,new Square(6,1)},
                {3,new Square(2,1)},
            };
            foreach (KeyValuePair<int, Square> kvp in sortedListOfSquares)
            {
                sb.AppendLine(string.Format("{0}:{1}", kvp.Key, kvp.Value));
            }
            Assert.IsNotNull(sb);
           
        }


    }
}
