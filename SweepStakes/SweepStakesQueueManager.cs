using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesQueueManager : ISweepStakesManager
    {
        //use factory design pattern here
        //Member Variables
        Queue<Contestant> queue = new Queue<Contestant>();


        //Ctor
        public SweepStakesQueueManager()
        {
                            
        }

        //Methods
        public void InsertSweepStakes()
        {
            //queue.Enqueue();
        }
        public void GetSweepStakes(SweepStakes sweepstakes)
        {
            queue.Dequeue();
        }

       
    }
}
