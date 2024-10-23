using AM.ApplicationCore.domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtention
        {
        public static void UpperFullName(this Passenger p) {
            p.FirstName = p.FirstName[0].ToString().ToUpper()
                + p.FirstName.Substring(1);
             
        }
    }
}