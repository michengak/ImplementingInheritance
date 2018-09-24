using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementinInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTypePersonnel();
           
            SecondTypePersonnel();

            ThirdTypePersonnel();

        }
        public static void FirstTypePersonnel()
        {
           

            Enlisted newSoldiers = new Enlisted();

            Console.WriteLine("A military Unit is very rigid pyramid, the following is a sample structure");

            newSoldiers.Aretrained();
            newSoldiers.AreTough();
            newSoldiers.AreTough();
            newSoldiers.DoAnythingTask();
            newSoldiers.JustObey();
            newSoldiers.HasDeployed();

            Console.WriteLine("\n");
        }
        public static void SecondTypePersonnel()
        {

            Ncos managers = new Ncos();

            managers.Aretrained();
            managers.AreTough();
            managers.EvaluatedSoldiers();
            managers.Trainedsoldiers();
            managers.HasDeployed();

            Console.WriteLine("\n\t");

        }
        public static void ThirdTypePersonnel()
        {
            Officers LT = new Officers();

            LT.AreTough();
            LT.Aretrained();
            LT.ControlEveryBody();
            LT.DoMorePaperWorks();
            LT.HasDeployed();

        }
    }
   

}

