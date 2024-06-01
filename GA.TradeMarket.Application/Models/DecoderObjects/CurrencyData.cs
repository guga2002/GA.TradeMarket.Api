using System.Text.Json.Serialization;

namespace GA.TradeMarket.Application.Models.DecoderObjects
{
    public class CurrencyData
    {
        [JsonPropertyName("base")]
        public string Base { get; set; }

        [JsonPropertyName("commercialRatesList")]
        public List<CommercialRate> CommercialRatesList { get; set; }
    }
}
