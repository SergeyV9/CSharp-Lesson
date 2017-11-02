using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclacc myclacc = new Myclacc();
            MyBoock boock = new MyBoock();

            //myclacc.Sos();
            Console.WriteLine("Переменная класса " + myclacc.Id);
            boock.ID = 1000;
            string G = boock.ToString();
            Console.WriteLine("Переменная " + boock.ToString() + " = " + boock.ID);

            Console.ReadKey();

        }
    }


    class Myclacc
    {
        public int Id { get; set; } = 33;

        //public void Sos()
        //{
        //    Console.WriteLine("Метод класса");
        //}
    }


    class MyBoock
    {
       private int id;
       

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                if(value > 0)
                {
                    id = value / 2;
                }

            }
        }
    }
}
