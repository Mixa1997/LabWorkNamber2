using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Code
    {
        public int OneNamber { get; set; }
        public int TwoNamber { get; set; }
        public Code(int onenumber, int twonamber)
        {
            OneNamber = onenumber;
            TwoNamber = twonamber;
        }
        public void Result()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (OneNamber <= TwoNamber) Console.WriteLine("Входит в диапозон");
            if (TwoNamber >= OneNamber) Console.WriteLine("Входит в диапозон");
            else Console.WriteLine("Не входит в диапозон");
        }
    }
}
