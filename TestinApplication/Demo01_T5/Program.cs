using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna aikamääre sekunteina: ");
            string line = Console.ReadLine(); // "50"
            int sekuntit = int.Parse(line); // 50
            int a;
            int tunnit = sekuntit / 3600;
            int minuutit = sekuntit / 60 - tunnit * 60;
            int sekunnit = sekuntit % 60;


            Console.WriteLine("Time: {0}h {1}m {2}s", tunnit, minuutit, sekunnit);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();

        }
    }
}
