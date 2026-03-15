using System.Text.Json.Serialization;

public class Ferramenta
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("categoria")]
    public string Categoria { get; set; }

    [JsonPropertyName("quantidadeEstoque")]
    public int QuantidadeEstoque { get; set; }

    [JsonPropertyName("precoUnitario")]
    public decimal PrecoUnitario { get; set; }

    [JsonPropertyName("marca")]
    public string Marca { get; set; }
}