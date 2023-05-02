namespace Coffee
{
    partial class FDanhSachSanPhamSapHET
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.iconButton_cangiao_huy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 64);
            this.panel1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(138, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sản phẩm sắp hết hàng";
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_list.Location = new System.Drawing.Point(0, 64);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.RowHeadersWidth = 62;
            this.dataGridView_list.RowTemplate.Height = 33;
            this.dataGridView_list.Size = new System.Drawing.Size(1131, 287);
            this.dataGridView_list.TabIndex = 2;
            // 
            // FDanhSachSanPhamSapHET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 352);
            this.Controls.Add(this.dataGridView_list);
            this.Controls.Add(this.panel1);
            this.Name = "FDanhSachSanPhamSapHET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sản phẩm sắp hết hàng";
            this.Load += new System.EventHandler(this.FDanhSachSanPhamSapHET_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton_cangiao_huy;
        private Label label1;
        private DataGridView dataGridView_list;
    }
}