using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
    class Getter_only_Auto_Properties
    {
        public int MyProperty { get; private set; }

        public int MyProperty1 { get;  }
    }
}
