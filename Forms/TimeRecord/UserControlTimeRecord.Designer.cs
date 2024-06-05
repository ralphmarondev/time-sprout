namespace TimeSprout.Forms.TimeRecord
{
    partial class UserControlTimeRecord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecordDate = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOtTimeOut = new System.Windows.Forms.Label();
            this.lblOtTimeIn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPmTimeOut = new System.Windows.Forms.Label();
            this.lblPmTimeIn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAmTimeOut = new System.Windows.Forms.Label();
            this.lblAmTimeIn = new System.Windows.Forms.Label();
            this.lblCurrProject = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.lblRecordDate);
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblOtTimeOut);
            this.panel1.Controls.Add(this.lblOtTimeIn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblPmTimeOut);
            this.panel1.Controls.Add(this.lblPmTimeIn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblAmTimeOut);
            this.panel1.Controls.Add(this.lblAmTimeIn);
            this.panel1.Controls.Add(this.lblCurrProject);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 96);
            this.panel1.TabIndex = 0;
            // 
            // lblRecordDate
            // 
            this.lblRecordDate.AutoSize = true;
            this.lblRecordDate.Font = new System.Drawing.Font("Courier New", 4F);
            this.lblRecordDate.Location = new System.Drawing.Point(166, 21);
            this.lblRecordDate.Name = "lblRecordDate";
            this.lblRecordDate.Size = new System.Drawing.Size(92, 8);
            this.lblRecordDate.TabIndex = 29;
            this.lblRecordDate.Text = "RecordDate [Invisible]";
            this.lblRecordDate.Visible = false;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.Location = new System.Drawing.Point(592, 31);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(106, 36);
            this.btnAction.TabIndex = 27;
            this.btnAction.Text = "ACTION";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "OT";
            // 
            // lblOtTimeOut
            // 
            this.lblOtTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtTimeOut.AutoSize = true;
            this.lblOtTimeOut.Location = new System.Drawing.Point(476, 57);
            this.lblOtTimeOut.Name = "lblOtTimeOut";
            this.lblOtTimeOut.Size = new System.Drawing.Size(70, 22);
            this.lblOtTimeOut.TabIndex = 25;
            this.lblOtTimeOut.Text = "23:00";
            this.lblOtTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOtTimeIn
            // 
            this.lblOtTimeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtTimeIn.AutoSize = true;
            this.lblOtTimeIn.Location = new System.Drawing.Point(476, 35);
            this.lblOtTimeIn.Name = "lblOtTimeIn";
            this.lblOtTimeIn.Size = new System.Drawing.Size(58, 22);
            this.lblOtTimeIn.TabIndex = 24;
            this.lblOtTimeIn.Text = "6:00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "PM";
            // 
            // lblPmTimeOut
            // 
            this.lblPmTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPmTimeOut.AutoSize = true;
            this.lblPmTimeOut.Location = new System.Drawing.Point(373, 57);
            this.lblPmTimeOut.Name = "lblPmTimeOut";
            this.lblPmTimeOut.Size = new System.Drawing.Size(58, 22);
            this.lblPmTimeOut.TabIndex = 22;
            this.lblPmTimeOut.Text = "5:00";
            // 
            // lblPmTimeIn
            // 
            this.lblPmTimeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPmTimeIn.AutoSize = true;
            this.lblPmTimeIn.Location = new System.Drawing.Point(373, 35);
            this.lblPmTimeIn.Name = "lblPmTimeIn";
            this.lblPmTimeIn.Size = new System.Drawing.Size(58, 22);
            this.lblPmTimeIn.TabIndex = 21;
            this.lblPmTimeIn.Text = "1:00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "AM";
            // 
            // lblAmTimeOut
            // 
            this.lblAmTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmTimeOut.AutoSize = true;
            this.lblAmTimeOut.Location = new System.Drawing.Point(264, 57);
            this.lblAmTimeOut.Name = "lblAmTimeOut";
            this.lblAmTimeOut.Size = new System.Drawing.Size(70, 22);
            this.lblAmTimeOut.TabIndex = 19;
            this.lblAmTimeOut.Text = "12:00";
            // 
            // lblAmTimeIn
            // 
            this.lblAmTimeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmTimeIn.AutoSize = true;
            this.lblAmTimeIn.Location = new System.Drawing.Point(264, 35);
            this.lblAmTimeIn.Name = "lblAmTimeIn";
            this.lblAmTimeIn.Size = new System.Drawing.Size(58, 22);
            this.lblAmTimeIn.TabIndex = 18;
            this.lblAmTimeIn.Text = "8:00";
            // 
            // lblCurrProject
            // 
            this.lblCurrProject.AutoSize = true;
            this.lblCurrProject.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrProject.Location = new System.Drawing.Point(9, 66);
            this.lblCurrProject.Name = "lblCurrProject";
            this.lblCurrProject.Size = new System.Drawing.Size(108, 20);
            this.lblCurrProject.TabIndex = 17;
            this.lblCurrProject.Text = "EARTH 2.0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(190, 23);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Ralph Maron Eda";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(9, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(129, 20);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "20240604-001";
            // 
            // UserControlTimeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlTimeRecord";
            this.Size = new System.Drawing.Size(717, 102);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecordDate;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOtTimeOut;
        private System.Windows.Forms.Label lblOtTimeIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPmTimeOut;
        private System.Windows.Forms.Label lblPmTimeIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAmTimeOut;
        private System.Windows.Forms.Label lblAmTimeIn;
        private System.Windows.Forms.Label lblCurrProject;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
    }
}
