using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Chart1
{
    public class CompareHeight :IComparer<Square>
    { public int Compare(object firstSquare, object secondSquare) {
            var square1 = firstSquare as Square;
            var square2 = secondSquare as Square;
            if (square1 == null || square2 == null)
                throw (new ArgumentException(
             "Both parameters must be of type Square"));
            else
                return Compare(square1, square2);
        }
        public int Compare(Square x, Square y) {
            if (x.Height == y.Height)
                return 0;
           else if (x.Height > y.Height)
                return 1;
           else if (x.Height < y.Height)
                return -1;
            else
                return -1;
        }
    }
}
