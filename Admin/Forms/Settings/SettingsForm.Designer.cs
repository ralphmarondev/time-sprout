namespace TimeSprout.Admin.Forms.Settings
{
    partial class SettingsForm
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
            this.btnNewUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnToggleNavPanel = new System.Windows.Forms.Button();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.btnEmployeeInfo = new System.Windows.Forms.PictureBox();
            this.lblAdminName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.Purple;
            this.btnNewUser.Location = new System.Drawing.Point(607, 521);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewUser.MaximumSize = new System.Drawing.Size(240, 74);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(240, 66);
            this.btnNewUser.TabIndex = 15;
            this.btnNewUser.Text = "NEW";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 434);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.btnFullScreen);
            this.panelTitle.Controls.Add(this.btnToggleNavPanel);
            this.panelTitle.Controls.Add(this.btnLogout2);
            this.panelTitle.Controls.Add(this.btnEmployeeInfo);
            this.panelTitle.Controls.Add(this.lblAdminName);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(858, 68);
            this.panelTitle.TabIndex = 13;
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
            this.btnFullScreen.Location = new System.Drawing.Point(734, 18);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(0);
            this.btnFullScreen.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(30, 30);
            this.btnFullScreen.TabIndex = 13;
            this.btnFullScreen.UseVisualStyleBackColor = false;
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
            this.btnToggleNavPanel.Location = new System.Drawing.Point(816, 18);
            this.btnToggleNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnToggleNavPanel.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnToggleNavPanel.Name = "btnToggleNavPanel";
            this.btnToggleNavPanel.Size = new System.Drawing.Size(30, 30);
            this.btnToggleNavPanel.TabIndex = 12;
            this.btnToggleNavPanel.UseVisualStyleBackColor = false;
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
            this.btnLogout2.Location = new System.Drawing.Point(776, 18);
            this.btnLogout2.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout2.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(30, 30);
            this.btnLogout2.TabIndex = 10;
            this.btnLogout2.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeInfo
            // 
            this.btnEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployeeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeInfo.Image = global::TimeSprout.Properties.Resources.icons8_test_account_80;
            this.btnEmployeeInfo.Location = new System.Drawing.Point(458, 17);
            this.btnEmployeeInfo.Name = "btnEmployeeInfo";
            this.btnEmployeeInfo.Size = new System.Drawing.Size(30, 30);
            this.btnEmployeeInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmployeeInfo.TabIndex = 11;
            this.btnEmployeeInfo.TabStop = false;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.White;
            this.lblAdminName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.Purple;
            this.lblAdminName.Location = new System.Drawing.Point(494, 25);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(70, 22);
            this.lblAdminName.TabIndex = 9;
            this.lblAdminName.Text = "ADMIN";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmployeeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Button btnToggleNavPanel;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.PictureBox btnEmployeeInfo;
        private System.Windows.Forms.Label lblAdminName;
    }
}