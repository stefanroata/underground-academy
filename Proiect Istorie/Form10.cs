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
    public partial class Form10 : Form1
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            change8();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.GreenYellow;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\Locul unde a fost penitenciarul Ocnele Mari.wmv";
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Form11 F11 = new Proiect_Istorie.Form11();
            this.Hide();
            F11.ShowDialog();
            this.Show();
            //button7_Click(button7, null);
        }
    }
}
