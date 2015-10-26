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
    public partial class SessionStartForm : Form
    {
        public SessionStartForm()
        {
            InitializeComponent();
        }

        public String IdentificationString
        {
            get { return this.studentIdentifierTextBox.Text; }
        }

        public int SessionType
        {
            get { return this.sessiontypeComboBox.SelectedIndex; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
