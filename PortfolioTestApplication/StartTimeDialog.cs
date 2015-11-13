using System;
using System.Windows.Forms;

namespace PortfolioTestApplication
{
    public partial class StartTimeDialog : Form
    {
        public StartTimeDialog()
        {
            InitializeComponent();
        }

        public DateTime StartTime { get; set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            StartTime = startTimeDateTimePicker.Value;
        }

        private void okButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
                okButton_Click(sender, e);
        }
    }
}