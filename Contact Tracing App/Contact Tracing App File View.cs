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
            string path = @"C:\Users\cruzr\Documents\Visual Studio 2015\Projects\Contact Tracing App\Contact Tracing App\bin\Debug\Contacts.txt";
            StreamReader stream = new StreamReader(path);
            string file = stream.ReadToEnd();
            fileview_box.Text = file.ToString();
            stream.Close();
        }
    }
}
