namespace ReportSystemManagement
{
    partial class Student_Main_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.records_table = new System.Windows.Forms.TableLayoutPanel();
            this.student_time = new System.Windows.Forms.Label();
            this.fac_name = new System.Windows.Forms.Label();
            this.student_email = new System.Windows.Forms.Label();
            this.student_num = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.Label();
            this.flow_bar_main = new System.Windows.Forms.FlowLayoutPanel();
            this.hi_username = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.records_table.SuspendLayout();
            this.flow_bar_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // records_table
            // 
            this.records_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.records_table.AutoScroll = true;
            this.records_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.records_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.records_table.ColumnCount = 7;
            this.records_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.records_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.records_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.records_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.records_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.records_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.records_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.records_table.Controls.Add(this.student_time, 5, 0);
            this.records_table.Controls.Add(this.delete_btn, 6, 0);
            this.records_table.Controls.Add(this.fac_name, 4, 0);
            this.records_table.Controls.Add(this.student_email, 3, 0);
            this.records_table.Controls.Add(this.student_num, 2, 0);
            this.records_table.Controls.Add(this.student_name, 1, 0);
            this.records_table.Controls.Add(this.student_id, 0, 0);
            this.records_table.Location = new System.Drawing.Point(155, 12);
            this.records_table.Name = "records_table";
            this.records_table.RowCount = 1;
            this.records_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.records_table.Size = new System.Drawing.Size(631, 140);
            this.records_table.TabIndex = 6;
            // 
            // student_time
            // 
            this.student_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_time.AutoSize = true;
            this.student_time.Location = new System.Drawing.Point(462, 63);
            this.student_time.Name = "student_time";
            this.student_time.Size = new System.Drawing.Size(65, 13);
            this.student_time.TabIndex = 5;
            this.student_time.Text = "Winter 2025";
            // 
            // fac_name
            // 
            this.fac_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fac_name.AutoSize = true;
            this.fac_name.Location = new System.Drawing.Point(385, 63);
            this.fac_name.Name = "fac_name";
            this.fac_name.Size = new System.Drawing.Size(38, 13);
            this.fac_name.TabIndex = 4;
            this.fac_name.Text = "fName";
            // 
            // student_email
            // 
            this.student_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_email.AutoSize = true;
            this.student_email.Location = new System.Drawing.Point(273, 57);
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(82, 26);
            this.student_email.TabIndex = 3;
            this.student_email.Text = "example@mytru.ca";
            // 
            // student_num
            // 
            this.student_num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_num.AutoSize = true;
            this.student_num.Location = new System.Drawing.Point(202, 63);
            this.student_num.Name = "student_num";
            this.student_num.Size = new System.Drawing.Size(44, 13);
            this.student_num.TabIndex = 2;
            this.student_num.Text = "T00125";
            // 
            // student_name
            // 
            this.student_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_name.AutoSize = true;
            this.student_name.Location = new System.Drawing.Point(117, 63);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(35, 13);
            this.student_name.TabIndex = 1;
            this.student_name.Text = "Name";
            // 
            // student_id
            // 
            this.student_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_id.AutoSize = true;
            this.student_id.Location = new System.Drawing.Point(26, 63);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(37, 13);
            this.student_id.TabIndex = 0;
            this.student_id.Text = "12345";
            // 
            // flow_bar_main
            // 
            this.flow_bar_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flow_bar_main.Controls.Add(this.hi_username);
            this.flow_bar_main.Controls.Add(this.create_btn);
            this.flow_bar_main.Controls.Add(this.logout_btn);
            this.flow_bar_main.Location = new System.Drawing.Point(3, 16);
            this.flow_bar_main.Name = "flow_bar_main";
            this.flow_bar_main.Size = new System.Drawing.Size(143, 431);
            this.flow_bar_main.TabIndex = 5;
            // 
            // hi_username
            // 
            this.hi_username.AutoSize = true;
            this.hi_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hi_username.Location = new System.Drawing.Point(3, 0);
            this.hi_username.Name = "hi_username";
            this.hi_username.Size = new System.Drawing.Size(101, 26);
            this.hi_username.TabIndex = 2;
            this.hi_username.Text = "Hi ____!";
            // 
            // create_btn
            // 
            this.create_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_btn.Location = new System.Drawing.Point(3, 29);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(137, 23);
            this.create_btn.TabIndex = 1;
            this.create_btn.Text = "Create new record";
            this.create_btn.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_btn.Location = new System.Drawing.Point(3, 58);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(137, 23);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Location = new System.Drawing.Point(543, 58);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(84, 23);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Delete record";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Student_Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.records_table);
            this.Controls.Add(this.flow_bar_main);
            this.Name = "Student_Main_Page";
            this.Text = "StudentMain";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.records_table.ResumeLayout(false);
            this.records_table.PerformLayout();
            this.flow_bar_main.ResumeLayout(false);
            this.flow_bar_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel records_table;
        private System.Windows.Forms.Label student_time;
        private System.Windows.Forms.Label fac_name;
        private System.Windows.Forms.Label student_email;
        private System.Windows.Forms.Label student_num;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.Label student_id;
        private System.Windows.Forms.FlowLayoutPanel flow_bar_main;
        private System.Windows.Forms.Label hi_username;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}