using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesManager : ISweepStakesManager
    {
        //also use factory design pattern here
        //Member Variables
        Stack<int> stack = new Stack<int>();


        //Ctor
        public SweepStakesManager()
        {

        }

        //Methods
        public void PushOnStack()
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
