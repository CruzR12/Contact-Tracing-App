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
    public partial class Contact_Tracing_App : Form
    {
        public Contact_Tracing_App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            time_label.Text = DateTime.Now.ToLongTimeString();
            date_label.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToLongTimeString();
            date_label.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void male_chckbx_CheckedChanged(object sender, EventArgs e)
        {
            female_chckbx.Enabled = false;
            if (male_chckbx.Checked == false)
            {
                female_chckbx.Enabled = true;
            }
        }

        private void female_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            male_chckbx.Enabled = false;
            if (female_chckbx.Checked == false)
            {
                male_chckbx.Enabled = true;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (name_txtbox.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }
            else if (male_chckbx.Checked == false && female_chckbx.Checked == false)
            {
                MessageBox.Show("Please enter your gender");
            }
            else if (age_txtbox.Text == "")
            {
                MessageBox.Show("Please enter your age");
            }
            else if (address_txtbox.Text == "")
            {
                MessageBox.Show("Please enter your address");
            }
            else if (cpnumber_txtbox.Text == "")
            {
                MessageBox.Show("Please enter your phone number");
            }
            else
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("Contacts.txt");
                outputFile.WriteLine("Contact");
                outputFile.WriteLine(DateTime.Now.ToLongDateString());
                outputFile.WriteLine(DateTime.Now.ToLongTimeString());

                string name = name_txtbox.Text;
                if (male_chckbx.Checked)
                {
                    string sex = "Male";
                    string age = age_txtbox.Text;
                    string address = address_txtbox.Text;
                    string cpnumber = cpnumber_txtbox.Text;

                    outputFile.WriteLine("Name:    " + name);
                    outputFile.WriteLine("Sex:  " + sex);
                    outputFile.WriteLine("Age:      " + age);
                    outputFile.WriteLine("Address: " + address);
                    outputFile.WriteLine("Number:  " + cpnumber);
                    outputFile.WriteLine("");
                }
                else if (female_chckbx.Checked)
                {
                    string sex = "Female";
                    string age = age_txtbox.Text;
                    string address = address_txtbox.Text;
                    string cpnumber = cpnumber_txtbox.Text;

                    outputFile.WriteLine("- " + name);
                    outputFile.WriteLine("- " + sex);
                    outputFile.WriteLine("- " + age);
                    outputFile.WriteLine("- " + address);
                    outputFile.WriteLine("- " + cpnumber);
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
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Tracing_App_File_View form2 = new Contact_Tracing_App_File_View();
            form2.ShowDialog();
            this.Close();
        }

        private void age_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch) && !Char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void cpnumber_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch) && !Char.IsControl(ch))
            {
                e.Handled = true;
            }
        }
    }
}
