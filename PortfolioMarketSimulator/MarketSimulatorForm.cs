using System;
using System.Windows.Forms;
using PortfolioMarketSimulator.PortfolioServiceReference;

namespace PortfolioMarketSimulator
{
    public partial class MarketSimulatorForm : Form
    {
        public MarketSimulatorForm()
        {
            InitializeComponent();
            PortfolioServiceClient = new PortfolioServiceClient();
        }

        public PortfolioServiceClient PortfolioServiceClient { get; set; }

        private void marketSimulatorTimer_Tick(object sender, EventArgs e)
        {
            bool res = PortfolioServiceClient.SimulateMarket(new decimal(GetRandomNumber(-2, 2)));
            MessageBox.Show(res
                                ? @"Actualisation des prix effectuée avec succès :)"
                                : @"Actualisation des prix non effectuée :(");
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            var random = new Random();
            return random.NextDouble()*(maximum - minimum) + minimum;
        }
    }
}