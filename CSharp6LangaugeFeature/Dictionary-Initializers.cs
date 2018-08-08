using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
  public class Dictionary_Initializers
    {
        public void GetDictinory()
        {
            var dictinoryPervious = new Dictionary<string, string>()
            {
                {"LAX", "Los Angeles International Airport"},
                {"vAX", "Los Angeles International Airport" }
            };

            var dictinoryNew = new Dictionary<string, string>()
            {
                ["LAX"]= "Los Angeles International Airport",
                ["vAX"]= "Los Angeles International Airport" 
            };
        }
    }
}
