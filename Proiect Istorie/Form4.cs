using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect_Istorie
{
    public partial class Form4 : Proiect_Istorie.Form1
    {
        int index=0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            change5();
            pictureBox1.Image = imageList1.Images[0];

        }
        private void label_text()
        {
            if (index == 0)
                label10.Text = "Închisoarea de la Ocnele Mari";
            else
                if (index == 1)
                label10.Text = "Penitenciarul de la Ocnele Mari";
            else
                if (index == 2)
                label10.Text = "Atelierul de tâmplărie- Închisoarea Ocnele Mari";
            else
                if (index == 3)
                label10.Text = "Ocnașii la lucru";
            else
                if (index == 4)
                label10.Text = "Ocnele Mari în anul 1950";
            else
                if (index == 5)
                label10.Text = "Penitenciarul Ocnele Mari în 1911";
            else
                if (index == 6)
                label10.Text = "Penitenciarul de la Ocnele Mari, salina și cazarma- anul 1925";
            else
                label10.Text = "Salina de la Ocnele Mari- 1902";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            index++;
            if (index == 8)
                index = 7;
            if (index == 7)
                button3.Enabled = false;
           
                if (index != 0)
                button2.Enabled = true;
            
            pictureBox1.Image = imageList1.Images[index];
            label_text();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
                index = 0;
            if(index==0)            
                button2.Enabled = false;
            
                if (index != 7)
                button3.Enabled = true;

            pictureBox1.Image = imageList1.Images[index];
            label_text();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            index = 6;
            button2.Enabled = true;
            button3.Enabled = true;
            pictureBox1.Image = pictureBox8.Image;
            label_text();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            index = 0;
            button2.Enabled = false;
            button3.Enabled = true;
            pictureBox1.Image = pictureBox2.Image;
            label_text();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            index = 1;
            button2.Enabled = true;
            button3.Enabled = true;
            pictureBox1.Image = pictureBox3.Image;
            label_text();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            index = 2;
            button2.Enabled = true;
            button3.Enabled = true;
            pictureBox1.Image = pictureBox4.Image;
            label_text();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            index = 3;
            button2.Enabled = true;
            button3.Enabled = true;
            pictureBox1.Image = pictureBox5.Image;
            label_text();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            index = 4;
            button2.Enabled = true;
            button3.Enabled = true;
            pictureBox1.Image = pictureBox6.Image;
            label_text();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            index = 5;
            button2.Enabled = true;
            button3.Enabled = true;
            pictureBox1.Image = pictureBox7.Image;
            label_text();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            index = 7;
            button3.Enabled = false;
            button2.Enabled = true;
            pictureBox1.Image = pictureBox9.Image;
            label_text();
        }
    }
}
