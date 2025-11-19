using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class Admin_Main_Page : Form
    {
        private String user, passwd, name;
        private String file;
        private String[] allRecords;
        private String[] delimiter = { "|||" };
        private static String NOTHING = "X";

        public Admin_Main_Page(String username, String password, String name)
        {
            InitializeComponent();
            user = username;
            passwd = password;
            this.name = name;
            hi_username.Text = "Hi " + name + "!";
            loadRecordTable();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void edit_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;

            if (btnClicked != null)
            {
                string recordId = btnClicked.Tag.ToString();
                String[] target = findStudent(recordId);
                if (target.Length !=0)
                {
                    Form recordForm = new Record(user, passwd, name, target);
                    recordForm.Show();
                    this.Hide();
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;

            if (btnClicked != null)
            {
                string recordId = btnClicked.Tag.ToString();
                String[] target = findStudent(recordId);
                String result = String.Join("|||", target);
                var start = new ProcessStartInfo();
                if (target.Length != 0)
                {

                    MessageBox.Show($"Deleting record: {result}");
                    start.FileName = "py";
                    start.Arguments = $"..\\..\\main.py {3} \"{result}\" {NOTHING}";
                    start.UseShellExecute = false;
                    start.CreateNoWindow = true;
                    start.RedirectStandardOutput = true;
                    start.RedirectStandardError = true;
                    using (Process process = Process.Start(start))
                    {
                        String output = process.StandardOutput.ReadToEnd();
                        String error = process.StandardError.ReadToEnd();
                        MessageBox.Show(output);
                    }
                }
            }

            loadRecordTable();
        }

        private void loadRecordTable()
        {
            // Check if file exist
            String filePath = "..\\..\\report_records.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Student data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            file = filePath;

            // Read all records
            String[] all = File.ReadAllLines(filePath);
            allRecords = all.Skip(1).ToArray(); // Minus header

            // Redraw table layout
            records_table.Controls.Clear();
            records_table.RowStyles.Clear();
            records_table.RowCount = allRecords.Length;

            // Set new row
            records_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F)); // 50px for header
            for (int i = 1; i < allRecords.Length; i++)
            {
                records_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F)); // 65px for record
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
            foreach (String record in allRecords)
            {
                String[] fields = record.Split(delimiter, StringSplitOptions.None);
                if (fields.Length == 38)
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


        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form login = new Login_Page();
            login.Show();
            Close();
        }

        private String[] findStudent(String id)
        {
            // Linear search
            foreach (String record in allRecords)
            {
                // Compare ids
                String[] current = record.Split(delimiter, StringSplitOptions.None);
                if (String.Equals(id, current[0]))
                {
                    return current;
                }
            }

            return new String[]{ };
        }
    }
}
