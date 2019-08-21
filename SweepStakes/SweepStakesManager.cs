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
        Stack<Contestant> stack = new Stack<Contestant>();


        //Ctor
        public SweepStakesManager()
        {

        }

        //Methods        

      
     

        public void InsertSweepStakes()
        {
            stack.Pop();
        }

  

        public void GetSweepStakes(SweepStakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
