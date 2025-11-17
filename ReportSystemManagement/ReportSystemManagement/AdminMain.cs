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

namespace ReportSystemManagement
{
    public partial class Main_Page : Form
    {
        private String user, passwd;
        private String file;

        public Main_Page(String username, String password)
        {
            InitializeComponent();
            user = username;
            passwd = password;
            hi_username.Text = "Hi " + user + "!";
            loadStudentRecord();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            Form newRecord = new Record();
            newRecord.Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;

            if (btnClicked != null)
            {
                string recordId = btnClicked.Tag.ToString();
                MessageBox.Show($"Editing record: {recordId}");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;

            if (btnClicked != null)
            {
                string recordId = btnClicked.Tag.ToString();
                MessageBox.Show($"Editing record: {recordId}");
            }
        }

        private void loadStudentRecord()
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
            String[] allRecords = all.Skip(1).ToArray(); // Minus header
            String[] delimiter = { "|||" };

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
    }
}
