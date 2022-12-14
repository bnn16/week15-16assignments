using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikingTrip
{
    public class Trip
    {
        public string destination { get; private set; }
        public double distance { get; private set; }
        public double rating { get; private set; }
        public string transport { get; private set; }

        public Trip(string destination, double distance, double rating, string transport = "bike")
        {
            this.destination = destination;
            this.distance = distance;
            this.rating = rating;
            this.transport = transport;
        }
        public override string ToString() 
        {
            return destination + " - " + distance + " km";
        }
    }
}
