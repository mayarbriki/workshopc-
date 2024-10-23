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
        public Action<Plane> FlightDetailsDel;
        public Func<string, float> DurationAverageDel;
        public FlightMethods()
        {
            /* FlightDetailsDel = ShowFlightDetails;
             DurationAverageDel = DurationAverage;*/
            FlightDetailsDel = p =>
            {
                var req = from f in Flights
                          where f.Plane == p
                          select new { f.FlightDate, f.Destination };

                foreach (var v in req)
                    Console.WriteLine("flight date" + v.FlightDate + v.Destination);
            };
         
        }

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
            /*  var req = from flight in Flights
                        where flight.Destination == destination
                        select flight.FlightDate;
              return req.ToList();*/
            var reqlambda = Flights
                      .Where( f=> f.Destination == destination)
                      .Select (f=>f.FlightDate);
            return reqlambda.ToList();

        }
        public void ShowFlightDetails(Plane plane)
        {/*
            var req = from f in Flights
                      where f.Plane == plane
                      select new { f.FlightDate, f.Destination };

            foreach (var v in req)
                Console.WriteLine("flight date" + v.FlightDate + v.Destination);
            */
            var req = Flights
                      .Where(f => f.Plane == plane);

            foreach (var v in req)
                Console.WriteLine("flight date" + v.FlightDate + v.Destination);

        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /* var req = from f in Flights
                       where f.FlightDate.CompareTo(startDate) > 0
                       && (f.FlightDate - startDate).TotalDays < 7
                       select f;
             return req.Count();*/
            var req =  Flights
                      .Where (f => f.FlightDate.CompareTo(startDate) > 0
                      && (f.FlightDate - startDate).TotalDays < 7)
                      .Select (f=>f);
            return req.Count();

        }

        public float DurationAverage(string destination)
        {
            var req = from f in Flights
                      where f.Destination == destination
                      select f.EstimatedDuration;
            return req.Average(); 
        }
        public IList<Flight> OrderedDurationFlights()
        { /*var  req = from f in Flights
                     orderby f.EstimatedDuration descending
                     select f;
            return req.ToList();*/
            var req = Flights
      .OrderByDescending(f => f.EstimatedDuration)
      .ToList();

            return req;
        }

        public IList<Passenger> SeniorTravellers(Flight flight)
        {
            /*var req =from p in flight.Passengers
                     where p is Traveller 
                     orderby p.BirthDate ascending
                     select p;
            return req.Take(1).ToList(); */
            var req = flight.Passengers
      .Where(p => p is Traveller)
      .OrderBy(p => p.BirthDate)
      ;

            return req.Take(3).ToList();

        }

        public IList<IGrouping<string, Flight>> DestinationGroupedFlights()
        {/*
            var req = from f in Flights
                      group f by f.Destination;
            foreach (var g in req)
            {
                Console.WriteLine("destination" + g.Key);

                foreach (var f in g)
                    Console.WriteLine("decollage" + f.FlightDate);
            }
            return req.ToList();*/
            var req = Flights
     .GroupBy(f => f.Destination)
     .ToList();

            foreach (var g in req)
            {
                Console.WriteLine("Destination " + g.Key);
                foreach (var f in g)
                {
                    Console.WriteLine("Décollage : " + f.FlightDate);
                }
            }

            return req;



        }


    }
}
