using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod3_1302213111
{
    public partial class Form1 : Form
    {
        int bil1;
        int bil2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button1.Text;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "" + button10.Text;
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if(bil1 == 0)
            {
                bil1 = int.Parse(output.Text);
            }
            output.Text = "";
        }


        private void btnhasil_Click(object sender, EventArgs e)
        {
            if (bil2 == 0)
            {
                bil2 = int.Parse(output.Text);
            }
            output.Text = "" + (bil1 + bil2);
            bil1 = bil1 + bil2;
            bil2 = 0;
        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
}
