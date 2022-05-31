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
    public partial class driversView : Form
    {
        public driversView()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brigadir newForm = new Brigadir();
            newForm.Show();
        }

        private void driversChange_Click(object sender, EventArgs e)
        {
            string driverID, BrigID, FIO, Profession, NumberG, Vihecle;
            driverID = ID.ValueType.ToString();
            BrigID = Column1.ValueType.ToString();
            FIO = Column2.ValueType.ToString();
            Profession = Column3.ValueType.ToString();
            NumberG = Column4.ValueType.ToString();
            Vihecle = Column5.ValueType.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
