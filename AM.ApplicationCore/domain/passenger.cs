using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString() { return "FirstName=" + this.FirstName + "LastName=" + this.LastName; }
        public bool CheckProfile(String firstName , string lastName , string email=null)
        {
            if (email != null)
            {
                return this.FirstName == firstName;
                return this.LastName == lastName;
                return this.EmailAddress == email;


            }
            else {
                return this.FirstName == firstName;
                return this.LastName == lastName;
            }

        }
        public virtual void PassengerType()
        {
            Console.WriteLine("i'm a passenger");
        }


    }
}
