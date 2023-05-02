namespace Coffee
{
    partial class Fchitietmonan
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
            this.label_maDH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label_maDH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 64);
            this.panel1.TabIndex = 1;
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
            // dataGridView_list
            // 
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_list.Location = new System.Drawing.Point(0, 64);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.RowHeadersWidth = 62;
            this.dataGridView_list.RowTemplate.Height = 33;
            this.dataGridView_list.Size = new System.Drawing.Size(1281, 287);
            this.dataGridView_list.TabIndex = 2;
            // 
            // Fchitietmonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 351);
            this.Controls.Add(this.dataGridView_list);
            this.Controls.Add(this.panel1);
            this.Name = "Fchitietmonan";
            this.Text = "Chi Tiết Món Ăn";
            this.Load += new System.EventHandler(this.Fchitietmonan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label_maDH;
        private Label label1;
        private DataGridView dataGridView_list;
    }
}