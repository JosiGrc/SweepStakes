using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesStackManager : ISweepStakesManager
    {
        //also use factory design pattern here
        //Member Variables
        Stack<Contestant> stack = new Stack<Contestant>();


        //Ctor
        public SweepStakesStackManager()
        {

        }

        //Methods         

        public void InsertSweepStakes()
        {
            stack.Pop();
        }  

        public void GetSweepStakes(SweepStakes sweepstakes)
        {
            stack.Pop();
        }
    }
}
