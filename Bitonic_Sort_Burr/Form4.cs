using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitonicSortBurr
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Color DARK_BLUE = Color.FromArgb(0, 34, 51);
            Color BRIGHT_BLUE = Color.FromArgb(61, 195, 241);
            BackColor = DARK_BLUE;
            ForeColor = BRIGHT_BLUE;
            button2_close.BackColor = BRIGHT_BLUE;
            button2_close.ForeColor = DARK_BLUE;
            groupBox1.ForeColor = BRIGHT_BLUE;
            groupBox2.ForeColor = BRIGHT_BLUE;
            groupBox3.ForeColor = BRIGHT_BLUE;
            groupBox4.ForeColor = BRIGHT_BLUE;
            groupBox5.ForeColor = BRIGHT_BLUE;
            groupBox6.ForeColor = BRIGHT_BLUE;
            groupBox7.ForeColor = BRIGHT_BLUE;
            groupBox8.ForeColor = BRIGHT_BLUE;
            groupBox9.ForeColor = BRIGHT_BLUE;
            groupBox10.ForeColor = BRIGHT_BLUE;
        }

        private void button2_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
