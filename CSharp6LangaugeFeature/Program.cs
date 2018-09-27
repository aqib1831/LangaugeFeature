using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p = new Point(3.14,2.71);
            //(double X, double Y) = p;
            //Console.WriteLine(X);
            //
            //Out_Variables.NewFunctionality("123");
            //var (_, _, _, pop1, _, pop2) = Discards .QueryCityDataForYears("New York City", 1960, 2010);

            // Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
            Person p = new Person("John", "Quincy", "Adams", "Boston", "MA");

            // <Snippet1>
            // Deconstruct the person object.
            //var (fName, lName, city, _) = p;
            //Console.WriteLine($"Hello {fName} {lName} of {city}!");
            object[] objects = { CultureInfo.CurrentCulture,
                           CultureInfo.CurrentCulture.DateTimeFormat,
                           CultureInfo.CurrentCulture.NumberFormat,
                           new ArgumentException(), null };
            foreach (var obj in objects)
                Person.ProvidesFormatInfo(obj);
            Console.ReadKey();
        }
    }
}
