
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<List<double>> numbers = new List<List<double>>();
            int col;
            int row;
            double sum = 0;
            double avg = 0;
            double temp = 0;


            Console.Write("Enter row: ");
            row = int.Parse(Console.ReadLine());


            Console.Write("Enter colum: ");
            col = int.Parse(Console.ReadLine());

            for(int i = 0; i<row; i++)
            {
                List<double> number = new List<double>();

                for(int j = 0; j< col; j++)
                {
                    Console.Write($"Enter Element in row: {i} - colum: {j}: ");
                    temp = double.Parse(Console.ReadLine());

                    number.Add(temp);
                     
                    sum += temp;
                    avg = sum / (col+row);



                }
                numbers.Add(number);
            }

            for(int i =0; i < numbers.Count;i++)
            {
                for(int j =0; j < numbers[i].Count; j++)
                {
                    Console.WriteLine($"Element in row: {i} - colum: {col} {numbers[i][j]}");
                }
            }

            Console.WriteLine($"the sum of all numbers  is: {sum} ");
            Console.WriteLine($"the average is: {avg} ");





            Console.ReadKey();



        }
    }
}
