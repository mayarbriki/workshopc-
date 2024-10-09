using AM.ApplicationCore.domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight> { };
        /*
        public IList<DateTime> GetFlightDates(string destination)
        {
            IList<DateTime> result = new List<DateTime> { };

            foreach (Flight f in Flights)
            {
                if (f.Destination.Equals(destination))

                { result.Add(f.FlightDate); }

            }  
            
            return result;
        }*/

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == filterValue)
                        {
                            Console.WriteLine(f);

                        }
                    }
                    break;
                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate == DateTime.Parse(filterValue))
                            Console.WriteLine(f);
                    }
                    break;
                case "FlightId":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightId == int.Parse(filterValue))
                            Console.WriteLine(f);
                    }
                    break;
            }


        }
        public IList<DateTime> GetFlightDates(string destination)
        {
            var req = from flight in Flights
                      where flight.Destination == destination
                      select flight.FlightDate;
            return req.ToList();
        }
        public void ShowFlightDetails(Plane plane)
        {
            var req = from f in Flights
                      where f.Plane == plane
                      select new { f.FlightDate, f.Destination };

            foreach (var v in req)
                Console.WriteLine("flight date" + v.FlightDate + v.Destination);
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var req = from f in Flights
                      where f.FlightDate.CompareTo(startDate) > 0
                      && (f.FlightDate - startDate).TotalDays < 7
                      select f;
            return req.Count();
        }

        public float DurationAverage(string destination)
        {
            var req = from f in Flights
                      where f.Destination == destination
                      select f.EstimatedDuration;
            return req.Average(); 
        }
    }
}
