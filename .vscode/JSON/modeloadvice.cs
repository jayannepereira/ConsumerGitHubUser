using System.Text.Json.Serialization;

namespace ConsumerAdviceApi
{
    public class AdviceResponse
    {
        [JsonPropertyName("slip")]
        public AdviceSlip Slip { get; set; }
    }

    public class AdviceSlip
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("advice")]
        public string Advice { get; set; }
    }
}