// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.domain;
using AM.ApplicationCore.Services;
using AM.ApplicationCore.Interfaces;

Console.WriteLine("Hello, World!");
Plane plane1 = new Plane();
plane1.Capacity = 200;
plane1.PlaneId = 1;
plane1.ManufactureDate = new DateTime(2024, 09, 18);
plane1.PlaneType = PlaneType.Boeing;
Console.WriteLine(plane1.ToString());
Plane plane2 = new Plane(PlaneType.Airbus,300,new DateTime(2024,09,19));
Passenger passenger = new Passenger
{
    FirstName = "mayar",
    LastName = "briki",
    EmailAddress="test"


};     
Console.WriteLine(passenger.CheckProfile("mayar","briki" , "test"));
Staff staff = new Staff();
Traveller traveller = new Traveller();
staff.PassengerType();
traveller.PassengerType();
FlightMethods flightMethods = new FlightMethods()
{
    Flights = TestData.listFlights
};
foreach (var item in flightMethods.GetFlightDates("Madrid"))
        {
    Console.WriteLine(item);
}
flightMethods.GetFlights("Destination ", "Paris");
flightMethods.ShowFlightDetails(TestData.BoingPlane);
Console.WriteLine(flightMethods.ProgrammedFlightNumber(new DateTime(2022, 02, 01)));
Console.WriteLine(flightMethods.DurationAverage("Paris"));

foreach (var item in flightMethods.OrderedDurationFlights())  { Console.WriteLine(item); }
foreach (var item in flightMethods.SeniorTravellers(TestData.flight1)) { Console.WriteLine(item); }
flightMethods.DestinationGroupedFlights();
flightMethods.FlightDetailsDel(TestData.BoingPlane);