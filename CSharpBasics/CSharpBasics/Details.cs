using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpBasics
{
    class Details : Syntax
    {
        internal bool example;

        public string examples { get; set; }
        public Details(string type, string name, string use, string example) : base(type, name, use)
        {
          
        }

       
   
    }
}
