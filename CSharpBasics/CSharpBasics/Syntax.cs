using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Syntax : Statement
    {
        public string type { get; set; }
        public string name { get; set; }
        public string use { get; set; }


        public Syntax(string type, string name, string use)
        {
            this.type = type;
            this.name = name;
            this.use = use;
        } 

        public override void display()
        {
           
            Console.WriteLine();
        }
    }
}
