using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    internal class Program
    { public double CelsiusToFahrenheit(Double Temperature) {
            return (Temperature*9/5)+32;
        }
        public double FahrenheitToCelsius(Double Temperature)
        {
            return (Temperature - 32)*5/9;
        }


        static void Main(string[] args)
        {
            double Temperature, result;
            Program Obj= new Program();
            Console.WriteLine("Enter temperature in Celsius:");
            Temperature = Convert.ToDouble(Console.ReadLine());
            result = Obj.CelsiusToFahrenheit(Temperature);
            Console.WriteLine($"{Temperature} Celsius = {result} Fahrenheit");

            Console.WriteLine("Enter temperature in Fahrenheit:");
            Temperature = Convert.ToDouble(Console.ReadLine());
            result = Obj.FahrenheitToCelsius(Temperature);
            Console.WriteLine($"{Temperature} Fahrenheit = {result} Celsius");
        }
    }
}
