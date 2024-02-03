using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Syntax : Statement
    {
        private string type { get; set; }
        private string name { get; set; }
        private string use { get; set; }


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
