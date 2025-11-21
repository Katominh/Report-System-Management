namespace ReportSystemManagement
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.TRU_Title = new System.Windows.Forms.PictureBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_input_box = new System.Windows.Forms.TextBox();
            this.username_input_box = new System.Windows.Forms.TextBox();
            this.test_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TRU_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // password_label
            // 
            this.password_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(162, 294);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Password";
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(162, 230);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(91, 13);
            this.username_label.TabIndex = 10;
            this.username_label.Text = "Username / Email";
            // 
            // TRU_Title
            // 
            this.TRU_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TRU_Title.Image = ((System.Drawing.Image)(resources.GetObject("TRU_Title.Image")));
            this.TRU_Title.Location = new System.Drawing.Point(113, 46);
            this.TRU_Title.Name = "TRU_Title";
            this.TRU_Title.Size = new System.Drawing.Size(557, 165);
            this.TRU_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TRU_Title.TabIndex = 9;
            this.TRU_Title.TabStop = false;
            // 
            // login_btn
            // 
            this.login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(144, 372);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(374, 30);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "Login / Sign In";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_input_box
            // 
            this.password_input_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_input_box.Location = new System.Drawing.Point(306, 287);
            this.password_input_box.Name = "password_input_box";
            this.password_input_box.Size = new System.Drawing.Size(348, 20);
            this.password_input_box.TabIndex = 7;
            this.password_input_box.UseSystemPasswordChar = true;
            // 
            // username_input_box
            // 
            this.username_input_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_input_box.Location = new System.Drawing.Point(306, 230);
            this.username_input_box.Name = "username_input_box";
            this.username_input_box.Size = new System.Drawing.Size(348, 20);
            this.username_input_box.TabIndex = 6;
            // 
            // test_btn
            // 
            this.test_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.test_btn.BackColor = System.Drawing.SystemColors.Info;
            this.test_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_btn.Location = new System.Drawing.Point(562, 361);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(108, 53);
            this.test_btn.TabIndex = 12;
            this.test_btn.Text = "Get Test Account";
            this.test_btn.UseVisualStyleBackColor = false;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.TRU_Title);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_input_box);
            this.Controls.Add(this.username_input_box);
            this.Name = "Login_Page";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Page_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TRU_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.PictureBox TRU_Title;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_input_box;
        private System.Windows.Forms.TextBox username_input_box;
        private System.Windows.Forms.Button test_btn;
    }
}

