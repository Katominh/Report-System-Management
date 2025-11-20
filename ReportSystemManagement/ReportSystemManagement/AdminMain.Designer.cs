namespace ReportSystemManagement
{
    partial class Admin_Main_Page
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
            this.side_bar_main = new System.Windows.Forms.GroupBox();
            this.flow_bar_main = new System.Windows.Forms.FlowLayoutPanel();
            this.hi_username = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.records_table = new System.Windows.Forms.TableLayoutPanel();
            this.student_time = new System.Windows.Forms.Label();
            this.fac_name = new System.Windows.Forms.Label();
            this.student_email = new System.Windows.Forms.Label();
            this.student_num = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chg_name_btn = new System.Windows.Forms.Button();
            this.side_bar_main.SuspendLayout();
            this.flow_bar_main.SuspendLayout();
            this.records_table.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_bar_main
            // 
            this.side_bar_main.Controls.Add(this.flow_bar_main);
            this.side_bar_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_bar_main.Location = new System.Drawing.Point(0, 0);
            this.side_bar_main.Name = "side_bar_main";
            this.side_bar_main.Size = new System.Drawing.Size(149, 450);
            this.side_bar_main.TabIndex = 1;
            this.side_bar_main.TabStop = false;
            // 
            // flow_bar_main
            // 
            this.flow_bar_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flow_bar_main.Controls.Add(this.hi_username);
            this.flow_bar_main.Controls.Add(this.chg_name_btn);
            this.flow_bar_main.Controls.Add(this.logout_btn);
            this.flow_bar_main.Location = new System.Drawing.Point(3, 16);
            this.flow_bar_main.Name = "flow_bar_main";
            this.flow_bar_main.Size = new System.Drawing.Size(143, 431);
            this.flow_bar_main.TabIndex = 2;
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
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_btn.Location = new System.Drawing.Point(3, 85);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(137, 50);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // records_table
            // 
            this.records_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.records_table.AutoSize = true;
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
            this.records_table.Controls.Add(this.fac_name, 4, 0);
            this.records_table.Controls.Add(this.student_email, 3, 0);
            this.records_table.Controls.Add(this.student_num, 2, 0);
            this.records_table.Controls.Add(this.student_name, 1, 0);
            this.records_table.Controls.Add(this.student_id, 0, 0);
            this.records_table.Controls.Add(this.flowLayoutPanel1, 6, 0);
            this.records_table.Location = new System.Drawing.Point(3, 3);
            this.records_table.Name = "records_table";
            this.records_table.RowCount = 1;
            this.records_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.records_table.Size = new System.Drawing.Size(714, 27);
            this.records_table.TabIndex = 4;
            // 
            // student_time
            // 
            this.student_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_time.AutoSize = true;
            this.student_time.Location = new System.Drawing.Point(523, 7);
            this.student_time.Name = "student_time";
            this.student_time.Size = new System.Drawing.Size(65, 13);
            this.student_time.TabIndex = 5;
            this.student_time.Text = "Winter 2025";
            // 
            // fac_name
            // 
            this.fac_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fac_name.AutoSize = true;
            this.fac_name.Location = new System.Drawing.Point(436, 7);
            this.fac_name.Name = "fac_name";
            this.fac_name.Size = new System.Drawing.Size(38, 13);
            this.fac_name.TabIndex = 4;
            this.fac_name.Text = "fName";
            // 
            // student_email
            // 
            this.student_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_email.AutoSize = true;
            this.student_email.Location = new System.Drawing.Point(308, 1);
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(91, 25);
            this.student_email.TabIndex = 3;
            this.student_email.Text = "example@mytru.ca";
            // 
            // student_num
            // 
            this.student_num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_num.AutoSize = true;
            this.student_num.Location = new System.Drawing.Point(231, 7);
            this.student_num.Name = "student_num";
            this.student_num.Size = new System.Drawing.Size(44, 13);
            this.student_num.TabIndex = 2;
            this.student_num.Text = "T00125";
            // 
            // student_name
            // 
            this.student_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_name.AutoSize = true;
            this.student_name.Location = new System.Drawing.Point(134, 7);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(35, 13);
            this.student_name.TabIndex = 1;
            this.student_name.Text = "Name";
            // 
            // student_id
            // 
            this.student_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_id.AutoSize = true;
            this.student_id.Location = new System.Drawing.Point(32, 7);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(37, 13);
            this.student_id.TabIndex = 0;
            this.student_id.Text = "12345";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.edit_btn);
            this.flowLayoutPanel1.Controls.Add(this.delete_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(619, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(81, 19);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Location = new System.Drawing.Point(3, 3);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "Edit record";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Location = new System.Drawing.Point(3, 32);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Delete record";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.records_table);
            this.panel1.Location = new System.Drawing.Point(155, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 435);
            this.panel1.TabIndex = 5;
            // 
            // chg_name_btn
            // 
            this.chg_name_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chg_name_btn.Location = new System.Drawing.Point(3, 29);
            this.chg_name_btn.Name = "chg_name_btn";
            this.chg_name_btn.Size = new System.Drawing.Size(137, 50);
            this.chg_name_btn.TabIndex = 3;
            this.chg_name_btn.Text = "Change Your Name";
            this.chg_name_btn.UseVisualStyleBackColor = true;
            this.chg_name_btn.Click += new System.EventHandler(this.chg_name_btn_Click);
            // 
            // Admin_Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.side_bar_main);
            this.Name = "Admin_Main_Page";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Main_Page_FormClosed);
            this.side_bar_main.ResumeLayout(false);
            this.flow_bar_main.ResumeLayout(false);
            this.flow_bar_main.PerformLayout();
            this.records_table.ResumeLayout(false);
            this.records_table.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox side_bar_main;
        private System.Windows.Forms.FlowLayoutPanel flow_bar_main;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label hi_username;
        private System.Windows.Forms.TableLayoutPanel records_table;
        private System.Windows.Forms.Label student_time;
        private System.Windows.Forms.Label fac_name;
        private System.Windows.Forms.Label student_email;
        private System.Windows.Forms.Label student_num;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.Label student_id;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button chg_name_btn;
    }
}