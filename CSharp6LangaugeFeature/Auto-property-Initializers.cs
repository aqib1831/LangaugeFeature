using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
    // we can directly initialize a property without the need to create a constructor:
    public class Auto_property_Initializers
    {
        public DateTime DateCreated { get; private set; } = DateTime.Now;

        public Collection<Comment> Comments { get; private set; }
           = new Collection<Comment>();
    }

    public class Comment
    {
    }
}
