using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire;
using Spire.Doc;

namespace DocConverter_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            
            Document doc = new Document();
            
            doc.LoadFromFile(@"C:\test.txt");
            
            doc.SaveToFile("Convert.PDF", FileFormat.PDF);
            doc.SaveToFile("Convert.Doc", FileFormat.Doc);
            doc.SaveToFile("Convert.Docx", FileFormat.Docx);
            doc.SaveToFile("Convert.Xml", FileFormat.Xml);

            System.Diagnostics.Process.Start("Convert.PDF");
            System.Diagnostics.Process.Start("Convert.Doc");
            System.Diagnostics.Process.Start("Convert.Docx");
            System.Diagnostics.Process.Start("Convert.Xml");
        }
    }
}
