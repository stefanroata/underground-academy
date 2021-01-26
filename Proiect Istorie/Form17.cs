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
    public partial class Form17 : Form1
    {
        public Form17()
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
        private void OpenPdf1(string filePath)
        {
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                webBrowser2.Navigate(@filePath);
            }
        }
        private void Form17_Load(object sender, EventArgs e)
        {
            change6();
            OpenPdf(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\Plan2D.pdf");
            OpenPdf1(@"C:\Users\Stefan\Desktop\Proiect Istorie\Proiect Istorie\Resources\despre penitenciar.pdf");
            
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
