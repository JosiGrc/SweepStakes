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
            ISweepStakesManager manager = FactoryDesignPattern.WhichDataStructureIsWanted();
            MarketingFirm marketingfirm = new MarketingFirm (manager);

            Console.ReadLine();
        }
    }
}
