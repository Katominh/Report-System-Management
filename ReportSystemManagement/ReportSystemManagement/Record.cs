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
    public partial class Record : Form
    {
        private bool isWrittentStatementChecked = false, isAdvicedChecked = false, isYesNoPage2Checked = false, isChairChecked = false, isDeanChecked = false, isEditing = false;
        private static String NOTHING = "X", PYTHON_EXE_FILE = "py", MAIN_FILE = $"..\\..\\main.py";
        private static String delimiter = "|||";
        private String username, password, name, id;
        private String[] data, newData;

        // For creating records
        public Record(String usr, String passwd, String name, String id)
        {
            InitializeComponent();
            username = usr;
            password = passwd;
            this.name = name;
            data = new String[] { };
            newData = new String[] { };
            this.id = id;
            loadName();
        }

        // For editing records
        public Record(String usr, String passwd, String name, String[] data)
        {
            InitializeComponent();
            username = usr;
            password = passwd;
            this.name = name;
            this.data = data;
            newData = new String[] { };
            id = data[0];
            loadName();
            loadText();
        }

        // Save button listener
        private void save_btn_Click(object sender, EventArgs e)
        {
            // If changes -> Update
            String changedIndices = GetChangedIndices();
            if (String.IsNullOrEmpty(changedIndices))
            {
                newData = getInputs();
            }

            String result = String.Join(delimiter, newData) + "a";
            MessageBox.Show(result);
            var start = new ProcessStartInfo();
            start.FileName = "py";
            if (data.Length == 0) // If no previous data, it's a new record
            {
                start.Arguments = $"..\\..\\main.py {1} \"{result}\" {NOTHING}"; // Choice mode 1 -> addRecord (Or saveRecord)
            } else
            {
                start.Arguments = $"..\\..\\main.py {4} \"{result}\" {changedIndices}"; // Choice mode 4 -> saveRecord
            }

            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            using (Process process = Process.Start(start))
            {
                String output = process.StandardOutput.ReadToEnd();
                String error = process.StandardError.ReadToEnd();
                MessageBox.Show(output);

                if (!String.IsNullOrEmpty(error))
                {
                    MessageBox.Show(output);
                    MessageBox.Show(error);
                }
            }
        }

        private void chair_check_no_input_MouseWheel(object sender, MouseEventArgs e)
        {
            if (richTextBox1.Focused)
            {
                if (e.Delta > 0)
                {
                    this.AutoScrollPosition = new Point(0, this.AutoScrollPosition.Y - 20);
                }
                else
                {
                    this.AutoScrollPosition = new Point(0, this.AutoScrollPosition.Y + 20);
                }
            }
        }

        

        // For all the checking buttons in the records
        private void written_statement_btn_Click(object sender, EventArgs e)
        {
            // Toggle button state
            if (isEditing)
            {
                isWrittentStatementChecked = !isWrittentStatementChecked;
                if (isWrittentStatementChecked)
                {
                    written_statement_btn.BackgroundImage = Properties.Resources.checked_image; // To show checkmark
                }
                else
                {
                    written_statement_btn.BackgroundImage = Properties.Resources.unchecked_image;
                }
            }
        }

        private void advice_btn_Click(object sender, EventArgs e)
        {
            // Toggle button state
            if (isEditing)
            {
                isAdvicedChecked = !isAdvicedChecked;
                if (isAdvicedChecked)
                {
                    advice_btn.BackgroundImage = Properties.Resources.checked_image; // To show checkmark
                }
                else
                {
                    advice_btn.BackgroundImage = Properties.Resources.unchecked_image;
                }
            }
        }

        private void yes_btn_page2_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isYesNoPage2Checked = true;
                yes_btn_page2.BackgroundImage = Properties.Resources.checked_image;
                no_btn_page2.BackgroundImage = Properties.Resources.unchecked_image;
            }
        }

        private void no_btn_page2_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isYesNoPage2Checked = false;
                no_btn_page2.BackgroundImage = Properties.Resources.checked_image;
                yes_btn_page2.BackgroundImage = Properties.Resources.unchecked_image;
            }
        }

        private void chair_yes_btn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isChairChecked = true;
                chair_yes_btn.BackgroundImage = Properties.Resources.checked_image;
                chair_no_btn.BackgroundImage = Properties.Resources.unchecked_image;
            }
        }

        private void chair_no_btn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isChairChecked = false;
                chair_no_btn.BackgroundImage = Properties.Resources.checked_image;
                chair_yes_btn.BackgroundImage = Properties.Resources.unchecked_image;
            }
        }

        private void dean_yes_input_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isDeanChecked = true;
                dean_yes_input.BackgroundImage = Properties.Resources.checked_image;
                dean_no_input.BackgroundImage = Properties.Resources.unchecked_image;
            }
        }

        private void dean_no_input_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isDeanChecked = false;
                dean_no_input.BackgroundImage = Properties.Resources.checked_image;
                dean_yes_input.BackgroundImage = Properties.Resources.unchecked_image;
            }
        }

        // Pre-filling text inputs
        private void loadText()
        {
            student_name_input.Text = data[1];
            student_number_input.Text = data[2];
            student_email_input.Text = data[3];
            fac_name_input.Text = data[4];
            date_input.Text = data[5];
            course_input.Text = data[6];
            ass_exam_input.Text = data[7];
            department_input.Text = data[8];
            term_sem_input.Text = data[9];
            desc_violation_input.Text = data[10];
            updateCheckState(data[11], 11);
            updateCheckState(data[12], 12);
            sign_fac_mem_input.Text = data[13];
            sign_fac_name_input.Text = data[14];
            sign_fac_date_input.Text = data[15];
            declare_input.Text = data[16];
            updateCheckState(data[17], 17);
            tru_input_page2.Text = data[18];
            sign_student_input.Text = data[19];
            date_student_input.Text = data[20];
            sign_fac_input.Text = data[21];
            name_fac_input.Text = data[22];
            date_fac_input_page2.Text = data[23];
            updateCheckState(data[24], 24);
            chair_check_no_input.Text = data[25];
            chair_comment_input.Text = data[26];
            sign_chair_input.Text = data[27];
            name_chair_input.Text = data[28];
            date_chair_input.Text = data[29];
            updateCheckState(data[30], 30);
            dean_check_no_input.Text = data[31];
            dean_comment_input.Text = data[32];
            sign_dean_input.Text = data[33];
            name_dean_input.Text = data[34];
            date_dean_input.Text = data[35];
            fac_comment_page4_input.Text = data[36];
            student_comment_page5_input.Text = data[37];
        }

        // Toggle edit Mode Button
        private void edit_mode_btn_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;
            if (isEditing)
            {
                edit_mode_btn.Text = "Turn Off Editing Mode";
                edit_mode_text.Text = "Edit Mode ON";
                setAllReadOnly(true);
            } else
            {
                edit_mode_btn.Text = "Turn On Editing Mode";
                edit_mode_text.Text = "Edit Mode OFF";
                setAllReadOnly(false);
            }
        }

        // Log out button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to log out? You may lose your unsaved changes.",
                "Log Out Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                Form login = new Login_Page();
                login.Show();
                Close();
            }
        }

        // Go back to Main button
        private void back_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to go back? You may lose your unsaved changes.",
                "Go Back Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                if (String.Equals(username, "admin"))
                {
                    Form aMain = new Admin_Main_Page(username, password, name);
                    aMain.Show();
                    Close();
                } else
                {
                    Form sMain = new Student_Main_Page(username, password, name);
                    sMain.Show();
                    Close();
                }
            }
        }

        private void loadName()
        {
            declare_input.Text = name;
            student_name_input.Text = name;
            declare_input.ReadOnly = true;
            student_name_input.ReadOnly = true;
        }

        private String[] getInputs()
        {
            String[] inputs = {
                id,
                name,
                student_number_input.Text,
                student_email_input.Text,
                fac_name_input.Text,
                date_input.Text,
                course_input.Text,
                ass_exam_input.Text,
                department_input.Text,
                term_sem_input.Text,
                desc_violation_input.Text,
                updateCheckState("get", 11),
                updateCheckState("get", 12),
                sign_fac_mem_input.Text,
                sign_fac_name_input.Text,
                sign_fac_date_input.Text,
                name,
                updateCheckState("get", 17),
                tru_input_page2.Text,
                sign_student_input.Text,
                date_student_input.Text,
                sign_fac_input.Text,
                name_fac_input.Text,
                date_fac_input_page2.Text,
                updateCheckState("get", 24),
                chair_check_no_input.Text,
                chair_comment_input.Text,
                sign_chair_input.Text,
                name_chair_input.Text,
                date_chair_input.Text,
                updateCheckState("get", 30),
                dean_check_no_input.Text,
                dean_comment_input.Text,
                sign_dean_input.Text,
                name_dean_input.Text,
                date_dean_input.Text,
                fac_comment_page4_input.Text,
                student_comment_page5_input.Text
            };
            return inputs;
        }

        private String GetChangedIndices()
        {
            if (data.Length == 38)
            {
                List<int> changedIndices = new List<int>();
                Dictionary<int, String> inputMap = new Dictionary<int, String>();

                // Populate dict
                inputMap.Add(1, student_name_input.Text); //
                inputMap.Add(2, student_number_input.Text);
                inputMap.Add(3, student_email_input.Text);
                inputMap.Add(4, fac_name_input.Text);
                inputMap.Add(5, date_input.Text);
                inputMap.Add(6, course_input.Text);
                inputMap.Add(7, ass_exam_input.Text);
                inputMap.Add(8, department_input.Text);
                inputMap.Add(9, term_sem_input.Text);
                inputMap.Add(10, desc_violation_input.Text);
                inputMap.Add(11, updateCheckState("get", 11)); //
                inputMap.Add(12, updateCheckState("get", 12)); //
                inputMap.Add(13, sign_fac_mem_input.Text);
                inputMap.Add(14, sign_fac_name_input.Text);
                inputMap.Add(15, sign_fac_date_input.Text);
                inputMap.Add(16, declare_input.Text);
                inputMap.Add(17, updateCheckState("get", 17)); //
                inputMap.Add(18, tru_input_page2.Text);
                inputMap.Add(19, sign_student_input.Text);
                inputMap.Add(20, date_student_input.Text);
                inputMap.Add(21, sign_fac_input.Text);
                inputMap.Add(22, name_fac_input.Text);
                inputMap.Add(23, date_fac_input_page2.Text);
                inputMap.Add(24, updateCheckState("get", 24)); //
                inputMap.Add(25, chair_check_no_input.Text);
                inputMap.Add(26, chair_comment_input.Text);
                inputMap.Add(27, sign_chair_input.Text);
                inputMap.Add(28, name_chair_input.Text);
                inputMap.Add(29, date_chair_input.Text);
                inputMap.Add(30, updateCheckState("get", 30)); //
                inputMap.Add(31, dean_check_no_input.Text);
                inputMap.Add(32, dean_comment_input.Text);
                inputMap.Add(33, sign_dean_input.Text);
                inputMap.Add(34, name_dean_input.Text);
                inputMap.Add(35, date_dean_input.Text);
                inputMap.Add(36, fac_comment_page4_input.Text);
                inputMap.Add(37, student_comment_page5_input.Text);

                // Actual comparing difference
                int index;
                foreach (var pair in inputMap)
                {
                    index = pair.Key;
                    if (!String.Equals(pair.Value, data[index]))
                    {
                        changedIndices.Add(index);
                    }
                }
                return String.Join(delimiter, changedIndices);
            } else
            {
                return "";
            }
        }

        private String updateCheckState(String input, int questionIndex)
        {

            if (String.Equals(input, "y"))
            {
                switch (questionIndex)
                {
                    case 11:
                        isWrittentStatementChecked = true;
                        written_statement_btn.BackgroundImage = Properties.Resources.checked_image;
                        break;
                    case 12:
                        isAdvicedChecked = true;
                        advice_btn.BackgroundImage = Properties.Resources.checked_image;
                        break;
                    case 17:
                        isYesNoPage2Checked = true;
                        yes_btn_page2.BackgroundImage = Properties.Resources.checked_image;
                        no_btn_page2.BackgroundImage = Properties.Resources.unchecked_image;
                        break;
                    case 24:
                        isChairChecked = true;
                        chair_yes_btn.BackgroundImage = Properties.Resources.checked_image;
                        chair_no_btn.BackgroundImage = Properties.Resources.unchecked_image;
                        break;
                    case 30:
                        isDeanChecked = true;
                        dean_yes_input.BackgroundImage = Properties.Resources.checked_image;
                        dean_no_input.BackgroundImage = Properties.Resources.unchecked_image;
                        break;
                }
            } else if (String.Equals(input, "get"))
            {
                String value;
                switch (questionIndex)
                {
                    case 11:
                        value = isWrittentStatementChecked ? "y" : "n";
                        break;
                    case 12:
                        value = isAdvicedChecked ? "y" : "n";
                        break;
                    case 17:
                        value = isYesNoPage2Checked ? "y" : "n";
                        break;
                    case 24:
                        value = isChairChecked ? "y" : "n";
                        break;
                    case 30:
                        value = isDeanChecked ? "y" : "n";
                        break;
                    default:
                        value = "n";
                        break;
                }
                return value;
            } else
            {
                switch (questionIndex)
                {
                    case 11:
                        isWrittentStatementChecked = false;
                        written_statement_btn.BackgroundImage = Properties.Resources.unchecked_image;
                        break;
                    case 12:
                        isAdvicedChecked = false;
                        advice_btn.BackgroundImage = Properties.Resources.unchecked_image;
                        break;
                    case 17:
                        isYesNoPage2Checked = false;
                        yes_btn_page2.BackgroundImage = Properties.Resources.unchecked_image;
                        no_btn_page2.BackgroundImage = Properties.Resources.checked_image;
                        break;
                    case 24:
                        isChairChecked = false;
                        chair_yes_btn.BackgroundImage = Properties.Resources.unchecked_image;
                        chair_no_btn.BackgroundImage = Properties.Resources.checked_image;
                        break;
                    case 30:
                        isDeanChecked = false;
                        dean_yes_input.BackgroundImage = Properties.Resources.unchecked_image;
                        dean_no_input.BackgroundImage = Properties.Resources.checked_image;
                        break;
                }
            }
            return "";
        }

        private void setAllReadOnly(bool state)
        {
            student_name_input.ReadOnly = state;
            student_number_input.ReadOnly = state;
            student_email_input.ReadOnly = state;
            fac_name_input.ReadOnly = state;
            date_input.ReadOnly = state;
            course_input.ReadOnly = state;
            ass_exam_input.ReadOnly = state;
            department_input.ReadOnly = state;
            term_sem_input.ReadOnly = state;
            desc_violation_input.ReadOnly = state;
            sign_fac_mem_input.ReadOnly = state;
            sign_fac_name_input.ReadOnly = state;
            sign_fac_date_input.ReadOnly = state;
            declare_input.ReadOnly = state;
            tru_input_page2.ReadOnly = state;
            sign_student_input.ReadOnly = state;
            date_student_input.ReadOnly = state;
            sign_fac_input.ReadOnly = state;
            name_fac_input.ReadOnly = state;
            date_fac_input_page2.ReadOnly = state;
            chair_check_no_input.ReadOnly = state;
            chair_comment_input.ReadOnly = state;
            sign_chair_input.ReadOnly = state;
            name_chair_input.ReadOnly = state;
            date_chair_input.ReadOnly = state;
            dean_check_no_input.ReadOnly = state;
            dean_comment_input.ReadOnly = state;
            sign_dean_input.ReadOnly = state;
            name_dean_input.ReadOnly = state;
            date_dean_input.ReadOnly = state;
            fac_comment_page4_input.ReadOnly = state;
            student_comment_page5_input.ReadOnly = state;
        }
    }
}
