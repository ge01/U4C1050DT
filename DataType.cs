using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4C1050DT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Type Delimiters and Suffixes

            // string data type
            var message = "Hello World!";

            // char data type
            var letter = "A";

            // decimal data type
            var price = 34.55m;

            // double data type
            var totalGrainsOfSandOnEarth = 5d;

            // float data type
            var weightOfPlanetEarth = 5f;

            // int data type
            var unitsInStock = 7;

            // long data type
            var countOfStars = 8978979893432434234;

            Console.WriteLine(price);

            // Converting Anything to a String
            var krogerPrice = 23.44m;

            Console.WriteLine(krogerPrice);

            var krogerMessage = "It costs " + krogerPrice.ToString() + " dollars";

            Console.WriteLine(krogerMessage);

            var krogerMessage1 = "It costs " + krogerPrice.ToString("c") + " dollars";

            Console.WriteLine(krogerMessage1);



            Console.ReadLine();


        }
    }
}
