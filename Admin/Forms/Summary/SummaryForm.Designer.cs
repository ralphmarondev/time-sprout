namespace TimeSprout.Admin.Forms.Summary
{
    partial class SummaryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnToggleNavPanel = new System.Windows.Forms.Button();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.btnEmployeeInfo = new System.Windows.Forms.PictureBox();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 418);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.btnSearch);
            this.panelTitle.Controls.Add(this.label3);
            this.panelTitle.Controls.Add(this.tbEmpID);
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.dtEndDateTime);
            this.panelTitle.Controls.Add(this.dtStartDateTime);
            this.panelTitle.Controls.Add(this.btnFullScreen);
            this.panelTitle.Controls.Add(this.btnToggleNavPanel);
            this.panelTitle.Controls.Add(this.btnLogout2);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.MinimumSize = new System.Drawing.Size(717, 68);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(858, 96);
            this.panelTitle.TabIndex = 12;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.label3.Location = new System.Drawing.Point(470, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employee ID:";
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(474, 40);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(144, 30);
            this.tbEmpID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.label2.Location = new System.Drawing.Point(241, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Date:";
            // 
            // dtEndDateTime
            // 
            this.dtEndDateTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDateTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtEndDateTime.Location = new System.Drawing.Point(245, 40);
            this.dtEndDateTime.Name = "dtEndDateTime";
            this.dtEndDateTime.Size = new System.Drawing.Size(223, 30);
            this.dtEndDateTime.TabIndex = 8;
            this.dtEndDateTime.ValueChanged += new System.EventHandler(this.dbEndDateTime_ValueChanged);
            // 
            // dtStartDateTime
            // 
            this.dtStartDateTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDateTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtStartDateTime.Location = new System.Drawing.Point(16, 40);
            this.dtStartDateTime.Name = "dtStartDateTime";
            this.dtStartDateTime.Size = new System.Drawing.Size(223, 30);
            this.dtStartDateTime.TabIndex = 7;
            this.dtStartDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFullScreen.BackgroundImage = global::TimeSprout.Properties.Resources.icons8_full_screen_48;
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.ForeColor = System.Drawing.Color.Purple;
            this.btnFullScreen.Location = new System.Drawing.Point(737, 17);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(0);
            this.btnFullScreen.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(30, 30);
            this.btnFullScreen.TabIndex = 6;
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnToggleNavPanel
            // 
            this.btnToggleNavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleNavPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggleNavPanel.BackgroundImage = global::TimeSprout.Properties.Resources.icons8_hide_sidepanel_50;
            this.btnToggleNavPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToggleNavPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleNavPanel.FlatAppearance.BorderSize = 0;
            this.btnToggleNavPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleNavPanel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleNavPanel.ForeColor = System.Drawing.Color.Purple;
            this.btnToggleNavPanel.Location = new System.Drawing.Point(819, 17);
            this.btnToggleNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnToggleNavPanel.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnToggleNavPanel.Name = "btnToggleNavPanel";
            this.btnToggleNavPanel.Size = new System.Drawing.Size(30, 30);
            this.btnToggleNavPanel.TabIndex = 5;
            this.btnToggleNavPanel.UseVisualStyleBackColor = false;
            this.btnToggleNavPanel.Click += new System.EventHandler(this.btnToggleNavPanel_Click);
            // 
            // btnLogout2
            // 
            this.btnLogout2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout2.BackgroundImage = global::TimeSprout.Properties.Resources.icons8_shutdown_64;
            this.btnLogout2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout2.FlatAppearance.BorderSize = 0;
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout2.ForeColor = System.Drawing.Color.Purple;
            this.btnLogout2.Location = new System.Drawing.Point(779, 17);
            this.btnLogout2.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout2.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(30, 30);
            this.btnLogout2.TabIndex = 4;
            this.btnLogout2.UseVisualStyleBackColor = false;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.Location = new System.Drawing.Point(59, 554);
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.ReadOnly = true;
            this.tbCurrentDate.Size = new System.Drawing.Size(180, 30);
            this.tbCurrentDate.TabIndex = 8;
            this.tbCurrentDate.Visible = false;
            // 
            // btnEmployeeInfo
            // 
            this.btnEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployeeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeInfo.Image = global::TimeSprout.Properties.Resources.icons8_test_account_80;
            this.btnEmployeeInfo.Location = new System.Drawing.Point(293, 554);
            this.btnEmployeeInfo.Name = "btnEmployeeInfo";
            this.btnEmployeeInfo.Size = new System.Drawing.Size(30, 30);
            this.btnEmployeeInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmployeeInfo.TabIndex = 4;
            this.btnEmployeeInfo.TabStop = false;
            this.btnEmployeeInfo.Visible = false;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.White;
            this.lblAdminName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.Purple;
            this.lblAdminName.Location = new System.Drawing.Point(329, 562);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(70, 22);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "ADMIN";
            this.lblAdminName.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Purple;
            this.btnExport.Location = new System.Drawing.Point(649, 532);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0);
            this.btnExport.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 60);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.BackgroundImage = global::TimeSprout.Properties.Resources.icons8_full_screen_48;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Purple;
            this.btnSearch.Location = new System.Drawing.Point(621, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.MaximumSize = new System.Drawing.Size(28, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(436, 532);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MaximumSize = new System.Drawing.Size(200, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "EXPORT ALL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCurrentDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnEmployeeInfo);
            this.Controls.Add(this.lblAdminName);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SummaryForm";
            this.ShowInTaskbar = false;
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmployeeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TextBox tbCurrentDate;
        private System.Windows.Forms.DateTimePicker dtStartDateTime;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Button btnToggleNavPanel;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.PictureBox btnEmployeeInfo;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dtEndDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
    }
}