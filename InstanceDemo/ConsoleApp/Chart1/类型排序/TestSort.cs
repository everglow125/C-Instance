using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Chart1
{
    public class TestSort
    {
        public static void ExcuteSort()
        {
            var listOfSquares = new List<Square>() {
                    new Square(1,3),
                    new Square (4,3),
                    new Square (2,1),
                    new Square (6,1)
            };

            Console.WriteLine("List<String>");
            Console.WriteLine("Original list");
            foreach (var square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }
            Console.WriteLine();
            IComparer<Square> heightCompare = new CompareHeight();
            listOfSquares.Sort(heightCompare);
            Console.WriteLine("Sorted list using Icomparer<Square>=heightCompare");
            foreach (var square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Sorted list using IComparable<Square>");
            listOfSquares.Sort();
            foreach (var square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }

            var sortedListOfSquare = new SortedList<int, Square>()
            {
                { 0,new Square(1,3)},
                { 2,new Square(3,3)},
                { 1,new Square(2,1)},
                { 3,new Square(6,1)},
            };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SortedList<Square>");
            foreach (KeyValuePair<int, Square> kvp in sortedListOfSquare)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }
        }

        public static void ExcuteSearch()
        {
            List<Square> listOfSquares = new List<Square>()
            {
                   new Square(1,3),
                    new Square (4,3),
                    new Square (2,1),
                    new Square (6,1)
            };
            IComparer<Square> heightCompare = new CompareHeight();
            Console.WriteLine("List<String>");
            Console.WriteLine("Original list");
            foreach (var square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Sorted list using IComparer<Square>=heightCompare");
            listOfSquares.Sort(heightCompare);
            foreach (Square square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Search using IComparer<Square>=heightCompare");
            int found = listOfSquares.BinarySearch(new Square(1, 3), heightCompare);
            Console.WriteLine($"Found(1,3):{found}");

            Console.WriteLine();
            Console.WriteLine("Sorted list using IComparable<Square>");
            listOfSquares.Sort();
            foreach (Square square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Search using IComparable<Square>");

            found = listOfSquares.BinarySearch(new Square(6, 1));
            Console.WriteLine($"Found(6,1):{found}");

            var sortedListOfSquares = new SortedList<int, Square>(){
                    {0, new Square(1,3)},
                    {2, new Square(4,3)},
                    {1, new Square(2,1)},
                    {4, new Square(6,1)}};
            Console.WriteLine();
            Console.WriteLine("SortedList<Square>");
            foreach (KeyValuePair<int, Square> kvp in sortedListOfSquares)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
            Console.WriteLine();
            bool foundItem = sortedListOfSquares.ContainsKey(2);
            Console.WriteLine($"sortedListOfSquares.ContainsKey(2):{foundItem}");

            Console.WriteLine();
            Square value = new Square(6, 1);
            foundItem = sortedListOfSquares.ContainsValue(value);
            Console.WriteLine($"sortedlistOfSquares.ContainsValue new Square()6,1:{foundItem}");
        }

        public static Tuple<int, int, int> ReturnDimensionsAsTuple(int inputShape)
        {
            var objDim = Tuple.Create<int, int, int>(5, 10, 15);
            return objDim;
        }
    }
}
