using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
   public class Pattern_matching
    {
        public static int DiceSum(IEnumerable<int> values)
        {
            return values.Sum();
        }
        public static int DiceSum2(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                if(item is int val)
                {
                    sum += val;
                }
                else if(item is IEnumerable<object> subList)
                {
                    sum += DiceSum2(subList);
                }
               
            }
            return sum;
        }
        public static int DiceSum3(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case 0:
                        break;
                    case int val:
                        sum += val;
                        break;
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum3(subList);
                        break;
                    case IEnumerable<object> subList:
                        break;
                    case null:
                        break;
                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
            return sum;
          
        }
    }
}
