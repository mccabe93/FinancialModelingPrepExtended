﻿using System.Text.Json.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model.AdvancedData
{
    public class ESGScoreResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("cik")]
        public string Cik { get; set; }

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        [JsonPropertyName("formType")]
        public string FormType { get; set; }

        [JsonPropertyName("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("environmentalScore")]
        public decimal EnvironmentalScore { get; set; }

        [JsonPropertyName("socialScore")]
        public decimal SocialScore { get; set; }

        [JsonPropertyName("governanceScore")]
        public decimal GovernanceScore { get; set; }

        [JsonPropertyName("ESGScore")]
        public decimal ESGScore { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
