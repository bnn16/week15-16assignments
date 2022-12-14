using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikingTrip
{
    public partial class Form2 : Form
    {
        TripManager tripManager;
        public Form2(TripManager tripManager)
        {
            InitializeComponent();
            this.tripManager = tripManager;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in tripManager.Trips)
            {
                ListOfTrips.Items.Add($"{item} | rating {item.rating}/5 using {item.transport}");
            }
            AvgRatingOfTrips.Text = Math.Round(tripManager.Rating(), 2).ToString();
        }
    }
}
