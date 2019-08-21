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
        public int regNumber;
        public int count;
        private int contestantsInSweepStakes;

        //Ctor
        public SweepStakes()
        {
            count = 0;
            regNumber = 1;
            contestantsInSweepStakes = 0;
        }

        //Methods
        private int GettigTheNumberOfContestants()
        {
            Console.WriteLine("How many Contestants are going to be oarticipating in this SweepStakes?");
            contestantsInSweepStakes = int.Parse(Console.ReadLine());
            return contestantsInSweepStakes;
        }
        private void SweepStakesMethod()//string name
        {
            for (int i = 0; i < contestantsInSweepStakes; i++)
            {
                Contestant contestants = new contestant();
                RegisterContestant(Contestant contestants);
            }

        }
        public void RegisterContestant(Contestant contestants)
        {
            contestants.firstName = contestants.GetFirstName();
            contestants.lastName = contestants.GetLastName();
            contestants.email = contestants.GetEmail();
            contestants.registrationNumber = regNumber;
            regNumber++;
        }

        string PickWinner()
        {
            return "random constestant"; 
        }

        void PrintContestantInfo(Contestant contestants)
        {
            Console.WriteLine("Here is their info: " + contestants.firstName + contestants.lastName + contestants.email + contestants.registrationNumber);
        }



    }
}
