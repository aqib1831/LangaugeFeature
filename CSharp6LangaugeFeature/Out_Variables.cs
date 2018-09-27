using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
   public class Out_Variables
    {
        public static void PerviousFunctionality(string input)
        {
            int Number;
            if(int.TryParse(input,out Number))
            {
                Console.WriteLine(Number);
            }
            else
            {
                Console.WriteLine("Could not parse input");
            }
            Console.ReadKey();
        }
        public static  void NewFunctionality(string input) {
            if(int.TryParse(input,out int Number))
            {
                Console.WriteLine(Number);
            }
            else
            {
                Console.WriteLine("Could not parse input");
            }
            ///
            if (int.TryParse(input, out var NumberImplicit))
            {
                Console.WriteLine(NumberImplicit);
            }
            else
            {
                Console.WriteLine("Could not parse input");
            }
            Console.ReadKey();
        }
    }
}
