using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNot
{
    internal class Program
    {

        public static void IsPrime(int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (num <= 1)
                {
                    Console.WriteLine($"{num} is neither prime or composite.");
                }
                else if (num == 2)
                {
                    Console.WriteLine($"{num} is a prime number.");
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is a composite number.");
                }
                else
                {
                    bool isComposite = false;
                    int limit = (int)Math.Sqrt(num);

                    for (int i = 3; i <= limit; i += 2)
                    {
                        if (num % i == 0)
                        {
                            isComposite = true;
                            break;
                        }
                    }

                    if (isComposite)
                    {
                        Console.WriteLine($"{num} is a composite number.");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is a prime number.");
                    }
                }
            }
        }


        static void Main(string[] args)
        {


            Console.Write("Enter numbers seperated by space: ");
            String nums = Console.ReadLine();

            var num = nums.Split(' ');
            int[] numbers = new int[num.Length];
               
         
          for(int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = int.Parse(num[i]);
                Console.WriteLine(numbers[i]);
            }


            IsPrime(numbers);

           







            Console.ReadKey();


        }
    }
}
