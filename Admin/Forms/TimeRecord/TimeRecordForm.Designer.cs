namespace TimeSprout.Admin.Forms
{
    partial class TimeRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeRecordForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblRefreshEmpId = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.listTimeRecordPanel = new System.Windows.Forms.Panel();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(53)))), ((int)(((byte)(200)))));
            this.titlePanel.Controls.Add(this.lblRefreshEmpId);
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.button1);
            this.titlePanel.Controls.Add(this.tbID);
            this.titlePanel.Controls.Add(this.lblDayOfWeek);
            this.titlePanel.Controls.Add(this.dateTimePicker1);
            this.titlePanel.Controls.Add(this.btnNew);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(844, 90);
            this.titlePanel.TabIndex = 1;
            // 
            // lblRefreshEmpId
            // 
            this.lblRefreshEmpId.AutoSize = true;
            this.lblRefreshEmpId.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefreshEmpId.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblRefreshEmpId.Location = new System.Drawing.Point(12, 60);
            this.lblRefreshEmpId.Name = "lblRefreshEmpId";
            this.lblRefreshEmpId.Size = new System.Drawing.Size(341, 17);
            this.lblRefreshEmpId.TabIndex = 12;
            this.lblRefreshEmpId.TabStop = true;
            this.lblRefreshEmpId.Text = "results for \'2024-002\' click to close";
            this.lblRefreshEmpId.Visible = false;
            this.lblRefreshEmpId.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRefreshEmpId_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "EMPLOYEE ID:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(189, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MaximumSize = new System.Drawing.Size(24, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(15, 28);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(198, 30);
            this.tbID.TabIndex = 4;
            this.tbID.Leave += new System.EventHandler(this.tbID_Leave);
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.lblDayOfWeek.Location = new System.Drawing.Point(546, 9);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(148, 29);
            this.lblDayOfWeek.TabIndex = 2;
            this.lblDayOfWeek.Text = "WEDNESDAY";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(551, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 30);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(747, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 36);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // listTimeRecordPanel
            // 
            this.listTimeRecordPanel.AutoScroll = true;
            this.listTimeRecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTimeRecordPanel.Location = new System.Drawing.Point(0, 90);
            this.listTimeRecordPanel.Name = "listTimeRecordPanel";
            this.listTimeRecordPanel.Size = new System.Drawing.Size(844, 460);
            this.listTimeRecordPanel.TabIndex = 2;
            // 
            // TimeRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(844, 550);
            this.Controls.Add(this.listTimeRecordPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeRecordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TimeRecordForm";
            this.Load += new System.EventHandler(this.TimeRecordForm_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel listTimeRecordPanel;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblRefreshEmpId;
    }
}