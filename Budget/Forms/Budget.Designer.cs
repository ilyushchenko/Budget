namespace Budget
{
    partial class Budget
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReestablish = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.gBRevise = new System.Windows.Forms.GroupBox();
            this.rBMonth = new System.Windows.Forms.RadioButton();
            this.raBWeek = new System.Windows.Forms.RadioButton();
            this.rBDay = new System.Windows.Forms.RadioButton();
            this.gBStatistics = new System.Windows.Forms.GroupBox();
            this.lSaldo = new System.Windows.Forms.Label();
            this.lExpence = new System.Windows.Forms.Label();
            this.lIncome = new System.Windows.Forms.Label();
            this.labSaldo = new System.Windows.Forms.Label();
            this.labExpense = new System.Windows.Forms.Label();
            this.labIncome = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isincome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBCategory = new System.Windows.Forms.GroupBox();
            this.lstbx_Categories = new System.Windows.Forms.ListBox();
            this.btn_AddNewArt = new System.Windows.Forms.Button();
            this.picBoxDel = new System.Windows.Forms.PictureBox();
            this.picBoxEdit = new System.Windows.Forms.PictureBox();
            this.picBoxAdd = new System.Windows.Forms.PictureBox();
            this.pnl_AddEditCtg = new System.Windows.Forms.Panel();
            this.btn_CancelAddNewCtg = new System.Windows.Forms.Button();
            this.btnAddNewCtg = new System.Windows.Forms.Button();
            this.tb_NameCtg = new System.Windows.Forms.TextBox();
            this.lbl_help = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rBAll = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.gBRevise.SuspendLayout();
            this.gBStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gBCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).BeginInit();
            this.pnl_AddEditCtg.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiCorrection,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateNewFile,
            this.tsmiOpenFile,
            this.toolStripMenuItem2,
            this.tsmiSaveFile,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Фаил";
            // 
            // tsmiCreateNewFile
            // 
            this.tsmiCreateNewFile.Name = "tsmiCreateNewFile";
            this.tsmiCreateNewFile.Size = new System.Drawing.Size(132, 22);
            this.tsmiCreateNewFile.Text = "Создать";
            // 
            // tsmiOpenFile
            // 
            this.tsmiOpenFile.Name = "tsmiOpenFile";
            this.tsmiOpenFile.Size = new System.Drawing.Size(132, 22);
            this.tsmiOpenFile.Text = "Открыть";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // tsmiSaveFile
            // 
            this.tsmiSaveFile.Name = "tsmiSaveFile";
            this.tsmiSaveFile.Size = new System.Drawing.Size(132, 22);
            this.tsmiSaveFile.Text = "Сохранить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(132, 22);
            this.tsmiExit.Text = "Выход";
            // 
            // tsmiCorrection
            // 
            this.tsmiCorrection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancel,
            this.tsmiReestablish,
            this.toolStripMenuItem3,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete});
            this.tsmiCorrection.Name = "tsmiCorrection";
            this.tsmiCorrection.Size = new System.Drawing.Size(59, 20);
            this.tsmiCorrection.Text = "Правка";
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(139, 22);
            this.tsmiCancel.Text = "Отменить";
            // 
            // tsmiReestablish
            // 
            this.tsmiReestablish.Name = "tsmiReestablish";
            this.tsmiReestablish.Size = new System.Drawing.Size(139, 22);
            this.tsmiReestablish.Text = "Вернуть";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(139, 22);
            this.tsmiCut.Text = "Вырезать";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(139, 22);
            this.tsmiCopy.Text = "Копировать";
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(139, 22);
            this.tsmiPaste.Text = "Вставить";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(139, 22);
            this.tsmiDelete.Text = "Удалить";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowHelp,
            this.tsmiAboutProgram});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(65, 20);
            this.tsmiHelp.Text = "Справка";
            // 
            // tsmiShowHelp
            // 
            this.tsmiShowHelp.Name = "tsmiShowHelp";
            this.tsmiShowHelp.Size = new System.Drawing.Size(179, 22);
            this.tsmiShowHelp.Text = "Просмотр справки";
            // 
            // tsmiAboutProgram
            // 
            this.tsmiAboutProgram.Name = "tsmiAboutProgram";
            this.tsmiAboutProgram.Size = new System.Drawing.Size(179, 22);
            this.tsmiAboutProgram.Text = "О программе";
            // 
            // gBRevise
            // 
            this.gBRevise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBRevise.Controls.Add(this.rBAll);
            this.gBRevise.Controls.Add(this.radioButton1);
            this.gBRevise.Controls.Add(this.dateTimePicker2);
            this.gBRevise.Controls.Add(this.dateTimePicker1);
            this.gBRevise.Controls.Add(this.label2);
            this.gBRevise.Controls.Add(this.label1);
            this.gBRevise.Controls.Add(this.rBMonth);
            this.gBRevise.Controls.Add(this.raBWeek);
            this.gBRevise.Controls.Add(this.rBDay);
            this.gBRevise.Location = new System.Drawing.Point(805, 16);
            this.gBRevise.Name = "gBRevise";
            this.gBRevise.Size = new System.Drawing.Size(164, 177);
            this.gBRevise.TabIndex = 2;
            this.gBRevise.TabStop = false;
            this.gBRevise.Text = "Просмотр";
            // 
            // rBMonth
            // 
            this.rBMonth.AutoSize = true;
            this.rBMonth.Location = new System.Drawing.Point(12, 59);
            this.rBMonth.Name = "rBMonth";
            this.rBMonth.Size = new System.Drawing.Size(73, 17);
            this.rBMonth.TabIndex = 5;
            this.rBMonth.TabStop = true;
            this.rBMonth.Text = "За месяц";
            this.rBMonth.UseVisualStyleBackColor = true;
            // 
            // raBWeek
            // 
            this.raBWeek.AutoSize = true;
            this.raBWeek.Location = new System.Drawing.Point(12, 38);
            this.raBWeek.Name = "raBWeek";
            this.raBWeek.Size = new System.Drawing.Size(79, 17);
            this.raBWeek.TabIndex = 4;
            this.raBWeek.TabStop = true;
            this.raBWeek.Text = "За неделю";
            this.raBWeek.UseVisualStyleBackColor = true;
            // 
            // rBDay
            // 
            this.rBDay.AutoSize = true;
            this.rBDay.Location = new System.Drawing.Point(12, 17);
            this.rBDay.Name = "rBDay";
            this.rBDay.Size = new System.Drawing.Size(65, 17);
            this.rBDay.TabIndex = 3;
            this.rBDay.TabStop = true;
            this.rBDay.Text = "За день";
            this.rBDay.UseVisualStyleBackColor = true;
            // 
            // gBStatistics
            // 
            this.gBStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBStatistics.Controls.Add(this.lSaldo);
            this.gBStatistics.Controls.Add(this.lExpence);
            this.gBStatistics.Controls.Add(this.lIncome);
            this.gBStatistics.Controls.Add(this.labSaldo);
            this.gBStatistics.Controls.Add(this.labExpense);
            this.gBStatistics.Controls.Add(this.labIncome);
            this.gBStatistics.Location = new System.Drawing.Point(7, 277);
            this.gBStatistics.Name = "gBStatistics";
            this.gBStatistics.Size = new System.Drawing.Size(164, 83);
            this.gBStatistics.TabIndex = 3;
            this.gBStatistics.TabStop = false;
            this.gBStatistics.Text = "Статистика";
            // 
            // lSaldo
            // 
            this.lSaldo.AutoSize = true;
            this.lSaldo.Location = new System.Drawing.Point(67, 61);
            this.lSaldo.Name = "lSaldo";
            this.lSaldo.Size = new System.Drawing.Size(13, 13);
            this.lSaldo.TabIndex = 5;
            this.lSaldo.Text = "3";
            // 
            // lExpence
            // 
            this.lExpence.AutoSize = true;
            this.lExpence.Location = new System.Drawing.Point(67, 41);
            this.lExpence.Name = "lExpence";
            this.lExpence.Size = new System.Drawing.Size(13, 13);
            this.lExpence.TabIndex = 4;
            this.lExpence.Text = "2";
            // 
            // lIncome
            // 
            this.lIncome.AutoSize = true;
            this.lIncome.Location = new System.Drawing.Point(67, 19);
            this.lIncome.Name = "lIncome";
            this.lIncome.Size = new System.Drawing.Size(13, 13);
            this.lIncome.TabIndex = 3;
            this.lIncome.Text = "1";
            // 
            // labSaldo
            // 
            this.labSaldo.AutoSize = true;
            this.labSaldo.Location = new System.Drawing.Point(11, 61);
            this.labSaldo.Name = "labSaldo";
            this.labSaldo.Size = new System.Drawing.Size(44, 13);
            this.labSaldo.TabIndex = 2;
            this.labSaldo.Text = "Сальдо";
            // 
            // labExpense
            // 
            this.labExpense.AutoSize = true;
            this.labExpense.Location = new System.Drawing.Point(11, 40);
            this.labExpense.Name = "labExpense";
            this.labExpense.Size = new System.Drawing.Size(43, 13);
            this.labExpense.TabIndex = 1;
            this.labExpense.Text = "Расход";
            // 
            // labIncome
            // 
            this.labIncome.AutoSize = true;
            this.labIncome.Location = new System.Drawing.Point(11, 19);
            this.labIncome.Name = "labIncome";
            this.labIncome.Size = new System.Drawing.Size(39, 13);
            this.labIncome.TabIndex = 0;
            this.labIncome.Text = "Доход";
            // 
            // Calendar
            // 
            this.Calendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Calendar.Location = new System.Drawing.Point(805, 198);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Isincome});
            this.dataGridView.Location = new System.Drawing.Point(181, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(618, 344);
            this.dataGridView.TabIndex = 5;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Дата";
            this.Column6.Name = "Column6";
            this.Column6.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Категория";
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стоимость";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество";
            this.Column4.Name = "Column4";
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Комментарий";
            this.Column5.Name = "Column5";
            // 
            // Isincome
            // 
            this.Isincome.HeaderText = "Доход/Расход";
            this.Isincome.Name = "Isincome";
            // 
            // gBCategory
            // 
            this.gBCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBCategory.Controls.Add(this.lstbx_Categories);
            this.gBCategory.Controls.Add(this.btn_AddNewArt);
            this.gBCategory.Controls.Add(this.picBoxDel);
            this.gBCategory.Controls.Add(this.picBoxEdit);
            this.gBCategory.Controls.Add(this.picBoxAdd);
            this.gBCategory.Location = new System.Drawing.Point(7, 16);
            this.gBCategory.Name = "gBCategory";
            this.gBCategory.Size = new System.Drawing.Size(168, 260);
            this.gBCategory.TabIndex = 6;
            this.gBCategory.TabStop = false;
            this.gBCategory.Text = "Категории";
            // 
            // lstbx_Categories
            // 
            this.lstbx_Categories.FormattingEnabled = true;
            this.lstbx_Categories.Location = new System.Drawing.Point(7, 19);
            this.lstbx_Categories.Name = "lstbx_Categories";
            this.lstbx_Categories.Size = new System.Drawing.Size(122, 199);
            this.lstbx_Categories.TabIndex = 6;
            this.lstbx_Categories.SelectedIndexChanged += new System.EventHandler(this.lstbx_Categories_SelectedIndexChanged);
            // 
            // btn_AddNewArt
            // 
            this.btn_AddNewArt.Enabled = false;
            this.btn_AddNewArt.Location = new System.Drawing.Point(7, 224);
            this.btn_AddNewArt.Name = "btn_AddNewArt";
            this.btn_AddNewArt.Size = new System.Drawing.Size(151, 30);
            this.btn_AddNewArt.TabIndex = 5;
            this.btn_AddNewArt.Text = "Добавить статью";
            this.btn_AddNewArt.UseVisualStyleBackColor = true;
            this.btn_AddNewArt.Click += new System.EventHandler(this.btn_AddNewArt_Click);
            // 
            // picBoxDel
            // 
            this.picBoxDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxDel.Enabled = false;
            this.picBoxDel.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDel.Image")));
            this.picBoxDel.Location = new System.Drawing.Point(135, 80);
            this.picBoxDel.Name = "picBoxDel";
            this.picBoxDel.Size = new System.Drawing.Size(23, 25);
            this.picBoxDel.TabIndex = 4;
            this.picBoxDel.TabStop = false;
            this.picBoxDel.Click += new System.EventHandler(this.picBoxDel_Click);
            // 
            // picBoxEdit
            // 
            this.picBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxEdit.Enabled = false;
            this.picBoxEdit.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEdit.Image")));
            this.picBoxEdit.Location = new System.Drawing.Point(135, 50);
            this.picBoxEdit.Name = "picBoxEdit";
            this.picBoxEdit.Size = new System.Drawing.Size(23, 24);
            this.picBoxEdit.TabIndex = 2;
            this.picBoxEdit.TabStop = false;
            this.picBoxEdit.Click += new System.EventHandler(this.picBoxEdit_Click);
            // 
            // picBoxAdd
            // 
            this.picBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAdd.Enabled = false;
            this.picBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAdd.Image")));
            this.picBoxAdd.Location = new System.Drawing.Point(135, 19);
            this.picBoxAdd.Name = "picBoxAdd";
            this.picBoxAdd.Size = new System.Drawing.Size(23, 24);
            this.picBoxAdd.TabIndex = 0;
            this.picBoxAdd.TabStop = false;
            this.picBoxAdd.Click += new System.EventHandler(this.picBoxAdd_Click);
            // 
            // pnl_AddEditCtg
            // 
            this.pnl_AddEditCtg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_AddEditCtg.Controls.Add(this.btn_CancelAddNewCtg);
            this.pnl_AddEditCtg.Controls.Add(this.btnAddNewCtg);
            this.pnl_AddEditCtg.Controls.Add(this.tb_NameCtg);
            this.pnl_AddEditCtg.Controls.Add(this.lbl_help);
            this.pnl_AddEditCtg.Location = new System.Drawing.Point(465, 136);
            this.pnl_AddEditCtg.Name = "pnl_AddEditCtg";
            this.pnl_AddEditCtg.Size = new System.Drawing.Size(199, 117);
            this.pnl_AddEditCtg.TabIndex = 9;
            this.pnl_AddEditCtg.Visible = false;
            // 
            // btn_CancelAddNewCtg
            // 
            this.btn_CancelAddNewCtg.Location = new System.Drawing.Point(105, 84);
            this.btn_CancelAddNewCtg.Name = "btn_CancelAddNewCtg";
            this.btn_CancelAddNewCtg.Size = new System.Drawing.Size(74, 23);
            this.btn_CancelAddNewCtg.TabIndex = 3;
            this.btn_CancelAddNewCtg.Text = "Отмена";
            this.btn_CancelAddNewCtg.UseVisualStyleBackColor = true;
            this.btn_CancelAddNewCtg.Click += new System.EventHandler(this.btn_CancelAddNewCtg_Click);
            // 
            // btnAddNewCtg
            // 
            this.btnAddNewCtg.Location = new System.Drawing.Point(21, 84);
            this.btnAddNewCtg.Name = "btnAddNewCtg";
            this.btnAddNewCtg.Size = new System.Drawing.Size(74, 23);
            this.btnAddNewCtg.TabIndex = 2;
            this.btnAddNewCtg.Text = "Добавить";
            this.btnAddNewCtg.UseVisualStyleBackColor = true;
            this.btnAddNewCtg.Click += new System.EventHandler(this.btnAddNewCtg_Click);
            // 
            // tb_NameCtg
            // 
            this.tb_NameCtg.Location = new System.Drawing.Point(21, 50);
            this.tb_NameCtg.Multiline = true;
            this.tb_NameCtg.Name = "tb_NameCtg";
            this.tb_NameCtg.Size = new System.Drawing.Size(158, 28);
            this.tb_NameCtg.TabIndex = 1;
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Location = new System.Drawing.Point(18, 22);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(0, 13);
            this.lbl_help.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "с";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(28, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "За промежуток";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rBAll
            // 
            this.rBAll.AutoSize = true;
            this.rBAll.Location = new System.Drawing.Point(12, 80);
            this.rBAll.Name = "rBAll";
            this.rBAll.Size = new System.Drawing.Size(94, 17);
            this.rBAll.TabIndex = 11;
            this.rBAll.TabStop = true;
            this.rBAll.Text = "За всё время";
            this.rBAll.UseVisualStyleBackColor = true;
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1120, 363);
            this.Controls.Add(this.pnl_AddEditCtg);
            this.Controls.Add(this.gBCategory);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.gBStatistics);
            this.Controls.Add(this.gBRevise);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Budget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Программа ведения бюджета";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Budget_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBRevise.ResumeLayout(false);
            this.gBRevise.PerformLayout();
            this.gBStatistics.ResumeLayout(false);
            this.gBStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gBCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).EndInit();
            this.pnl_AddEditCtg.ResumeLayout(false);
            this.pnl_AddEditCtg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateNewFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorrection;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmiReestablish;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowHelp;
        private System.Windows.Forms.GroupBox gBRevise;
        private System.Windows.Forms.RadioButton rBMonth;
        private System.Windows.Forms.RadioButton raBWeek;
        private System.Windows.Forms.RadioButton rBDay;
        private System.Windows.Forms.GroupBox gBStatistics;
        private System.Windows.Forms.Label labSaldo;
        private System.Windows.Forms.Label labExpense;
        private System.Windows.Forms.Label labIncome;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutProgram;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.GroupBox gBCategory;
        private System.Windows.Forms.PictureBox picBoxDel;
        private System.Windows.Forms.PictureBox picBoxEdit;
        private System.Windows.Forms.PictureBox picBoxAdd;
        private System.Windows.Forms.Label lSaldo;
        private System.Windows.Forms.Label lExpence;
        private System.Windows.Forms.Label lIncome;
        private System.Windows.Forms.Button btn_AddNewArt;
        private System.Windows.Forms.ListBox lstbx_Categories;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel pnl_AddEditCtg;
        private System.Windows.Forms.Button btnAddNewCtg;
        private System.Windows.Forms.TextBox tb_NameCtg;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_CancelAddNewCtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isincome;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rBAll;
    }
}

