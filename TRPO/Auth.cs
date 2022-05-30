using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TRPO
{
    public partial class Auth : Form
    {
        string password, login;
        string BrigPassword = "123", MasterPassword = "1234", MainPassword = "12345";

        private void brigadirForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brigadir brigadir = new Brigadir();
            brigadir.Show();
        }

        string BrigLogin = "Brig", MasterLogin = "Master", MainLogin = "Main";
        public Auth()
        {
            InitializeComponent();
        }
    }
}
