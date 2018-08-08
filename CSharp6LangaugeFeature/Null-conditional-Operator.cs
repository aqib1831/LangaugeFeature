using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6LangaugeFeature
{
   public class Null_conditional_Operator
    {
        public void NullCondtionFunctionality()
        {
            Title title = null;
            Post post = null;
            if (post != null)
                title = post.Title
        }
    }

    internal class Title
    {
    }
    public class Post
    {
        public string Title { get; set; }
    }
}
