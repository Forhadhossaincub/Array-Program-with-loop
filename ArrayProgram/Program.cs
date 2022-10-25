using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            double[] dNumber = new double[] { 10.0, 20.0, 30.0, 40.0, 50.0 };

            foreach(double d in dNumber)
            {
                Console.Write($"{d} \t");
            }

            Console.ReadKey();
        }
    }
}
