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
        public int RegistrationNumber;
        private int winnerNumber;
        public int count;
        private int contestantsInSweepStakes;
        //ISweepStakesManager manager;

        //Ctor
        public SweepStakes()
        {
            count = 0;
            RegistrationNumber = 0;
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
                Contestant contestants = new Contestant();
                RegisterContestant(contestants);
                this.contestants.Add(contestants.registrationNumber, contestants);               
                count++;
            }

        }
        public void RegisterContestant(Contestant contestants)
        {
            contestants.firstName = contestants.GetFirstName();
            contestants.lastName = contestants.GetLastName();
            contestants.email = contestants.GetEmail();
            contestants.registrationNumber = RegistrationNumber;           
            RegistrationNumber++;
        }

        string PickWinner()
        {
            Random random = new Random();
            winnerNumber = random.Next(1, contestantsInSweepStakes);

            Contestant winner = contestants[winnerNumber];

            Console.WriteLine("The winner is: " + winner.firstName + winner.lastName + " with the registration number of " + winner.registrationNumber);
            return "Congratulations!";
        }

        void PrintContestantInfo(Contestant contestants)
        {
            Console.WriteLine("Here is their info: " + contestants.firstName + contestants.lastName + contestants.email + contestants.registrationNumber);
        }



    }
}
