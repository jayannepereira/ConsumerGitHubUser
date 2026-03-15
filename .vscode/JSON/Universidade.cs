using System.Text.Json.Serialization;
using System.Collections.Generic;

public class Universidade
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("sigla")]
    public string Sigla { get; set; }

    [JsonPropertyName("campus")]
    public string Campus { get; set; }

    [JsonPropertyName("cursosDisponiveis")]
    public List<string> CursosDisponiveis { get; set; }

    [JsonPropertyName("publica")]
    public bool Publica { get; set; }
}