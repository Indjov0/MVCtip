using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtip.View
{
    internal class Display
    {
        public double Amount { get; private set; }
        public double Percent { get; private set; }

        public void Input()
        {
            Console.WriteLine("Enter the amount of the meal:");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent you want tip to tip:");
            Percent = double.Parse(Console.ReadLine());
        }
        public void Output()
        {

        }
    }
}
