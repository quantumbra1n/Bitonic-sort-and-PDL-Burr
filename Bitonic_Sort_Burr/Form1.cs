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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Color DARK_BLUE = Color.FromArgb(0, 34, 51);
            Color BRIGHT_BLUE = Color.FromArgb(61, 195, 241);
            ForeColor = BRIGHT_BLUE;
            button_exit0.BackColor = BRIGHT_BLUE;
            button_exit0.ForeColor = DARK_BLUE;
            button_go.BackColor = BRIGHT_BLUE;
            button_go.ForeColor = DARK_BLUE;
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button_exit0_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
