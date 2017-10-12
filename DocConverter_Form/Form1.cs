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
            //Load Document  
            Document doc = new Document();
            //Pass path of Word Document in LoadFromFile method
            doc.LoadFromFile(@"C:\test.txt");
            //doc.LoadFromFile(@"C:\Users\pseela\Work Folders\Documents\test.txt");
            //Pass Document Name and FileFormat of Document as Parameter in SaveToFile Method  
            doc.SaveToFile("Convert.PDF", FileFormat.PDF);
            //Launch Document  
            System.Diagnostics.Process.Start("Convert.PDF");
        }
    }
}
