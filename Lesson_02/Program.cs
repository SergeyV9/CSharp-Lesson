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
            MyClacc myclacc = new MyClacc(651561651);
            MyBoocks boock = new MyBoocks();

            //myclacc.Sos();
            Console.WriteLine($"Переменная класса MyClass = {myclacc.Id}");
            boock.ID = 1000;
            Console.WriteLine($"Пременная класса MyBoock = {boock.ID}");

            Console.ReadKey();

        }
    }


    class MyClacc
    {
        public double Id { get; set; }

        public MyClacc() // пустой конструктор класса
        {
        }

        public MyClacc(double i) //конструктор класса с 1 входным параметром
        {
            Id = Math.Sqrt(i);
        }

        public void Sos()
        {
            Console.WriteLine("Метод класса");
        }
    }


    #region Класс MyBoock

    class MyBoocks
    {
        private int id;

        public int ID
        {
            get => id;

            set
            {
                if (value > 0)
                {
                    id = value;
                }

            }
        }

        public MyBoocks()
        {
            id = Convert.ToInt32(Math.Sqrt(ID));
        }
    } 
    #endregion
}
