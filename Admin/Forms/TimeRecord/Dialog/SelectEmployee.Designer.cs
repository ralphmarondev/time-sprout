namespace TimeSprout.Admin.Forms.TimeRecord.Dialog
{
    partial class SelectEmployee
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCurProj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(57, 40);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(303, 27);
            this.tbId.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(57, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(303, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(57, 73);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(303, 27);
            this.tbName.TabIndex = 2;
            // 
            // tbCurProj
            // 
            this.tbCurProj.Location = new System.Drawing.Point(57, 106);
            this.tbCurProj.Name = "tbCurProj";
            this.tbCurProj.Size = new System.Drawing.Size(303, 27);
            this.tbCurProj.TabIndex = 3;
            // 
            // SelectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 409);
            this.Controls.Add(this.tbCurProj);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbId);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectEmployee";
            this.ShowInTaskbar = false;
            this.Text = "SelectEmployee";
            this.Load += new System.EventHandler(this.SelectEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCurProj;
    }
}