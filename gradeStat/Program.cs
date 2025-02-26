using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeStat
{
    class Program
    {
        static void Main(string[] args)
        {
            // input grades in a class until -1 is entered, the compute the class average

            int grade;
            float sum = 0;
            int count = 0;

            do
            {
                Console.Write("Enter a grade: ");
                grade = int.Parse(Console.ReadLine());

                if (grade > 0)
                {
                    sum += grade;
                    count++;
                }

            } 
            while (grade != -1);


            Console.WriteLine($"class average = {sum/count}");




        }
    }
}
