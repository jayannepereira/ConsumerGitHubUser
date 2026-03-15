using System.Text.Json.Serialization;

public class Livro
{
    [JsonPropertyName("isbn")]
    public string Isbn { get; set; }

    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string Autor { get; set; }

    [JsonPropertyName("editora")]
    public string Editora { get; set; }

    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }

    [JsonPropertyName("genero")]
    public string Genero { get; set; }
}