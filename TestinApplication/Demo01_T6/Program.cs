using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_T6
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Tehtävä 6
            //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
            //Tee ohjelma, joka tulostaa ajetulla matkalla(kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
            Console.Write("Kilometres: ");
            string line = Console.ReadLine(); // "50"
            int distance = int.Parse(line); // 50

            double gasoline = distance * 7.02/100;
            double gascost = 1.595;
            double cost = gasoline * gascost;


            Console.WriteLine("Distance: {0}km Consumption: {1}L Cost: {2} Eur", distance, gasoline, cost);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();


        }
    }
}
