using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int score1;
            int score2;
            int score3;
            double average;

            Console.WriteLine("What is your first test score?");
            score1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second test score?");
            score2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your third test score?");
            score3 = Convert.ToInt32(Console.ReadLine());
            var addition = (score1 + score2 + score3);
            average = addition / 3;
            Console.WriteLine("Average score is " + average);
            Console.ReadKey();

            
        }
    }
}
