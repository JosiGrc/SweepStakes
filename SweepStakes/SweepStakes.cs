using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakes
    {
        //Member Variables
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();

        //Ctor
        public SweepStakes()
        {

        }

        //Methods
        SweepStakes(string name)
        {

        }
        void RegisterContestant(Contestant contestants)//Will ruin the methods to get the contestants info
        {
            
        }
        
        string PickWinner()//pick a random constestant to win (registration number)
        {
            return "random constestant"; 
        }

        void PrintContestantInfo(Contestant contestants)
        {
            Console.WriteLine();
        }



    }
}
