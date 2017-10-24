using System;
using System.IO;

namespace Read_file
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] spline = File.ReadAllLines("C:\\Users\\esins\\source\\repos\\CSharp-Lesson\\Read_file\\test_dot_ref.txt");
            string[,] myresut = new string[spline.Length, 5];
            string mywords = "";

            for (int i = 0; i < spline.Length; i++)
            {
                mywords = spline[i];
                string[] split = mywords.Split(new Char[] { ' '/*, ',', '.', ':', '\t' */});

                for (int j = 0; j < 5; j++)
                {
                    myresut.SetValue(split[j], i, j);
                    Console.WriteLine(myresut[i, j]);
                }

            }

            Console.ReadLine();

        }
    }
}
