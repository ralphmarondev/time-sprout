namespace TimeSprout.Admin.Forms.TimeRecord.MyControls
{
    partial class TimeRecordUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblCurrentProject = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAmTimeOut = new System.Windows.Forms.Label();
            this.lblAmTimeIn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPmTimeIn = new System.Windows.Forms.Label();
            this.lblPmTimeOut = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOtTimeIn = new System.Windows.Forms.Label();
            this.lblOtTimeOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 1);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "24-001";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(38, 34);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(254, 31);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "RALPH MARON EDA";
            // 
            // lblCurrentProject
            // 
            this.lblCurrentProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentProject.AutoSize = true;
            this.lblCurrentProject.Location = new System.Drawing.Point(3, 78);
            this.lblCurrentProject.Name = "lblCurrentProject";
            this.lblCurrentProject.Size = new System.Drawing.Size(118, 22);
            this.lblCurrentProject.TabIndex = 2;
            this.lblCurrentProject.Text = "EARTH 2.0";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(621, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 42);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(621, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 42);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAmTimeOut
            // 
            this.lblAmTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmTimeOut.AutoSize = true;
            this.lblAmTimeOut.Location = new System.Drawing.Point(315, 67);
            this.lblAmTimeOut.Name = "lblAmTimeOut";
            this.lblAmTimeOut.Size = new System.Drawing.Size(70, 22);
            this.lblAmTimeOut.TabIndex = 5;
            this.lblAmTimeOut.Text = "12:00";
            this.lblAmTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmTimeIn
            // 
            this.lblAmTimeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmTimeIn.AutoSize = true;
            this.lblAmTimeIn.Location = new System.Drawing.Point(315, 40);
            this.lblAmTimeIn.Name = "lblAmTimeIn";
            this.lblAmTimeIn.Size = new System.Drawing.Size(58, 22);
            this.lblAmTimeIn.TabIndex = 6;
            this.lblAmTimeIn.Text = "9:00";
            this.lblAmTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "AM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "PM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPmTimeIn
            // 
            this.lblPmTimeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPmTimeIn.AutoSize = true;
            this.lblPmTimeIn.Location = new System.Drawing.Point(415, 40);
            this.lblPmTimeIn.Name = "lblPmTimeIn";
            this.lblPmTimeIn.Size = new System.Drawing.Size(58, 22);
            this.lblPmTimeIn.TabIndex = 9;
            this.lblPmTimeIn.Text = "1:00";
            this.lblPmTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPmTimeOut
            // 
            this.lblPmTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPmTimeOut.AutoSize = true;
            this.lblPmTimeOut.Location = new System.Drawing.Point(415, 67);
            this.lblPmTimeOut.Name = "lblPmTimeOut";
            this.lblPmTimeOut.Size = new System.Drawing.Size(58, 22);
            this.lblPmTimeOut.TabIndex = 8;
            this.lblPmTimeOut.Text = "5:00";
            this.lblPmTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "OT";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOtTimeIn
            // 
            this.lblOtTimeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtTimeIn.AutoSize = true;
            this.lblOtTimeIn.Location = new System.Drawing.Point(511, 40);
            this.lblOtTimeIn.Name = "lblOtTimeIn";
            this.lblOtTimeIn.Size = new System.Drawing.Size(58, 22);
            this.lblOtTimeIn.TabIndex = 12;
            this.lblOtTimeIn.Text = "7:00";
            this.lblOtTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOtTimeOut
            // 
            this.lblOtTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtTimeOut.AutoSize = true;
            this.lblOtTimeOut.Location = new System.Drawing.Point(511, 67);
            this.lblOtTimeOut.Name = "lblOtTimeOut";
            this.lblOtTimeOut.Size = new System.Drawing.Size(70, 22);
            this.lblOtTimeOut.TabIndex = 11;
            this.lblOtTimeOut.Text = "10:00";
            this.lblOtTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeRecordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblOtTimeIn);
            this.Controls.Add(this.lblOtTimeOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPmTimeIn);
            this.Controls.Add(this.lblPmTimeOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAmTimeIn);
            this.Controls.Add(this.lblAmTimeOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblCurrentProject);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeRecordUserControl";
            this.Size = new System.Drawing.Size(750, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblCurrentProject;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAmTimeOut;
        private System.Windows.Forms.Label lblAmTimeIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPmTimeIn;
        private System.Windows.Forms.Label lblPmTimeOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOtTimeIn;
        private System.Windows.Forms.Label lblOtTimeOut;
    }
}
