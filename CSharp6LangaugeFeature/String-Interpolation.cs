using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
  public  class String_Interpolation
    {

        public void StringInterpolation()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Value of A ={0} and Value of B ={1}",a,b);

            // new Functionality
            Console.WriteLine($"Value of A={a} and Value of B={b}");
        }
    }
}
