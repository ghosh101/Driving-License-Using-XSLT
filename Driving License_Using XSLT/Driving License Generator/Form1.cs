using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void EnterData_Click(object sender, EventArgs e)
        {
            Form2 See = new Form2();
            See.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
