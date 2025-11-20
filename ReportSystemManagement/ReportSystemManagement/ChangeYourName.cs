using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class ChangeYourName : Form
    {
        private readonly Student_Main_Page studentPage;
        private readonly Admin_Main_Page adminPage;
        private String oldName, newName;

        // ###################################################################################
        // Constructors
        // ###################################################################################
        public ChangeYourName(Student_Main_Page student, String oldName)
        {
            InitializeComponent();
            this.oldName = oldName;
            studentPage = student;
            old_name_text.Text = oldName;
            new_name_text.Text = oldName;
        }

        public ChangeYourName(Admin_Main_Page admin, String oldName)
        {
            InitializeComponent();
            this.oldName = oldName;
            adminPage = admin;
            old_name_text.Text = oldName;
            new_name_text.Text = oldName;
        }

        // ###################################################################################
        // Save & Close Button
        // ###################################################################################
        private void button1_Click(object sender, EventArgs e)
        {
            newName = new_name_text.Text;
            if (String.IsNullOrEmpty(newName)) // If name is empty
            {
                MessageBox.Show("Please enter a new name.", "Incomplete Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (String.Equals(oldName, newName))
            {
                Close();
            } else
            {
                if (studentPage != null)
                {
                    studentPage.UpdateData(newName);
                } else
                {
                    adminPage.UpdateData(newName);
                }
                saveAccount();
                Close();
            }
        }

        // ###################################################################################
        // Supporting Function
        // ###################################################################################
        private void saveAccount()
        {
            // Start Python
            var start = new ProcessStartInfo();
            start.FileName = "py";
            start.Arguments = $"..\\..\\save_account_name.py \"{oldName}\" \"{newName}\"";

            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            using (Process process = Process.Start(start))
            {
                String output = process.StandardOutput.ReadToEnd();
                String error = process.StandardError.ReadToEnd();

                if (!String.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                }
            }
        }
    }
}
