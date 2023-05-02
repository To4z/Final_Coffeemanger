namespace CoffeeOngBau
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tbxAcc = new TextBox();
            tbxPass = new TextBox();
            btnLog = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lb_err_pass = new Label();
            lb_err_sdt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // tbxAcc
            // 
            tbxAcc.BackColor = SystemColors.Info;
            tbxAcc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAcc.Location = new Point(453, 157);
            tbxAcc.Margin = new Padding(5);
            tbxAcc.Name = "tbxAcc";
            tbxAcc.PlaceholderText = "Tài khoản";
            tbxAcc.Size = new Size(288, 34);
            tbxAcc.TabIndex = 2;
            tbxAcc.TextChanged += textBox1_TextChanged;
            // 
            // tbxPass
            // 
            tbxPass.BackColor = SystemColors.Info;
            tbxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPass.Location = new Point(453, 225);
            tbxPass.Margin = new Padding(5);
            tbxPass.Name = "tbxPass";
            tbxPass.PlaceholderText = "Mật khẩu";
            tbxPass.Size = new Size(288, 34);
            tbxPass.TabIndex = 3;
            tbxPass.UseSystemPasswordChar = true;
            tbxPass.TextChanged += tbxPass_TextChanged;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(161, 107, 86);
            btnLog.FlatStyle = FlatStyle.Popup;
            btnLog.Location = new Point(471, 298);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(115, 34);
            btnLog.TabIndex = 4;
            btnLog.Text = "Đăng nhâp";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(161, 107, 86);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(606, 298);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(161, 107, 86);
            label1.Location = new Point(453, 36);
            label1.Name = "label1";
            label1.Size = new Size(277, 31);
            label1.TabIndex = 6;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.BackColorChanged += label1_Click;
            label1.Click += label1_Click;
            label1.Paint += textBox1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(161, 107, 86);
            label2.Location = new Point(498, 372);
            label2.Name = "label2";
            label2.Size = new Size(204, 20);
            label2.TabIndex = 7;
            label2.Text = "Chuỗi café thương hiệu Việt";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(222, 197, 132);
            label3.Location = new Point(485, 392);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 8;
            label3.Text = "Vietnamese brand coffee chain";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb_err_pass);
            panel1.Controls.Add(lb_err_sdt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 9;
            // 
            // lb_err_pass
            // 
            lb_err_pass.AutoSize = true;
            lb_err_pass.ForeColor = Color.Red;
            lb_err_pass.Location = new Point(453, 264);
            lb_err_pass.Margin = new Padding(2, 0, 2, 0);
            lb_err_pass.Name = "lb_err_pass";
            lb_err_pass.Size = new Size(190, 20);
            lb_err_pass.TabIndex = 11;
            lb_err_pass.Text = "Invalid password! try again!";
            lb_err_pass.Visible = false;
            // 
            // lb_err_sdt
            // 
            lb_err_sdt.AutoSize = true;
            lb_err_sdt.ForeColor = Color.Red;
            lb_err_sdt.Location = new Point(453, 196);
            lb_err_sdt.Margin = new Padding(2, 0, 2, 0);
            lb_err_sdt.Name = "lb_err_sdt";
            lb_err_sdt.Size = new Size(224, 20);
            lb_err_sdt.TabIndex = 10;
            lb_err_sdt.Text = "Invalid phone number! try again!";
            lb_err_sdt.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 214, 107);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnLog);
            Controls.Add(tbxPass);
            Controls.Add(tbxAcc);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tbxAcc;
        private TextBox tbxPass;
        private Button btnLog;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label lb_err_sdt;
        private Label lb_err_pass;
    }
}