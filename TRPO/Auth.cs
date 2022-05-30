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
        string BrigLogin = "Brig", MasterLogin = "Master", MainLogin = "Main";
        string BrigPassword = "123", MasterPassword = "1234", MainPassword = "12345";

        internal static Brigadir brigadir = new Brigadir();
        internal static Master master = new Master();
        internal static Main main = new Main();

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Auth()
        {
            InitializeComponent();
        }

        private void button_Auth_Click(object sender, EventArgs e)
        {
            login = textBox_Login.Text;
            password = textBox_Password.Text;

            if (login == BrigLogin & password == BrigPassword)
            {
                this.Hide();              
                brigadir.Show();
            }
            else if (login == MasterLogin & password == MasterPassword)
            {
                this.Hide();
                master.Show();
            }
            else if (login == MainLogin & password == MainPassword)
            {
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Ведите корректные данные!!!");
            }
        }
        private void brigadirForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brigadir brigadir = new Brigadir();
            brigadir.Show();
        }
        private void button_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            master.Show();
        }
    }
}
