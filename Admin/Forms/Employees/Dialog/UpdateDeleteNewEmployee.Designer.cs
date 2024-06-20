namespace TimeSprout.Admin.Forms.Employees.Dialog
{
    partial class UpdateDeleteNewEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteNav = new System.Windows.Forms.Button();
            this.btnUpdateNav = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.tbCurrentProject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbNameDel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdDel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDeleteNav);
            this.panel1.Controls.Add(this.btnUpdateNav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 380);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteNav
            // 
            this.btnDeleteNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteNav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNav.FlatAppearance.BorderSize = 0;
            this.btnDeleteNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNav.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNav.ForeColor = System.Drawing.Color.Purple;
            this.btnDeleteNav.Location = new System.Drawing.Point(9, 83);
            this.btnDeleteNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteNav.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnDeleteNav.Name = "btnDeleteNav";
            this.btnDeleteNav.Size = new System.Drawing.Size(178, 60);
            this.btnDeleteNav.TabIndex = 4;
            this.btnDeleteNav.Text = "DELETE >";
            this.btnDeleteNav.UseVisualStyleBackColor = false;
            this.btnDeleteNav.Click += new System.EventHandler(this.btnDeleteNav_Click);
            // 
            // btnUpdateNav
            // 
            this.btnUpdateNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateNav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateNav.FlatAppearance.BorderSize = 0;
            this.btnUpdateNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNav.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNav.ForeColor = System.Drawing.Color.Purple;
            this.btnUpdateNav.Location = new System.Drawing.Point(9, 9);
            this.btnUpdateNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateNav.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnUpdateNav.Name = "btnUpdateNav";
            this.btnUpdateNav.Size = new System.Drawing.Size(178, 60);
            this.btnUpdateNav.TabIndex = 3;
            this.btnUpdateNav.Text = "UPDATE >";
            this.btnUpdateNav.UseVisualStyleBackColor = false;
            this.btnUpdateNav.Click += new System.EventHandler(this.btnUpdateNav_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.updatePanel);
            this.panel2.Controls.Add(this.deletePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 380);
            this.panel2.TabIndex = 1;
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.updatePanel.Controls.Add(this.tbCurrentProject);
            this.updatePanel.Controls.Add(this.label1);
            this.updatePanel.Controls.Add(this.tbPassword);
            this.updatePanel.Controls.Add(this.label3);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.tbName);
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Controls.Add(this.tbId);
            this.updatePanel.Controls.Add(this.label2);
            this.updatePanel.Location = new System.Drawing.Point(205, 9);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(305, 352);
            this.updatePanel.TabIndex = 7;
            this.updatePanel.Visible = false;
            // 
            // tbCurrentProject
            // 
            this.tbCurrentProject.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbCurrentProject.Location = new System.Drawing.Point(38, 236);
            this.tbCurrentProject.Name = "tbCurrentProject";
            this.tbCurrentProject.Size = new System.Drawing.Size(228, 30);
            this.tbCurrentProject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(35, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Project:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbPassword.Location = new System.Drawing.Point(38, 171);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(228, 30);
            this.tbPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(38, 291);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 41);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbName.Location = new System.Drawing.Point(38, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 30);
            this.tbName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(35, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.SystemColors.Window;
            this.tbId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbId.Location = new System.Drawing.Point(38, 44);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(228, 30);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.deletePanel.Controls.Add(this.label6);
            this.deletePanel.Controls.Add(this.btnDelete);
            this.deletePanel.Controls.Add(this.tbNameDel);
            this.deletePanel.Controls.Add(this.label7);
            this.deletePanel.Controls.Add(this.tbIdDel);
            this.deletePanel.Controls.Add(this.label8);
            this.deletePanel.Location = new System.Drawing.Point(205, 9);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(305, 352);
            this.deletePanel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label6.Location = new System.Drawing.Point(35, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 60);
            this.label6.TabIndex = 5;
            this.label6.Text = "PLEASE BE CAREFUL IN\r\nDELETING. THIS ACTION\r\nIS IRREVERSIBLE!";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(37, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbNameDel
            // 
            this.tbNameDel.BackColor = System.Drawing.SystemColors.Window;
            this.tbNameDel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbNameDel.Location = new System.Drawing.Point(37, 106);
            this.tbNameDel.Name = "tbNameDel";
            this.tbNameDel.ReadOnly = true;
            this.tbNameDel.Size = new System.Drawing.Size(228, 30);
            this.tbNameDel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label7.Location = new System.Drawing.Point(34, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name:";
            // 
            // tbIdDel
            // 
            this.tbIdDel.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdDel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.tbIdDel.Location = new System.Drawing.Point(37, 44);
            this.tbIdDel.Name = "tbIdDel";
            this.tbIdDel.ReadOnly = true;
            this.tbIdDel.Size = new System.Drawing.Size(228, 30);
            this.tbIdDel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label8.Location = new System.Drawing.Point(34, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // UpdateDeleteNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateDeleteNewEmployee";
            this.ShowInTaskbar = false;
            this.Text = "Update | Delete Employee";
            this.Load += new System.EventHandler(this.UpdateDeleteNewEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateNav;
        private System.Windows.Forms.Button btnDeleteNav;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.TextBox tbCurrentProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbNameDel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdDel;
        private System.Windows.Forms.Label label8;
    }
}