using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect_Istorie
{
    public partial class Form3 : Proiect_Istorie.Form1
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void OpenPdf(string filePath)
        {
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                webBrowser1.Navigate(@filePath);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            change1();
            radioButton1.Visible = true; label11.Visible = true;
            radioButton2.Visible = true; label12.Visible = true;
            radioButton3.Visible = true; label13.Visible = true;
            radioButton4.Visible = true; label14.Visible = true;
            radioButton5.Visible = true; label15.Visible = true;
            radioButton6.Visible = true; label16.Visible = true;
            //radioButton7.Visible=true;label17.Visible = true;
            radioButton8.Visible = true; label18.Visible = true;
            radioButton9.Visible = true; label19.Visible = true;

        }
        string[] str = { "1837-1838:\nînființarea penitenciarului pentru deținuți politici închiși administrativ ( necondamnați )"
        ,"1890:\n-construirea corpului mare al închisorii\n-adăpostirea deținuților de drept comun condamnați pe viață,care își ispășeau pedeapsa lucrând în salină",
        "1951-1954:\nperioada conducerii locotenentului Dumitru Alexandrescu",
        "1949(martie):\nînchisoarea găzduia acum doar deținuți politici internați administrativ ( ``lagăriști`` ) ",
        "1949( 24 aprilie):\ntransferarea unui lot important de deținuți, printre care: Octavian Tripa, Nicolae Crăcea, Ion Victor Vojen, Petre Țuțea, gen. Dumitru Coroamă, Dumitru ( Tache ) Funda, pr. Ion Dumitrescu-Borșa",
        "1950( 10 iulie - 1 decembrie ):\nconducerea lui Loghin Inochent Păcuraru",
        "1950( 15 noiembrie)- 1953:\nînchisoarea a devenit unitate productivă, cu indicativul Unitatea de Muncă Nr.4 Ocnele Mari, care avea ca obiect prelucrarea lemnului( în închisoare a fost lucrată și tâmplăria pentru Casa Scânteii )",
        "1954:\ndesființarea pedepselor administrative","1964-1965:\ndemolarea penitenciarului"};

        public Graphics drawArea;
        public Pen greenpen = new Pen(Color.Black, 5);
        public Point[] a = { new Point(900, 120), new Point(900, 80), new Point(940, 100) };
        public SolidBrush b = new SolidBrush(Color.Black);
        public void desen()
        {
            drawArea = TimeAxis.CreateGraphics();
            drawArea.DrawLine(greenpen, 50, 100, 900, 100);
            drawArea.DrawPolygon(greenpen, a);
            drawArea.FillPolygon(b, a);
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[0];
            label10.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[1];
            label10.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[2];
            label10.Visible = true;
            OpenPdf(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\Exterminare şi Reeducare la Ocnele Mari.pdf");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[3];
            label10.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[4];
            label10.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[5];
            label10.Visible = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[6];
            label10.Visible = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[7];
            label10.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = str[8];
            label10.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void TimeAxis_Click(object sender, EventArgs e)
        {

        }

        private void TimeAxis_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
