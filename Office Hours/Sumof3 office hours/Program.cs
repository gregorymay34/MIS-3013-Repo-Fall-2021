using System;

namespace Sumof3_office_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double var1;
            var1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter another number");
            double var2;
            var2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter another number");
            double var3;
            var3 = Convert.ToDouble(Console.ReadLine());

            double sum;
            sum = var1 + var2 + var3;

            Console.WriteLine(sum.ToString("N3"));

            const double luckynumber = 7.777;
            Console.WriteLine(luckynumber * sum);


            





        }
    }
}
