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
    public partial class Gruz : Form
    {
        public Gruz()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int T_ID, ID_G, Power, Long, Time, CountR, Summ;
            string TypeT, ClassT, Mark;

            T_ID = Convert.ToUInt16(Column1.ValueType.ToString());
            ID_G = Convert.ToUInt16(Column2.ValueType.ToString());
            Power = Convert.ToUInt16(Column3.ValueType.ToString());
            Long = Convert.ToUInt16(Column4.ValueType.ToString());
            Time = Convert.ToUInt16(Column5.ValueType.ToString());
            CountR = Convert.ToUInt16(Column6.ValueType.ToString());
            Summ = Convert.ToUInt16(Column7.ValueType.ToString());

            TypeT = Column8.ValueType.ToString();
            ClassT = Column9.ValueType.ToString();
            Mark = Column10.ValueType.ToString();
        }
    }
}
