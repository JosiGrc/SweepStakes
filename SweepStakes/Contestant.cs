using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant : IGetContestantInfo
    {
        //contestants will need to be object with first and last name email address and reg number
        //Variables
        public int registrationNumber;
        public string firstName;
        public string lastName;
        public string email;

        //Ctor
        public Contestant()
        {
            registrationNumber = GetRegistrationNumber();
            firstName = GetFirstName();
            lastName = GetLastName();
            email = GetEmail();

        }

        //Methods
        public string GetFirstName()
        {
            Console.WriteLine("Please enter your First name");
            return Console.ReadLine();
        }
        public string GetLastName()
        {
            Console.WriteLine("Please enter your Last name");
            return Console.ReadLine();
        }
        public string GetEmail()
        {
            Console.WriteLine("Please enter your EMail");
            return Console.ReadLine();
        }
        public int GetRegistrationNumber()
        {
            Console.WriteLine("Please enter a registartion number");
            return int.Parse(Console.ReadLine());
        }
    }
}
