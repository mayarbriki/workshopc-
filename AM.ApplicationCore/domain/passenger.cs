using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Passenger
    {
        public FullName FullName { get; set; }
        //public int PassengerId { get; set; }
        [Display(Name = "Date of birht")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        [Key, StringLength(7)]
        public string PassportNumber { get; set; }
        public string? EmailAddress { get; set; }
       
        public string? TelNumber { get; set; }
        [RegularExpression("^@ [0 - 9]{8}$" )]
        public ICollection<Flight> Flights { get; set; }
        public override string ToString() { return "FirstName=" + this.FullName.FirstName + "LastName=" + this.FullName.LastName; }
        public bool CheckProfile(String firstName , string lastName , string email=null)
        {
            if (email != null)
            {
                return this.FullName.FirstName == firstName;
                return this.FullName.LastName == lastName;
                return this.EmailAddress == email;


            }
            else {
                return this.FullName.FirstName == firstName;
                return this.FullName.LastName == lastName;
            }

        }
        public virtual void PassengerType()
        {
            Console.WriteLine("i'm a passenger");
        }


    }
}
