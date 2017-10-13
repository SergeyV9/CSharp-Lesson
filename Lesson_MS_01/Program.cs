using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LINQQueryExpressions
{
    static void Main()
    {

        // Specify the data source.
        //int[] scores = new int[] { 97, 92, 81, 60, 62, 33, 24, 80, 99, 2, 0, 1, 5 };
        int[] scores = { 97, 92, 81, 60, 62, 33, 24, 80, 99, 2, 0, 1, 5 };

        // Define the query expression.
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 1
            select score;

        // Execute the query.
        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }

        Console.ReadKey();
    }
}