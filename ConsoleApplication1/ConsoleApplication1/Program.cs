using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;

            string n = Console.ReadLine();
            int s = int.Parse(n);
            while(s>0)

            {
                sum = sum + s % 10;
                s = s / 10;

            }
            Console.WriteLine(sum);
            Console.ReadKey();



        }
    }
}
