using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryDesignPattern factorydesignpattern = new FactoryDesignPattern();
            WhichDataStructureIsWanted();
            Console.ReadLine();
        }
    }
}
