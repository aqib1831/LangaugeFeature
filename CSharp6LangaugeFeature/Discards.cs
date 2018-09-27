using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Person(string fname, string mname, string lname,
                 string cityName, string stateName)
        {
            FirstName = fname;
            MiddleName = mname;
            LastName = lname;
            City = cityName;
            State = stateName;
        }
        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string lname,
                                out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }
        public static void ProvidesFormatInfo(object obj)
        {
            if (obj is IFormatProvider fmt)
                Console.WriteLine($"{fmt} object");
            else if (obj is null)
            {
                Console.Write("A null object reference: ");
                Console.WriteLine("Its use could result in a NullReferenceException");
            }
            else if (obj is var _)
                Console.WriteLine($"Some object type without format information");
        }
    }
   public class Discards
    {
        public static (string,double,int,int,int,int) QueryCityDataForYears(string name,int year1,int year2)
        {
            int population1 = 0, population2 = 0;
            double area = 0;
            if (name == "New York City")
            {
                area = 46.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }
            return ("", 0, 0, 0, 0, 0);
        }
    }
}
