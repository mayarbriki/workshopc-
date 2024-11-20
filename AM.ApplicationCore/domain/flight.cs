using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
namespace AM.ApplicationCore.domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string? Destination { get; set; }
        public string? Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public float EstimatedDuration { get; set; }
        [ForeignKey("MyPlane")]
        public int PlaneId { get; set; }
        [ForeignKey("PlaneId")]

        public Plane Plane { get; set; }

        public ICollection<Passenger> Passengers { get; set; }
        public override string ToString() { return "flight Id=" + this.FlightId + "Durée=" + this.EstimatedDuration ; }
        public string? airlinelogo { get; set; }
    }
}
