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
    public partial class PassgeT : Form
    {
        public PassgeT()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
