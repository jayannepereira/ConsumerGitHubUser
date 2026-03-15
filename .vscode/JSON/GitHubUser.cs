using System.Text.Json.Serialization;

namespace ConsumerGitHubUser
{
    public class GitHubUser
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("company")]
        public string Empresa { get; set; }

        [JsonPropertyName("location")]
        public string Localizacao { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }
    }
}