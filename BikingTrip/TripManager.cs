using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikingTrip
{
    public class TripManager
    {
        private List<Trip> trips;

        public TripManager(List<Trip> trips = null)
        {
            this.trips = trips;
        }

        public List<Trip> Trips { get => trips; }
        public void AddTrip(Trip trip) { trips.Add(trip); }
        public void RemoveTrip(Trip trip) { trips.Remove(trip); }
        public string GetInfo(Trip trip) { return trip + $" with rating {trip.rating}"; }
        public List<Trip> SearchByRating(double lowest, double max)
        {
            List<Trip> result = new List<Trip>();
            foreach (var item in trips)
            {
                if (lowest <= item.rating && max >= item.rating)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public double Rating()
        {
            double rating = 0;
            int tripCount = trips.Count();
            foreach (var item in trips)
            {
                rating += item.rating;
            }
            return rating/ tripCount;
        }
    }
}
