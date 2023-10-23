namespace PROJECT_NetGameVN_STINGDAU
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.lblShowUser = new System.Windows.Forms.Label();
            this.lblShowNew = new System.Windows.Forms.Label();
            this.lblShowInfor = new System.Windows.Forms.Label();
            this.lblShowConf = new System.Windows.Forms.Label();
            this.lblShowOld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "User Name";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(157, 181);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(208, 26);
            this.txtNewPass.TabIndex = 2;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(157, 237);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(208, 26);
            this.txtConfirm.TabIndex = 3;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(157, 122);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(208, 26);
            this.txtOldPass.TabIndex = 1;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(157, 64);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(208, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.Red;
            this.btnApply.Location = new System.Drawing.Point(277, 347);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(88, 31);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(157, 347);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(262, 284);
            this.chkShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(101, 17);
            this.chkShowPass.TabIndex = 16;
            this.chkShowPass.Text = "Show password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // lblShowUser
            // 
            this.lblShowUser.AutoSize = true;
            this.lblShowUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUser.ForeColor = System.Drawing.Color.White;
            this.lblShowUser.Location = new System.Drawing.Point(160, 93);
            this.lblShowUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowUser.Name = "lblShowUser";
            this.lblShowUser.Size = new System.Drawing.Size(13, 18);
            this.lblShowUser.TabIndex = 17;
            this.lblShowUser.Text = "-";
            this.lblShowUser.Click += new System.EventHandler(this.lblShowUser_Click);
            // 
            // lblShowNew
            // 
            this.lblShowNew.AutoSize = true;
            this.lblShowNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNew.ForeColor = System.Drawing.Color.White;
            this.lblShowNew.Location = new System.Drawing.Point(160, 210);
            this.lblShowNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowNew.Name = "lblShowNew";
            this.lblShowNew.Size = new System.Drawing.Size(13, 18);
            this.lblShowNew.TabIndex = 19;
            this.lblShowNew.Text = "-";
            this.lblShowNew.Click += new System.EventHandler(this.lblShowNew_Click);
            // 
            // lblShowInfor
            // 
            this.lblShowInfor.AutoSize = true;
            this.lblShowInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowInfor.ForeColor = System.Drawing.Color.Transparent;
            this.lblShowInfor.Location = new System.Drawing.Point(37, 320);
            this.lblShowInfor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowInfor.Name = "lblShowInfor";
            this.lblShowInfor.Size = new System.Drawing.Size(13, 18);
            this.lblShowInfor.TabIndex = 20;
            this.lblShowInfor.Text = "-";
            // 
            // lblShowConf
            // 
            this.lblShowConf.AutoSize = true;
            this.lblShowConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowConf.ForeColor = System.Drawing.Color.Transparent;
            this.lblShowConf.Location = new System.Drawing.Point(159, 265);
            this.lblShowConf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowConf.Name = "lblShowConf";
            this.lblShowConf.Size = new System.Drawing.Size(13, 18);
            this.lblShowConf.TabIndex = 20;
            this.lblShowConf.Text = "-";
            // 
            // lblShowOld
            // 
            this.lblShowOld.AutoSize = true;
            this.lblShowOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOld.ForeColor = System.Drawing.Color.White;
            this.lblShowOld.Location = new System.Drawing.Point(160, 151);
            this.lblShowOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowOld.Name = "lblShowOld";
            this.lblShowOld.Size = new System.Drawing.Size(13, 18);
            this.lblShowOld.TabIndex = 18;
            this.lblShowOld.Text = "-";
            this.lblShowOld.Click += new System.EventHandler(this.lblShowOld_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 389);
            this.Controls.Add(this.lblShowConf);
            this.Controls.Add(this.lblShowInfor);
            this.Controls.Add(this.lblShowNew);
            this.Controls.Add(this.lblShowOld);
            this.Controls.Add(this.lblShowUser);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label lblShowUser;
        private System.Windows.Forms.Label lblShowNew;
        private System.Windows.Forms.Label lblShowInfor;
        private System.Windows.Forms.Label lblShowConf;
        private System.Windows.Forms.Label lblShowOld;
    }
}