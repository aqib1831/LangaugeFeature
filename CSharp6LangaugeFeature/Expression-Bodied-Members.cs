using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
    class Expression_Bodied_Members
    {
        public DateTime DateCreated { get; private set; } = DateTime.Now;

        public Double DaysOld()
        {
            return (DateCreated - DateTime.Today).TotalDays;
        }
        public Double DayOlds=> (DateCreated - DateTime.Today).TotalDays;
    }
}

