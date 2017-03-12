using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication2
{
    class Program
    {
        class Polygon
        {
         
        }
        public static void getPerimeter(int a,int b)
        {
           int p = 2 * (a + b);
        }
        static void Main(string[] args)
        {
            DirectoryInfo info = new DirectoryInfo("C:\Users\1\Desktop\polygon");
            DirectoryInfo[] dirs = info.GetDirectories();
            FileInfo[] files = info.GetFiles();        
            int d = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            getPerimeter(d, c);
            Console.WriteLine(p);
            Console.ReadKey();
        
        }
    }
}
