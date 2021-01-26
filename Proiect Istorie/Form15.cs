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
    public partial class Form15 : Form1
    {
        public Form15()
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
        private void Form15_Load(object sender, EventArgs e)
        {
            button8.BackColor = Color.GreenYellow;
            player_video.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\images\Fisiere video personalitati\A venit aseară mama versuri Vasile Militaru.wmv";
            player_video.Ctlcontrols.stop();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenPdf(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\manoilescu.pdf");
            pictureBox1.Image = imageList1.Images[0];
            panel2.Visible = true;
            panel_poezii.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenPdf(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\tutea.pdf");
            pictureBox1.Image = imageList1.Images[1];
            panel2.Visible = false;
            panel_poezii.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenPdf(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\militaru.pdf");
            pictureBox1.Image = imageList1.Images[2];
            panel_poezii.Visible = true;
            panel2.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenPdf(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\pandrea.pdf");
            pictureBox1.Image = imageList1.Images[3];
            panel2.Visible = false;
            panel_poezii.Visible = false;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            //player_video.fullScreen = true;
            player_video.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\images\Fisiere video personalitati\A venit aseară mama versuri Vasile Militaru.wmv";
            player_video.Ctlcontrols.play();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //player_video.fullScreen = true;
            player_video.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\images\Fisiere video personalitati\Crucea lui Hristos-Vasile Militaru-O poezie ortodoxa sublima.wmv";
            player_video.Ctlcontrols.play();
        }

        private void label13_Click(object sender, EventArgs e)
        {
           // player_video.fullScreen = true;
            player_video.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\images\Fisiere video personalitati\Hristos in gradina Ghetsimani  Autor Vasile Militaru Recita Valeriu Marza.wmv";
            player_video.Ctlcontrols.play();
        }

        private void label14_Click(object sender, EventArgs e)
        {
           // player_video.fullScreen = true;
            player_video.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\images\Fisiere video personalitati\M-am nascut intr-un bordei - Interpretează  Ionut Fulea.wmv";
            player_video.Ctlcontrols.play();
        }

        private void label15_Click(object sender, EventArgs e)
        {
           // player_video.fullScreen = true;
            player_video.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\images\Fisiere video personalitati\POEZIE CREDINŢA ÎN POPOR ! de Vasile Militaru.wmv";
            player_video.Ctlcontrols.play();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //player_video.fullScreen = true;
            player_video.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\images\Fisiere video personalitati\Sfanta Treime- Vasile Militaru- Recita Valeriu Marza.wmv";
            player_video.Ctlcontrols.play();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.versuri-si-creatii.ro/poezii/m/vasile-militaru-6zundcu/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            player_video.Ctlcontrols.stop();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            player_video.Ctlcontrols.pause();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            player_video.fullScreen = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            player_video.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\Manoilescu si dictatul de la Viena.wmv";
            player_video.Ctlcontrols.play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            player_video.fullScreen = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            player_video.Ctlcontrols.stop();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            player_video.Ctlcontrols.pause();
        }
    }
}
