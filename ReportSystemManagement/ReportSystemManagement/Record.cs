using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class Record : Form
    {

        private String username, password;
        private String[] data;
        public Record()
        {
            InitializeComponent();
        }

        public Record(String usr, String passwd, String[] data)
        {
            InitializeComponent();
            username = usr;
            password = passwd;
            this.data = data;
            loadText();
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

        private void loadText()
        {
            // The commented out lines are for check boxes (need to be implemented)
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
            //written_statement_btn.Text = data[11];
            //advice_btn.Text = data[12];
            sign_fac_mem_input.Text = data[13];
            sign_fac_name_input.Text = data[14];
            sign_fac_date_input.Text = data[15];
            declare_input.Text = data[16];
            //yes_btn_page2.Text = data[17];
            //no_btn_page2.Text = data[17];
            tru_input_page2.Text = data[18];
            sign_student_input.Text = data[19];
            date_student_input.Text = data[20];
            sign_fac_input.Text = data[21];
            name_fac_input.Text = data[22];
            date_fac_input_page2.Text = data[23];
            //chair_yes_btn.Text = data[24];
            //chair_no_btn.Text = data[24];
            chair_check_no_input.Text = data[25];
            chair_comment_input.Text = data[26];
            sign_chair_input.Text = data[27];
            name_chair_input.Text = data[28];
            date_chair_input.Text = data[29];
            //dean_yes_input.Text = data[30];
            //dean_no_input.Text = data[30];
            dean_check_no_input.Text = data[31];
            dean_comment_input.Text = data[32];
            sign_dean_input.Text = data[33];
            name_dean_input.Text = data[34];
            date_dean_input.Text = data[35];
            fac_comment_page4_input.Text = data[36];
            student_comment_page5_input.Text = data[37];
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form login = new Login_Page();
            login.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form aMain = new Admin_Main_Page(username, password);
            aMain.Show();
            this.Hide();
        }
    }
}
