using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{

    public class Point
    {
        public Point(double x,double y)
        {
            this.X = x;
            this.Y = y;

        }

        public double X { get; }
        public double Y { get; }

        public void Deconstruct(out double x,out double y)
        {
            x = this.X;
            y = this.Y;
        }
    }
   public class Tuples
    {
        
        public void TuplesFunctionality()
        {
            var letters = ("a","b");
            var name = (1, 2,3,4,5,6,7,8,9,10);
            Console.WriteLine(letters.Item1);
            Console.WriteLine(letters.Item2);


            (string Alpha, string Beta) namedletter = ("a", "b");
            Console.WriteLine(namedletter.Alpha);
            Console.WriteLine(namedletter.Beta);

            var alphabetStart = (Alpha :"a", Beta: "b");
            Console.WriteLine(alphabetStart.Alpha);
            Console.WriteLine(alphabetStart.Beta);
        }
        public static (int Max,int Min) Range(IEnumerable<int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var item in numbers)
            {
                min = (item < min) ? item : min;
                max = (item > max) ? item : max;
            }
            return (max, min);
        }
    }
}
