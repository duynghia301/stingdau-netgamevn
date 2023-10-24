namespace PROJECT_NetGameVN_STINGDAU
{
    partial class frmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbDV = new System.Windows.Forms.GroupBox();
            this.dgvListDV = new System.Windows.Forms.DataGridView();
            this.picBDV = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grbDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(303, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Dịch Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Dịch Vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(133, 23);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(198, 26);
            this.txtMaDV.TabIndex = 0;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(133, 68);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(198, 26);
            this.txtTenDV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Dịch Vụ";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(133, 115);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(198, 26);
            this.txtGiaTien.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá Tiền";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(133, 161);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(198, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm Dịch Vụ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(133, 214);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(198, 32);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa Dịch Vụ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(133, 272);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(198, 32);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa Dịch Vụ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBaoCao.Location = new System.Drawing.Point(133, 327);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(198, 32);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.txtMaDV);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtTenDV);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 370);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // grbDV
            // 
            this.grbDV.Controls.Add(this.dgvListDV);
            this.grbDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDV.Location = new System.Drawing.Point(386, 69);
            this.grbDV.Name = "grbDV";
            this.grbDV.Size = new System.Drawing.Size(532, 370);
            this.grbDV.TabIndex = 7;
            this.grbDV.TabStop = false;
            this.grbDV.Text = "Danh sách dịch vụ";
            this.grbDV.Enter += new System.EventHandler(this.grbDV_Enter);
            // 
            // dgvListDV
            // 
            this.dgvListDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDV.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvListDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListDV.Location = new System.Drawing.Point(3, 20);
            this.dgvListDV.Name = "dgvListDV";
            this.dgvListDV.Size = new System.Drawing.Size(526, 347);
            this.dgvListDV.TabIndex = 0;
            this.dgvListDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDV_CellClick);
            this.dgvListDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDV_CellContentClick);
            // 
            // picBDV
            // 
            this.picBDV.Image = global::PROJECT_NetGameVN_STINGDAU.Properties.Resources.Sync;
            this.picBDV.Location = new System.Drawing.Point(803, 23);
            this.picBDV.Name = "picBDV";
            this.picBDV.Size = new System.Drawing.Size(43, 40);
            this.picBDV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBDV.TabIndex = 8;
            this.picBDV.TabStop = false;
            this.picBDV.Click += new System.EventHandler(this.picBDV_Click);
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 459);
            this.Controls.Add(this.picBDV);
            this.Controls.Add(this.grbDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDichVu";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbDV;
        private System.Windows.Forms.DataGridView dgvListDV;
        private System.Windows.Forms.PictureBox picBDV;
    }
}