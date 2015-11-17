namespace MathTime
{
    partial class MainWindow
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
            this.threeDigitEquationTopLabel = new System.Windows.Forms.Label();
            this.equationSymbolLabel = new System.Windows.Forms.Label();
            this.summationLinePanel = new System.Windows.Forms.Panel();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.statusTextListBox = new System.Windows.Forms.ListBox();
            this.currentThreeDigitEquationGroupBox = new System.Windows.Forms.GroupBox();
            this.thousandsCarryNotesTextBox = new System.Windows.Forms.TextBox();
            this.hundredsCarryNotesTextBox = new System.Windows.Forms.TextBox();
            this.tensCarryNotesTextBox = new System.Windows.Forms.TextBox();
            this.solutionThousandsDigitTextBox = new System.Windows.Forms.TextBox();
            this.nextEquationButton = new System.Windows.Forms.Button();
            this.solutionOnesDigitTextBox = new System.Windows.Forms.TextBox();
            this.solutionTensDigitTextBox = new System.Windows.Forms.TextBox();
            this.threeDigitEquationBottomLabel = new System.Windows.Forms.Label();
            this.solutionHundredsDigitTextBox = new System.Windows.Forms.TextBox();
            this.instructionsGroupBox = new System.Windows.Forms.GroupBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.fileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redeemTokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSessionStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusGroupBox.SuspendLayout();
            this.currentThreeDigitEquationGroupBox.SuspendLayout();
            this.instructionsGroupBox.SuspendLayout();
            this.fileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // threeDigitEquationTopLabel
            // 
            this.threeDigitEquationTopLabel.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDigitEquationTopLabel.Location = new System.Drawing.Point(286, 64);
            this.threeDigitEquationTopLabel.Name = "threeDigitEquationTopLabel";
            this.threeDigitEquationTopLabel.Size = new System.Drawing.Size(146, 73);
            this.threeDigitEquationTopLabel.TabIndex = 1;
            this.threeDigitEquationTopLabel.Text = "123";
            this.threeDigitEquationTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equationSymbolLabel
            // 
            this.equationSymbolLabel.AutoSize = true;
            this.equationSymbolLabel.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equationSymbolLabel.Location = new System.Drawing.Point(235, 138);
            this.equationSymbolLabel.Name = "equationSymbolLabel";
            this.equationSymbolLabel.Size = new System.Drawing.Size(70, 73);
            this.equationSymbolLabel.TabIndex = 7;
            this.equationSymbolLabel.Text = "+";
            // 
            // summationLinePanel
            // 
            this.summationLinePanel.BackColor = System.Drawing.Color.Black;
            this.summationLinePanel.Location = new System.Drawing.Point(13, 216);
            this.summationLinePanel.Name = "summationLinePanel";
            this.summationLinePanel.Size = new System.Drawing.Size(712, 10);
            this.summationLinePanel.TabIndex = 8;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.statusTextListBox);
            this.statusGroupBox.Location = new System.Drawing.Point(3, 442);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(737, 122);
            this.statusGroupBox.TabIndex = 9;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Session Status";
            // 
            // statusTextListBox
            // 
            this.statusTextListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusTextListBox.FormattingEnabled = true;
            this.statusTextListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.statusTextListBox.Location = new System.Drawing.Point(3, 16);
            this.statusTextListBox.Name = "statusTextListBox";
            this.statusTextListBox.ScrollAlwaysVisible = true;
            this.statusTextListBox.Size = new System.Drawing.Size(731, 103);
            this.statusTextListBox.TabIndex = 0;
            // 
            // currentThreeDigitEquationGroupBox
            // 
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.thousandsCarryNotesTextBox);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.hundredsCarryNotesTextBox);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.tensCarryNotesTextBox);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.solutionThousandsDigitTextBox);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.nextEquationButton);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.solutionOnesDigitTextBox);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.solutionTensDigitTextBox);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.threeDigitEquationBottomLabel);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.solutionHundredsDigitTextBox);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.threeDigitEquationTopLabel);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.summationLinePanel);
            this.currentThreeDigitEquationGroupBox.Controls.Add(this.equationSymbolLabel);
            this.currentThreeDigitEquationGroupBox.Location = new System.Drawing.Point(3, 133);
            this.currentThreeDigitEquationGroupBox.Name = "currentThreeDigitEquationGroupBox";
            this.currentThreeDigitEquationGroupBox.Size = new System.Drawing.Size(737, 303);
            this.currentThreeDigitEquationGroupBox.TabIndex = 10;
            this.currentThreeDigitEquationGroupBox.TabStop = false;
            this.currentThreeDigitEquationGroupBox.Text = "Current Equation";
            // 
            // thousandsCarryNotesTextBox
            // 
            this.thousandsCarryNotesTextBox.Enabled = false;
            this.thousandsCarryNotesTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thousandsCarryNotesTextBox.Location = new System.Drawing.Point(269, 30);
            this.thousandsCarryNotesTextBox.MaxLength = 1;
            this.thousandsCarryNotesTextBox.Name = "thousandsCarryNotesTextBox";
            this.thousandsCarryNotesTextBox.Size = new System.Drawing.Size(16, 26);
            this.thousandsCarryNotesTextBox.TabIndex = 5;
            this.thousandsCarryNotesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thousandsCarryNotesTextBox_KeyPress);
            // 
            // hundredsCarryNotesTextBox
            // 
            this.hundredsCarryNotesTextBox.Enabled = false;
            this.hundredsCarryNotesTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredsCarryNotesTextBox.Location = new System.Drawing.Point(309, 30);
            this.hundredsCarryNotesTextBox.MaxLength = 1;
            this.hundredsCarryNotesTextBox.Name = "hundredsCarryNotesTextBox";
            this.hundredsCarryNotesTextBox.Size = new System.Drawing.Size(16, 26);
            this.hundredsCarryNotesTextBox.TabIndex = 3;
            this.hundredsCarryNotesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hundredsCarryNotesTextBox_KeyPress);
            // 
            // tensCarryNotesTextBox
            // 
            this.tensCarryNotesTextBox.Enabled = false;
            this.tensCarryNotesTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensCarryNotesTextBox.Location = new System.Drawing.Point(349, 30);
            this.tensCarryNotesTextBox.MaxLength = 1;
            this.tensCarryNotesTextBox.Name = "tensCarryNotesTextBox";
            this.tensCarryNotesTextBox.Size = new System.Drawing.Size(16, 26);
            this.tensCarryNotesTextBox.TabIndex = 1;
            this.tensCarryNotesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tensCarryNotesTextBox_KeyPress);
            // 
            // solutionThousandsDigitTextBox
            // 
            this.solutionThousandsDigitTextBox.Enabled = false;
            this.solutionThousandsDigitTextBox.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionThousandsDigitTextBox.Location = new System.Drawing.Point(260, 232);
            this.solutionThousandsDigitTextBox.MaxLength = 1;
            this.solutionThousandsDigitTextBox.Name = "solutionThousandsDigitTextBox";
            this.solutionThousandsDigitTextBox.Size = new System.Drawing.Size(35, 62);
            this.solutionThousandsDigitTextBox.TabIndex = 6;
            this.solutionThousandsDigitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.solutionThousandsDigitTextBox.TextChanged += new System.EventHandler(this.solutionThousandsDigitTextBox_TextChanged);
            this.solutionThousandsDigitTextBox.Enter += new System.EventHandler(this.solutionThousandsDigitTextBox_Enter);
            this.solutionThousandsDigitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solutionThousandsDigitTextBox_KeyPress);
            // 
            // nextEquationButton
            // 
            this.nextEquationButton.Enabled = false;
            this.nextEquationButton.Location = new System.Drawing.Point(608, 232);
            this.nextEquationButton.Name = "nextEquationButton";
            this.nextEquationButton.Size = new System.Drawing.Size(117, 61);
            this.nextEquationButton.TabIndex = 7;
            this.nextEquationButton.Text = "Next Equation...";
            this.nextEquationButton.UseVisualStyleBackColor = true;
            this.nextEquationButton.Click += new System.EventHandler(this.nextEquationButton_Click);
            // 
            // solutionOnesDigitTextBox
            // 
            this.solutionOnesDigitTextBox.Enabled = false;
            this.solutionOnesDigitTextBox.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionOnesDigitTextBox.Location = new System.Drawing.Point(378, 232);
            this.solutionOnesDigitTextBox.MaxLength = 1;
            this.solutionOnesDigitTextBox.Name = "solutionOnesDigitTextBox";
            this.solutionOnesDigitTextBox.Size = new System.Drawing.Size(35, 62);
            this.solutionOnesDigitTextBox.TabIndex = 0;
            this.solutionOnesDigitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.solutionOnesDigitTextBox.TextChanged += new System.EventHandler(this.solutionOnesDigitTextBox_TextChanged);
            this.solutionOnesDigitTextBox.Enter += new System.EventHandler(this.solutionOnesDigitTextBox_Enter);
            this.solutionOnesDigitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solutionOnesDigitTextBox_KeyPress);
            // 
            // solutionTensDigitTextBox
            // 
            this.solutionTensDigitTextBox.Enabled = false;
            this.solutionTensDigitTextBox.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionTensDigitTextBox.Location = new System.Drawing.Point(338, 232);
            this.solutionTensDigitTextBox.MaxLength = 1;
            this.solutionTensDigitTextBox.Name = "solutionTensDigitTextBox";
            this.solutionTensDigitTextBox.Size = new System.Drawing.Size(35, 62);
            this.solutionTensDigitTextBox.TabIndex = 2;
            this.solutionTensDigitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.solutionTensDigitTextBox.TextChanged += new System.EventHandler(this.solutionTensDigitTextBox_TextChanged);
            this.solutionTensDigitTextBox.Enter += new System.EventHandler(this.solutionTensDigitTextBox_Enter);
            this.solutionTensDigitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solutionTensDigitTextBox_KeyPress);
            // 
            // threeDigitEquationBottomLabel
            // 
            this.threeDigitEquationBottomLabel.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDigitEquationBottomLabel.Location = new System.Drawing.Point(286, 137);
            this.threeDigitEquationBottomLabel.Name = "threeDigitEquationBottomLabel";
            this.threeDigitEquationBottomLabel.Size = new System.Drawing.Size(146, 73);
            this.threeDigitEquationBottomLabel.TabIndex = 9;
            this.threeDigitEquationBottomLabel.Text = "456";
            this.threeDigitEquationBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // solutionHundredsDigitTextBox
            // 
            this.solutionHundredsDigitTextBox.Enabled = false;
            this.solutionHundredsDigitTextBox.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionHundredsDigitTextBox.Location = new System.Drawing.Point(299, 232);
            this.solutionHundredsDigitTextBox.MaxLength = 1;
            this.solutionHundredsDigitTextBox.Name = "solutionHundredsDigitTextBox";
            this.solutionHundredsDigitTextBox.Size = new System.Drawing.Size(35, 62);
            this.solutionHundredsDigitTextBox.TabIndex = 4;
            this.solutionHundredsDigitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.solutionHundredsDigitTextBox.TextChanged += new System.EventHandler(this.solutionHundredsDigitTextBox_TextChanged);
            this.solutionHundredsDigitTextBox.Enter += new System.EventHandler(this.solutionHundredsDigitTextBox_Enter);
            this.solutionHundredsDigitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solutionHundredsDigitTextBox_KeyPress);
            // 
            // instructionsGroupBox
            // 
            this.instructionsGroupBox.Controls.Add(this.progressLabel);
            this.instructionsGroupBox.Controls.Add(this.statusProgressBar);
            this.instructionsGroupBox.Controls.Add(this.instructionsLabel);
            this.instructionsGroupBox.Location = new System.Drawing.Point(3, 30);
            this.instructionsGroupBox.Name = "instructionsGroupBox";
            this.instructionsGroupBox.Size = new System.Drawing.Size(737, 97);
            this.instructionsGroupBox.TabIndex = 11;
            this.instructionsGroupBox.TabStop = false;
            this.instructionsGroupBox.Text = "Instructions and Progress";
            // 
            // progressLabel
            // 
            this.progressLabel.Location = new System.Drawing.Point(161, 47);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(415, 16);
            this.progressLabel.TabIndex = 2;
            this.progressLabel.Text = "This is equation 0 of 30.";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(13, 66);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(712, 26);
            this.statusProgressBar.Step = 1;
            this.statusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.statusProgressBar.TabIndex = 1;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(10, 20);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(365, 13);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Please solve each equation as quickly as possible.  Your answers are timed.";
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExitMenuItem,
            this.optionsToolStripMenuItem});
            this.fileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fileMenuStrip.Size = new System.Drawing.Size(740, 24);
            this.fileMenuStrip.TabIndex = 12;
            this.fileMenuStrip.Text = "File";
            // 
            // fileExitMenuItem
            // 
            this.fileExitMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewSessionToolStripMenuItem,
            this.redeemTokensToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileExitMenuItem.Name = "fileExitMenuItem";
            this.fileExitMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileExitMenuItem.Text = "&File";
            // 
            // startNewSessionToolStripMenuItem
            // 
            this.startNewSessionToolStripMenuItem.Name = "startNewSessionToolStripMenuItem";
            this.startNewSessionToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.startNewSessionToolStripMenuItem.Text = "Start &New Session";
            this.startNewSessionToolStripMenuItem.Click += new System.EventHandler(this.startNewSessionToolStripMenuItem_Click);
            // 
            // redeemTokensToolStripMenuItem
            // 
            this.redeemTokensToolStripMenuItem.Enabled = false;
            this.redeemTokensToolStripMenuItem.Name = "redeemTokensToolStripMenuItem";
            this.redeemTokensToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.redeemTokensToolStripMenuItem.Text = "&Redeem Tokens";
            this.redeemTokensToolStripMenuItem.Click += new System.EventHandler(this.redeemTokensToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSessionStatusToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // showSessionStatusToolStripMenuItem
            // 
            this.showSessionStatusToolStripMenuItem.Name = "showSessionStatusToolStripMenuItem";
            this.showSessionStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showSessionStatusToolStripMenuItem.Text = "Show Session Status";
            this.showSessionStatusToolStripMenuItem.Click += new System.EventHandler(this.showSessionStatusToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 564);
            this.Controls.Add(this.instructionsGroupBox);
            this.Controls.Add(this.currentThreeDigitEquationGroupBox);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.fileMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.fileMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MathTime";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.statusGroupBox.ResumeLayout(false);
            this.currentThreeDigitEquationGroupBox.ResumeLayout(false);
            this.currentThreeDigitEquationGroupBox.PerformLayout();
            this.instructionsGroupBox.ResumeLayout(false);
            this.instructionsGroupBox.PerformLayout();
            this.fileMenuStrip.ResumeLayout(false);
            this.fileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label threeDigitEquationTopLabel;
        private System.Windows.Forms.Label equationSymbolLabel;
        private System.Windows.Forms.Panel summationLinePanel;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.GroupBox currentThreeDigitEquationGroupBox;
        private System.Windows.Forms.GroupBox instructionsGroupBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.MenuStrip fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewSessionToolStripMenuItem;
        private System.Windows.Forms.TextBox solutionHundredsDigitTextBox;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.TextBox solutionOnesDigitTextBox;
        private System.Windows.Forms.TextBox solutionTensDigitTextBox;
        private System.Windows.Forms.Label threeDigitEquationBottomLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button nextEquationButton;
        private System.Windows.Forms.ListBox statusTextListBox;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSessionStatusToolStripMenuItem;
        private System.Windows.Forms.TextBox solutionThousandsDigitTextBox;
        private System.Windows.Forms.TextBox thousandsCarryNotesTextBox;
        private System.Windows.Forms.TextBox hundredsCarryNotesTextBox;
        private System.Windows.Forms.TextBox tensCarryNotesTextBox;
        private System.Windows.Forms.ToolStripMenuItem redeemTokensToolStripMenuItem;
    }
}

