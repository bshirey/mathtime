namespace MathTime
{
    partial class SessionStartForm
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
            this.studentIdentifierTextBox = new System.Windows.Forms.TextBox();
            this.sessionIdentificationgroupBox = new System.Windows.Forms.GroupBox();
            this.sessiontypeComboBox = new System.Windows.Forms.ComboBox();
            this.sessionTypeLabel = new System.Windows.Forms.Label();
            this.studentIdentifierLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.sessionIdentificationgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIdentifierTextBox
            // 
            this.studentIdentifierTextBox.Location = new System.Drawing.Point(102, 19);
            this.studentIdentifierTextBox.Name = "studentIdentifierTextBox";
            this.studentIdentifierTextBox.Size = new System.Drawing.Size(233, 20);
            this.studentIdentifierTextBox.TabIndex = 0;
            // 
            // sessionIdentificationgroupBox
            // 
            this.sessionIdentificationgroupBox.Controls.Add(this.sessiontypeComboBox);
            this.sessionIdentificationgroupBox.Controls.Add(this.sessionTypeLabel);
            this.sessionIdentificationgroupBox.Controls.Add(this.studentIdentifierLabel);
            this.sessionIdentificationgroupBox.Controls.Add(this.studentIdentifierTextBox);
            this.sessionIdentificationgroupBox.Location = new System.Drawing.Point(3, 4);
            this.sessionIdentificationgroupBox.Name = "sessionIdentificationgroupBox";
            this.sessionIdentificationgroupBox.Size = new System.Drawing.Size(345, 85);
            this.sessionIdentificationgroupBox.TabIndex = 1;
            this.sessionIdentificationgroupBox.TabStop = false;
            this.sessionIdentificationgroupBox.Text = "Session Identification";
            // 
            // sessiontypeComboBox
            // 
            this.sessiontypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessiontypeComboBox.FormattingEnabled = true;
            this.sessiontypeComboBox.Items.AddRange(new object[] {
            "Single Digit Summation",
            "Triple Digit Summation",
            "Variable Length Summation"});
            this.sessiontypeComboBox.Location = new System.Drawing.Point(102, 52);
            this.sessiontypeComboBox.Name = "sessiontypeComboBox";
            this.sessiontypeComboBox.Size = new System.Drawing.Size(233, 21);
            this.sessiontypeComboBox.TabIndex = 3;
            // 
            // sessionTypeLabel
            // 
            this.sessionTypeLabel.Location = new System.Drawing.Point(9, 52);
            this.sessionTypeLabel.Name = "sessionTypeLabel";
            this.sessionTypeLabel.Size = new System.Drawing.Size(90, 17);
            this.sessionTypeLabel.TabIndex = 2;
            this.sessionTypeLabel.Text = "Session Type:";
            // 
            // studentIdentifierLabel
            // 
            this.studentIdentifierLabel.Location = new System.Drawing.Point(6, 22);
            this.studentIdentifierLabel.Name = "studentIdentifierLabel";
            this.studentIdentifierLabel.Size = new System.Drawing.Size(90, 17);
            this.studentIdentifierLabel.TabIndex = 1;
            this.studentIdentifierLabel.Text = "Student Identifier:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(118, 96);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(114, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SessionStartForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 123);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sessionIdentificationgroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SessionStartForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start a New MathTime Session";
            this.TopMost = true;
            this.sessionIdentificationgroupBox.ResumeLayout(false);
            this.sessionIdentificationgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox studentIdentifierTextBox;
        private System.Windows.Forms.GroupBox sessionIdentificationgroupBox;
        private System.Windows.Forms.ComboBox sessiontypeComboBox;
        private System.Windows.Forms.Label sessionTypeLabel;
        private System.Windows.Forms.Label studentIdentifierLabel;
        private System.Windows.Forms.Button okButton;
    }
}