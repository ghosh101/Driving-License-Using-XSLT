using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Driving_License_Generator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                XslCompiledTransform Trans = new XslCompiledTransform();
                XsltSettings Set = new XsltSettings();
                Set.EnableScript = true;
                Trans.Load("dltransform.xsl", Set, null);

                Trans.Transform("License.xml", "YourLicense.html");
                Process.Start("YourLicense.html");
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }    
    }
}

