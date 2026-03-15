using System.Text.Json.Serialization;

public class Usuario
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("ativo")]
    public bool Ativo { get; set; }
}
