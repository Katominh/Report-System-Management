using System;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class Admin_Main_Page : Form
    {
        private String user, passwd, userID;
        private String[] allRecords;
        private String[] delimiter = { "|||" };
        private static String NOTHING = "X";

        // ###################################################################################
        // Constructors
        // ###################################################################################
        public Admin_Main_Page(String username, String password, String userID)
        {
            InitializeComponent();
            user = username;
            passwd = password;
            this.userID = userID;
            hi_username.Text = "Hi Faculty Member!";
            loadRecordTable();
        }

        // ###################################################################################
        // Key Button Functions
        // ###################################################################################

        // Edit button
        private void edit_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            if (btnClicked != null)
            {
                String[] target = findRecordById(btnClicked.Tag.ToString());
                if (target.Length !=0)
                {
                    Form recordForm = new Record(user, passwd, userID, target);
                    recordForm.Show();
                    Close();
                }
            }
        }

        // Delete button
        private void delete_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            if (btnClicked != null)
            {
                String result = String.Join("|||", findRecordById(btnClicked.Tag.ToString()));
                if (result.Length != 0)
                {
                    var start = new ProcessStartInfo("py", $"..\\..\\main.py {3} \"{result}\" {NOTHING}");
                    processConfig(start);

                    using (Process process = Process.Start(start))
                    {
                        String output = process.StandardOutput.ReadToEnd();
                        String error = process.StandardError.ReadToEnd();
                        if (!String.IsNullOrEmpty(error))
                            MessageBox.Show(error);
                        else
                        {
                            Form mainForm = new Loading(user, passwd, userID);
                            mainForm.Show();
                            Close();
                        }
                    }
                }
            }
        }


        // Logout Button
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
            // Read all records
            String[] all = File.ReadAllLines("..\\..\\report_records.txt");
            allRecords = all.Skip(1).ToArray(); // Minus header
            

            // Redraw table layout
            records_table.Controls.Clear();
            records_table.RowStyles.Clear();
            records_table.RowCount = allRecords.Length;

            // Set new row
            records_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F)); // 50px for header
            for (int i = 1; i < allRecords.Length; i++)
                records_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F)); // 65px for record

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
                rowIndex++;
            }
        }

        // Return a record based on RECORD id
        private String[] findRecordById(String id)
        {
            // Linear search
            foreach (String record in allRecords)
            {
                // Compare ids
                String[] current = record.Split(delimiter, StringSplitOptions.None);
                if (String.Equals(id, current[0]))
                    return current;
            }

            return new String[]{ };
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
        private void Admin_Main_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if there are any other open forms left.
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}