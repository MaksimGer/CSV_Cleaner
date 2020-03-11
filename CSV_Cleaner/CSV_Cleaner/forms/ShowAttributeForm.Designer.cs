namespace CSV_Cleaner.forms
{
    partial class ShowAttributeForm
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
            this.dgvShowAttr = new System.Windows.Forms.DataGridView();
            this.casesNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseCountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAttrName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUnicCases = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAttr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowAttr
            // 
            this.dgvShowAttr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowAttr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowAttr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAttr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.casesNameCol,
            this.caseCountCol});
            this.dgvShowAttr.Location = new System.Drawing.Point(13, 40);
            this.dgvShowAttr.Name = "dgvShowAttr";
            this.dgvShowAttr.Size = new System.Drawing.Size(566, 398);
            this.dgvShowAttr.TabIndex = 0;
            // 
            // casesNameCol
            // 
            this.casesNameCol.HeaderText = "Значение атрибута: ";
            this.casesNameCol.Name = "casesNameCol";
            // 
            // caseCountCol
            // 
            this.caseCountCol.HeaderText = "Количество случаев:";
            this.caseCountCol.Name = "caseCountCol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название атрибута:";
            // 
            // lblAttrName
            // 
            this.lblAttrName.AutoSize = true;
            this.lblAttrName.Location = new System.Drawing.Point(128, 13);
            this.lblAttrName.Name = "lblAttrName";
            this.lblAttrName.Size = new System.Drawing.Size(0, 13);
            this.lblAttrName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Уникальных значений: ";
            // 
            // lblUnicCases
            // 
            this.lblUnicCases.AutoSize = true;
            this.lblUnicCases.Location = new System.Drawing.Point(446, 13);
            this.lblUnicCases.Name = "lblUnicCases";
            this.lblUnicCases.Size = new System.Drawing.Size(13, 13);
            this.lblUnicCases.TabIndex = 4;
            this.lblUnicCases.Text = "0";
            // 
            // ShowAttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.lblUnicCases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAttrName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShowAttr);
            this.Name = "ShowAttributeForm";
            this.Text = "ShowAttributeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAttr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowAttr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAttrName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUnicCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn casesNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseCountCol;
    }
}