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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button_Pass_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassgeT passgeT = new PassgeT();
            passgeT.Show();
        }

        private void button_Gruz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gruz gruz = new Gruz();
            gruz.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
