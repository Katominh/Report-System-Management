using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class Student_Main_Page : Form
    {
        private static String NOTHING = "X", PYTHON_EXE_FILE = "py";
        private String user, passwd, name;
        private String[] yourRecords;
        private String[] delimiter = { "|||" };
        private ProcessStartInfo start = new ProcessStartInfo();

        public Student_Main_Page(String username, String password, String name)
        {
            InitializeComponent();
            user = username;
            passwd = password;
            this.name = name;
            hi_username.Text = "Hi " + name + "!";
            loadRecordTable();
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }

        private void loadRecordTable()
        {
            // Read the student's record(s)
            yourRecords = fetchStudentByName();

            // Redraw table layout
            records_table.Controls.Clear();
            records_table.RowStyles.Clear();
            records_table.RowCount = yourRecords.Length;

            // Set new row
            records_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // 40px for header
            for (int i = 0; i < yourRecords.Length; i++)
            {
                records_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F)); // 65px for height
            }

            // Fill header row
            int colIndex = 0;
            String[] headers = { "Record ID", "Student Name", "Student Number", "Student Email", "Faculty Name", "Term" };
            for (int i = 0; i < 6; i++)
            {
                Label label = new Label();
                label.Text = headers[i];
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;

                records_table.Controls.Add(label, colIndex, 0);
                colIndex++;
            }


            // Fill each record
            int rowIndex = 1;
            int[] displayVals = { 0, 1, 2, 3, 4, 9 };
            foreach (String record in yourRecords)
            {
                String[] fields = record.Split(delimiter, StringSplitOptions.None);
                if (String.Equals(fields[1], name))
                {
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
                    editBtn.Tag = fields[0].Trim(); // Associate by ID
                    editBtn.Click += edit_btn_Click;

                    delBtn.Text = "Delete record";
                    delBtn.Tag = fields[0].Trim();
                    delBtn.Click += delete_btn_Click;

                    buttonPanel.Controls.Add(editBtn);
                    buttonPanel.Controls.Add(delBtn);
                    records_table.Controls.Add(buttonPanel, colIndex, rowIndex);
                }
                rowIndex++;
            }
        }

        // Editing a record
        private void edit_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            if (btnClicked != null)
            {
                string recordId = btnClicked.Tag.ToString();
                String[] target = findRecordById(recordId);
                if (target.Length != 0)
                {
                    Form recordForm = new Record(user, passwd, name, target);
                    recordForm.Show();
                    this.Hide();
                }
            }


        }

        // Deleting a record
        private void delete_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            if (btnClicked != null)
            {
                string recordId = btnClicked.Tag.ToString();
                if (findRecordById(recordId).Length != 0)
                {
                    start = new ProcessStartInfo(PYTHON_EXE_FILE, $"..\\..\\main.py {3} {recordId} {NOTHING}"); // Choice Mode 3 = Delete the record by record ID

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

        // Log out button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form login = new Login_Page();
            login.Show();
            Close();
        }

        // Creating a record
        private void create_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;

            if (btnClicked != null)
            {
                Form recordForm = new Record(user, passwd, name, getId());
                recordForm.Show();
                this.Hide();
            }
        }

        // This is where I'll get the id from Python
        private String getId()
        {
            start = new ProcessStartInfo(PYTHON_EXE_FILE, $"..\\..\\main.py {0} {NOTHING} {NOTHING}"); // Option 0 = get the generated ID

            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            using (Process process = Process.Start(start))
            {
                String output = process.StandardOutput.ReadToEnd(); // Use print() in Python so I can recieve the output
                String error = process.StandardError.ReadToEnd();

                if (String.IsNullOrEmpty(error))
                {
                    return output;
                }
                else
                {
                    MessageBox.Show(error);
                    return "";
                }
            }
        }

        // Get only the student's records
        private String[] fetchStudentByName()
        {
            // Check if file exist
            if (!File.Exists("..\\..\\report_records.txt"))
            {
                MessageBox.Show("Student data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new string[] { };
            }
            if (!File.Exists($"..\\..\\main.py"))
            {
                MessageBox.Show("Main Python file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new string[] { };
            }

            // Read all records
            String[] all = File.ReadAllLines("..\\..\\report_records.txt").Skip(1).ToArray();
            String[] ownerOf = new string[] { };
            
            return ownerOf;
        }
  
        // Return a record based on record id
        private String[] findRecordById(String id)
        {
            // Linear search
            foreach (String record in yourRecords)
            {
                // Compare ids
                String[] current = record.Split(delimiter, StringSplitOptions.None);
                if (String.Equals(id, current[0]))
                {
                    return current;
                }
            }

            return new String[] { };
        }
    }
}
