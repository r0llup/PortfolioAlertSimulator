using System;
using System.Windows.Forms;
using PortfolioTestApplication.PortfolioServiceReference;

namespace PortfolioTestApplication
{
    public partial class TestApplicationForm : Form
    {
        public TestApplicationForm()
        {
            InitializeComponent();
            PortfolioServiceClient = new PortfolioServiceClient();
            StartTimeDialog = new StartTimeDialog();
        }

        public PortfolioServiceClient PortfolioServiceClient { get; set; }
        public StartTimeDialog StartTimeDialog { get; set; }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = StartTimeDialog.ShowDialog(this);
            if (dialogResult != DialogResult.OK) return;
            StartTimeDialog.Hide();
            portfolioDataGridView.DataSource =
                PortfolioServiceClient.GetCheckResults(StartTimeDialog.StartTime);
        }
    }
}