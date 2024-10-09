using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        IList<DateTime> GetFlightDates(string Destination);
       void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        float DurationAverage(string destination);

    }
}
