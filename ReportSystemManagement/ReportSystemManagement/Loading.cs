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
        public Loading(String username, String password, String name)
        {
            InitializeComponent();
            this.user = username;
            this.passwd = password;
            this.name = name;
        }

        private async void Loading_Load(object sender, EventArgs e)
        {

            progressBar1.Value = 0;

            for (int i = 0; i <= 100; i+=3)
            {
                progressBar1.Value = i;
                await Task.Delay(1);
            }

            // Move progress to 100%
            progressBar1.Value = 100;

            MessageBox.Show(user);

            if (String.Equals(user.Substring(0,5), "admin"))
            {
                //MessageBox.Show("You are logged in as ADMIN", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form mainForm = new Admin_Main_Page(user, passwd, name);
                mainForm.Show();
                this.Hide();
            }

            else if (String.Equals(user.Substring(0, 7), "student"))
            {
                //MessageBox.Show("You are logged in as STUDENT", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form mainForm = new Student_Main_Page(user, passwd, name);
                mainForm.Show();
                this.Hide();
            }
            
            
        }
    }
}
