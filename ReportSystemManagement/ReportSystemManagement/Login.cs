using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class Login_Page : Form
    {
        // ###################################################################################
        // Constructor
        // ###################################################################################
        public Login_Page()
        {
            InitializeComponent();
        }

        // ###################################################################################
        // Main Function
        // ###################################################################################
        private void button1_Click(object sender, EventArgs e)
        {
            var start = new ProcessStartInfo();
            start.FileName = "py";
            start.Arguments = $"..\\..\\login.py {username_input_box.Text} {password_input_box.Text}";

            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            using (Process process = Process.Start(start))
            {
                String output = process.StandardOutput.ReadToEnd();
                String error = process.StandardError.ReadToEnd();

                if (String.IsNullOrEmpty(error))
                {
                    if (String.Equals(output.Substring(0, 5), "Admin"))
                    {
                        Form mainForm = new Admin_Main_Page(username_input_box.Text, password_input_box.Text, output.Substring(5));
                        mainForm.Show();
                        Close();
                    }

                    else if (String.Equals(output.Substring(0, 7), "Student"))
                    {
                        Form mainForm = new Student_Main_Page(username_input_box.Text, password_input_box.Text, output.Substring(7));
                        mainForm.Show();
                        Close();
                    }

                    else
                    {
                        MessageBox.Show("Incorrect username and/or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(error);
                }
            }
        }

        // For opening test account form
        private void test_btn_Click(object sender, EventArgs e)
        {
            new TestAccount().Show();
        }

        // ###################################################################################
        // Window Closing Function
        // ###################################################################################
        private void Login_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if there are any other open forms left.
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
