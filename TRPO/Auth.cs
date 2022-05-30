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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void brigadirForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brigadir newForm = new Brigadir();
            newForm.Show();
        }
    }
}
