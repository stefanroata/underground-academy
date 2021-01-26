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
    public partial class Form12 : Form1
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            change4();
            button14.BackColor = Color.GreenYellow;
            label10.Visible = true;
            button7.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\Recurs la istorie Ororile de la penitenciarul Ocnele Mari (II).mp4";
            // axWindowsMediaPlayer1.Ctlcontrols.stop();
            button9_Click(button9, null);
        }


        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.DialogResult = DialogResult.OK;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }

        private void button8_Click(object sender, EventArgs e)
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
    }
}
