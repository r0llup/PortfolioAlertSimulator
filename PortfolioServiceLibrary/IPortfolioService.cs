using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace PortfolioServiceLibrary
{
    [ServiceContract]
    public interface IPortfolioService
    {
        [OperationContract]
        List<CheckResult> GetCheckResults(DateTime startTime);
    }

    [DataContract]
    public class CheckResult
    {
        [DataMember]
        public DateTime Time { get; set; }

        [DataMember]
        public String Portfolio { get; set; }

        [DataMember]
        public Boolean IsMarketValueCheckIn { get; set; }

        [DataMember]
        public Boolean IsWeightCheckIn { get; set; }
    }
}