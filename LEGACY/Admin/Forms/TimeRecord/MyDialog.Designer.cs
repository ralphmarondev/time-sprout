namespace TimeSprout.Forms.TimeRecord
{
    partial class MyDialog
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
            this.timeRecordPanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOverTime = new System.Windows.Forms.Label();
            this.lblTotalWorkTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOtOut = new System.Windows.Forms.Button();
            this.btnOtIn = new System.Windows.Forms.Button();
            this.lblOtOut = new System.Windows.Forms.Label();
            this.lblOtIn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPmOut = new System.Windows.Forms.Button();
            this.btnPmIn = new System.Windows.Forms.Button();
            this.lblPmOut = new System.Windows.Forms.Label();
            this.lblPmIn = new System.Windows.Forms.Label();
            this.tbCurrentProject = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.groupAM = new System.Windows.Forms.GroupBox();
            this.btnAmOut = new System.Windows.Forms.Button();
            this.btnAmIn = new System.Windows.Forms.Button();
            this.lblAmOut = new System.Windows.Forms.Label();
            this.lblAmIn = new System.Windows.Forms.Label();
            this.tbDayOfWeek = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timeRecordPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupAM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeRecordPanel
            // 
            this.timeRecordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.timeRecordPanel.Controls.Add(this.btnSave);
            this.timeRecordPanel.Controls.Add(this.lblOverTime);
            this.timeRecordPanel.Controls.Add(this.lblTotalWorkTime);
            this.timeRecordPanel.Controls.Add(this.groupBox2);
            this.timeRecordPanel.Controls.Add(this.groupBox1);
            this.timeRecordPanel.Controls.Add(this.tbCurrentProject);
            this.timeRecordPanel.Controls.Add(this.tbName);
            this.timeRecordPanel.Controls.Add(this.tbID);
            this.timeRecordPanel.Controls.Add(this.groupAM);
            this.timeRecordPanel.Controls.Add(this.tbDayOfWeek);
            this.timeRecordPanel.Controls.Add(this.dateTimePicker1);
            this.timeRecordPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeRecordPanel.Location = new System.Drawing.Point(239, 0);
            this.timeRecordPanel.Name = "timeRecordPanel";
            this.timeRecordPanel.Size = new System.Drawing.Size(716, 459);
            this.timeRecordPanel.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(465, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 43);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOverTime
            // 
            this.lblOverTime.AutoSize = true;
            this.lblOverTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverTime.Location = new System.Drawing.Point(23, 380);
            this.lblOverTime.Name = "lblOverTime";
            this.lblOverTime.Size = new System.Drawing.Size(226, 22);
            this.lblOverTime.TabIndex = 17;
            this.lblOverTime.Text = "OVERTIME: 0 HOUR/S";
            // 
            // lblTotalWorkTime
            // 
            this.lblTotalWorkTime.AutoSize = true;
            this.lblTotalWorkTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWorkTime.Location = new System.Drawing.Point(22, 345);
            this.lblTotalWorkTime.Name = "lblTotalWorkTime";
            this.lblTotalWorkTime.Size = new System.Drawing.Size(310, 22);
            this.lblTotalWorkTime.TabIndex = 16;
            this.lblTotalWorkTime.Text = "TOTAL WORK TIME: 8 HOUR/S";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnOtOut);
            this.groupBox2.Controls.Add(this.btnOtIn);
            this.groupBox2.Controls.Add(this.lblOtOut);
            this.groupBox2.Controls.Add(this.lblOtIn);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(462, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 157);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  OVERTIME  ";
            // 
            // btnOtOut
            // 
            this.btnOtOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnOtOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtOut.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnOtOut.ForeColor = System.Drawing.Color.White;
            this.btnOtOut.Location = new System.Drawing.Point(114, 107);
            this.btnOtOut.Name = "btnOtOut";
            this.btnOtOut.Size = new System.Drawing.Size(66, 29);
            this.btnOtOut.TabIndex = 7;
            this.btnOtOut.Text = "OUT";
            this.btnOtOut.UseVisualStyleBackColor = false;
            this.btnOtOut.Click += new System.EventHandler(this.btnOtOut_Click);
            // 
            // btnOtIn
            // 
            this.btnOtIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(37)))), ((int)(((byte)(133)))));
            this.btnOtIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtIn.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnOtIn.ForeColor = System.Drawing.Color.White;
            this.btnOtIn.Location = new System.Drawing.Point(23, 107);
            this.btnOtIn.Name = "btnOtIn";
            this.btnOtIn.Size = new System.Drawing.Size(66, 29);
            this.btnOtIn.TabIndex = 6;
            this.btnOtIn.Text = "IN";
            this.btnOtIn.UseVisualStyleBackColor = false;
            this.btnOtIn.Click += new System.EventHandler(this.btnOtIn_Click);
            // 
            // lblOtOut
            // 
            this.lblOtOut.AutoSize = true;
            this.lblOtOut.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtOut.Location = new System.Drawing.Point(110, 49);
            this.lblOtOut.Name = "lblOtOut";
            this.lblOtOut.Size = new System.Drawing.Size(70, 22);
            this.lblOtOut.TabIndex = 1;
            this.lblOtOut.Text = "--:--";
            // 
            // lblOtIn
            // 
            this.lblOtIn.AutoSize = true;
            this.lblOtIn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtIn.Location = new System.Drawing.Point(19, 49);
            this.lblOtIn.Name = "lblOtIn";
            this.lblOtIn.Size = new System.Drawing.Size(70, 22);
            this.lblOtIn.TabIndex = 0;
            this.lblOtIn.Text = "--:--";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnPmOut);
            this.groupBox1.Controls.Add(this.btnPmIn);
            this.groupBox1.Controls.Add(this.lblPmOut);
            this.groupBox1.Controls.Add(this.lblPmIn);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 157);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  PM  ";
            // 
            // btnPmOut
            // 
            this.btnPmOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnPmOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPmOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPmOut.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnPmOut.ForeColor = System.Drawing.Color.White;
            this.btnPmOut.Location = new System.Drawing.Point(114, 107);
            this.btnPmOut.Name = "btnPmOut";
            this.btnPmOut.Size = new System.Drawing.Size(66, 29);
            this.btnPmOut.TabIndex = 7;
            this.btnPmOut.Text = "OUT";
            this.btnPmOut.UseVisualStyleBackColor = false;
            this.btnPmOut.Click += new System.EventHandler(this.btnPmOut_Click);
            // 
            // btnPmIn
            // 
            this.btnPmIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(37)))), ((int)(((byte)(133)))));
            this.btnPmIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPmIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPmIn.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnPmIn.ForeColor = System.Drawing.Color.White;
            this.btnPmIn.Location = new System.Drawing.Point(23, 107);
            this.btnPmIn.Name = "btnPmIn";
            this.btnPmIn.Size = new System.Drawing.Size(66, 29);
            this.btnPmIn.TabIndex = 6;
            this.btnPmIn.Text = "IN";
            this.btnPmIn.UseVisualStyleBackColor = false;
            this.btnPmIn.Click += new System.EventHandler(this.btnPmIn_Click);
            // 
            // lblPmOut
            // 
            this.lblPmOut.AutoSize = true;
            this.lblPmOut.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPmOut.Location = new System.Drawing.Point(110, 49);
            this.lblPmOut.Name = "lblPmOut";
            this.lblPmOut.Size = new System.Drawing.Size(70, 22);
            this.lblPmOut.TabIndex = 1;
            this.lblPmOut.Text = "--:--";
            // 
            // lblPmIn
            // 
            this.lblPmIn.AutoSize = true;
            this.lblPmIn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPmIn.Location = new System.Drawing.Point(19, 49);
            this.lblPmIn.Name = "lblPmIn";
            this.lblPmIn.Size = new System.Drawing.Size(70, 22);
            this.lblPmIn.TabIndex = 0;
            this.lblPmIn.Text = "--:--";
            // 
            // tbCurrentProject
            // 
            this.tbCurrentProject.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbCurrentProject.Location = new System.Drawing.Point(26, 94);
            this.tbCurrentProject.Name = "tbCurrentProject";
            this.tbCurrentProject.ReadOnly = true;
            this.tbCurrentProject.Size = new System.Drawing.Size(232, 30);
            this.tbCurrentProject.TabIndex = 14;
            this.tbCurrentProject.Text = "CURRENT PROJECT";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbName.Location = new System.Drawing.Point(26, 58);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(232, 30);
            this.tbName.TabIndex = 13;
            this.tbName.Text = "EMPLOYEE NAME";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbID.Location = new System.Drawing.Point(26, 22);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(232, 30);
            this.tbID.TabIndex = 12;
            this.tbID.Text = "ID";
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            this.tbID.Leave += new System.EventHandler(this.tbID_Leave);
            // 
            // groupAM
            // 
            this.groupAM.BackColor = System.Drawing.Color.White;
            this.groupAM.Controls.Add(this.btnAmOut);
            this.groupAM.Controls.Add(this.btnAmIn);
            this.groupAM.Controls.Add(this.lblAmOut);
            this.groupAM.Controls.Add(this.lblAmIn);
            this.groupAM.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAM.Location = new System.Drawing.Point(26, 164);
            this.groupAM.Name = "groupAM";
            this.groupAM.Size = new System.Drawing.Size(201, 157);
            this.groupAM.TabIndex = 9;
            this.groupAM.TabStop = false;
            this.groupAM.Text = "  AM  ";
            // 
            // btnAmOut
            // 
            this.btnAmOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnAmOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmOut.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnAmOut.ForeColor = System.Drawing.Color.White;
            this.btnAmOut.Location = new System.Drawing.Point(114, 107);
            this.btnAmOut.Name = "btnAmOut";
            this.btnAmOut.Size = new System.Drawing.Size(66, 29);
            this.btnAmOut.TabIndex = 7;
            this.btnAmOut.Text = "OUT";
            this.btnAmOut.UseVisualStyleBackColor = false;
            this.btnAmOut.Click += new System.EventHandler(this.btnAmOut_Click);
            // 
            // btnAmIn
            // 
            this.btnAmIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(37)))), ((int)(((byte)(133)))));
            this.btnAmIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmIn.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnAmIn.ForeColor = System.Drawing.Color.White;
            this.btnAmIn.Location = new System.Drawing.Point(23, 107);
            this.btnAmIn.Name = "btnAmIn";
            this.btnAmIn.Size = new System.Drawing.Size(66, 29);
            this.btnAmIn.TabIndex = 6;
            this.btnAmIn.Text = "IN";
            this.btnAmIn.UseVisualStyleBackColor = false;
            this.btnAmIn.Click += new System.EventHandler(this.btnAmIn_Click);
            // 
            // lblAmOut
            // 
            this.lblAmOut.AutoSize = true;
            this.lblAmOut.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmOut.Location = new System.Drawing.Point(110, 49);
            this.lblAmOut.Name = "lblAmOut";
            this.lblAmOut.Size = new System.Drawing.Size(70, 22);
            this.lblAmOut.TabIndex = 1;
            this.lblAmOut.Text = "--:--";
            // 
            // lblAmIn
            // 
            this.lblAmIn.AutoSize = true;
            this.lblAmIn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmIn.Location = new System.Drawing.Point(19, 49);
            this.lblAmIn.Name = "lblAmIn";
            this.lblAmIn.Size = new System.Drawing.Size(70, 22);
            this.lblAmIn.TabIndex = 0;
            this.lblAmIn.Text = "08:00";
            // 
            // tbDayOfWeek
            // 
            this.tbDayOfWeek.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayOfWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbDayOfWeek.Location = new System.Drawing.Point(431, 61);
            this.tbDayOfWeek.Name = "tbDayOfWeek";
            this.tbDayOfWeek.ReadOnly = true;
            this.tbDayOfWeek.Size = new System.Drawing.Size(232, 30);
            this.tbDayOfWeek.TabIndex = 7;
            this.tbDayOfWeek.Text = "MONDAY";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(431, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 30);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 459);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timeRecordPanel);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MyDialog";
            this.ShowInTaskbar = false;
            this.Text = "MyDialog";
            this.timeRecordPanel.ResumeLayout(false);
            this.timeRecordPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAM.ResumeLayout(false);
            this.groupAM.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel timeRecordPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupAM;
        private System.Windows.Forms.Label lblAmOut;
        private System.Windows.Forms.Label lblAmIn;
        private System.Windows.Forms.TextBox tbDayOfWeek;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbCurrentProject;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAmOut;
        private System.Windows.Forms.Button btnAmIn;
        private System.Windows.Forms.Label lblOverTime;
        private System.Windows.Forms.Label lblTotalWorkTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOtOut;
        private System.Windows.Forms.Button btnOtIn;
        private System.Windows.Forms.Label lblOtOut;
        private System.Windows.Forms.Label lblOtIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPmOut;
        private System.Windows.Forms.Button btnPmIn;
        private System.Windows.Forms.Label lblPmOut;
        private System.Windows.Forms.Label lblPmIn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}