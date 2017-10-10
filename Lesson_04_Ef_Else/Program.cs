using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_Ef_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 6;

            if (a<b)
            {
                Console.WriteLine("a больше b");
            }
            else if (a>b)
            {
                Console.WriteLine("a меньше b");
             
            }
            else
        	{

                Console.WriteLine("a навно b");
                
            }

            Console.ReadKey();
        }
    }
}
