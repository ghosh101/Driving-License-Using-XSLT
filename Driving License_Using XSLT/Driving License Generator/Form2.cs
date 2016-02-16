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
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string Data1;
            string Data2;
            string Data3;
            string Data4;
            string Data5;
            string Data6;
            string Data7;
            string Data8;
            string Data9;
            string Data10;
            string Data11;
            string Data12;
            string Data13;
            string Data14;
            string Data15;
            string Data16;

            Data1 = TextBox11.Text;
            Data2 = TextBox12.Text;
            Data3 = TextBox7.Text;
            Data4 = TextBox3.Text;
            Data5 = TextBox4.Text;
            Data6 = TextBox5.Text;
            Data7 = TextBox2.Text;
            Data8 = TextBox8.Text;
            Data9 = TextBox6.Text;
            Data10 = TextBox14.Text;
            Data11 = textBox1.Text;
            Data12 = comboBox1.Text;
            Data13 = textBox15.Text;
            Data14 = textBox16.Text;
            Data16 = textBox9.Text;


            if (String.IsNullOrEmpty(textBox9.Text) || String.IsNullOrEmpty(textBox16.Text) || String.IsNullOrEmpty(textBox15.Text) ||
                String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(TextBox14.Text) || String.IsNullOrEmpty(TextBox6.Text) ||
                String.IsNullOrEmpty(TextBox8.Text) || String.IsNullOrEmpty(TextBox2.Text) || String.IsNullOrEmpty(TextBox5.Text) || String.IsNullOrEmpty(TextBox4.Text) ||
                String.IsNullOrEmpty(TextBox3.Text) || String.IsNullOrEmpty(TextBox7.Text) || String.IsNullOrEmpty(TextBox12.Text) || String.IsNullOrEmpty(TextBox11.Text))
            {
                MessageBox.Show("Please don't leave any fields empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(TextBox3.Text.Length < 15)
                {
                    Data4 = TextBox3.Text.PadRight(TextBox3.Text.Length + (15 - TextBox3.Text.Length),' ');
                }
                if (TextBox4.Text.Length < 15)
                {
                    Data5 = TextBox4.Text.PadRight(TextBox4.Text.Length + (15 - TextBox4.Text.Length), ' ');
                }
            string Year = DateTime.Now.Year.ToString();

            Random rnd = new Random();
            int num = rnd.Next(0000000, 9999999);
            string license = "MH03 " + Year + Convert.ToString(num);
            Data15 = license;

            XmlTextWriter text1 = new XmlTextWriter("License.xml", System.Text.Encoding.UTF8);
            text1.WriteStartDocument(true);
            text1.Formatting = Formatting.Indented;
            text1.Indentation = 2;
            text1.WriteStartElement("License");
            Generate(Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8, Data9, Data10, Data11, Data12, Data13, Data14, Data15, Data16, text1);
            text1.WriteEndElement();
            text1.WriteEndDocument();
            text1.Close();

                MessageBox.Show("License #: " + Data15 + " Generated", "License Number Generated", MessageBoxButtons.OK, MessageBoxIcon.None);
                Form3 See = new Form3();
                See.Show();
                this.Visible = false;
            }
        }

        private void Generate(string FullN, string FatherN, string DOB, string Apt, string Street, string City, string PinCode,
        string State, string Country, string IssueDate, string ExpiryDate, string Vehicle, string LMVDate, string DLD, string LicenseNo, string AID, XmlTextWriter Text)
        {
            Text.WriteStartElement("FullName");
            Text.WriteString(FullN);
            Text.WriteEndElement();
            Text.WriteStartElement("FatherName");
            Text.WriteString(FatherN);
            Text.WriteEndElement();
            Text.WriteStartElement("BirthDate");
            Text.WriteString(DOB);
            Text.WriteEndElement();
            Text.WriteStartElement("AptName");
            Text.WriteString(Apt);
            Text.WriteEndElement();
            Text.WriteStartElement("Street");
            Text.WriteString(Street);
            Text.WriteEndElement();
            Text.WriteStartElement("City");
            Text.WriteString(City);
            Text.WriteEndElement();
            Text.WriteStartElement("PinCode");
            Text.WriteString(PinCode);
            Text.WriteEndElement();
            Text.WriteStartElement("State");
            Text.WriteString(State);
            Text.WriteEndElement();
            Text.WriteStartElement("Country");
            Text.WriteString(Country);
            Text.WriteEndElement();
            Text.WriteStartElement("IssueDate");
            Text.WriteString(IssueDate);
            Text.WriteEndElement();
            Text.WriteStartElement("ExpiryDate");
            Text.WriteString(ExpiryDate);
            Text.WriteEndElement();
            Text.WriteStartElement("Vehicle");
            Text.WriteString(Vehicle);
            Text.WriteEndElement();
            Text.WriteStartElement("VehicleDate");
            Text.WriteString(LMVDate);
            Text.WriteEndElement();
            Text.WriteStartElement("DLD");
            Text.WriteString(DLD);
            Text.WriteEndElement();
            Text.WriteStartElement("LicenseNo");
            Text.WriteString(LicenseNo);
            Text.WriteEndElement();
            Text.WriteStartElement("AuthorityID");
            Text.WriteString(AID);
            Text.WriteEndElement();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}


