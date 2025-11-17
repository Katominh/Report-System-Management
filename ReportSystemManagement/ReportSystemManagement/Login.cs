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
        public Login_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var start = new ProcessStartInfo();
            start.FileName = @"C:\Program Files\Python310\python.exe";
            start.Arguments = $"login.py {username_input_box.Text} {password_input_box.Text}";

            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            using (Process process = Process.Start(start))
            {
                String output = process.StandardOutput.ReadToEnd();
                String error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    if (String.Equals(output, "Admin"))
                    {
                        Form mainForm = new Main_Page();
                        mainForm.Show();
                    }

                    else if (String.Equals(output, "Student"))
                    {
                        MessageBox.Show("You are logged in as STUDENT", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form mainForm = new Main_Page();
                        mainForm.Show();
                    }

                    else
                    {
                        MessageBox.Show("Incorrect username and/or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show(output);
                        MessageBox.Show(error);
                    }
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
