using System;
using System.Collections.Generic;

namespace PortfolioServiceLibrary
{
    public class PortfolioService : IPortfolioService
    {
        public PortfolioService()
        {
            PortfolioDataAccessLayer = new PortfolioDataAccessLayer.PortfolioDataAccessLayer();
        }

        public PortfolioDataAccessLayer.PortfolioDataAccessLayer PortfolioDataAccessLayer { get; set; }

        public List<CheckResult> GetCheckResults(DateTime startTime)
        {
            var checkResultList = new List<CheckResult>
                {
                    new CheckResult
                        {
                            IsMarketValueCheckIn = true,
                            Portfolio = "Trolololo",
                            IsWeightCheckIn = true,
                            Time = startTime
                        }
                };
            return checkResultList;
        }
    }
}