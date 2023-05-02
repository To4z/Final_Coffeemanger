namespace Coffee
{
    partial class FRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegister));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lb_err_confirmpass = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tb_confirmpass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_err_pass = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_err_name = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_err_sdt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linklb_login = new System.Windows.Forms.LinkLabel();
            this.btn_register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Gold;
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1279, 61);
            this.pnl_header.TabIndex = 2;
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnl_logo.Controls.Add(this.label1);
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_logo.Location = new System.Drawing.Point(0, 61);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(418, 622);
            this.pnl_logo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chuỗi Café ÔNG BẦU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lb_err_confirmpass);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.tb_confirmpass);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(503, 439);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(676, 94);
            this.panel7.TabIndex = 14;
            // 
            // lb_err_confirmpass
            // 
            this.lb_err_confirmpass.AutoSize = true;
            this.lb_err_confirmpass.ForeColor = System.Drawing.Color.Red;
            this.lb_err_confirmpass.Location = new System.Drawing.Point(250, 62);
            this.lb_err_confirmpass.Name = "lb_err_confirmpass";
            this.lb_err_confirmpass.Size = new System.Drawing.Size(288, 25);
            this.lb_err_confirmpass.TabIndex = 4;
            this.lb_err_confirmpass.Text = "Invalid and fill password! try again!";
            this.lb_err_confirmpass.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(250, 58);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(363, 1);
            this.panel8.TabIndex = 3;
            // 
            // tb_confirmpass
            // 
            this.tb_confirmpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_confirmpass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_confirmpass.ForeColor = System.Drawing.Color.Gray;
            this.tb_confirmpass.Location = new System.Drawing.Point(250, 14);
            this.tb_confirmpass.Name = "tb_confirmpass";
            this.tb_confirmpass.Size = new System.Drawing.Size(364, 38);
            this.tb_confirmpass.TabIndex = 1;
            this.tb_confirmpass.UseSystemPasswordChar = true;
            this.tb_confirmpass.Click += new System.EventHandler(this.tb_confirmpass_Click);
            this.tb_confirmpass.TextChanged += new System.EventHandler(this.tb_confirmpass_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Confirm password";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb_err_pass);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.tb_pass);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(503, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(676, 94);
            this.panel5.TabIndex = 15;
            // 
            // lb_err_pass
            // 
            this.lb_err_pass.AutoSize = true;
            this.lb_err_pass.ForeColor = System.Drawing.Color.Red;
            this.lb_err_pass.Location = new System.Drawing.Point(250, 62);
            this.lb_err_pass.Name = "lb_err_pass";
            this.lb_err_pass.Size = new System.Drawing.Size(288, 25);
            this.lb_err_pass.TabIndex = 4;
            this.lb_err_pass.Text = "Invalid and fill password! try again!";
            this.lb_err_pass.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(250, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(363, 1);
            this.panel6.TabIndex = 3;
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pass.ForeColor = System.Drawing.Color.Gray;
            this.tb_pass.Location = new System.Drawing.Point(250, 14);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(364, 38);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.UseSystemPasswordChar = true;
            this.tb_pass.Click += new System.EventHandler(this.tb_pass_Click);
            this.tb_pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_err_name);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tb_name);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(503, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 94);
            this.panel3.TabIndex = 16;
            // 
            // lb_err_name
            // 
            this.lb_err_name.AutoSize = true;
            this.lb_err_name.ForeColor = System.Drawing.Color.Red;
            this.lb_err_name.Location = new System.Drawing.Point(250, 62);
            this.lb_err_name.Name = "lb_err_name";
            this.lb_err_name.Size = new System.Drawing.Size(238, 25);
            this.lb_err_name.TabIndex = 4;
            this.lb_err_name.Text = "Invalid your name! try again!";
            this.lb_err_name.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(250, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 1);
            this.panel4.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_name.Location = new System.Drawing.Point(250, 14);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(364, 38);
            this.tb_name.TabIndex = 1;
            this.tb_name.Text = "Enter name";
            this.tb_name.Click += new System.EventHandler(this.tb_name_Click);
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_err_sdt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(503, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 94);
            this.panel1.TabIndex = 20;
            // 
            // lb_err_sdt
            // 
            this.lb_err_sdt.AutoSize = true;
            this.lb_err_sdt.ForeColor = System.Drawing.Color.Red;
            this.lb_err_sdt.Location = new System.Drawing.Point(250, 62);
            this.lb_err_sdt.Name = "lb_err_sdt";
            this.lb_err_sdt.Size = new System.Drawing.Size(271, 25);
            this.lb_err_sdt.TabIndex = 4;
            this.lb_err_sdt.Text = "Invalid phone number! try again!";
            this.lb_err_sdt.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(250, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 1);
            this.panel2.TabIndex = 3;
            // 
            // tb_sdt
            // 
            this.tb_sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_sdt.ForeColor = System.Drawing.Color.Gray;
            this.tb_sdt.Location = new System.Drawing.Point(250, 14);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(364, 38);
            this.tb_sdt.TabIndex = 1;
            this.tb_sdt.Text = "Enter  phone number";
            this.tb_sdt.Click += new System.EventHandler(this.tb_sdt_Click);
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone number";
            // 
            // linklb_login
            // 
            this.linklb_login.AutoSize = true;
            this.linklb_login.Location = new System.Drawing.Point(762, 636);
            this.linklb_login.Name = "linklb_login";
            this.linklb_login.Size = new System.Drawing.Size(195, 25);
            this.linklb_login.TabIndex = 19;
            this.linklb_login.TabStop = true;
            this.linklb_login.Text = "Already have a account";
            this.linklb_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_login_LinkClicked);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_register.Location = new System.Drawing.Point(762, 561);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(189, 57);
            this.btn_register.TabIndex = 18;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(753, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "Register";
            // 
            // FRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1279, 683);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linklb_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_logo);
            this.Controls.Add(this.pnl_header);
            this.Name = "FRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_header;
        private Panel pnl_logo;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Label lb_err_confirmpass;
        private Panel panel8;
        private TextBox tb_confirmpass;
        private Label label9;
        private Panel panel5;
        private Label lb_err_pass;
        private Panel panel6;
        private TextBox tb_pass;
        private Label label7;
        private Panel panel3;
        private Label lb_err_name;
        private Panel panel4;
        private TextBox tb_name;
        private Label label5;
        private Panel panel1;
        private Label lb_err_sdt;
        private Panel panel2;
        private TextBox tb_sdt;
        private Label label3;
        private LinkLabel linklb_login;
        private Button btn_register;
        private Label label2;
    }
}