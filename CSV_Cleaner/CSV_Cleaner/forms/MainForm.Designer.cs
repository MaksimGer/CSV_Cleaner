namespace CSV_Cleaner
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFileNameTitle = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblSelectSeparator = new System.Windows.Forms.Label();
            this.cmbBoxDelimiter = new System.Windows.Forms.ComboBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvAttributes = new System.Windows.Forms.DataGridView();
            this.selectCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.showInfoCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chBoxDelMissVal = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // lblFileNameTitle
            // 
            this.lblFileNameTitle.AutoSize = true;
            this.lblFileNameTitle.Location = new System.Drawing.Point(12, 44);
            this.lblFileNameTitle.Name = "lblFileNameTitle";
            this.lblFileNameTitle.Size = new System.Drawing.Size(70, 13);
            this.lblFileNameTitle.TabIndex = 1;
            this.lblFileNameTitle.Text = "Имя файла: ";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(88, 44);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(95, 13);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "Файл не выбран!";
            // 
            // lblSelectSeparator
            // 
            this.lblSelectSeparator.AutoSize = true;
            this.lblSelectSeparator.Location = new System.Drawing.Point(13, 83);
            this.lblSelectSeparator.Name = "lblSelectSeparator";
            this.lblSelectSeparator.Size = new System.Drawing.Size(73, 13);
            this.lblSelectSeparator.TabIndex = 3;
            this.lblSelectSeparator.Text = "Разделитель";
            // 
            // cmbBoxDelimiter
            // 
            this.cmbBoxDelimiter.FormattingEnabled = true;
            this.cmbBoxDelimiter.Location = new System.Drawing.Point(92, 80);
            this.cmbBoxDelimiter.Name = "cmbBoxDelimiter";
            this.cmbBoxDelimiter.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDelimiter.TabIndex = 4;
            this.cmbBoxDelimiter.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSepar_SelectedIndexChanged);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(16, 114);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(352, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Считать из файла";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(374, 114);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(352, 23);
            this.btnShowTable.TabIndex = 6;
            this.btnShowTable.Text = "Просмотр данных";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(774, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить файл";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvAttributes
            // 
            this.dgvAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectCol,
            this.nameCol,
            this.typeCol,
            this.showInfoCol});
            this.dgvAttributes.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvAttributes.Location = new System.Drawing.Point(16, 143);
            this.dgvAttributes.Name = "dgvAttributes";
            this.dgvAttributes.Size = new System.Drawing.Size(710, 363);
            this.dgvAttributes.TabIndex = 8;
            this.dgvAttributes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttributes_CellClick);
            // 
            // selectCol
            // 
            this.selectCol.HeaderText = "Выбрать";
            this.selectCol.Name = "selectCol";
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Название атрибута";
            this.nameCol.Name = "nameCol";
            // 
            // typeCol
            // 
            this.typeCol.HeaderText = "Тип атрибута";
            this.typeCol.Name = "typeCol";
            // 
            // showInfoCol
            // 
            this.showInfoCol.HeaderText = "Информация об атрибуте";
            this.showInfoCol.Name = "showInfoCol";
            this.showInfoCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите пункты очистки:";
            // 
            // chBoxDelMissVal
            // 
            this.chBoxDelMissVal.AutoSize = true;
            this.chBoxDelMissVal.Location = new System.Drawing.Point(774, 143);
            this.chBoxDelMissVal.Name = "chBoxDelMissVal";
            this.chBoxDelMissVal.Size = new System.Drawing.Size(143, 30);
            this.chBoxDelMissVal.TabIndex = 10;
            this.chBoxDelMissVal.Text = "Удалить строки \r\nс пустыми значениями";
            this.chBoxDelMissVal.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(774, 192);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(162, 30);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Удалить строки\r\nс единичными значениями\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 518);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chBoxDelMissVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAttributes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowTable);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.cmbBoxDelimiter);
            this.Controls.Add(this.lblSelectSeparator);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblFileNameTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CSV_Cleaner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label lblFileNameTitle;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSelectSeparator;
        private System.Windows.Forms.ComboBox cmbBoxDelimiter;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAttributes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeCol;
        private System.Windows.Forms.DataGridViewButtonColumn showInfoCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBoxDelMissVal;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

