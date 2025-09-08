using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool chk = true;

            while (chk == true)
            {
                Console.Write("enter word: ");
                string orig = Console.ReadLine().ToLower();

                string reversed = "";
                

                for (int i = orig.Length - 1; i >= 0; i--)
                {
                    reversed += orig[i];
                }

                
                Console.WriteLine($"Original string   Reversed string        Palindrome");
                Console.WriteLine();
                Console.Write($"     {orig}             {reversed}                 ");
                
                    
                if (orig.Equals(reversed))
                {
                    Console.WriteLine("      Yes");
                    Console.WriteLine();
                }
                
                else
                {
                    Console.WriteLine(" No ");
                    Console.WriteLine();
                }


                 if (orig.Equals("*"))
                {
                    chk = false;
                    Console.WriteLine("program closed");

                }
            }

            Console.ReadKey();
        }
    }
}
