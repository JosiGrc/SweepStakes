using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class FactoryDesignPattern
    {
        //Variables
        private ISweepStakesManager manager;

        //Ctor

        //Methods
        public ISweepStakesManager WhichDataStructureIsWanted()
        {
            Console.WriteLine("Which data structure would you like to use, Stack or Queue");
            switch (Console.ReadLine())
            {
                case "Stack":
                    manager = new SweepStakesStackManager();
                    break;
                case "Queue":
                    manager = new SweepStakesQueueManager();
                    break;
                default:
                    Console.WriteLine("That is not a valid data structure");
                    break;

            }
            return manager;
        }
    }
}
