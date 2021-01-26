using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Istorie
{
    public partial class Form11 : Form1
    {
        public Form11()
        {
            InitializeComponent();
        }

        public int index = 0;
        public void get_index_for_buttons()
        {
            if (index == 0)
            {
                back_button.Enabled = false;
                front_button.Enabled = true;
            }
            if (index == 1)
            {
                back_button.Enabled = true;
                front_button.Enabled = true;
            }
            if (index == 2)
            {
                back_button.Enabled = true;
                front_button.Enabled = true;
            }
            if (index == 3)
            {
                back_button.Enabled = true;
                front_button.Enabled = false;
            }
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            change8();
            index = 0;
            pictureBox1.Image = imageList1.Images[0];
            get_index_for_buttons();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                get_index_for_buttons();
                pictureBox1.Image = imageList1.Images[index];
            }
            else
                get_index_for_buttons();
        }

        private void front_button_Click(object sender, EventArgs e)
        {
            if (index < 3)
            {
                index++;
                get_index_for_buttons();
                pictureBox1.Image = imageList1.Images[index];
            }
            else
                get_index_for_buttons();
        }
    }
}
