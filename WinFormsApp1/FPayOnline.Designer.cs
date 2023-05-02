namespace Coffee
{
    partial class FPayOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPayOnline));
            pictureBox1 = new PictureBox();
            button_done = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button_done
            // 
            button_done.BackColor = Color.FromArgb(161, 107, 86);
            button_done.FlatStyle = FlatStyle.Popup;
            button_done.Location = new Point(2, 293);
            button_done.Margin = new Padding(2, 2, 2, 2);
            button_done.Name = "button_done";
            button_done.Size = new Size(295, 44);
            button_done.TabIndex = 4;
            button_done.Text = "ĐÃ XONG";
            button_done.UseVisualStyleBackColor = false;
            button_done.Click += button_done_Click;
            // 
            // FPayOnline
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 202, 6);
            ClientSize = new Size(297, 335);
            Controls.Add(button_done);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FPayOnline";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay Online";
            Load += FPayOnline_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_done;
    }
}