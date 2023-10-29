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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Color DARK_BLUE = Color.FromArgb(0, 34, 51);
            Color BRIGHT_BLUE = Color.FromArgb(61, 195, 241);
            BackColor = DARK_BLUE;
            ForeColor = BRIGHT_BLUE;
            button1_close.BackColor = BRIGHT_BLUE;
            button1_close.ForeColor = DARK_BLUE;
            groupBox1.ForeColor = BRIGHT_BLUE;
            groupBox2.ForeColor = BRIGHT_BLUE;
        }

        private void button1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
