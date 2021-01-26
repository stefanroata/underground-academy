using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Proiect_Istorie
{
    public partial class Form8 : Proiect_Istorie.Form1
    {
        public Form8()
        {
            InitializeComponent();
        }

        
    
     
    private void Form8_Load(object sender, EventArgs e)
        {
            change4();

            axWindowsMediaPlayer1.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\ocne_audio1.mp3";
            axWindowsMediaPlayer2.URL=@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\ocne_audio2.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            button13.BackColor = Color.GreenYellow;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            Form12 F12 = new Proiect_Istorie.Form12();
            this.Hide();
            F12.ShowDialog();
            this.Show();
        }
    }
}
