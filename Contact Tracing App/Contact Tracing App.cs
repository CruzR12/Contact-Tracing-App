using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void male_chckbx_CheckedChanged(object sender, EventArgs e)
        {
            string gender = "Male";
            female_chckbx.Enabled = false;
            if (male_chckbx.Checked == false)
            {
                female_chckbx.Enabled = true;
                gender = "";
            }
        }

        private void female_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            string gender = "Female";
            male_chckbx.Enabled = false;
            if (female_chckbx.Checked == false)
            {
                male_chckbx.Enabled = true;
                gender = "";
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("Contacts.txt");
            outputFile.WriteLine("Contact");

            string name = name_txtbox.Text;
            if (male_chckbx.Checked)
            {
                string gender = "Male";
                string age = age_txtbox.Text;
                string address = address_txtbox.Text;
                string cpnumber = cpnumber_txtbox.Text;

                outputFile.WriteLine("-" + name);
                outputFile.WriteLine("-" + gender);
                outputFile.WriteLine("-" + age);
                outputFile.WriteLine("-" + address);
                outputFile.WriteLine("-" + cpnumber);
                outputFile.WriteLine("");
            }
            else if (female_chckbx.Checked)
            {
                string gender = "Female";
                string age = age_txtbox.Text;
                string address = address_txtbox.Text;
                string cpnumber = cpnumber_txtbox.Text;

                outputFile.WriteLine("-" + name);
                outputFile.WriteLine("-" + gender);
                outputFile.WriteLine("-" + age);
                outputFile.WriteLine("-" + address);
                outputFile.WriteLine("-" + cpnumber);
                outputFile.WriteLine("");
            }

            outputFile.Close();
            name_txtbox.Text = "";
            male_chckbx.Checked = false;
            female_chckbx.Checked = false;
            age_txtbox.Text = "";
            address_txtbox.Text = "";
            cpnumber_txtbox.Text = "";
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
