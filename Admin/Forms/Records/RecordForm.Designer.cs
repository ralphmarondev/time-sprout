namespace TimeSprout.Admin.Forms.Records
{
    partial class RecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblRefreshEmpId = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.listTimeRecordPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.listTimeRecordPanel.SuspendLayout();
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
            this.titlePanel.Controls.Add(this.btnExport);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(973, 80);
            this.titlePanel.TabIndex = 2;
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
            this.tbID.Text = "NOT IMPLEMENTED YET";
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.lblDayOfWeek.Location = new System.Drawing.Point(672, 23);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(103, 29);
            this.lblDayOfWeek.TabIndex = 2;
            this.lblDayOfWeek.Text = "MONDAY";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(781, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(435, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 31);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "REFRESH";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            // 
            // listTimeRecordPanel
            // 
            this.listTimeRecordPanel.AutoScroll = true;
            this.listTimeRecordPanel.Controls.Add(this.label2);
            this.listTimeRecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTimeRecordPanel.Location = new System.Drawing.Point(0, 80);
            this.listTimeRecordPanel.Name = "listTimeRecordPanel";
            this.listTimeRecordPanel.Size = new System.Drawing.Size(973, 513);
            this.listTimeRecordPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 110);
            this.label2.TabIndex = 0;
            this.label2.Text = "THIS FORM WILL ONLY SHOW DATA \r\nI.E. RECORDS ON THE SPECIFIC DATE SELECTED\r\n\r\nTHE" +
    " USER CAN ALSO SELECT A CERTAIN EMPLOYEE\r\nTO SHOW ITS DETAILS ON THAT SPECIFIC D" +
    "AY";
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 593);
            this.Controls.Add(this.listTimeRecordPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecordForm";
            this.Text = "RecordForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.listTimeRecordPanel.ResumeLayout(false);
            this.listTimeRecordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.LinkLabel lblRefreshEmpId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel listTimeRecordPanel;
        private System.Windows.Forms.Label label2;
    }
}