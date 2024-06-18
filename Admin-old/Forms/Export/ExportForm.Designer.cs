namespace TimeSprout.Admin.Forms.Export
{
    partial class ExportForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fieldsPanel = new System.Windows.Forms.Panel();
            this.btnExportByDate = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportAllData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportByTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTableName = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.fieldsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(53)))), ((int)(((byte)(200)))));
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(940, 80);
            this.titlePanel.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // fieldsPanel
            // 
            this.fieldsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.fieldsPanel.Controls.Add(this.btnExportByDate);
            this.fieldsPanel.Controls.Add(this.dateTimePicker1);
            this.fieldsPanel.Controls.Add(this.label2);
            this.fieldsPanel.Location = new System.Drawing.Point(15, 107);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.Size = new System.Drawing.Size(305, 211);
            this.fieldsPanel.TabIndex = 4;
            // 
            // btnExportByDate
            // 
            this.btnExportByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnExportByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportByDate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportByDate.ForeColor = System.Drawing.Color.White;
            this.btnExportByDate.Location = new System.Drawing.Point(85, 132);
            this.btnExportByDate.Name = "btnExportByDate";
            this.btnExportByDate.Size = new System.Drawing.Size(134, 41);
            this.btnExportByDate.TabIndex = 4;
            this.btnExportByDate.Text = "EXPORT";
            this.btnExportByDate.UseVisualStyleBackColor = false;
            this.btnExportByDate.Click += new System.EventHandler(this.btnExportByDate_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbUsername.Location = new System.Drawing.Point(43, 21);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(228, 53);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "EXPORT ALL DATA\r\nFROM DATABASE.";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Day to export:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btnExportAllData);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Location = new System.Drawing.Point(344, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 211);
            this.panel1.TabIndex = 5;
            // 
            // btnExportAllData
            // 
            this.btnExportAllData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnExportAllData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAllData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportAllData.ForeColor = System.Drawing.Color.White;
            this.btnExportAllData.Location = new System.Drawing.Point(89, 132);
            this.btnExportAllData.Name = "btnExportAllData";
            this.btnExportAllData.Size = new System.Drawing.Size(134, 41);
            this.btnExportAllData.TabIndex = 4;
            this.btnExportAllData.Text = "EXPORT";
            this.btnExportAllData.UseVisualStyleBackColor = false;
            this.btnExportAllData.Click += new System.EventHandler(this.btnExportAllData_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.tbTableName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnExportByTable);
            this.panel2.Location = new System.Drawing.Point(189, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 211);
            this.panel2.TabIndex = 6;
            // 
            // btnExportByTable
            // 
            this.btnExportByTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnExportByTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportByTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportByTable.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportByTable.ForeColor = System.Drawing.Color.White;
            this.btnExportByTable.Location = new System.Drawing.Point(89, 132);
            this.btnExportByTable.Name = "btnExportByTable";
            this.btnExportByTable.Size = new System.Drawing.Size(134, 41);
            this.btnExportByTable.TabIndex = 4;
            this.btnExportByTable.Text = "EXPORT";
            this.btnExportByTable.UseVisualStyleBackColor = false;
            this.btnExportByTable.Click += new System.EventHandler(this.btnExportByTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Others:";
            // 
            // tbTableName
            // 
            this.tbTableName.FormattingEnabled = true;
            this.tbTableName.Items.AddRange(new object[] {
            "USERS",
            "EMPLOYEES"});
            this.tbTableName.Location = new System.Drawing.Point(46, 47);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(228, 30);
            this.tbTableName.TabIndex = 6;
            this.tbTableName.Text = "USERS";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "EXPORTING RECORDS TO EXCEL";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fieldsPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.fieldsPanel.ResumeLayout(false);
            this.fieldsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel fieldsPanel;
        private System.Windows.Forms.Button btnExportByDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportAllData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox tbTableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportByTable;
        private System.Windows.Forms.Label lblTitle;
    }
}