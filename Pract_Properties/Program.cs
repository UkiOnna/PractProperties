using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray array = new RangeOfArray();
            Random random = new Random();
            int rangeStart;
            int rangeFinish;
            Console.WriteLine("Введите диапозон массива");
            int.TryParse(Console.ReadLine(), out rangeStart);
            int.TryParse(Console.ReadLine(), out rangeFinish);
            array.rangeStart = rangeStart;
            array.rangeFinish = rangeFinish;
            for(int i = rangeStart; i < rangeFinish; i++)
            {
                array[i] = random.Next(100);
                Console.Write("{0}  ",array[i]);
            }

            Console.ReadLine();

        }
    }
}
