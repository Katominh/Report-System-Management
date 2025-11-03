namespace ReportSystemManagement
{
    partial class Main_Page
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
            this.create_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.side_bar_main.SuspendLayout();
            this.flow_bar_main.SuspendLayout();
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
            this.flow_bar_main.Controls.Add(this.create_btn);
            this.flow_bar_main.Controls.Add(this.logout_btn);
            this.flow_bar_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_bar_main.Location = new System.Drawing.Point(3, 16);
            this.flow_bar_main.Name = "flow_bar_main";
            this.flow_bar_main.Size = new System.Drawing.Size(143, 431);
            this.flow_bar_main.TabIndex = 2;
            // 
            // create_btn
            // 
            this.create_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_btn.Location = new System.Drawing.Point(3, 3);
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
            this.logout_btn.Location = new System.Drawing.Point(3, 32);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(137, 23);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(192, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 55);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.side_bar_main);
            this.Name = "Main_Page";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Login_Load);
            this.side_bar_main.ResumeLayout(false);
            this.flow_bar_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox side_bar_main;
        private System.Windows.Forms.FlowLayoutPanel flow_bar_main;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}