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
    public partial class Contact_Tracing_App_File_View : Form
    {
        public Contact_Tracing_App_File_View()
        {
            InitializeComponent();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\cruzr\Source\Repos\Contact-Tracing-App\Contact Tracing App\bin\Debug\Contacts.txt";
            StreamReader stream = new StreamReader(path);
            string file = stream.ReadToEnd();
            fileview_box.Text = file.ToString();
            stream.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Tracing_App form1 = new Contact_Tracing_App();
            form1.ShowDialog();
            this.Close();
        }
    }
}
