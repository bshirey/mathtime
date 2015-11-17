using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathTime
{
    public partial class RedeemTokensForm : Form
    {
        protected int tokensToRedeem;

        public RedeemTokensForm()
        {
            InitializeComponent();
            this.tokensToRedeem = 0;
        }

        public int RequestedTokensCount
        {
            get { return this.tokensToRedeem; }
        }

        public int CurrentStudentTokenCount
        {
            set { this.currentTokenCountLabel.Text = value.ToString(); }
        }

        public String CurrentStudentID
        {
            set { this.studentIdLabel.Text = value; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.tokensToRedeem = (int)this.numTokensToRedeemUpDown.Value;
            this.Close();
        }
    }
}
