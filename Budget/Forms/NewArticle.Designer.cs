namespace Budget
{
    partial class NewArticle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CommentAtr = new System.Windows.Forms.TextBox();
            this.tb_NameArt = new System.Windows.Forms.TextBox();
            this.tb_AmountArt = new System.Windows.Forms.TextBox();
            this.tb_PriceArt = new System.Windows.Forms.TextBox();
            this.btn_CreateNewArt = new System.Windows.Forms.Button();
            this.btn_CancelAddArt = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnIncome = new System.Windows.Forms.RadioButton();
            this.rbtnExpence = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Комментарий";
            // 
            // tb_CommentAtr
            // 
            this.tb_CommentAtr.Location = new System.Drawing.Point(90, 181);
            this.tb_CommentAtr.Multiline = true;
            this.tb_CommentAtr.Name = "tb_CommentAtr";
            this.tb_CommentAtr.Size = new System.Drawing.Size(184, 21);
            this.tb_CommentAtr.TabIndex = 4;
            // 
            // tb_NameArt
            // 
            this.tb_NameArt.Location = new System.Drawing.Point(90, 82);
            this.tb_NameArt.Multiline = true;
            this.tb_NameArt.Name = "tb_NameArt";
            this.tb_NameArt.Size = new System.Drawing.Size(184, 21);
            this.tb_NameArt.TabIndex = 5;
            // 
            // tb_AmountArt
            // 
            this.tb_AmountArt.Location = new System.Drawing.Point(90, 147);
            this.tb_AmountArt.Multiline = true;
            this.tb_AmountArt.Name = "tb_AmountArt";
            this.tb_AmountArt.Size = new System.Drawing.Size(184, 21);
            this.tb_AmountArt.TabIndex = 6;
            // 
            // tb_PriceArt
            // 
            this.tb_PriceArt.Location = new System.Drawing.Point(90, 116);
            this.tb_PriceArt.Multiline = true;
            this.tb_PriceArt.Name = "tb_PriceArt";
            this.tb_PriceArt.Size = new System.Drawing.Size(184, 21);
            this.tb_PriceArt.TabIndex = 7;
            // 
            // btn_CreateNewArt
            // 
            this.btn_CreateNewArt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_CreateNewArt.Location = new System.Drawing.Point(28, 213);
            this.btn_CreateNewArt.Name = "btn_CreateNewArt";
            this.btn_CreateNewArt.Size = new System.Drawing.Size(107, 31);
            this.btn_CreateNewArt.TabIndex = 8;
            this.btn_CreateNewArt.Text = "Добавить статью";
            this.btn_CreateNewArt.UseVisualStyleBackColor = true;
            this.btn_CreateNewArt.Click += new System.EventHandler(this.btn_CreateNewArt_Click);
            // 
            // btn_CancelAddArt
            // 
            this.btn_CancelAddArt.Location = new System.Drawing.Point(153, 213);
            this.btn_CancelAddArt.Name = "btn_CancelAddArt";
            this.btn_CancelAddArt.Size = new System.Drawing.Size(121, 31);
            this.btn_CancelAddArt.TabIndex = 9;
            this.btn_CancelAddArt.Text = "Отмена";
            this.btn_CancelAddArt.UseVisualStyleBackColor = true;
            this.btn_CancelAddArt.Click += new System.EventHandler(this.btn_CancelAddArt_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата";
            // 
            // rbtnIncome
            // 
            this.rbtnIncome.AutoSize = true;
            this.rbtnIncome.Location = new System.Drawing.Point(52, 18);
            this.rbtnIncome.Name = "rbtnIncome";
            this.rbtnIncome.Size = new System.Drawing.Size(57, 17);
            this.rbtnIncome.TabIndex = 12;
            this.rbtnIncome.Text = "Доход";
            this.rbtnIncome.UseVisualStyleBackColor = true;
            // 
            // rbtnExpence
            // 
            this.rbtnExpence.AutoSize = true;
            this.rbtnExpence.Checked = true;
            this.rbtnExpence.Location = new System.Drawing.Point(158, 18);
            this.rbtnExpence.Name = "rbtnExpence";
            this.rbtnExpence.Size = new System.Drawing.Size(61, 17);
            this.rbtnExpence.TabIndex = 13;
            this.rbtnExpence.TabStop = true;
            this.rbtnExpence.Text = "Расход";
            this.rbtnExpence.UseVisualStyleBackColor = true;
            // 
            // NewArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 256);
            this.Controls.Add(this.rbtnExpence);
            this.Controls.Add(this.rbtnIncome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_CancelAddArt);
            this.Controls.Add(this.btn_CreateNewArt);
            this.Controls.Add(this.tb_PriceArt);
            this.Controls.Add(this.tb_AmountArt);
            this.Controls.Add(this.tb_NameArt);
            this.Controls.Add(this.tb_CommentAtr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewArticle";
            this.ShowIcon = false;
            this.Text = "Создание новой статьи";
            this.Load += new System.EventHandler(this.NewArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CommentAtr;
        private System.Windows.Forms.TextBox tb_NameArt;
        private System.Windows.Forms.TextBox tb_AmountArt;
        private System.Windows.Forms.TextBox tb_PriceArt;
        private System.Windows.Forms.Button btn_CreateNewArt;
        private System.Windows.Forms.Button btn_CancelAddArt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnIncome;
        private System.Windows.Forms.RadioButton rbtnExpence;
    }
}