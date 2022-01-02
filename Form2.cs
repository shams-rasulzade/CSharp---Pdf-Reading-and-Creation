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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Pdf_Reading_and_Creation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream("C::Trial.Pdf", FileMode.Create));
            doc.AddAuthor(textBox1.Text);
            doc.AddCreationDate();
            doc.AddCreator(textBox2.Text);
            doc.AddSubject(textBox3.Text);
            //doc.AddKeywords(..);

            if (doc.IsOpen() == false)
            {
                doc.Open();
            }

            doc.Add(new Paragraph(richTextBox1.Text));
            doc.Close();
        }
    }
}
