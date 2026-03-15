using System.Text.Json.Serialization;

public class Shopping
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("endereco")]
    public string Endereco { get; set; }

    [JsonPropertyName("quantidadeLojas")]
    public int QuantidadeLojas { get; set; }

    [JsonPropertyName("temCinema")]
    public bool TemCinema { get; set; }

    [JsonPropertyName("horarioAbertura")]
    public string HorarioAbertura { get; set; }

    [JsonPropertyName("horarioFechamento")]
    public string HorarioFechamento { get; set; }
}