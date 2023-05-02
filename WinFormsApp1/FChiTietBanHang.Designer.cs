namespace Coffee
{
    partial class FChiTietBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton_cangiao_huy = new FontAwesome.Sharp.IconButton();
            this.label_maDH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_maloaihang = new System.Windows.Forms.Label();
            this.comboBox_danhsachmonan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton_themMon = new FontAwesome.Sharp.IconButton();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.iconButton_cangiao_huy);
            this.panel1.Controls.Add(this.label_maDH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 64);
            this.panel1.TabIndex = 0;
            // 
            // iconButton_cangiao_huy
            // 
            this.iconButton_cangiao_huy.BackColor = System.Drawing.SystemColors.Info;
            this.iconButton_cangiao_huy.FlatAppearance.BorderSize = 0;
            this.iconButton_cangiao_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_cangiao_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton_cangiao_huy.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton_cangiao_huy.IconColor = System.Drawing.Color.OliveDrab;
            this.iconButton_cangiao_huy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_cangiao_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_cangiao_huy.Location = new System.Drawing.Point(956, 4);
            this.iconButton_cangiao_huy.Margin = new System.Windows.Forms.Padding(8);
            this.iconButton_cangiao_huy.Name = "iconButton_cangiao_huy";
            this.iconButton_cangiao_huy.Size = new System.Drawing.Size(128, 54);
            this.iconButton_cangiao_huy.TabIndex = 26;
            this.iconButton_cangiao_huy.Text = "Thoát";
            this.iconButton_cangiao_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_cangiao_huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_cangiao_huy.UseVisualStyleBackColor = false;
            this.iconButton_cangiao_huy.Click += new System.EventHandler(this.iconButton_cangiao_huy_Click);
            // 
            // label_maDH
            // 
            this.label_maDH.AutoSize = true;
            this.label_maDH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_maDH.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_maDH.Location = new System.Drawing.Point(636, 18);
            this.label_maDH.Name = "label_maDH";
            this.label_maDH.Size = new System.Drawing.Size(38, 32);
            this.label_maDH.TabIndex = 1;
            this.label_maDH.Text = "sa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(138, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Món Ăn Của Đơn Hàng Có Mã:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 365);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_maloaihang);
            this.panel3.Controls.Add(this.comboBox_danhsachmonan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.iconButton_themMon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1296, 78);
            this.panel3.TabIndex = 1;
            // 
            // label_maloaihang
            // 
            this.label_maloaihang.AutoSize = true;
            this.label_maloaihang.Location = new System.Drawing.Point(625, 24);
            this.label_maloaihang.Name = "label_maloaihang";
            this.label_maloaihang.Size = new System.Drawing.Size(108, 25);
            this.label_maloaihang.TabIndex = 29;
            this.label_maloaihang.Text = "maloaiHang";
            // 
            // comboBox_danhsachmonan
            // 
            this.comboBox_danhsachmonan.FormattingEnabled = true;
            this.comboBox_danhsachmonan.Location = new System.Drawing.Point(375, 21);
            this.comboBox_danhsachmonan.Name = "comboBox_danhsachmonan";
            this.comboBox_danhsachmonan.Size = new System.Drawing.Size(244, 33);
            this.comboBox_danhsachmonan.TabIndex = 28;
            this.comboBox_danhsachmonan.SelectedValueChanged += new System.EventHandler(this.comboBox_danhsachmonan_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(113, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Danh Sách Món Ăn";
            // 
            // iconButton_themMon
            // 
            this.iconButton_themMon.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconButton_themMon.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton_themMon.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButton_themMon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_themMon.Location = new System.Drawing.Point(991, 6);
            this.iconButton_themMon.Name = "iconButton_themMon";
            this.iconButton_themMon.Size = new System.Drawing.Size(112, 66);
            this.iconButton_themMon.TabIndex = 0;
            this.iconButton_themMon.UseVisualStyleBackColor = true;
            this.iconButton_themMon.Click += new System.EventHandler(this.iconButton_themMon_Click);
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_list.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.RowHeadersWidth = 62;
            this.dataGridView_list.RowTemplate.Height = 33;
            this.dataGridView_list.Size = new System.Drawing.Size(1296, 287);
            this.dataGridView_list.TabIndex = 0;
            // 
            // FChiTietBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FChiTietBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Các Sản Phẩm Được Order";
            this.Load += new System.EventHandler(this.FChiTietBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label_maDH;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView_list;
        private FontAwesome.Sharp.IconButton iconButton_cangiao_huy;
        private Panel panel3;
        private ComboBox comboBox_danhsachmonan;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton_themMon;
        private Label label_maloaihang;
    }
}