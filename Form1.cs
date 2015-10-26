﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathTime
{
    public partial class MainWindow : Form
    {
        private List<MathTimeEquation> equationsForSession;
        private int currentEquationIndex;
        private String studentIdentifier;

        static private int MaxHighPRequestCount = 2;

        /*
        private String ThreeDigitSummationFileName
        {
            get { return "threeDigitSummationEquations.dat"; }
        }

        private String SingleDigitSummationFileName
        {
            get { return "singleDigitSummationEquations.dat"; }
        }

        private String VariableDigitSummationFileName
        {
            get { return "variableDigitSummationEquations.dat"; }
        }
        */

        public MainWindow()
        {
            this.equationsForSession = new List<MathTimeEquation>();
            this.currentEquationIndex = 0;

            InitializeComponent();
            ClearPreviousSession();

            this.Height -= this.statusGroupBox.Height;
            this.statusGroupBox.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void solutionThousandsDigitTextBox_Enter(object sender, EventArgs e)
        {
            if ((this.equationsForSession.Count > 0) && (this.equationsForSession[this.currentEquationIndex].thousandsDigitBoxFocusedTime == DateTime.MinValue))
            {
                this.equationsForSession[this.currentEquationIndex].thousandsDigitBoxFocusedTime = DateTime.Now;
            }
        }

        private void solutionHundredsDigitTextBox_Enter(object sender, EventArgs e)
        {
            if ((this.equationsForSession.Count > 0) && (this.equationsForSession[this.currentEquationIndex].hundredsDigitBoxFocusedTime == DateTime.MinValue))
            {
                this.equationsForSession[this.currentEquationIndex].hundredsDigitBoxFocusedTime = DateTime.Now;
            }
        }

        private void solutionTensDigitTextBox_Enter(object sender, EventArgs e)
        {
            if ((this.equationsForSession.Count > 0) && (this.equationsForSession[this.currentEquationIndex].tensDigitBoxFocusedTime == DateTime.MinValue))
            {
                this.equationsForSession[this.currentEquationIndex].tensDigitBoxFocusedTime = DateTime.Now;
            }
        }

        private void solutionOnesDigitTextBox_Enter(object sender, EventArgs e)
        {
            if ((this.equationsForSession.Count > 0) && (this.equationsForSession[this.currentEquationIndex].onesDigitBoxFocusedTime == DateTime.MinValue))
            {
                this.equationsForSession[this.currentEquationIndex].onesDigitBoxFocusedTime = DateTime.Now;
            }
        }

        private void solutionHundredsDigitTextBox_TextChanged(object sender, EventArgs e)
        {
            // check for user entering stuff versus us changing it
            if (this.solutionHundredsDigitTextBox.Focused)
            {
                if (this.equationsForSession.Count > 0)
                {
                    this.equationsForSession[this.currentEquationIndex].hundredsDigitEnteredTime = DateTime.Now;
                    CheckForEnabledSolutionDigits();
                }
                this.CheckToEnableNextButton();
            }
        }

        private void solutionTensDigitTextBox_TextChanged(object sender, EventArgs e)
        {
            // check for user entering stuff versus us changing it
            if (this.solutionTensDigitTextBox.Focused)
            {
                if (this.equationsForSession.Count > 0)
                {
                    this.equationsForSession[this.currentEquationIndex].tensDigitEnteredTime = DateTime.Now;
                    CheckForEnabledSolutionDigits();
                }
                this.CheckToEnableNextButton();
            }
        }

        private void solutionOnesDigitTextBox_TextChanged(object sender, EventArgs e)
        {
            // check for user entering stuff versus us changing it
            if (this.solutionOnesDigitTextBox.Focused)
            {
                if (this.equationsForSession.Count > 0)
                {
                    this.equationsForSession[this.currentEquationIndex].onesDigitEnteredTime = DateTime.Now;
                    CheckForEnabledSolutionDigits();
                }
                this.CheckToEnableNextButton();
            }
        }

        private void solutionThousandsDigitTextBox_TextChanged(object sender, EventArgs e)
        {
            // check for user entering stuff versus us changing it
            if (this.solutionThousandsDigitTextBox.Focused)
            {
                if (this.equationsForSession.Count > 0)
                {
                    this.equationsForSession[this.currentEquationIndex].thousandsDigitEnteredTime = DateTime.Now;
                    CheckForEnabledSolutionDigits();
                }
                this.CheckToEnableNextButton();
            }
        }

        private void DoNextEquationButtonClick()
        {
            this.nextEquationButton.Focus();
            this.nextEquationButton.Enabled = false;
            this.solutionThousandsDigitTextBox.Enabled = false;
            this.solutionHundredsDigitTextBox.Enabled = false;
            this.solutionTensDigitTextBox.Enabled = false;
            this.solutionOnesDigitTextBox.Enabled = false;
            this.thousandsCarryNotesTextBox.Enabled = false;
            this.hundredsCarryNotesTextBox.Enabled = false;
            this.tensCarryNotesTextBox.Enabled = false;

            this.CheckDigitTimes();
            this.CheckEquationSolutionTime();
            this.CheckForCorrectSolution();

            this.currentEquationIndex = this.currentEquationIndex + 1;

            if (this.currentEquationIndex < equationsForSession.Count)
            {
                if (this.currentEquationIndex == (equationsForSession.Count - 1))
                {
                    this.nextEquationButton.Text = "Finish!";
                }

                this.UpdateProgressLabel();
                ShowCurrentEquation();
            }
            else
            {
                this.currentEquationIndex = equationsForSession.Count - 1;
                this.nextEquationButton.Enabled = false;
                WriteResultsToFile();
            }

            this.CheckForEnabledSolutionDigits();
        }

        private void nextEquationButton_Click(object sender, EventArgs e)
        {
            DoNextEquationButtonClick();
        }

        private void WriteResultsToFile()
        {
            TimeSpan unixTimeSpan = (DateTime.UtcNow - new DateTime(1970,1,1,0,0,0));
            double unixTime = unixTimeSpan.TotalSeconds;

            string directoryString = Directory.GetCurrentDirectory() + "\\results\\" + this.studentIdentifier;
            Directory.CreateDirectory(directoryString);

            try
            {
                String fileName = String.Format("results_{0:d}.csv", (uint)unixTime);
                TextWriter writer = new StreamWriter(directoryString + "\\" + fileName);
                writer.WriteLine("EqNum,SolutionElapsedTime,ThousandsFocusToEnterTime,HundredsFocusToEnterTime,TensFocusToEnterTime,OnesFocusToEnterTime,Equation,Solution,UserAnswer,Correct?");
                int i = 0;
                foreach (MathTimeEquation eq in this.equationsForSession)
                {
                    i = i + 1;
                    writer.Write(String.Format("{0:d},", i));
                    writer.Write(String.Format("{0:f},", ((TimeSpan)(eq.equationEndTime - eq.equationStartTime)).TotalSeconds));
                    writer.Write(String.Format("{0:f},", ((TimeSpan)(eq.thousandsDigitEnteredTime - eq.thousandsDigitBoxFocusedTime)).TotalSeconds));
                    writer.Write(String.Format("{0:f},", ((TimeSpan)(eq.hundredsDigitEnteredTime - eq.hundredsDigitBoxFocusedTime)).TotalSeconds));
                    writer.Write(String.Format("{0:f},", ((TimeSpan)(eq.tensDigitEnteredTime - eq.tensDigitBoxFocusedTime)).TotalSeconds));
                    writer.Write(String.Format("{0:f},", ((TimeSpan)(eq.onesDigitEnteredTime - eq.onesDigitBoxFocusedTime)).TotalSeconds));
                    writer.Write(String.Format("{0:d}+{1:d},", eq.topValue, eq.bottomValue));
                    writer.Write(String.Format("{0:d},", eq.topValue + eq.bottomValue));
                    writer.Write(String.Format("{0:d},", eq.userAnswer));
                    if (eq.wasCorrect)
                        writer.Write("True");
                    else
                        writer.Write("False");
                    writer.WriteLine();
                }
                writer.Close();

                MessageBox.Show("Data and results saved to the file \"" + this.studentIdentifier + "\\" + fileName + "\"");
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error saving the session results.  Possibly could not create the data file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                String fileName = String.Format("results_{0:d}.log", (uint)unixTime);
                TextWriter writer = new StreamWriter(directoryString + "\\" + fileName);
                foreach (String s in this.statusTextListBox.Items)
                {
                    writer.WriteLine(s);
                }
                writer.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error saving the log file.  Possibly could not create the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.ClearPreviousSession();
        }

        private void AddStatusMessageAndScroll(String msg)
        {
            this.statusTextListBox.Items.Add(msg);
            this.statusTextListBox.SelectedIndex = this.statusTextListBox.Items.Count - 1;
            this.statusTextListBox.SelectedIndex = -1;
        }

        private void CheckDigitTimes()
        {
            MathTimeEquation currEq = equationsForSession[currentEquationIndex];

            // cover cases where a digit box was never focused
            if (currEq.onesDigitBoxFocusedTime == DateTime.MinValue) 
                currEq.onesDigitBoxFocusedTime = DateTime.Now;
            if (currEq.tensDigitBoxFocusedTime == DateTime.MinValue)
                currEq.tensDigitBoxFocusedTime = DateTime.Now;
            if (currEq.hundredsDigitBoxFocusedTime == DateTime.MinValue)
                currEq.hundredsDigitBoxFocusedTime = DateTime.Now;
            if (currEq.thousandsDigitBoxFocusedTime == DateTime.MinValue)
                currEq.thousandsDigitBoxFocusedTime = DateTime.Now;

            // cover cases where a digit box never had text entered to it
            if (currEq.onesDigitEnteredTime == DateTime.MinValue)
                currEq.onesDigitEnteredTime = currEq.onesDigitBoxFocusedTime;
            if (currEq.tensDigitEnteredTime == DateTime.MinValue)
                currEq.tensDigitEnteredTime = currEq.tensDigitBoxFocusedTime;
            if (currEq.hundredsDigitEnteredTime == DateTime.MinValue)
                currEq.hundredsDigitEnteredTime = currEq.hundredsDigitBoxFocusedTime;
            if (currEq.thousandsDigitEnteredTime == DateTime.MinValue)
                currEq.thousandsDigitEnteredTime = currEq.thousandsDigitBoxFocusedTime;

            TimeSpan onesTimeSpan = currEq.onesDigitEnteredTime - currEq.onesDigitBoxFocusedTime;
            TimeSpan tensTimeSpan = currEq.tensDigitEnteredTime - currEq.tensDigitBoxFocusedTime;
            TimeSpan hundredsTimeSpan = currEq.hundredsDigitEnteredTime - currEq.hundredsDigitBoxFocusedTime;
            TimeSpan thousandsTimeSpan = currEq.thousandsDigitEnteredTime - currEq.thousandsDigitBoxFocusedTime;

            if (onesTimeSpan.TotalSeconds > 0)
                AddStatusMessageAndScroll(String.Format("Equation {0:d} ones digit entered {1:f} seconds after focus", currentEquationIndex + 1, onesTimeSpan.TotalSeconds));
            if (tensTimeSpan.TotalSeconds > 0)
                AddStatusMessageAndScroll(String.Format("Equation {0:d} tens digit entered {1:f} seconds after focus", currentEquationIndex + 1, tensTimeSpan.TotalSeconds));
            if (hundredsTimeSpan.TotalSeconds > 0)
                AddStatusMessageAndScroll(String.Format("Equation {0:d} hundreds digit entered {1:f} seconds after focus", currentEquationIndex + 1, hundredsTimeSpan.TotalSeconds));
            if (thousandsTimeSpan.TotalSeconds > 0)
                AddStatusMessageAndScroll(String.Format("Equation {0:d} thousands digit entered {1:f} seconds after focus", currentEquationIndex + 1, thousandsTimeSpan.TotalSeconds));
        }
        
        private void CheckEquationSolutionTime()
        {
            this.equationsForSession[this.currentEquationIndex].equationEndTime = DateTime.Now;
            TimeSpan timeSpan = this.equationsForSession[this.currentEquationIndex].equationEndTime - this.equationsForSession[this.currentEquationIndex].equationStartTime;
            this.AddStatusMessageAndScroll(String.Format("Equation {0:d} completed in {1:f} seconds", this.currentEquationIndex + 1, timeSpan.TotalSeconds));
        }

        private void CheckForCorrectSolution()
        {
            int thousandsDigit = 0;
            int hundredsDigit = 0;
            int tensDigit = 0;
            int onesDigit = 0;

            try
            {
                if ((this.solutionOnesDigitTextBox.Text != null) && (this.solutionOnesDigitTextBox.Text != ""))
                    onesDigit = Int32.Parse(this.solutionOnesDigitTextBox.Text);
                if ((this.solutionTensDigitTextBox.Text != null) && (this.solutionTensDigitTextBox.Text != ""))
                    tensDigit = Int32.Parse(this.solutionTensDigitTextBox.Text);
                if ((this.solutionHundredsDigitTextBox.Text != null) && (this.solutionHundredsDigitTextBox.Text != ""))
                    hundredsDigit = Int32.Parse(this.solutionHundredsDigitTextBox.Text);
                if ((this.solutionThousandsDigitTextBox.Text != null) && (this.solutionThousandsDigitTextBox.Text != ""))
                    thousandsDigit = Int32.Parse(this.solutionThousandsDigitTextBox.Text);
            }
            catch (Exception)
            {
                onesDigit = tensDigit = hundredsDigit = thousandsDigit = 0;
            }

            int enteredSolution = (thousandsDigit * 1000) + (hundredsDigit * 100) + (tensDigit * 10) + onesDigit;
            int correctSolution = this.equationsForSession[this.currentEquationIndex].topValue + this.equationsForSession[this.currentEquationIndex].bottomValue;
            this.equationsForSession[this.currentEquationIndex].userAnswer = enteredSolution;

            if (enteredSolution == correctSolution)
            {
                this.AddStatusMessageAndScroll(String.Format("Equation {0:d} answered correctly!", this.currentEquationIndex + 1));
                this.equationsForSession[this.currentEquationIndex].wasCorrect = true;
            }
            else
            {
                this.AddStatusMessageAndScroll(String.Format("Equation {0:d} answered incorrectly!", this.currentEquationIndex + 1));
                this.equationsForSession[this.currentEquationIndex].wasCorrect = false;
            }
        }

        private void CheckForEnabledSolutionDigits()
        {
            try
            {
                int onesDigitEntered = -1;
                int tensDigitEntered = -1;
                int hundredsDigitEntered = -1;
                int thousandsDigitEntered = -1;

                if ((this.solutionOnesDigitTextBox.Text != null) && (this.solutionOnesDigitTextBox.Text != ""))
                    onesDigitEntered = Int32.Parse(this.solutionOnesDigitTextBox.Text);
                if ((this.solutionTensDigitTextBox.Text != null) && (this.solutionTensDigitTextBox.Text != ""))
                    tensDigitEntered = Int32.Parse(this.solutionTensDigitTextBox.Text);
                if ((this.solutionHundredsDigitTextBox.Text != null) && (this.solutionHundredsDigitTextBox.Text != ""))
                    hundredsDigitEntered = Int32.Parse(this.solutionHundredsDigitTextBox.Text);
                if ((this.solutionThousandsDigitTextBox.Text != null) && (this.solutionThousandsDigitTextBox.Text != ""))
                    thousandsDigitEntered = Int32.Parse(this.solutionThousandsDigitTextBox.Text);

                this.solutionOnesDigitTextBox.Enabled = this.equationsForSession.Count > 0;
                this.solutionTensDigitTextBox.Enabled = ((this.solutionOnesDigitTextBox.Enabled) && (onesDigitEntered >= 0) && (onesDigitEntered <= 9));
                this.solutionHundredsDigitTextBox.Enabled = ((this.solutionTensDigitTextBox.Enabled) && (tensDigitEntered >= 0) && (tensDigitEntered <= 9));
                this.solutionThousandsDigitTextBox.Enabled = ((this.solutionHundredsDigitTextBox.Enabled) && (hundredsDigitEntered >= 0) && (hundredsDigitEntered <= 9));

                this.tensCarryNotesTextBox.Enabled = this.solutionTensDigitTextBox.Enabled;
                this.hundredsCarryNotesTextBox.Enabled = this.solutionHundredsDigitTextBox.Enabled;
                this.thousandsCarryNotesTextBox.Enabled = this.solutionThousandsDigitTextBox.Enabled;
            }
            catch (Exception)
            {
            }
        }

        private void CheckToEnableNextButton()
        {
            try
            {
                int onesDigitEntered = -1;
                int tensDigitEntered = 0;
                int hundredsDigitEntered = 0;
                int thousandsDigitEntered = 0;

                if ((this.solutionOnesDigitTextBox.Text != null) && (this.solutionOnesDigitTextBox.Text != ""))
                    onesDigitEntered = Int32.Parse(this.solutionOnesDigitTextBox.Text);
                if ((this.solutionTensDigitTextBox.Text != null) && (this.solutionTensDigitTextBox.Text != ""))
                    tensDigitEntered = Int32.Parse(this.solutionTensDigitTextBox.Text);
                if ((this.solutionHundredsDigitTextBox.Text != null) && (this.solutionHundredsDigitTextBox.Text != ""))
                    hundredsDigitEntered = Int32.Parse(this.solutionHundredsDigitTextBox.Text);
                if ((this.solutionThousandsDigitTextBox.Text != null) && (this.solutionThousandsDigitTextBox.Text != ""))
                    thousandsDigitEntered = Int32.Parse(this.solutionThousandsDigitTextBox.Text);

                if (((onesDigitEntered >= 0) && (onesDigitEntered <= 9)) &&
                    ((tensDigitEntered >= 0) && (tensDigitEntered <= 9)) &&
                    ((hundredsDigitEntered >= 0) && (hundredsDigitEntered <= 9)) &&
                    ((thousandsDigitEntered >= 0) && (thousandsDigitEntered <= 9)))
                {
                    this.nextEquationButton.Enabled = true;
                    return;
                }
            }
            catch(Exception)
            {
            }
            this.nextEquationButton.Enabled = false;
        }

        private void UpdateProgressLabel()
        {
            this.progressLabel.Text = String.Format("This is equation {0:d} of {1:d}.", this.currentEquationIndex + 1, this.equationsForSession.Count);
            this.statusProgressBar.Maximum = this.equationsForSession.Count;
            if (this.currentEquationIndex < this.equationsForSession.Count)
                this.statusProgressBar.Value = this.currentEquationIndex + 1;
        }
        
        private void ClearPreviousSession()
        {
            this.threeDigitEquationTopLabel.ResetText();
            this.threeDigitEquationBottomLabel.ResetText();
            this.solutionThousandsDigitTextBox.ResetText();
            this.solutionHundredsDigitTextBox.ResetText();
            this.solutionTensDigitTextBox.ResetText();
            this.solutionOnesDigitTextBox.ResetText();
            this.tensCarryNotesTextBox.ResetText();
            this.hundredsCarryNotesTextBox.ResetText();
            this.thousandsCarryNotesTextBox.ResetText();
            this.statusProgressBar.Value = 0;
            this.statusProgressBar.Maximum = 0;
            this.statusTextListBox.Items.Clear();
            this.progressLabel.ResetText();
            this.equationsForSession.Clear();
            this.currentEquationIndex = 0;
            this.solutionThousandsDigitTextBox.Enabled = false;
            this.solutionHundredsDigitTextBox.Enabled = false;
            this.solutionTensDigitTextBox.Enabled = false;
            this.solutionOnesDigitTextBox.Enabled = false;
        }

        /*
        private bool ParseDataFile(String fileName, bool splitEquations, int maxRandomEquations)
        {
            try
            {
                TextReader reader = new StreamReader(fileName);

                String line = reader.ReadLine();
                while (line != null)
                {
                    // we expect each line to be something in the form of xxx+yyy
                    int plusIndex = line.IndexOf('+');
                    if ((plusIndex != -1) && (plusIndex > 0) && (plusIndex < (line.Length - 1)))
                    {
                        String leftSide = line.Substring(0, plusIndex);
                        String rightSide = line.Substring(plusIndex + 1);
                        if ((leftSide != null) && (rightSide != null))
                        {
                            MathTimeEquation eq = new MathTimeEquation();
                            eq.topValue = Int32.Parse(leftSide);
                            eq.bottomValue = Int32.Parse(rightSide);
                            equationsForSession.Add(eq);
                        }
                    }

                    line = reader.ReadLine();
                }
                reader.Close();

                // reduce the input set to the right number of equations
                Random random = new Random();
                while (equationsForSession.Count > maxRandomEquations)
                {
                    int indexToDelete = random.Next(equationsForSession.Count);
                    equationsForSession.RemoveAt(indexToDelete);
                }

                if (splitEquations)
                {
                    foreach (MathTimeEquation eq in equationsForSession)
                    {
                        String leftSide = String.Format("{0:d}", eq.topValue);
                        String rightSide = String.Format("{0:d}", eq.bottomValue);

                        // make sure the lengths are the same, zero prefixing the shorter
                        int maxLen = Math.Max(leftSide.Length, rightSide.Length);
                        while (leftSide.Length < maxLen)
                            leftSide = "0" + leftSide;
                        while (rightSide.Length < maxLen)
                            rightSide = "0" + rightSide;

                        while (maxLen > 0)
                        {
                            String leftSideDigitStr = leftSide.Substring(maxLen - 1, 1);
                            String rightSideDigitStr = rightSide.Substring(maxLen - 1, 1);

                            MathTimeEquation singleDigitEq = new MathTimeEquation();
                            singleDigitEq.topValue = Int32.Parse(leftSideDigitStr);
                            singleDigitEq.bottomValue = Int32.Parse(rightSideDigitStr);
                            equationsForSession.Add(singleDigitEq);

                            maxLen--;
                        }
                    }
                }

                return true;
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("There was an error starting the session.  Possibly could not find the data file.  Exiting!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }*/

        private void GenerateEquations(int minValue, int maxValue, bool splitEquations, int maxEquations)
        {
            Random random = new Random();
            while (this.equationsForSession.Count < maxEquations)
            {
                MathTimeEquation eq = new MathTimeEquation();
                eq.topValue = random.Next(minValue, maxValue);
                eq.bottomValue = random.Next(minValue, maxValue);
                this.equationsForSession.Add(eq);
            }

            if (splitEquations)
            {
                List<MathTimeEquation> originalEquations = new List<MathTimeEquation>();
                originalEquations.AddRange(this.equationsForSession);
                this.equationsForSession.Clear();

                foreach (MathTimeEquation eq in originalEquations)
                {
                    String leftSide = String.Format("{0:d}", eq.topValue);
                    String rightSide = String.Format("{0:d}", eq.bottomValue);

                    // make sure the lengths are the same, zero prefixing the shorter
                    int maxLen = Math.Max(leftSide.Length, rightSide.Length);
                    while (leftSide.Length < maxLen)
                        leftSide = "0" + leftSide;
                    while (rightSide.Length < maxLen)
                        rightSide = "0" + rightSide;

                    int highPDigitsUsed = 0;
                    while ((maxLen > 0) && (highPDigitsUsed < MainWindow.MaxHighPRequestCount))
                    {
                        String leftSideDigitStr = leftSide.Substring(maxLen - 1, 1);
                        String rightSideDigitStr = rightSide.Substring(maxLen - 1, 1);

                        MathTimeEquation singleDigitEq = new MathTimeEquation();
                        singleDigitEq.topValue = Int32.Parse(leftSideDigitStr);
                        singleDigitEq.bottomValue = Int32.Parse(rightSideDigitStr);
                        this.equationsForSession.Add(singleDigitEq);

                        highPDigitsUsed++;
                        maxLen--;
                    }

                    this.equationsForSession.Add(eq);
                }
            }
        }

        private void StartNewSession(int minValue, int maxValue, bool splitEquations, int maxRandomEquations)
        {
            this.GenerateEquations(minValue, maxValue, splitEquations, maxRandomEquations);
            this.currentEquationIndex = 0;
            this.UpdateProgressLabel();
            CheckForEnabledSolutionDigits();
            ShowCurrentEquation();
        }

        private void ShowCurrentEquation()
        {
            MathTimeEquation currEq = equationsForSession[currentEquationIndex];

            if (this.currentEquationIndex < this.equationsForSession.Count)
            {
                this.threeDigitEquationTopLabel.Text = String.Format("{0:d}", currEq.topValue);
                this.threeDigitEquationBottomLabel.Text = String.Format("{0:d}", currEq.bottomValue);
                this.solutionThousandsDigitTextBox.ResetText();
                this.solutionHundredsDigitTextBox.ResetText();
                this.solutionTensDigitTextBox.ResetText();
                this.solutionOnesDigitTextBox.ResetText();
                this.tensCarryNotesTextBox.ResetText();
                this.hundredsCarryNotesTextBox.ResetText();
                this.thousandsCarryNotesTextBox.ResetText();
                this.AddStatusMessageAndScroll(String.Format("Displaying and starting the timer for equation {0:d}", this.currentEquationIndex + 1));
                this.equationsForSession[this.currentEquationIndex].equationStartTime = DateTime.Now;
            }
            else
            {
                this.threeDigitEquationTopLabel.ResetText();
                this.threeDigitEquationBottomLabel.ResetText();
                this.solutionHundredsDigitTextBox.ResetText();
                this.solutionTensDigitTextBox.ResetText();
                this.solutionOnesDigitTextBox.ResetText();
                this.tensCarryNotesTextBox.ResetText();
                this.hundredsCarryNotesTextBox.ResetText();
                this.thousandsCarryNotesTextBox.ResetText();
            }
        }

        private void startNewSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewSessionDialog();
        }

        private void StartNewSessionDialog()
        {
            SessionStartForm startForm = new SessionStartForm();
            startForm.ShowDialog();

            int selectedIndex = startForm.SessionType;
            String identifier = startForm.IdentificationString;
            if (identifier.Trim().Length == 0)
            {
                MessageBox.Show("You must enter a valid identifier");
                return;
            }

            if (selectedIndex == -1)
            {
                MessageBox.Show("You must choose a valid session type");
                return;
            }

            this.ClearPreviousSession();
            if (selectedIndex == 0)
                this.StartNewSession(0, 9, false, 20);
            else if (selectedIndex == 1)
                this.StartNewSession(100, 999, false, 10);
            else if (selectedIndex == 2)
                this.StartNewSession(100, 999, true, 10);
            else
            {
                MessageBox.Show("You must choose a valid session type");
                return;
            }

            this.studentIdentifier = identifier;
        }

        private void showSessionStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showSessionStatusToolStripMenuItem.Checked = !this.showSessionStatusToolStripMenuItem.Checked;

            if (this.showSessionStatusToolStripMenuItem.Checked)
            {
                this.Height += this.statusGroupBox.Height;
            }
            else
            {
                this.Height -= this.statusGroupBox.Height;
            }

            this.statusGroupBox.Visible = this.showSessionStatusToolStripMenuItem.Checked;
        }

        private void solutionDigitsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.nextEquationButton.Enabled && (e.KeyChar == (char)13))
            {
                DoNextEquationButtonClick();
                e.Handled = true;
            }
        }

        private void solutionOnesDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { 
            solutionDigitsTextBox_KeyPress(sender, e);
        }

        private void solutionTensDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            solutionDigitsTextBox_KeyPress(sender, e);
        }

        private void solutionHundredsDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            solutionDigitsTextBox_KeyPress(sender, e);
        }

        private void solutionThousandsDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            solutionDigitsTextBox_KeyPress(sender, e);
        }

        private void tensCarryNotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            solutionDigitsTextBox_KeyPress(sender, e);
        }

        private void hundredsCarryNotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            solutionDigitsTextBox_KeyPress(sender, e);
        }

        private void thousandsCarryNotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            solutionDigitsTextBox_KeyPress(sender, e);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            StartNewSessionDialog();
        }
    }

    class MathTimeEquation
    {
        public int topValue;
        public int bottomValue;
        public int userAnswer;
        public bool wasCorrect;
        public DateTime equationStartTime;
        public DateTime hundredsDigitEnteredTime;
        public DateTime tensDigitEnteredTime;
        public DateTime onesDigitEnteredTime;
        public DateTime thousandsDigitEnteredTime;
        public DateTime hundredsDigitBoxFocusedTime;
        public DateTime tensDigitBoxFocusedTime;
        public DateTime onesDigitBoxFocusedTime;
        public DateTime thousandsDigitBoxFocusedTime;
        public DateTime equationEndTime;

        public MathTimeEquation()
        {
            topValue = 0;
            bottomValue = 0;
            userAnswer = 0;
            wasCorrect = false;
            equationStartTime = DateTime.MinValue;
            hundredsDigitEnteredTime = DateTime.MinValue;
            tensDigitEnteredTime = DateTime.MinValue;
            onesDigitEnteredTime = DateTime.MinValue;
            thousandsDigitEnteredTime = DateTime.MinValue;
            hundredsDigitBoxFocusedTime = DateTime.MinValue;
            tensDigitBoxFocusedTime = DateTime.MinValue;
            onesDigitBoxFocusedTime = DateTime.MinValue;
            thousandsDigitBoxFocusedTime = DateTime.MinValue;
            equationEndTime = DateTime.MinValue;
        }

        public int DigitLength
        {
            get { return String.Format("{0:d}", topValue).Length; }
        }
    };
}