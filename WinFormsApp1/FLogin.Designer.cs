namespace WinFormsApp1
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            pnl_header = new Panel();
            pnl_logo = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnl_login = new Panel();
            btn_exit = new Button();
            linklb_register = new LinkLabel();
            btn_login = new Button();
            panel3 = new Panel();
            lb_err_pass = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            tb_password = new TextBox();
            label5 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lb_err_sdt = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            tb_sdt = new TextBox();
            label3 = new Label();
            pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_login.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.BackColor = Color.Gold;
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Margin = new Padding(2, 2, 2, 2);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(999, 49);
            pnl_header.TabIndex = 1;
            // 
            // pnl_logo
            // 
            pnl_logo.BackColor = Color.FromArgb(50, 50, 50);
            pnl_logo.Controls.Add(label1);
            pnl_logo.Controls.Add(pictureBox1);
            pnl_logo.Dock = DockStyle.Left;
            pnl_logo.Location = new Point(0, 49);
            pnl_logo.Margin = new Padding(2, 2, 2, 2);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(331, 498);
            pnl_logo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(17, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 41);
            label1.TabIndex = 1;
            label1.Text = "Chuỗi Café ÔNG BẦU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 141);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnl_login
            // 
            pnl_login.BackColor = Color.FromArgb(30, 30, 30);
            pnl_login.BackgroundImageLayout = ImageLayout.None;
            pnl_login.Controls.Add(btn_exit);
            pnl_login.Controls.Add(linklb_register);
            pnl_login.Controls.Add(btn_login);
            pnl_login.Controls.Add(panel3);
            pnl_login.Controls.Add(label2);
            pnl_login.Controls.Add(panel1);
            pnl_login.Dock = DockStyle.Fill;
            pnl_login.ForeColor = SystemColors.AppWorkspace;
            pnl_login.Location = new Point(331, 49);
            pnl_login.Margin = new Padding(2, 2, 2, 2);
            pnl_login.Name = "pnl_login";
            pnl_login.Size = new Size(668, 498);
            pnl_login.TabIndex = 3;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(0, 192, 0);
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.ForeColor = SystemColors.ActiveCaptionText;
            btn_exit.Location = new Point(366, 299);
            btn_exit.Margin = new Padding(2, 2, 2, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(151, 46);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // linklb_register
            // 
            linklb_register.AutoSize = true;
            linklb_register.Location = new Point(264, 366);
            linklb_register.Margin = new Padding(2, 0, 2, 0);
            linklb_register.Name = "linklb_register";
            linklb_register.Size = new Size(139, 20);
            linklb_register.TabIndex = 7;
            linklb_register.TabStop = true;
            linklb_register.Text = "Create new account";
            linklb_register.LinkClicked += linklb_register_LinkClicked;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(0, 192, 0);
            btn_login.Cursor = Cursors.Hand;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ActiveCaptionText;
            btn_login.Location = new Point(154, 299);
            btn_login.Margin = new Padding(2, 2, 2, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(151, 46);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lb_err_pass);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(tb_password);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(50, 180);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(541, 75);
            panel3.TabIndex = 5;
            // 
            // lb_err_pass
            // 
            lb_err_pass.AutoSize = true;
            lb_err_pass.ForeColor = Color.Red;
            lb_err_pass.Location = new Point(200, 50);
            lb_err_pass.Margin = new Padding(2, 0, 2, 0);
            lb_err_pass.Name = "lb_err_pass";
            lb_err_pass.Size = new Size(190, 20);
            lb_err_pass.TabIndex = 4;
            lb_err_pass.Text = "Invalid password! try again!";
            lb_err_pass.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(200, 46);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(290, 1);
            panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 2);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // tb_password
            // 
            tb_password.BackColor = Color.FromArgb(30, 30, 30);
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tb_password.ForeColor = Color.Gray;
            tb_password.Location = new Point(200, 11);
            tb_password.Margin = new Padding(2, 2, 2, 2);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(291, 32);
            tb_password.TabIndex = 1;
            tb_password.UseSystemPasswordChar = true;
            tb_password.Click += tb_password_Click;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 17);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 0;
            label5.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(264, 26);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 40);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_err_sdt);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(tb_sdt);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(50, 83);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 75);
            panel1.TabIndex = 0;
            // 
            // lb_err_sdt
            // 
            lb_err_sdt.AutoSize = true;
            lb_err_sdt.ForeColor = Color.Red;
            lb_err_sdt.Location = new Point(200, 49);
            lb_err_sdt.Margin = new Padding(2, 0, 2, 0);
            lb_err_sdt.Name = "lb_err_sdt";
            lb_err_sdt.Size = new Size(224, 20);
            lb_err_sdt.TabIndex = 4;
            lb_err_sdt.Text = "Invalid phone number! try again!";
            lb_err_sdt.Visible = false;
            lb_err_sdt.Click += lb_err_sdt_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(200, 46);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 1);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tb_sdt
            // 
            tb_sdt.BackColor = Color.FromArgb(30, 30, 30);
            tb_sdt.BorderStyle = BorderStyle.None;
            tb_sdt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tb_sdt.ForeColor = Color.Gray;
            tb_sdt.Location = new Point(200, 11);
            tb_sdt.Margin = new Padding(2, 2, 2, 2);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(291, 32);
            tb_sdt.TabIndex = 1;
            tb_sdt.Text = "Enter  phone number";
            tb_sdt.Click += tb_sdt_Click;
            tb_sdt.TextChanged += tb_sdt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 0;
            label3.Text = "Phone number";
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 547);
            Controls.Add(pnl_login);
            Controls.Add(pnl_logo);
            Controls.Add(pnl_header);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FLogin_Load;
            pnl_logo.ResumeLayout(false);
            pnl_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_login.ResumeLayout(false);
            pnl_login.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_header;
        private Panel pnl_logo;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnl_login;
        private Button btn_exit;
        private LinkLabel linklb_register;
        private Button btn_login;
        private Panel panel3;
        private Label lb_err_pass;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox tb_password;
        private Label label5;
        private Label label2;
        private Panel panel1;
        private Label lb_err_sdt;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox tb_sdt;
        private Label label3;
    }
}