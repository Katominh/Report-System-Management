using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class Record : Form
    {
        private static String NOTHING = "X";
        private String username, password, userID, recordID;
        private String[] data, newData;
        private Dictionary<int, Control> inputMap = new Dictionary<int, Control>(); // For iteration over text inputs
        private bool isWrittentStatementChecked = false, isAdvicedChecked = false, isYesNoPage2Checked = false, isChairChecked = false, isDeanChecked = false, isEditing;

        // ###################################################################################
        // Constructors
        // ###################################################################################

        // For creating records
        public Record(String usr, String passwd, String userID, String recordID)
        {
            InitializeComponent();
            fillAllInputReference();
            username = usr;
            password = passwd;
            this.userID = userID;
            newData = new String[] { };
            this.recordID = recordID;

            isEditing = true;
            edit_mode_text.Text = "Edit Mode ON";
            edit_mode_text.ForeColor = Color.Green;
            setAllReadOnly(false);
        }

        // For editing records
        public Record(String usr, String passwd, String userID, String[] data)
        {
            InitializeComponent();
            fillAllInputReference();
            username = usr;
            password = passwd;
            this.userID = userID;
            this.data = data;
            newData = new String[] { };
            recordID = data[0];
            loadText();

            isEditing = false;
            setAllReadOnly(true);
        }

        // ###################################################################################
        // Side Bar Button Function
        // ###################################################################################

        // Save button listener
        private void save_btn_Click(object sender, EventArgs e)
        {
            // Get new data
            newData = getInputs();
            String result = String.Join("|||", newData);

            var start = new ProcessStartInfo("py", $"..\\..\\main.py {1} \"{result}\" {NOTHING}"); // Choice mode 1 -> addRecord (Or else saveRecord)
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            using (Process process = Process.Start(start))
            {
                String output = process.StandardOutput.ReadToEnd();
                String error = process.StandardError.ReadToEnd();

                if (!String.IsNullOrEmpty(error))
                    MessageBox.Show(error);
            }
        }

        // Toggle Edit Mode Button
        private void edit_mode_btn_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;
            if (isEditing)
            {
                edit_mode_btn.Text = "Turn Off Editing Mode";
                edit_mode_btn.BackColor = Color.White;
                edit_mode_text.Text = "Edit Mode ON";
                edit_mode_text.ForeColor = Color.Green;
                setAllReadOnly(false);
            }
            else
            {
                edit_mode_btn.Text = "Turn On Editing Mode";
                edit_mode_btn.BackColor = Color.AliceBlue;
                edit_mode_text.Text = "Edit Mode OFF";
                edit_mode_text.ForeColor = Color.Red;
                setAllReadOnly(true);
            }
        }

        // Log out button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to log out? You may lose your unsaved changes if you have any.",
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
                "Do you want to go back? You may lose your unsaved changes if you have any.",
                "Go Back Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                if (String.Equals(username, "admin"))
                {
                    Form aMain = new Admin_Main_Page(username, password, userID);
                    aMain.Show();
                    Close();
                }

                else
                {
                    Form sMain = new Student_Main_Page(username, password, userID);
                    sMain.Show();
                    Close();
                }
            }
        }

        // ###################################################################################
        // "Checkbox" Button Logic for the Record
        // ###################################################################################

        // For all the checking buttons in the records
        private void written_statement_btn_Click(object sender, EventArgs e)
        {
            // Toggle button state + images
            isWrittentStatementChecked = !isWrittentStatementChecked;
            if (isWrittentStatementChecked)
                written_statement_btn.BackgroundImage = Properties.Resources.checked_image; // To show checkmark
            else
                written_statement_btn.BackgroundImage = Properties.Resources.unchecked_image;
        }

        private void advice_btn_Click(object sender, EventArgs e)
        {
            // Toggle button state + images
            isAdvicedChecked = !isAdvicedChecked;
            if (isAdvicedChecked)
                advice_btn.BackgroundImage = Properties.Resources.checked_image; // To show checkmark
            else
                advice_btn.BackgroundImage = Properties.Resources.unchecked_image;
        }

        private void yes_btn_page2_Click(object sender, EventArgs e)
        {
            // Yes button state + images
            isYesNoPage2Checked = true;
            yes_btn_page2.BackgroundImage = Properties.Resources.checked_image;
            no_btn_page2.BackgroundImage = Properties.Resources.unchecked_image;
        }

        private void no_btn_page2_Click(object sender, EventArgs e)
        {
            // No button state + images
            isYesNoPage2Checked = false;
            no_btn_page2.BackgroundImage = Properties.Resources.checked_image;
            yes_btn_page2.BackgroundImage = Properties.Resources.unchecked_image;
        }

        private void chair_yes_btn_Click(object sender, EventArgs e)
        {
            // Yes button state + images
            isChairChecked = true;
            chair_yes_btn.BackgroundImage = Properties.Resources.checked_image;
            chair_no_btn.BackgroundImage = Properties.Resources.unchecked_image;
        }

        private void chair_no_btn_Click(object sender, EventArgs e)
        {
            // No button state + images
            isChairChecked = false;
            chair_no_btn.BackgroundImage = Properties.Resources.checked_image;
            chair_yes_btn.BackgroundImage = Properties.Resources.unchecked_image;
        }

        private void dean_yes_input_Click(object sender, EventArgs e)
        {
            // Yes button state + images
            isDeanChecked = true;
            dean_yes_input.BackgroundImage = Properties.Resources.checked_image;
            dean_no_input.BackgroundImage = Properties.Resources.unchecked_image;
        }

        private void dean_no_input_Click(object sender, EventArgs e)
        {
            // No button state + images
            isDeanChecked = false;
            dean_no_input.BackgroundImage = Properties.Resources.checked_image;
            dean_yes_input.BackgroundImage = Properties.Resources.unchecked_image;
        }


        // ###################################################################################
        // Supporting Functions
        // ###################################################################################

        // Pre-filling text inputs
        private void loadText()
        {
            foreach (var item in inputMap)
            {
                int index = item.Key;
                Control obj = item.Value;

                if (obj is TextBox textBox)
                    textBox.Text = data[index];

                else if (obj is RichTextBox richTextBox)
                    richTextBox.Text = data[index];

                else if (obj is Button button)
                    updateCheckState(data[index], index);
            }
        }

        // Get user input as list of Strings
        private String[] getInputs()
        {
            List<String> inputsList = new List<string>();
            inputsList.Add(recordID);

            foreach (var item in inputMap)
            {
                int index = item.Key;
                Control obj = item.Value;

                if (obj is TextBox textBox)
                    inputsList.Add(textBox.Text);

                else if (obj is RichTextBox richTextBox)
                    inputsList.Add(richTextBox.Text);

                else if (obj is Button button)
                    inputsList.Add(updateCheckState("get", index));
            }

            inputsList.Add(userID);
            return inputsList.ToArray();
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
            }

            else if (String.Equals(input, "get"))
            {
                switch (questionIndex)
                {
                    case 11:
                        return isWrittentStatementChecked ? "y" : "n";
                    case 12:
                        return isAdvicedChecked ? "y" : "n";
                    case 17:
                        return isYesNoPage2Checked ? "y" : "n";
                    case 24:
                        return isChairChecked ? "y" : "n";
                    case 30:
                        return isDeanChecked ? "y" : "n";
                    default:
                        return "n";
                }
            }

            else
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

        // Set ReadOnly and Enable attributes
        private void setAllReadOnly(bool state)
        {
            foreach (var item in inputMap)
            {
                Control obj = item.Value;
                if (obj is TextBox textBox)
                    textBox.ReadOnly = state;

                else if (obj is RichTextBox richTextBox)
                    richTextBox.ReadOnly = state;

                else if (obj is Button button)
                    button.Enabled = !state;
            }
        }

        // Load the dictionary with all INPUT references. TEXTBOXES + "CHECKBOXES" BUTTONS
        private void fillAllInputReference()
        {
            inputMap.Add(1, student_name_input);
            inputMap.Add(2, student_number_input);
            inputMap.Add(3, student_email_input);
            inputMap.Add(4, fac_name_input);
            inputMap.Add(5, date_input);
            inputMap.Add(6, course_input);
            inputMap.Add(7, ass_exam_input);
            inputMap.Add(8, department_input);
            inputMap.Add(9, term_sem_input);
            inputMap.Add(10, desc_violation_input);
            inputMap.Add(11, written_statement_btn);
            inputMap.Add(12, advice_btn);
            inputMap.Add(13, sign_fac_mem_input);
            inputMap.Add(14, sign_fac_name_input);
            inputMap.Add(15, sign_fac_date_input);
            inputMap.Add(16, declare_input);
            inputMap.Add(17, yes_btn_page2);
            inputMap.Add(18, tru_input_page2);
            inputMap.Add(19, sign_student_input);
            inputMap.Add(20, date_student_input);
            inputMap.Add(21, sign_fac_input);
            inputMap.Add(22, name_fac_input);
            inputMap.Add(23, date_fac_input_page2);
            inputMap.Add(24, chair_yes_btn);
            inputMap.Add(25, chair_check_no_input);
            inputMap.Add(26, chair_comment_input);
            inputMap.Add(27, sign_chair_input);
            inputMap.Add(28, name_chair_input);
            inputMap.Add(29, date_chair_input);
            inputMap.Add(30, dean_yes_input);
            inputMap.Add(31, dean_check_no_input);
            inputMap.Add(32, dean_comment_input);
            inputMap.Add(33, sign_dean_input);
            inputMap.Add(34, name_dean_input);
            inputMap.Add(35, date_dean_input);
            inputMap.Add(36, fac_comment_page4_input);
            inputMap.Add(37, student_comment_page5_input);
        }

        // ###################################################################################
        // Window Closing Function
        // ###################################################################################
        private void Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if there are any other open forms left.
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
