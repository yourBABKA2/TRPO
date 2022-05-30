using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void showRoutes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routes routes = new Routes();
            routes.Show();
        }

        private void showGarages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Garages garages = new Garages();
            garages.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void driversShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            driversView driversView = new driversView();
            driversView.Show();
        }

        private void mechanicsShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            mechanicsView mechanicsView = new mechanicsView();
            mechanicsView.Show();
        }
    }
}
