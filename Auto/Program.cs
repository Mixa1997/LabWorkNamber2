using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write($"Введите первое число:");
                int onenamber = int.Parse(Console.ReadLine());
                Console.Write($"Введите второе число:");
                int twonamber = int.Parse(Console.ReadLine());
                Code code = new Code(onenamber, twonamber);
                code.Result();
            }
            catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
