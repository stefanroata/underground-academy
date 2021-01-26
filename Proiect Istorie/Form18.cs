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
    public partial class Form18 : Form1
    {
        public Form18()
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

        private void Form18_Load(object sender, EventArgs e)
        {
            OpenPdf(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\bibliografie selectiva.pdf");
        }
    }
}
