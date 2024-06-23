namespace TimeSprout.Admin.Forms.Project.Dialog
{
    partial class UpdateDeleteProject
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteNav = new System.Windows.Forms.Button();
            this.btnUpdateNav = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updatePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(38, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 41);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
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
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project ID:";
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.tbName);
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Controls.Add(this.tbId);
            this.updatePanel.Controls.Add(this.label2);
            this.updatePanel.Location = new System.Drawing.Point(9, 9);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(305, 255);
            this.updatePanel.TabIndex = 7;
            this.updatePanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(35, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Project Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.updatePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 282);
            this.panel2.TabIndex = 3;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDeleteNav);
            this.panel1.Controls.Add(this.btnUpdateNav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 282);
            this.panel1.TabIndex = 2;
            // 
            // UpdateDeleteProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 282);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateDeleteProject";
            this.Text = "UpdateDeleteProject";
            this.Load += new System.EventHandler(this.UpdateDeleteProject_Load);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteNav;
        private System.Windows.Forms.Button btnUpdateNav;
        private System.Windows.Forms.Panel panel1;
    }
}