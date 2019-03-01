using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterestCalculator SimpleInterest = new SimpleInterestCalculator();
            decimal interest = SimpleInterest.GetSimpleInterest(1000, 5, 2);
            double numberOfYears = SimpleInterest.GetNumberOfYears(1000, 100, 5);
            decimal principal = SimpleInterest.GetPrincipal(100, 5, 2);
            double rate = SimpleInterest.GetRate(1000, 2, 5);

            Console.WriteLine($"Principal   Interest   Rate   Years\n===================================\n   {principal}    {interest}    {rate}    {numberOfYears}");
            
            Console.ReadKey();
        }
    }
}
