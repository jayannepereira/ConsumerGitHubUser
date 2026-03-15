using System.Text.Json.Serialization;

public class Livro
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string Autor { get; set; }

    [JsonPropertyName("anoPublicacao")]
    public int AnoPublicacao { get; set; }

    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }

    [JsonPropertyName("genero")]
    public string Genero { get; set; }

    [JsonPropertyName("isbn")]
    public string Isbn { get; set; }

    [JsonPropertyName("disponivel")]
    public bool EstaDisponivel { get; set; }
}