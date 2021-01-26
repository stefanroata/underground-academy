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
    public partial class Form19 : Form1
    {
        public Form19()
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
        private void Form19_Load(object sender, EventArgs e)
        {
            change7();
            OpenPdf(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\decedaţi Ocnele Mari.pdf");
        }
    }
}
