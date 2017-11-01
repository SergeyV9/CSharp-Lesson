using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Моя первая консольная программа
            //Console.Write("Hello world!");
            //Console.ReadKey();
            //Console.Write("My first program");
            //Console.ReadKey();

            //double a = double.Parse("1,54");

            //Console.WriteLine(a);

            //Console.ReadKey();

            #endregion

            #region чтение из файла 

            //string words = "C 0,130 0,042 0,016 0,088 " + 
            //               "C 0,062 0,021 0,010 0,043 " +
            //               "K 1,665 1,803 2,016 1,729 ";

            //string[] split = words.Split(new Char[] { ' '/*, ',', '.', ':', '\t' */});

            //foreach (string s in split)
            //{

            //    if (s.Trim() != "")
            //        Console.WriteLine(s);


            //}

            #endregion

            string counter;
            string words;
            int resalt = 0;
            counter = Console.ReadLine();
            words = Console.ReadLine();

            string[] massive = words.Split(new Char[] { ' ' });

            for (int i = 0; i < int.Parse(counter); i++)
            {

                resalt += int.Parse(massive[i]);

            }
            
            Console.WriteLine(resalt);

            Console.ReadKey();
        }
    }
}
