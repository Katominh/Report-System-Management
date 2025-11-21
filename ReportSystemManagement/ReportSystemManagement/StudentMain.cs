using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class Student_Main_Page : Form
    {
        private String user, passwd, userID;
        private String[] yourRecords;
        private String[] delimiter = { "|||" };
        private ProcessStartInfo start = new ProcessStartInfo();

        // ###################################################################################
        // Constructor
        // ###################################################################################
        public Student_Main_Page(String username, String password, String userID)
        {
            InitializeComponent();
            user = username;
            passwd = password;
            this.userID = userID;
            hi_username.Text = "Hi TRU Student!";
            loadRecordTable();
        }

        // ###################################################################################
        // Key Button Functions
        // ###################################################################################

        // Edit Button
        private void edit_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button; // Cast to get its tag ID
            if (btnClicked != null)
            {
                String[] target = findRecordById(btnClicked.Tag.ToString());
                if (target.Length != 0)
                {
                    Form recordForm = new Record(user, passwd, userID, target);
                    recordForm.Show();
                    Close();
                }
            }
        }

        // Delete Button
        private void delete_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            if (btnClicked != null)
            {
                String recordId = btnClicked.Tag.ToString();
                String result = String.Join("|||", findRecordById(recordId));
                if (findRecordById(recordId).Length != 0)
                {
                    start = new ProcessStartInfo("py", $"..\\..\\main.py {3} {result}"); // Choice Mode 3 = Delete the record by record ID
                    processConfig(start);

                    using (Process process = Process.Start(start))
                    {
                        String output = process.StandardOutput.ReadToEnd();
                        String error = process.StandardError.ReadToEnd();

                        if (!String.IsNullOrEmpty(error))
                            MessageBox.Show(error);
                        else
                        {
                            Form loadForm = new Loading(user, passwd, userID);
                            loadForm.Show();
                            Close();
                        }
                    }
                }
            }
        }

        // ###################################################################################
        // Side Bar Button Functions
        // ###################################################################################

        // Create Button
        private void create_btn_Click(object sender, EventArgs e)
        {
            Form recordForm = new Record(user, passwd, userID, getRecordId());
            recordForm.Show();
            Close();
        }

        // Log out button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form login = new Login_Page();
            login.Show();
            Close();
        }

        // ###################################################################################
        // Supporting Functions
        // ###################################################################################
        private void loadRecordTable()
        {
            // Read the student's record(s)
            yourRecords = fetchStudentByID();

            // Redraw table layout
            records_table.Controls.Clear();
            records_table.RowStyles.Clear();
            records_table.RowCount = yourRecords.Length;

            // Set new row
            records_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // 40px for header
            for (int i = 0; i < yourRecords.Length; i++)
                records_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F)); // 65px for height

            // Fill header row
            int colIndex = 0;
            String[] headers = { "Record ID", "Student Name", "Student Number", "Student Email", "Faculty Name", "Term" };
            for (int i = 0; i < 6; i++)
            {
                Label label = new Label();
                label.Text = headers[i];
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;

                records_table.Controls.Add(label, colIndex, 0); // Row 0
                colIndex++;
            }


            // Fill each record
            int rowIndex = 1;
            int[] displayVals = { 0, 1, 2, 3, 4, 9 };
            foreach (String record in yourRecords)
            {
                String[] fields = record.Split(delimiter, StringSplitOptions.None);
                colIndex = 0;

                // Fill each data in a record
                foreach (int i in displayVals)
                {
                    Label label = new Label();
                    label.Text = fields[i];
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Dock = DockStyle.Fill;

                    records_table.Controls.Add(label, colIndex, rowIndex);
                    colIndex++;
                }

                // Delete + edit btn
                FlowLayoutPanel buttonPanel = new FlowLayoutPanel();
                buttonPanel.AutoSize = true;
                buttonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                buttonPanel.Anchor = AnchorStyles.Top;

                Button editBtn = new Button(), delBtn = new Button();
                editBtn.Text = "Edit record";
                editBtn.Tag = fields[0].Trim(); // Associate by RECORD ID
                editBtn.Click += edit_btn_Click;

                delBtn.Text = "Delete record";
                delBtn.Tag = fields[0].Trim();
                delBtn.Click += delete_btn_Click;

                buttonPanel.Controls.Add(editBtn);
                buttonPanel.Controls.Add(delBtn);
                records_table.Controls.Add(buttonPanel, colIndex, rowIndex);
                rowIndex++;
            }
        }

        // This is where I'll get the RECORD id from Python
        private String getRecordId()
        {
            String NOTHING = "X";
            start = new ProcessStartInfo("py", $"..\\..\\main.py {0} {NOTHING}"); // Option 0 = get the generated ID
            processConfig(start);

            using (Process process = Process.Start(start))
            {
                String output = process.StandardOutput.ReadToEnd();
                String error = process.StandardError.ReadToEnd();

                if (String.IsNullOrEmpty(error))
                    return output;
                else
                {
                    MessageBox.Show(error);
                    return "";
                }
            }
        }

        // Get only student's records by STUDENT ID
        private String[] fetchStudentByID()
        {
            // Read all records
            String[] all = File.ReadAllLines("..\\..\\report_records.txt").Skip(1).ToArray();
            List<string> ownerList = new List<string>();

            foreach (String record in all)
            {
                // Filter out student's record
                String[] fields = record.Split(delimiter, StringSplitOptions.None);
                if (fields.Length >= 2)
                {
                    if (String.Equals(userID, fields[fields.Length - 1])) 
                        ownerList.Add(record);
                }
                else if (!string.IsNullOrWhiteSpace(record))
                    MessageBox.Show($"Skipped malformed record: {record}", "Fetch ID Error");
            }
            return ownerList.ToArray();
        }
  
        // Return a record based on record id
        private String[] findRecordById(String id)
        {
            // Linear search
            foreach (String record in yourRecords)
            {
                // Compare RECORD ids
                String[] current = record.Split(delimiter, StringSplitOptions.None);
                if (String.Equals(id, current[0]))
                    return current;
            }

            return new String[] { };
        }

        private void processConfig(ProcessStartInfo start)
        {
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
        }

        // ###################################################################################
        // Window Closing Function
        // ###################################################################################
        private void Student_Main_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if there are any other open forms left.
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
