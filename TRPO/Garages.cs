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
    public partial class Garages : Form
    {
        public Garages()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master newForm = new Master();
            newForm.Show();
        }
    }
}
