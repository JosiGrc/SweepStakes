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
        Queue<int> queue = new Queue<int>();


        //Ctor
        public SweepStakesQueueManager()
        {
                            
        }

        //Methods
        public void EnqueueOnQueue()
        {

        }
        public SweepStakes GetSweepStake()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepStakes()
        {
            throw new NotImplementedException();
        }
    }
}
