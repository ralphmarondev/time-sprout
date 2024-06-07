namespace TimeSprout.Employee
{
    partial class EmployeeMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAmOut = new System.Windows.Forms.Button();
            this.btnAmIn = new System.Windows.Forms.Button();
            this.tbAmOut = new System.Windows.Forms.TextBox();
            this.tbAmIn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPmOut = new System.Windows.Forms.Button();
            this.btnPmIn = new System.Windows.Forms.Button();
            this.tbPmOut = new System.Windows.Forms.TextBox();
            this.tbPmIn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOtOut = new System.Windows.Forms.Button();
            this.btnOtIn = new System.Windows.Forms.Button();
            this.tbOtOut = new System.Windows.Forms.TextBox();
            this.tbOtIn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDayOfWeek = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbCurrentProject = new System.Windows.Forms.TextBox();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnTimeRecord = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 30);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnAmOut
            // 
            this.btnAmOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.btnAmOut.FlatAppearance.BorderSize = 0;
            this.btnAmOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmOut.Location = new System.Drawing.Point(136, 103);
            this.btnAmOut.Name = "btnAmOut";
            this.btnAmOut.Size = new System.Drawing.Size(90, 31);
            this.btnAmOut.TabIndex = 3;
            this.btnAmOut.Text = "OUT";
            this.btnAmOut.UseVisualStyleBackColor = false;
            // 
            // btnAmIn
            // 
            this.btnAmIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnAmIn.FlatAppearance.BorderSize = 0;
            this.btnAmIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmIn.Location = new System.Drawing.Point(17, 103);
            this.btnAmIn.Name = "btnAmIn";
            this.btnAmIn.Size = new System.Drawing.Size(90, 31);
            this.btnAmIn.TabIndex = 2;
            this.btnAmIn.Text = "IN";
            this.btnAmIn.UseVisualStyleBackColor = false;
            // 
            // tbAmOut
            // 
            this.tbAmOut.Location = new System.Drawing.Point(136, 47);
            this.tbAmOut.Name = "tbAmOut";
            this.tbAmOut.Size = new System.Drawing.Size(90, 30);
            this.tbAmOut.TabIndex = 1;
            this.tbAmOut.Text = "12:00";
            this.tbAmOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAmIn
            // 
            this.tbAmIn.Location = new System.Drawing.Point(17, 47);
            this.tbAmIn.Name = "tbAmIn";
            this.tbAmIn.Size = new System.Drawing.Size(90, 30);
            this.tbAmIn.TabIndex = 0;
            this.tbAmIn.Text = "8:00";
            this.tbAmIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(122)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnAmOut);
            this.groupBox1.Controls.Add(this.btnAmIn);
            this.groupBox1.Controls.Add(this.tbAmOut);
            this.groupBox1.Controls.Add(this.tbAmIn);
            this.groupBox1.Location = new System.Drawing.Point(26, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AM";
            // 
            // btnPmOut
            // 
            this.btnPmOut.Location = new System.Drawing.Point(136, 103);
            this.btnPmOut.Name = "btnPmOut";
            this.btnPmOut.Size = new System.Drawing.Size(90, 31);
            this.btnPmOut.TabIndex = 3;
            this.btnPmOut.Text = "OUT";
            this.btnPmOut.UseVisualStyleBackColor = true;
            // 
            // btnPmIn
            // 
            this.btnPmIn.Location = new System.Drawing.Point(17, 103);
            this.btnPmIn.Name = "btnPmIn";
            this.btnPmIn.Size = new System.Drawing.Size(90, 31);
            this.btnPmIn.TabIndex = 2;
            this.btnPmIn.Text = "IN";
            this.btnPmIn.UseVisualStyleBackColor = true;
            // 
            // tbPmOut
            // 
            this.tbPmOut.Location = new System.Drawing.Point(136, 47);
            this.tbPmOut.Name = "tbPmOut";
            this.tbPmOut.Size = new System.Drawing.Size(90, 30);
            this.tbPmOut.TabIndex = 1;
            this.tbPmOut.Text = "5:00";
            this.tbPmOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPmIn
            // 
            this.tbPmIn.Location = new System.Drawing.Point(17, 47);
            this.tbPmIn.Name = "tbPmIn";
            this.tbPmIn.Size = new System.Drawing.Size(90, 30);
            this.tbPmIn.TabIndex = 0;
            this.tbPmIn.Text = "1:00";
            this.tbPmIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btnOtOut);
            this.groupBox3.Controls.Add(this.btnOtIn);
            this.groupBox3.Controls.Add(this.tbOtOut);
            this.groupBox3.Controls.Add(this.tbOtIn);
            this.groupBox3.Location = new System.Drawing.Point(563, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 172);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OVERTIME";
            // 
            // btnOtOut
            // 
            this.btnOtOut.Location = new System.Drawing.Point(136, 103);
            this.btnOtOut.Name = "btnOtOut";
            this.btnOtOut.Size = new System.Drawing.Size(90, 31);
            this.btnOtOut.TabIndex = 3;
            this.btnOtOut.Text = "OUT";
            this.btnOtOut.UseVisualStyleBackColor = true;
            // 
            // btnOtIn
            // 
            this.btnOtIn.Location = new System.Drawing.Point(17, 103);
            this.btnOtIn.Name = "btnOtIn";
            this.btnOtIn.Size = new System.Drawing.Size(90, 31);
            this.btnOtIn.TabIndex = 2;
            this.btnOtIn.Text = "IN";
            this.btnOtIn.UseVisualStyleBackColor = true;
            // 
            // tbOtOut
            // 
            this.tbOtOut.Location = new System.Drawing.Point(136, 47);
            this.tbOtOut.Name = "tbOtOut";
            this.tbOtOut.Size = new System.Drawing.Size(90, 30);
            this.tbOtOut.TabIndex = 1;
            this.tbOtOut.Text = "--:--";
            this.tbOtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOtIn
            // 
            this.tbOtIn.Location = new System.Drawing.Point(17, 47);
            this.tbOtIn.Name = "tbOtIn";
            this.tbOtIn.Size = new System.Drawing.Size(90, 30);
            this.tbOtIn.TabIndex = 0;
            this.tbOtIn.Text = "--:--";
            this.tbOtIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(147)))), ((int)(((byte)(193)))));
            this.groupBox2.Controls.Add(this.btnPmOut);
            this.groupBox2.Controls.Add(this.btnPmIn);
            this.groupBox2.Controls.Add(this.tbPmOut);
            this.groupBox2.Controls.Add(this.tbPmIn);
            this.groupBox2.Location = new System.Drawing.Point(294, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PM";
            // 
            // tbDayOfWeek
            // 
            this.tbDayOfWeek.Location = new System.Drawing.Point(26, 64);
            this.tbDayOfWeek.Name = "tbDayOfWeek";
            this.tbDayOfWeek.ReadOnly = true;
            this.tbDayOfWeek.Size = new System.Drawing.Size(189, 30);
            this.tbDayOfWeek.TabIndex = 1;
            this.tbDayOfWeek.Text = "SATURDAY";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(90)))), ((int)(((byte)(155)))));
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.btnSave);
            this.mainPanel.Controls.Add(this.tbCurrentProject);
            this.mainPanel.Controls.Add(this.groupBox3);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.tbDayOfWeek);
            this.mainPanel.Controls.Add(this.dateTimePicker1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(219, 72);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(851, 459);
            this.mainPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(613, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "CURRENT PROJECT:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Purple;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(675, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbCurrentProject
            // 
            this.tbCurrentProject.Location = new System.Drawing.Point(617, 40);
            this.tbCurrentProject.Name = "tbCurrentProject";
            this.tbCurrentProject.ReadOnly = true;
            this.tbCurrentProject.Size = new System.Drawing.Size(198, 30);
            this.tbCurrentProject.TabIndex = 2;
            this.tbCurrentProject.Text = "EARTH 2.0";
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.navigationPanel.Controls.Add(this.btnLogout);
            this.navigationPanel.Controls.Add(this.btnExport);
            this.navigationPanel.Controls.Add(this.btnSummary);
            this.navigationPanel.Controls.Add(this.btnTimeRecord);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 72);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(219, 459);
            this.navigationPanel.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 395);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(219, 64);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(0, 128);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(219, 64);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSummary.FlatAppearance.BorderSize = 0;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummary.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.ForeColor = System.Drawing.Color.White;
            this.btnSummary.Location = new System.Drawing.Point(0, 64);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(219, 64);
            this.btnSummary.TabIndex = 2;
            this.btnSummary.Text = "SUMMARY";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnTimeRecord
            // 
            this.btnTimeRecord.BackColor = System.Drawing.Color.DeepPink;
            this.btnTimeRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimeRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimeRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeRecord.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeRecord.ForeColor = System.Drawing.Color.White;
            this.btnTimeRecord.Location = new System.Drawing.Point(0, 0);
            this.btnTimeRecord.Name = "btnTimeRecord";
            this.btnTimeRecord.Size = new System.Drawing.Size(219, 64);
            this.btnTimeRecord.TabIndex = 1;
            this.btnTimeRecord.Text = "TIME RECORD";
            this.btnTimeRecord.UseVisualStyleBackColor = false;
            this.btnTimeRecord.Click += new System.EventHandler(this.btnTimeRecord_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Controls.Add(this.label2);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(219, 72);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "DTR V1";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panelTitle.Controls.Add(this.lblGreetings);
            this.panelTitle.Controls.Add(this.logoPanel);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1070, 72);
            this.panelTitle.TabIndex = 4;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.Color.White;
            this.lblGreetings.Location = new System.Drawing.Point(241, 33);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(406, 23);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "HELLO, RALPH MARON EDA (2024-001)";
            // 
            // EmployeeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 531);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMainForm";
            this.Load += new System.EventHandler(this.EmployeeMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAmOut;
        private System.Windows.Forms.Button btnAmIn;
        private System.Windows.Forms.TextBox tbAmOut;
        private System.Windows.Forms.TextBox tbAmIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPmOut;
        private System.Windows.Forms.Button btnPmIn;
        private System.Windows.Forms.TextBox tbPmOut;
        private System.Windows.Forms.TextBox tbPmIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOtOut;
        private System.Windows.Forms.Button btnOtIn;
        private System.Windows.Forms.TextBox tbOtOut;
        private System.Windows.Forms.TextBox tbOtIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDayOfWeek;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbCurrentProject;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnTimeRecord;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblGreetings;
    }
}