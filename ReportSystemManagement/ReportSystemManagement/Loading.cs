using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class Loading : Form
    {
        private String user, passwd, name;

        // ###################################################################################
        // Constructor
        // ###################################################################################
        public Loading(String username, String password, String name)
        {
            InitializeComponent();
            user = username;
            passwd = password;
            this.name = name;
        }

        // ###################################################################################
        // Async Loading Bar Function
        // ###################################################################################
        private async void Loading_Load(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            for (int i = 0; i <= 100; i+=5)
            {
                progressBar1.Value = i;
                await Task.Delay(1);
            }

            // Move progress to 100%
            progressBar1.Value = 100;

            // Go back to Main Page
            if (String.Equals(user.Substring(0,5), "admin"))
            {
                Form mainForm = new Admin_Main_Page(user, passwd, name);
                mainForm.Show();
                Close();
            }

            else if (String.Equals(user.Substring(0, 7), "student"))
            {
                Form mainForm = new Student_Main_Page(user, passwd, name);
                mainForm.Show();
                Close();
            }
            
            
        }
    }
}
