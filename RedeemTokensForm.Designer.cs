namespace MathTime
{
    partial class RedeemTokensForm
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
            this.studentIdDescriptionLabel = new System.Windows.Forms.Label();
            this.currentTokenCountDescriptionLabel = new System.Windows.Forms.Label();
            this.numTokensToRedeemLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.currentTokenCountLabel = new System.Windows.Forms.Label();
            this.numTokensToRedeemUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTokensToRedeemUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIdDescriptionLabel
            // 
            this.studentIdDescriptionLabel.AutoSize = true;
            this.studentIdDescriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.studentIdDescriptionLabel.Name = "studentIdDescriptionLabel";
            this.studentIdDescriptionLabel.Size = new System.Drawing.Size(61, 13);
            this.studentIdDescriptionLabel.TabIndex = 0;
            this.studentIdDescriptionLabel.Text = "Student ID:";
            // 
            // currentTokenCountDescriptionLabel
            // 
            this.currentTokenCountDescriptionLabel.AutoSize = true;
            this.currentTokenCountDescriptionLabel.Location = new System.Drawing.Point(13, 34);
            this.currentTokenCountDescriptionLabel.Name = "currentTokenCountDescriptionLabel";
            this.currentTokenCountDescriptionLabel.Size = new System.Drawing.Size(109, 13);
            this.currentTokenCountDescriptionLabel.TabIndex = 1;
            this.currentTokenCountDescriptionLabel.Text = "Current Token Count:";
            // 
            // numTokensToRedeemLabel
            // 
            this.numTokensToRedeemLabel.AutoSize = true;
            this.numTokensToRedeemLabel.Location = new System.Drawing.Point(13, 54);
            this.numTokensToRedeemLabel.Name = "numTokensToRedeemLabel";
            this.numTokensToRedeemLabel.Size = new System.Drawing.Size(157, 13);
            this.numTokensToRedeemLabel.TabIndex = 2;
            this.numTokensToRedeemLabel.Text = "Number of Tokens To Redeem:";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.Location = new System.Drawing.Point(182, 13);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(206, 21);
            this.studentIdLabel.TabIndex = 3;
            // 
            // currentTokenCountLabel
            // 
            this.currentTokenCountLabel.Location = new System.Drawing.Point(182, 34);
            this.currentTokenCountLabel.Name = "currentTokenCountLabel";
            this.currentTokenCountLabel.Size = new System.Drawing.Size(198, 17);
            this.currentTokenCountLabel.TabIndex = 4;
            // 
            // numTokensToRedeemUpDown
            // 
            this.numTokensToRedeemUpDown.Location = new System.Drawing.Point(185, 54);
            this.numTokensToRedeemUpDown.Name = "numTokensToRedeemUpDown";
            this.numTokensToRedeemUpDown.Size = new System.Drawing.Size(203, 20);
            this.numTokensToRedeemUpDown.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(109, 86);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Redeem";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(236, 86);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // RedeemTokensForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(400, 117);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.numTokensToRedeemUpDown);
            this.Controls.Add(this.currentTokenCountLabel);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.numTokensToRedeemLabel);
            this.Controls.Add(this.currentTokenCountDescriptionLabel);
            this.Controls.Add(this.studentIdDescriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RedeemTokensForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Redeem Tokens";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numTokensToRedeemUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIdDescriptionLabel;
        private System.Windows.Forms.Label currentTokenCountDescriptionLabel;
        private System.Windows.Forms.Label numTokensToRedeemLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label currentTokenCountLabel;
        private System.Windows.Forms.NumericUpDown numTokensToRedeemUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}