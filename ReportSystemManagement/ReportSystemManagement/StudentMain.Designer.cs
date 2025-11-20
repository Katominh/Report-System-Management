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
            this.flow_bar_main = new System.Windows.Forms.FlowLayoutPanel();
            this.hi_username = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.chg_name_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.records_table = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flow_bar_main.SuspendLayout();
            this.records_table.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flow_bar_main
            // 
            this.flow_bar_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flow_bar_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flow_bar_main.Controls.Add(this.hi_username);
            this.flow_bar_main.Controls.Add(this.create_btn);
            this.flow_bar_main.Controls.Add(this.chg_name_btn);
            this.flow_bar_main.Controls.Add(this.logout_btn);
            this.flow_bar_main.Location = new System.Drawing.Point(3, 10);
            this.flow_bar_main.Name = "flow_bar_main";
            this.flow_bar_main.Size = new System.Drawing.Size(143, 437);
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
            this.create_btn.Location = new System.Drawing.Point(3, 36);
            this.create_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(137, 50);
            this.create_btn.TabIndex = 1;
            this.create_btn.Text = "Create new record";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // chg_name_btn
            // 
            this.chg_name_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chg_name_btn.Location = new System.Drawing.Point(3, 92);
            this.chg_name_btn.Name = "chg_name_btn";
            this.chg_name_btn.Size = new System.Drawing.Size(137, 50);
            this.chg_name_btn.TabIndex = 3;
            this.chg_name_btn.Text = "Change Your Name";
            this.chg_name_btn.UseVisualStyleBackColor = true;
            this.chg_name_btn.Click += new System.EventHandler(this.chg_name_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_btn.Location = new System.Drawing.Point(3, 148);
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
            this.records_table.Controls.Add(this.flowLayoutPanel1, 6, 0);
            this.records_table.Controls.Add(this.label1, 5, 0);
            this.records_table.Controls.Add(this.label2, 4, 0);
            this.records_table.Controls.Add(this.label3, 3, 0);
            this.records_table.Controls.Add(this.label4, 2, 0);
            this.records_table.Controls.Add(this.label5, 1, 0);
            this.records_table.Controls.Add(this.label6, 0, 0);
            this.records_table.Location = new System.Drawing.Point(3, 3);
            this.records_table.Name = "records_table";
            this.records_table.RowCount = 1;
            this.records_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.records_table.Size = new System.Drawing.Size(707, 37);
            this.records_table.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.edit_btn);
            this.flowLayoutPanel1.Controls.Add(this.delete_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(613, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(81, 29);
            this.flowLayoutPanel1.TabIndex = 9;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Winter 2025";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "fName";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "example@mytru.ca";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "T00125 sadasdasdasd";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "12345";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.records_table);
            this.panel1.Location = new System.Drawing.Point(152, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 444);
            this.panel1.TabIndex = 9;
            // 
            // Student_Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flow_bar_main);
            this.Name = "Student_Main_Page";
            this.Text = "StudentMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_Main_Page_FormClosed);
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
        private System.Windows.Forms.FlowLayoutPanel flow_bar_main;
        private System.Windows.Forms.Label hi_username;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.TableLayoutPanel records_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button chg_name_btn;
    }
}