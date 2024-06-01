using System.Text.Json.Serialization;

namespace GA.TradeMarket.Application.Models.DecoderObjects
{
    public class CommercialRate
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("buy")]
        public decimal Buy { get; set; }

        [JsonPropertyName("sell")]
        public decimal Sell { get; set; }
    }
}
