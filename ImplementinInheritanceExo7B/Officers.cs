using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementinInheritance
{
    class Officers : Personnel
    {
        public void ControlEveryBody()
        {
            Console.WriteLine("Officers are the top soldiers, they give directives");
        }
        public void DoMorePaperWorks()
        {
            Console.WriteLine("They spend most of thier time doing paperwork");
        }
        public override void HasDeployed()
        {
            Console.WriteLine("Officers are few and they from the front, they Has to deploy if needed");
        }
    }
}
