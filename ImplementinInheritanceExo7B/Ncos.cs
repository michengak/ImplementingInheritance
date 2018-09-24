using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementinInheritance
{
     class Ncos : Personnel
     {
           public void Trainedsoldiers()
           {
                Console.WriteLine("Non commisions officers trained soldiers on a daily base");
           }
           public void EvaluatedSoldiers()
           {
                Console.WriteLine("At the end of each, soldiers are evaluated by Ncos");
           }
           public override void HasDeployed()
           {
            Console.WriteLine("Ncos have the choice to deploy or not");
           }


     }
    
}
    