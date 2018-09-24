using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementinInheritance
{
    class Enlisted : Personnel
    { 
        public void DoAnythingTask()
        {
            Console.WriteLine("Soldier below Nco rank are forced to perform all sort of basics tasks");
        }
        public void JustObey()
        {
            Console.WriteLine("Enlisted soldiers can denied a direct order from their leaders");
        }

        public override void HasDeployed()
        {
            Console.WriteLine("Deployed as soon as they leave AIT");
        }
    }
}
