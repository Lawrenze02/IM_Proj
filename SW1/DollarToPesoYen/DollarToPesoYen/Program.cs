using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarToPesoYen
{
    internal class Program
    {

        static (double peso, double yen) converter(double dollar)
            
        {
            double yen = 146.67*dollar;
            double peso = 57.17*dollar;

            return(peso, yen);
        }

        static void Main(string[] args)
        {

            Console.Write("Enter amount in $: ");
            double dollar = double.Parse(Console.ReadLine());

            var (peso,yen) = converter(dollar);
            Console.WriteLine($"{dollar}D={peso}peso {dollar}D={yen}yen ");

            Console.ReadKey();

        }
    }
}
