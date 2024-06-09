namespace TimeSprout.Admin.Forms.Employees
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.label2 = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.listEmployeesPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRefreshEmpId = new System.Windows.Forms.LinkLabel();
            this.titlePanel.SuspendLayout();
            this.listEmployeesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "LIST OF TIME EMPLOYEES";
            this.label2.Visible = false;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(53)))), ((int)(((byte)(200)))));
            this.titlePanel.Controls.Add(this.lblRefreshEmpId);
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.button1);
            this.titlePanel.Controls.Add(this.comboBox1);
            this.titlePanel.Controls.Add(this.tbId);
            this.titlePanel.Controls.Add(this.btnNew);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(797, 80);
            this.titlePanel.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 30);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "ALL PROJECTS";
            // 
            // tbId
            // 
            this.tbId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbId.Location = new System.Drawing.Point(22, 28);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(198, 30);
            this.tbId.TabIndex = 3;
            this.tbId.Leave += new System.EventHandler(this.tbId_Leave);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(700, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // listEmployeesPanel
            // 
            this.listEmployeesPanel.AutoScroll = true;
            this.listEmployeesPanel.AutoSize = true;
            this.listEmployeesPanel.Controls.Add(this.label2);
            this.listEmployeesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEmployeesPanel.Location = new System.Drawing.Point(0, 80);
            this.listEmployeesPanel.Name = "listEmployeesPanel";
            this.listEmployeesPanel.Size = new System.Drawing.Size(797, 460);
            this.listEmployeesPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(196, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MaximumSize = new System.Drawing.Size(24, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "EMPLOYEE ID:";
            // 
            // lblRefreshEmpId
            // 
            this.lblRefreshEmpId.AutoSize = true;
            this.lblRefreshEmpId.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefreshEmpId.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblRefreshEmpId.Location = new System.Drawing.Point(19, 61);
            this.lblRefreshEmpId.Name = "lblRefreshEmpId";
            this.lblRefreshEmpId.Size = new System.Drawing.Size(341, 17);
            this.lblRefreshEmpId.TabIndex = 11;
            this.lblRefreshEmpId.TabStop = true;
            this.lblRefreshEmpId.Text = "results for \'2024-002\' click to close";
            this.lblRefreshEmpId.Visible = false;
            this.lblRefreshEmpId.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRefreshEmpId_LinkClicked);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(797, 540);
            this.Controls.Add(this.listEmployeesPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EmployeesForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.listEmployeesPanel.ResumeLayout(false);
            this.listEmployeesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel listEmployeesPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblRefreshEmpId;
    }
}