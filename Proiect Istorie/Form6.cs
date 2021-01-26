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
    public partial class Form6 : Proiect_Istorie.Form1
    {
        public Form6()
        {
            InitializeComponent();
            change3();
        }
       
        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label11.Visible = true;
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label11.Visible = true;
            pictureBox1.Image = imageList1.Images[2];
            pictureBox2.Image = imageList1.Images[3];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label11.Visible = true;
            pictureBox1.Image = imageList1.Images[5];
            pictureBox2.Image = imageList1.Images[4];
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label11.Visible = true;
            pictureBox1.Image = imageList1.Images[6];
            pictureBox2.Image = imageList1.Images[7];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button7.BackColor = Color.GreenYellow;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {

        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

       

        private void button15_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label13.Visible = true;
            pictureBox3.Image = imageList2.Images[0];
            pictureBox4.Image = imageList2.Images[1];
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label13.Visible = true;
            pictureBox3.Image = imageList2.Images[2];
            pictureBox4.Image = imageList2.Images[3];
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label13.Visible = true;
            pictureBox3.Image = imageList2.Images[4];
            pictureBox4.Image = imageList2.Images[5];
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label13.Visible = true;
            pictureBox3.Image = imageList2.Images[6];
            pictureBox4.Image = imageList2.Images[7];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Proiect_Istorie.Form7();
            this.Hide();
            F7.ShowDialog();
            this.Show();
        }
    }
}
