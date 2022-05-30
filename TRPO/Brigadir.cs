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
    public partial class Brigadir : Form
    {
        public Brigadir()
        {
            InitializeComponent();
        }

        private void driversPersonel_Click(object sender, EventArgs e)
        {
            this.Hide();
            driversView newForm  = new driversView();
            newForm.Show();
        }

        private void mechanicsPersonel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mechanicsView mechanicsView = new mechanicsView();
            mechanicsView.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
