using System;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int RANDOM = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 1);
            if (empCheck == RANDOM)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
