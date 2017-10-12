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
            
            doc.SaveToFile("SavedFiles\\Convert.PDF", FileFormat.PDF);
            doc.SaveToFile("SavedFiles\\Convert.Doc", FileFormat.Doc);
            doc.SaveToFile("SavedFiles\\Convert.Docx", FileFormat.Docx);
            doc.SaveToFile("SavedFiles\\Convert.Xml", FileFormat.Xml);
            doc.SaveToFile("SavedFiles\\Convert.XPS", FileFormat.XPS);
            doc.SaveToFile("SavedFiles\\Convert.Html", FileFormat.Html);


            //to open the saved files
            System.Diagnostics.Process.Start("SavedFiles\\Convert.PDF");
            //System.Diagnostics.Process.Start("SavedFiles\\Convert.Doc");
            //System.Diagnostics.Process.Start("SavedFiles\\Convert.Docx");
            //System.Diagnostics.Process.Start("SavedFiles\\Convert.Xml");
        }
    }
}
