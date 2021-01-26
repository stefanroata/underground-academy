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
    public partial class Form1 : Form
    {
        public PictureBox marire_poza;
        //protected Form9 F9 = new Proiect_Istorie.Form9();
        /*public void marire_full(PictureBox sender,EventArgs e)
        {
            F9.ShowDialog();
            try
            {               
                F9.BackgroundImage=sender.Image;
            }
            catch { }


        }*/
        public void change1()
        {
            label1.BackColor = Color.GreenYellow;
        }
        public void change2()
        {
            label2.BackColor = Color.GreenYellow;
        }
        public void change3()
        {
            label3.BackColor = Color.GreenYellow;
        }
        public void change4()
        {
            label4.BackColor = Color.GreenYellow;
        }
        public void change5()
        {
            label5.BackColor = Color.GreenYellow;
        }
        public void change6()
        {
            label6.BackColor = Color.GreenYellow;
        }
        public void change8()
        {
            label8.BackColor = Color.GreenYellow;
        }
        public void change10()
        {
            label10.BackColor = Color.GreenYellow;
        }
        public void change7()
        {
            label7.BackColor = Color.GreenYellow;
        }
        public void change9()
        {
            label9.BackColor = Color.GreenYellow;
        }
        public Form1()
        {
            
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            PW = Spanel.Width;
            Spanel.Width = 0;
            Hidden = true;

            //end the flickering
        }
        //Form2 F2 = new Form2();
        // Form3 F3 = new Form3();
        int PW;
        bool Hidden;

        public void label4_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            this.Hide();
            F6.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            this.Hide();
            F8.ShowDialog();
            this.Close();
        }

        protected void label7_Click(object sender, EventArgs e)
        {
            Form17 F17 = new Form17();
            this.Hide();
            F17.ShowDialog();
            this.Close();
        }

        protected void label9_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Proiect_Istorie.Form10();
            this.Hide();
            F10.ShowDialog();
            this.Close();
        }
        protected void label8_Click(object sender, EventArgs e)
        {
            Form19 F19 = new Proiect_Istorie.Form19();
            this.Hide();
            F19.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            this.Hide();
            F3.ShowDialog();
            this.Close();
        }
        private Size oldSize;
        private void Form1_Load(object sender, EventArgs e)
        {
            oldSize = base.Size;
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            foreach (Control cnt in this.Controls)
            {
                ResizeAll(cnt, base.Size);
            }
            oldSize = base.Size;
        }
        private void ResizeAll(Control cnt, Size newSize)
        {
            int iWidth = newSize.Width - oldSize.Width;
            cnt.Left += (cnt.Left * iWidth) / oldSize.Width;
            cnt.Width += (cnt.Width * iWidth) / oldSize.Width;

            int iHeight = newSize.Height - oldSize.Height;
            cnt.Top += (cnt.Top * iHeight) / oldSize.Height;
            cnt.Height += (cnt.Height * iHeight) / oldSize.Height;
        }





        private void label2_Click(object sender, EventArgs e)
        {

            Form2 F2 = new Form2();
            this.Hide();
            F2.ShowDialog();
            this.Close();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Hidden)
                button1.Text = "A\nS\nC\nU\nN\nD\nE";
            else
                button1.Text = "M\nE\nN\nI\nU";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                Spanel.Width = Spanel.Width + 20;
                if (Spanel.Width >= PW)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                Spanel.Width = Spanel.Width - 20;
                if (Spanel.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

            Form4 F4 = new Form4();
            this.Hide();
            F4.ShowDialog();
            this.Close();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Form20 F20 = new Form20();
            this.Hide();
            F20.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 F13 = new Form13();
            this.Hide();
            F13.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            this.Hide();
            F5.ShowDialog();
            this.Close();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 11, FontStyle.Bold);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.Name, 11, FontStyle.Bold);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.Name, 11, FontStyle.Bold);

        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font.Name, 11, FontStyle.Bold);

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font.Name, 11, FontStyle.Bold);

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font.Name, 11, FontStyle.Bold);

        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);

        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font.Name, 11, FontStyle.Bold);

        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);

        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font.Name, 11, FontStyle.Bold);

        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);

        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font.Name, 11, FontStyle.Bold);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 F14 = new Form14();
            this.Close();
            F14.ShowDialog();
            this.Hide();
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.Name, 11, FontStyle.Bold | FontStyle.Underline);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.Name, 11, FontStyle.Bold);
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            Form16 F16 = new Proiect_Istorie.Form16();
            this.Hide();
            F16.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form18 F18 = new Proiect_Istorie.Form18();
            this.Hide();
            F18.ShowDialog();
            this.Close();
        }
    }
}
