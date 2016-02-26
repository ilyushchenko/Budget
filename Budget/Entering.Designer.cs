namespace Budget
{
    partial class Entering
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_CreateNewUser = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_UserName);
            this.groupBox1.Controls.Add(this.tb_Password);
            this.groupBox1.Controls.Add(this.lbl_Password);
            this.groupBox1.Controls.Add(this.lbl_UserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(6, 41);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(202, 20);
            this.tb_UserName.TabIndex = 3;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(6, 92);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(202, 20);
            this.tb_Password.TabIndex = 2;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(6, 71);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(45, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Пароль";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(3, 16);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(103, 13);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "Имя пользователя";
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(136, 150);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(84, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Выход";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_CreateNewUser
            // 
            this.btn_CreateNewUser.Location = new System.Drawing.Point(18, 192);
            this.btn_CreateNewUser.Name = "btn_CreateNewUser";
            this.btn_CreateNewUser.Size = new System.Drawing.Size(202, 23);
            this.btn_CreateNewUser.TabIndex = 5;
            this.btn_CreateNewUser.Text = "Создать нового пользователя";
            this.btn_CreateNewUser.UseVisualStyleBackColor = true;
            this.btn_CreateNewUser.Click += new System.EventHandler(this.btn_CreateNewUser_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(21, 150);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(84, 23);
            this.btn_Enter.TabIndex = 6;
            this.btn_Enter.Text = "Войти";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // Entering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 226);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_CreateNewUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entering";
            this.Text = "Выберите пользователя";
            this.Load += new System.EventHandler(this.Entering_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_CreateNewUser;
        private System.Windows.Forms.Button btn_Enter;
    }
}