using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BikingTrip
{
    //Made by bogdan
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            destinations = new List<Trip>()
            {
                new Trip("Amsterdam", 121, 4),
                new Trip("Rome", 1532, 4),
                new Trip("Paris", 447, 3.5),
                new Trip("Amsterdam", 121, 4.5),
                new Trip("Paris", 447, 5),
                new Trip("Amsterdam", 121, 2)
            };
            Manager = new TripManager(destinations);
            ShowAllTrips(this, EventArgs.Empty);
        }

        private List<Trip> destinations;
        private TripManager Manager;

        private void AddToTrips(object sender, EventArgs e)
        {
            string destination = TripTo.Text;
            double distance = Convert.ToDouble(DistanceKM.Value);
            double rating = Convert.ToDouble(TripRating.Value);


            if (!String.IsNullOrEmpty(destination) && distance > 0 && Transport.SelectedItem != null)
            {
                Manager.AddTrip(new Trip(destination, distance, rating, Transport.SelectedItem.ToString()));

                MyTrips.Items.Add(Manager.Trips[Manager.Trips.Count - 1]);
                TripTo.Clear();
                DistanceKM.Value = 0m;
                TripRating.Value = 0m;
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        //Working?

        private void DeleteTrip(object sender, EventArgs e)
        {
            if (MyTrips.SelectedIndex > -1)
            {
                Manager.RemoveTrip((Trip)MyTrips.SelectedItem);
            }
        }

        private void SearchBetweenRatings(object sender, EventArgs e)
        {
            if (BetweenR1.Value < BetweenR2.Value)
            {
                MyTrips.Items.Clear();
                foreach (var item in Manager.SearchByRating((double)BetweenR1.Value, (double)BetweenR2.Value))
                {
                    MyTrips.Items.Add(item);
                }
            }
        }

        private void SearchTrip(object sender, EventArgs e)
        {

            MyTrips.Items.Clear();

            string query = Search.Text;
            foreach (var item in Manager.Trips)
            {
                if (item.destination.Contains(query))
                {
                    MyTrips.Items.Add(item);
                }
            }
        }

        private void ShowAllTrips(object sender, EventArgs e)
        {
            MyTrips.Items.Clear();
            foreach (var trip in Manager.Trips)
            {
                MyTrips.Items.Add(trip);
            }
        }
        private void InfoAboutTrip(object sender, EventArgs e)
        {
            if (MyTrips.SelectedIndex > -1)
            {
                Trip tempTrip = (Trip)MyTrips.SelectedItem;
                MessageBox.Show($"{MyTrips.SelectedItem} | rating {tempTrip.rating}/5 using {tempTrip.transport}");
            }
        }
        private void ShowAgg(object sender, EventArgs e)
        {
            Form2 aggregate = new Form2(Manager);
            aggregate.Show();
        }
    }
}
