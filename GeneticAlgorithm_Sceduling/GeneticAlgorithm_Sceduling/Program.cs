using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm_Sceduling
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneticAlgorithm geneticAlgorithm = new GeneticAlgorithm();

            geneticAlgorithm.Solve();

            Console.ReadLine();
        }
    }
}
