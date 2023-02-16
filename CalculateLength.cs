using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class CalculateLength
    {
        public void LengthLine()
        {
            Double x1, x2, y1, y2, Line;

            Console.WriteLine("Enter x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            Line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Line Length is {0}", Line);
        }
    }
}
