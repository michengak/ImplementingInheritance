using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementinInheritance
{
    class Personnel
    {
        public void Aretrained()
        {
            Console.WriteLine("All soldiers are trained for months");
        }
        public void AreTough()
        {
            Console.WriteLine("Almost all soldiers are very tough, strive for results");
        }

        public virtual void HasDeployed()
        {
            Console.WriteLine("All the soldiers have to deploy when they are needed, is not an option");
        }


            
    }
}
