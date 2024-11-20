using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public enum PlaneType
    {
        Boeing,
        Airbus
    }
    public class Plane
    {

        public int PlaneId { get; set; }
        [Range (0 , int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }
            public override string ToString()  { return "Plane Id=" + this.PlaneId + "capacity=" + this.Capacity;}
        public Plane(PlaneType pt, int capacity ,DateTime date)
        {
            this.PlaneType = pt;
            this.Capacity = capacity;
            this.ManufactureDate = date;
        }
        public ICollection<Flight> Flights { get; set; }
        public Plane()
        {
        }
    }



}
