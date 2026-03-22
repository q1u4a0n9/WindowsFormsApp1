namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(26, 19);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(44, 16);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "label1";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Location = new System.Drawing.Point(26, 45);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(44, 16);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "label1";
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Location = new System.Drawing.Point(29, 82);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.Size = new System.Drawing.Size(797, 312);
            this.dgvDSSV.TabIndex = 2;
            this.dgvDSSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_CellContentClick);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(369, 411);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 38);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Close";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 461);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.Button btnDong;
    }
}