using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.domain;
using Microsoft.EntityFrameworkCore;
namespace AM.Infrastructure
{
    public class AMContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=MayarBrikiDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Traveller> travellers { get; set; }
        public DbSet<Staff> Staff { get; set; }




    }
}
