using System;
using System,Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double miles, kilometers;

      Concole.WriteLine("Miles to Metric Kilometer Converter");
      Concole.WriteLine("================================================");
      Concole.Write("Please input the value of miles to be converted: ");

      // Reading the value
      miles = Convert.ToDouble(Console.Readline());
      // Processing the value and conversion
      kilometer = 1.609344 * miles;
      kilometer = Math.Round(kilometer, 1);

      // Output Value
      Concole.WriteLine($"Original Miles: {miles}");
      Concole.WriteLine($"Converted Value: {kilometer}");
      Concole.Read();
    }
  }
}
