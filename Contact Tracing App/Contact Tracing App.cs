using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = name_txtbox.Text;
            if (male_chckbx.Checked)
            {
                string gender = "Male";
            }
            else if (female_chckbox.Checked)
            {
                string gender = "Female";
            }
            string age = age_txtbox.Text;
            string address = address_txtbox.Text;
            string cpnumber = cpnumber_txtbox.Text;
            name_txtbox.Text = "";
            male_chckbx.Checked = false;
            female_chckbox.Checked = false;
            age_txtbox.Text = "";
            address_txtbox.Text = "";
            cpnumber_txtbox.Text = "";
        }
    }
}
