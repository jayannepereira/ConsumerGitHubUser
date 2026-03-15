using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumerGitHubUser
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://api.github.com/user/1";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "jayannepereira-app");

                    string response = await client.GetStringAsync(url);

                    var user = JsonSerializer.Deserialize<GitHubUser>(response);

                    Console.WriteLine("Nome:");
                    Console.WriteLine(user.Nome);
                    Console.WriteLine($"Empresa: {user.Empresa}");
                    Console.WriteLine($"Localização: {user.Localizacao}");
                    Console.WriteLine($"Login: {user.Login}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
            }
        }
    }
}