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
        public Details(string type, string name, string use) : base(type, name, use)
        {
          
        }

        private string examples { get; set; }
   
    }
}
