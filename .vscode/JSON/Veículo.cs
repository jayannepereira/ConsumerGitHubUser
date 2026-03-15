using System.Text.Json.Serialization;

public class Veiculo
{
    [JsonPropertyName("placa")]
    public string Placa { get; set; }

    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }

    [JsonPropertyName("marca")]
    public string Marca { get; set; }

    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    [JsonPropertyName("cor")]
    public string Cor { get; set; }

    [JsonPropertyName("preco")]
    public decimal Preco { get; set; }

    [JsonPropertyName("novo")]
    public bool Novo { get; set; }
}