using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pdf_Reading_and_Creation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.Title = "Select PDF file";
            pdf.Filter = "PDF Documnets(*.Pdf)| *.Pdf";
            if (pdf.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = pdf.FileName;
                axAcroPDF1.LoadFile(pdf.FileName);
            }
        }
    }
}
